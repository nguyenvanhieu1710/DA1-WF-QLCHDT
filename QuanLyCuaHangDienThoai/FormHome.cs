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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            FormProduct formProduct = new FormProduct();
            formProduct.openNewForm += FormProduct_openNewForm;
            content(formProduct);
        }

        private void content(object _form)
        {
            if(pnlContent.Controls.Count > 0)
            {
                pnlContent.Controls.Clear();
            }
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(fm);
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
            FormProduct formProduct = new FormProduct();
            formProduct.openNewForm += FormProduct_openNewForm;
            content(formProduct);
        }
        private void FormProduct_openNewForm(object sender, EventArgs e)
        {
            content(new FormProfile());
        }
        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Staff Management";
            picTopic.Image = Properties.Resources.User;
            content(new FormStaffManagement());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Login";
            picTopic.Image = Properties.Resources.icon_login_blue;
            content(new FormDangNhap());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblTopic.Text = "Register";
            picTopic.Image = Properties.Resources.icon_register_blue;
            content(new FormDangKy());
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
            picTopic.Image = Properties.Resources.icon_login_blue;
            content(new FormCategoryManagement());
        }
    }
}
