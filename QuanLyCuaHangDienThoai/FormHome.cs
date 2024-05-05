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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private void LoadProduct()
        {
            FormProduct formProduct = new FormProduct();
            // formProduct.openNewForm += FormProduct_openNewForm;
            // truy cập vào biến openNewForm
            // và khởi tạo đối tượng dựa trên class của em nó
            formProduct.moveInFormProductDetail = new FormProduct.MoveInFormProductDetail(moveInFormProductDetail);
            formProduct.moveInFormCart = new FormProduct.MoveInFormCart(moveInFormCart);
            content(formProduct);
        }
        private void moveInFormProductDetail(Product_DTO product_DTO)
        {
            FormProductDetail productDetail = new FormProductDetail();
            productDetail.getProduct(product_DTO);
            productDetail.moveInFormCart = new FormProductDetail.MoveInFormCart(moveInFormCart);
            content(productDetail);
        }
        private void moveInFormCart()
        {
            FormCart cart = new FormCart();
            //cart.getProduct(product_DTO);
            content(cart);
        }
        private void moveInFormPay(Product_DTO product_DTO)
        {
            FormPay formPay = new FormPay();
            formPay.getProduct(product_DTO);
            content(formPay);
        }
        private void moveProductToFormPay(List<Product_DTO> listProductSelected)
        {
            FormPay formPay = new FormPay();
            formPay.getlistProductSelected(listProductSelected);
            // dùng tạm product như form home
            formPay.moveInFormHome = new FormPay.MoveInFormHome(LoadProduct);
            // formPay.getProduct(product_DTO);
            content(formPay);
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadControlWithCustomer();
        }
        private void LoadControlWithCustomer()
        {
            btnHome.Visible = true;
            btnLogin.Visible = true;
            btnRegister.Visible = true;
            btnProfile.Visible = true;
            btnCart.Visible = true;
            btnOrder.Visible = true;

            btnProductManagement.Visible = false;
            btnCategoryManagement.Visible = false;
            btnUserManagement.Visible = false;
            btnStaffManagement.Visible = false;
            btnDashboard.Visible = false;
            btnVoucherManagement.Visible = false;
            btnVoucher.Visible = false;
            btnReport.Visible = false;
            btnBill.Visible = false;
        }
        private void Navigation(Account_DTO account_DTO)
        {
            if(account_DTO.Role == "Admin")
            {
                btnUserManagement.Visible = true;
                btnStaffManagement.Visible = true;

                btnProductManagement.Visible = false;
                btnCategoryManagement.Visible = false;
                btnHome.Visible = false;
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnProfile.Visible = false;
                btnCart.Visible = false;
                btnDashboard.Visible = false;
                btnVoucherManagement.Visible = false;
                btnOrder.Visible = false;
                btnVoucher.Visible = false;
                btnReport.Visible = false;
                btnBill.Visible = false;
            }
            if(account_DTO.Role == "Staff")
            {
                btnProductManagement.Visible = true;
                btnCategoryManagement.Visible = true;
                btnDashboard.Visible = true;
                btnVoucherManagement.Visible = true;
                btnOrder.Visible = true;
                btnReport.Visible = true;
                btnBill.Visible = true;

                btnHome.Visible = false;
                btnUserManagement.Visible = false;
                btnStaffManagement.Visible = false;
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnCart.Visible = false;
                btnProfile.Visible = false;
                btnVoucher.Visible = false;
            }
            if (account_DTO.Role == "Customer")
            {
                LoadControlWithCustomer();
            }
        }
        private void content(object _form)
        {
            if(pnlContent.Controls.Count > 0)
            {
                pnlContent.Controls.Clear();
            }
            // Ép kiểu đối tượng _form thành một Form
            Form fm = _form as Form;
            // cho phép fm được thêm vào pnlContent
            fm.TopLevel = false;
            // add form in control
            pnlContent.Controls.Add(fm);
            // Thuộc tính Tag thường được sử dụng để lưu trữ dữ liệu liên quan đến đối tượng
            pnlContent.Tag = fm;
            fm.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "User Management";
            picTopic.Image = Properties.Resources.User;
            content(new FormUserManagement());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Home";
            picTopic.Image = Properties.Resources.icon_home_blue;
            //FormProduct formProduct = new FormProduct();
            //// formProduct.openNewForm += FormProduct_openNewForm;
            //content(formProduct);
            LoadProduct();
        }
        private void FormProduct_openNewForm(object sender, EventArgs e)
        {
            //FormProductDetail formProductDetail = new FormProductDetail();
            //formProductDetail.getProduct();
            //content(new FormProductDetail());
        }
        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Staff Management";
            picTopic.Image = Properties.Resources.User;
            content(new FormStaffManagement());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            // truy cập vào biến openNewForm
            // và khởi tạo đối tượng dựa trên class của em nó
            formDangNhap.openNewForm = new FormDangNhap.OpenNewForm(Navigation);
            lblTopic.Text = "Login";
            picTopic.Image = Properties.Resources.icon_login_blue;
            // content(new FormDangNhap());
            content(formDangNhap);
            // đầu tiên gán Nav -> login
            // xong thì content(formDangNhap) chạy login xong thì gán đối tượng lại Nav
            // xong Nav điều khiển home thay đổi theo ý mình
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Register";
            picTopic.Image = Properties.Resources.icon_register_blue;
            content(new FormDangKy());
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoadControlWithCustomer();
                Account_BLL account_BLL = new Account_BLL();
                account_BLL.UpdateStatusOffline();
                MessageBox.Show("Log out success", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                pnlContent.Controls.Clear();
            }
        }
        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Product Management";
            picTopic.Image = Properties.Resources.icon_mobile_phone_blue;
            content(new FormProductManagement());
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Profile";
            picTopic.Image = Properties.Resources.User;
            content(new FormProfile());
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Category Management";
            picTopic.Image = Properties.Resources.icon_mobile_phone_blue;
            content(new FormCategoryManagement());
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            //formCart.moveInFormPay = new FormCart.MoveInFormPay(moveInFormPay);
            formCart.moveProductToFormPay = new FormCart.MoveProductToFormPay(moveProductToFormPay);
            lblTopic.Text = "Cart";
            picTopic.Image = Properties.Resources.icon_mobile_phone_blue;
            content(formCart);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Dashboard";
            picTopic.Image = Properties.Resources.icon_dashboard_blue;
            content(new FormDashboard());
        }

        private void btnVoucherManagement_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Voucher Management";
            picTopic.Image = Properties.Resources.icon_voucher_blue;
            content(new FormVoucherManagement());
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Function is updating. Do you still want to continue watching?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            lblTopic.Text = "Help";
            picTopic.Image = Properties.Resources.icon_info_blue;
            content(new FormMessage());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Account_BLL account_BLL = new Account_BLL();
            account_BLL.UpdateStatusOffline();
            // MessageBox.Show("Log out success", "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Close();
        }
        private void moveInFormOrderDetail(OrderTable_DTO orderTable_DTO)
        {
            FormOrderDetailcs formOrderDetailcs = new FormOrderDetailcs();
            formOrderDetailcs.getOrder(orderTable_DTO);
            lblTopic.Text = "Order Detail";
            picTopic.Image = Properties.Resources.icon_order_blue;
            content(formOrderDetailcs);
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder order = new FormOrder();
            order.moveInFormOrderDetail = new FormOrder.MoveInFormOrderDetail(moveInFormOrderDetail);
            lblTopic.Text = "Order";
            picTopic.Image = Properties.Resources.icon_order_blue;
            content(order);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Report";
            picTopic.Image = Properties.Resources.icon_report_blue;
            content(new FormReport());
        }private void btnBill_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Bill";
            picTopic.Image = Properties.Resources.icon_bill_blue;
            content(new FormBill());
        }
    }
}
