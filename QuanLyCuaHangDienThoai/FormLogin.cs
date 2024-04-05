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

namespace QuanLyCuaHangDienThoai
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.IconRight = Properties.Resources.eye_open;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.IconRight = Properties.Resources.eye_close;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Account_BLL account_BLL = new Account_BLL();
            
            if(account_BLL.CheckAccount(txtUserName.Text, txtPassword.Text, cbRole.Text))
            {
                FormLoading formLoading = new FormLoading();
                formLoading.ShowDialog();
            }
            else
            {
                MessageBox.Show("User Name & Password & Role is incorrect","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
