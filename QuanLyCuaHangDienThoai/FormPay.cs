using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using Guna.UI2.WinForms;
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
    public partial class FormPay : Form
    {
        public FormPay()
        {
            InitializeComponent();
        }

        public delegate void MoveInFormHome();
        public MoveInFormHome moveInFormHome;

        List<Product_DTO> listProductSelected = new List<Product_DTO>();
        public void getlistProductSelected(List<Product_DTO> list)
        {
            listProductSelected = list;
        }

        private void FormPay_Load(object sender, EventArgs e)
        {
            flpContainerProduct.Controls.Clear();
            foreach (Product_DTO product in listProductSelected)
            {
                //MessageBox.Show(product.ProductName);
                flpContainerProduct.Controls.Add(GenerateProduct(product));
            }
            lblPaymentRequired.Text = (int.Parse(lblTotalAmount.Text.Replace(",", "").Replace("đ", "").Trim()) 
                - int.Parse(lblDiscountVoucher.Text.Replace(",", "").Replace("đ", "").Trim())).ToString("N0") +"đ";
            turnOffHorizontalScrollbar(flpContainerProduct);

        }
        private void loadVoucherName()
        {
            cbVoucher.Items.Add("Voucher Name: " + voucher_DTO.VoucherName);
            cbVoucher.Text = "Voucher Name: " + voucher_DTO.VoucherName;
        }
        int totalMoney;
        private Panel GenerateProduct(Product_DTO product_DTO)
        {
            Panel pnlProduct = new Panel();
            // 
            // pnlProduct
            // 
            pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            pnlProduct.Location = new System.Drawing.Point(3, 3);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new System.Drawing.Size(883, 104);
            pnlProduct.TabIndex = 3;
            // 
            // lblPrice
            // 
            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(676, 33);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(53, 24);
            lblPrice.TabIndex = 4;
            lblPrice.Text = product_DTO.Price.ToString("N0") +"đ";

            // vì lblPrice ở dạng 1,000,000đ
            totalMoney += int.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
            lblTotalAmount.Text = totalMoney.ToString("N0") + "đ";
            // 
            // lblProductName
            // 
            Label lblProductName = new Label();
            lblProductName.AutoSize = true;
            lblProductName.Location = new System.Drawing.Point(150, 33);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(135, 24);
            lblProductName.TabIndex = 1;
            lblProductName.Text = product_DTO.ProductName;
            // 
            // picImageProduct
            // 
            Guna2PictureBox picImageProduct = new Guna2PictureBox();          
            picImageProduct.ImageRotate = 0F;
            picImageProduct.Location = new System.Drawing.Point(69, 12);
            picImageProduct.Name = "picImageProduct";
            picImageProduct.Size = new System.Drawing.Size(75, 75);
            picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picImageProduct.TabIndex = 0;
            picImageProduct.TabStop = false;
            picImageProduct.ImageLocation = product_DTO.ImageProduct;

            pnlProduct.Controls.Add(lblPrice);
            pnlProduct.Controls.Add(lblProductName);
            pnlProduct.Controls.Add(picImageProduct);
            return pnlProduct;
        }
        private void turnOffHorizontalScrollbar(FlowLayoutPanel flowLayoutPanel)
        {
            // tắt thanh cuộn ngang
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Maximum = 0;

            // tắt thanh cuộn dọc
            flowLayoutPanel.VerticalScroll.Enabled = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.VerticalScroll.Maximum = 0;

            flowLayoutPanel.AutoScroll = true;
        }
        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if(txtDeliveryAddress.Text.Trim() == "")
            {
                MessageBox.Show("Delivery Address is blank", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();

            // lấy đại ra id của staff bất kì để thêm bản ghi vô thôi cho đỡ lỗi khóa ngoại
            // chứ thật ra về sau thằng staff nào chỉnh sửa đơn hàng này thì lại cập nhật lại mà
            Staff_BLL staff_BLL = new Staff_BLL();
            List<int> idStaffList = staff_BLL.getIdStaff();

            // add order
            OrderTable_DTO orderTable_DTO = new OrderTable_DTO();          
            orderTable_DTO.IdCustomer = accountOnline.IdAccount;
            orderTable_DTO.IdStaff = idStaffList[0];
            orderTable_DTO.OrderStatus = "Wait for confirmation"; // cho nó mặc định chuỗi để định nghĩa về sau
            orderTable_DTO.TotalPrice = decimal.Parse(lblPaymentRequired.Text.Replace(",", "").Replace("đ", "").Trim());
            orderTable_DTO.DayBuy = DateTime.Now;
            orderTable_DTO.DeliveryAddress = txtDeliveryAddress.Text;

            OrderTable_BLL order_BLL = new OrderTable_BLL();
            int result = 1;
            if(result != order_BLL.addOrder(orderTable_DTO))
            {
                MessageBox.Show("add order is fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // add order detail
            // lấy ra id của order để add vào order detail
            int IdOrder = 0;
            List<OrderTable_DTO> orderList = order_BLL.OrderList();

            OrderTable_DTO lastOrder = orderList[orderList.Count - 1];
            IdOrder = lastOrder.IdOrderTable;

            foreach (Product_DTO product in listProductSelected)
            {
                OrderDetail_DTO orderDetail_DTO = new OrderDetail_DTO();
                orderDetail_DTO.IdOrder = IdOrder;
                orderDetail_DTO.IdProduct = product.IdProduct;
                orderDetail_DTO.QuantityProduct = product.Quantity;
                orderDetail_DTO.Price = product.Price;
                orderDetail_DTO.DiscountAmount = int.Parse(lblDiscountVoucher.Text.Replace(",", "").Replace("đ", "").Trim());
                orderDetail_DTO.IdVoucher = voucher_DTO.IdVoucher; // lấy id voucher từ bên form voucher

                if (result != order_BLL.addOrderDetail(orderDetail_DTO))
                {
                    MessageBox.Show("add order detail is fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            // sau khi add order detail thì thông báo thành công thôi
            MessageBox.Show("add order is success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // xóa hàng đã mua trong cart
            Product_BLL product_BLL = new Product_BLL();
            Cart_BLL cart_BLL = new Cart_BLL();
            foreach (Product_DTO product in listProductSelected)
            {
                if (result != cart_BLL.deleteCart(product, accountOnline))
                {
                    MessageBox.Show("delete product in cart is fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // cập nhật lại số lượng sản phẩm sau khi mua
                if (result != product_BLL.updateProductAfterBuy(product))
                {
                    MessageBox.Show("update quantity product after buy is fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            // chuyển đến form home
            moveInFormHome();
        }
        Voucher_DTO voucher_DTO = new Voucher_DTO();
        private void cbVoucher_Click(object sender, EventArgs e)
        {
            FormVoucher formVoucher = new FormVoucher();     
            formVoucher.ShowDialog();
            // phải cho nó show xong -> chọn xong -> lấy được voucher
            voucher_DTO = formVoucher.returnvoucherselected();
            // MessageBox.Show("Id voucher: " + voucher_DTO.IdVoucher.ToString()+", "+voucher_DTO.VoucherName);
            loadVoucherName();
        }
    }
}
