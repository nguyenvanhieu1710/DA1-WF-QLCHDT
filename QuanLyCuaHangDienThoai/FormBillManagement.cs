using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormBillManagement : Form
    {
        public FormBillManagement()
        {
            InitializeComponent();
        }
        OrderTable_BLL OrderTable_BLL = new OrderTable_BLL();
        private void BillManagement_Load(object sender, EventArgs e)
        {
            Refrech();
        }
        private void Refrech()
        {
            List<OrderTable_DTO> orderTableList = OrderTable_BLL.OrderList();
            dgvOrder.DataSource = ConvertData.ConvertToDataTable(orderTableList);
            // số lượng OrderTable
            lblQuantityBill.Text = orderTableList.Count.ToString() + " Bill";    
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            OrderTable_DTO OrderTable_DTO = AssignDataDTO();

            if (!OrderTable_BLL.CheckExit(OrderTable_DTO))
            {
                MessageBox.Show("Order does not exist");
                return;
            }
            int result = 1; //kiểm tra số bản ghi sửa có đúng không
            if (OrderTable_BLL.updateOrder(OrderTable_DTO) == result)
            {
                MessageBox.Show("Fixed Order successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Fix failed Order");
                Refrech();
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            OrderTable_DTO OrderTable_DTO = AssignDataDTO();

            if (!OrderTable_BLL.CheckExit(OrderTable_DTO))
            {
                MessageBox.Show("OrderTable does not exist");
                return;
            }

            // vì không xác định được chính xác số bản ghi bị ảnh hưởng nên cứ để chạy bình thường thôi
            OrderTable_BLL.deleteOrder(OrderTable_DTO);

            if (!OrderTable_BLL.CheckExit(OrderTable_DTO))
            {
                MessageBox.Show("Delete Order success");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Delete fail Order");
                Refrech();
                return;
            }
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            Refrech();
            txtIdOrder.Text = "";
            txtIdCustomer.Text = "";
            txtIdStaff.Text = "";
            txtOrderStatus.Text = "";
            txtTotalPrice.Text = "";
            txtDeliveryAddress.Text = "";
            DateTimePickerDayBuy.Value = DateTime.Now;
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvOrder.Rows[e.RowIndex];
            txtIdOrder.Text = row.Cells[0].Value.ToString();
            txtIdCustomer.Text = row.Cells[1].Value.ToString();
            txtIdStaff.Text = row.Cells[2].Value.ToString();
            txtOrderStatus.Text = row.Cells[3].Value.ToString();
            txtTotalPrice.Text = row.Cells[4].Value.ToString();
            DateTimePickerDayBuy.Text = row.Cells[5].Value.ToString();
            txtDeliveryAddress.Text = row.Cells[6].Value.ToString();
        }
        private bool CheckRegex()
        {
            if (txtIdOrder.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID order");
                return false;
            }
            if (!RegexData.IsValidId(txtIdOrder.Text.Trim()))
            {
                MessageBox.Show("ID order not valid");
                return false;
            }
            if (txtIdCustomer.Text.Trim() == "")
            {
                MessageBox.Show("Please enter id customer");
                return false;
            }
            if (!RegexData.IsValidId(txtIdCustomer.Text.Trim()))
            {
                MessageBox.Show("ID customer not valid");
                return false;
            }
            if (txtIdStaff.Text.Trim() == "")
            {
                MessageBox.Show("Please enter id staff");
                return false;
            }
            if (!RegexData.IsValidId(txtIdStaff.Text.Trim()))
            {
                MessageBox.Show("ID staff not valid");
                return false;
            }
            if (txtOrderStatus.Text.Trim() == "")
            {
                MessageBox.Show("Please enter order status");
                return false;
            }
            if (txtTotalPrice.Text.Trim() == "")
            {
                MessageBox.Show("Please enter total price");
                return false;
            }
            if (!RegexData.IsValidId(txtTotalPrice.Text.Trim()))
            {
                MessageBox.Show("Total price is not valid");
                return false;
            }
            if (int.Parse(txtTotalPrice.Text.Trim()) < 0)
            {
                MessageBox.Show("Total price is not valid");
                return false;
            }
            if (txtDeliveryAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please enter delivery address");
                return false;
            }
            return true;
        }
        private OrderTable_DTO AssignDataDTO()
        {
            // Hàm gán dữ liệu trở lại đối tượng DTO
            OrderTable_DTO OrderTable_DTO = new OrderTable_DTO();
            OrderTable_DTO.IdOrderTable = int.Parse(txtIdOrder.Text);
            OrderTable_DTO.IdCustomer = int.Parse(txtIdCustomer.Text);
            OrderTable_DTO.IdStaff = int.Parse(txtIdStaff.Text);
            OrderTable_DTO.TotalPrice = decimal.Parse(txtTotalPrice.Text);
            OrderTable_DTO.DayBuy = DateTime.Parse(DateTimePickerDayBuy.Text);
            OrderTable_DTO.DeliveryAddress = txtDeliveryAddress.Text;
            OrderTable_DTO.OrderStatus = txtOrderStatus.Text;
            return OrderTable_DTO;
        }
    }
}
