using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormVoucherManagement : Form
    {
        public FormVoucherManagement()
        {
            InitializeComponent();
        }
        Voucher_BLL Voucher_BLL = new Voucher_BLL();
        private void Refrech()
        {
            dgvVoucher.DataSource = Voucher_BLL.VoucherList();
            List<Voucher_DTO> Voucher_DTO = Voucher_BLL.VoucherList();
            lblQuantityVoucher.Text = Voucher_DTO.Count.ToString() + " Voucher";
            LoadDataComboBox();
        }
        private void FormVoucherManagement_Load(object sender, EventArgs e)
        {
            Refrech();
        }
        private bool CheckRegex()
        {
            if (txtIdVoucher.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID Voucher");
                return false;
            }
            if (!RegexData.IsValidId(txtIdVoucher.Text.Trim()))
            {
                MessageBox.Show("ID Voucher not valid");
                return false;
            }
            if (txtVoucherName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Voucher name");
                return false;
            }
            if (txtFixedPrice.Text.Trim() == "")
            {
                MessageBox.Show("Please enter fixed price");
                return false;
            }
            if (txtMinimumPrice.Text.Trim() == "")
            {
                MessageBox.Show("Please enter minimum price");
                return false;
            }
            if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("Please enter quantity");
                return false;
            }
            if (cbIdCategory.Text.Trim() == "")
            {
                MessageBox.Show("Please choose id category");
                return false;
            }
            return true;
        }
        private Voucher_DTO AssignDataDTO()
        {
            // Hàm gán dữ liệu trở lại đối tượng DTO
            Voucher_DTO Voucher_DTO = new Voucher_DTO();
            Voucher_DTO.IdVoucher = int.Parse(txtIdVoucher.Text);
            Voucher_DTO.VoucherName = txtVoucherName.Text;
            Voucher_DTO.FixedPrice = int.Parse(txtFixedPrice.Text);
            Voucher_DTO.Minimumprice = int.Parse(txtMinimumPrice.Text);
            Voucher_DTO.Quantity = int.Parse(txtQuantity.Text); 
            Voucher_DTO.StartDay = DateTime.Parse(DateTimePickerStartDay.Text);
            Voucher_DTO.EndDate = DateTime.Parse(DateTimePickerEndDate.Text);
            Voucher_DTO.IdCategory = int.Parse(cbIdCategory.Text);
            return Voucher_DTO;
        }
        private void LoadDataComboBox()
        {
            cbIdCategory.Items.Clear();
            Category_BLL category_BLL = new Category_BLL();
            List<Category_DTO> categoryList = category_BLL.CategoryList();
            foreach (Category_DTO category_DTO in categoryList)
            {
                cbIdCategory.Items.Add(category_DTO.IdCategory);
            }
        }
        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            if (!CheckRegex())
            {
                return;
            }
            Voucher_DTO Voucher_DTO = AssignDataDTO();

            if (Voucher_BLL.CheckExit(Voucher_DTO))
            {
                MessageBox.Show("The Voucher already exists");
                return;
            }

            int result = 1; //kiểm tra số bản ghi thêm vào có đúng không
            // lưu vào database và so sánh
            if (Voucher_BLL.addVoucher(Voucher_DTO) == result)
            {
                MessageBox.Show("Added Vouchers successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Adding failed Vouchers");
                Refrech();
                return;
            }
        }

        private void btnFixVoucher_Click(object sender, EventArgs e)
        {
            if (!CheckRegex())
            {
                return;
            }
            Voucher_DTO Voucher_DTO = AssignDataDTO();

            if (!Voucher_BLL.CheckExit(Voucher_DTO))
            {
                MessageBox.Show("Voucher does not exist");
                return;
            }

            int result = 1; //kiểm tra số bản ghi sửa có đúng không
            if (Voucher_BLL.fixVoucher(Voucher_DTO) == result)
            {
                MessageBox.Show("Fixed Vouchers successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Fix failed Vouchers");
                Refrech();
                return;
            }
        }

        private void btnDeleteVoucher_Click(object sender, EventArgs e)
        {
            if (!CheckRegex())
            {
                return;
            }
            Voucher_DTO Voucher_DTO = AssignDataDTO();

            if (!Voucher_BLL.CheckExit(Voucher_DTO))
            {
                MessageBox.Show("Voucher does not exist");
                return;
            }

            // vì không xác định được chính xác số bản ghi bị ảnh hưởng nên cứ để chạy bình thường thôi
            Voucher_BLL.deleteVoucher(Voucher_DTO);

            if (!Voucher_BLL.CheckExit(Voucher_DTO))
            {
                MessageBox.Show("Delete Voucher success");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Delete fail Voucher");
                Refrech();
                return;
            }
        }

        private void btnSearchVoucher_Click(object sender, EventArgs e)
        {
            if (txtVoucherName.Text.Trim() == "")
            {
                MessageBox.Show("please enter Voucher name");
                return;
            }
            Voucher_DTO Voucher = new Voucher_DTO();
            Voucher.VoucherName = txtVoucherName.Text.Trim();
            List<Voucher_DTO> VoucherList_search = Voucher_BLL.searchVoucher(Voucher);
            DataTable dataTable = ConvertData.ConvertToDataTable(VoucherList_search);
            dgvVoucher.DataSource = dataTable;
            // số lượng user
            lblQuantityVoucher.Text = VoucherList_search.Count.ToString() + " Voucher";
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            Refrech();
            txtIdVoucher.Text = "";
            txtVoucherName.Text = "";
            txtFixedPrice.Text = "";
            txtMinimumPrice.Text = "";
            txtQuantity.Text = "";
            cbIdCategory.Text = "";
        }
    }
}
