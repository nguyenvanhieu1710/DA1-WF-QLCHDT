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
        private void deleteControl()
        {
            foreach (Control c in this.Controls)
            {
                this.Controls.Remove(c);
            }
            // C#
            this.Controls.Remove(panel2);
            this.Controls.Remove(txtUserName);
            this.Controls.Remove(linkLabelFogetPassword);
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
        }
        // người dùng định nghĩa 1 con trỏ hàm 
        public delegate void OpenNewForm(Account_DTO account);
        public OpenNewForm openNewForm;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Account_BLL account_BLL = new Account_BLL();
            Account_DTO accountDTO = new Account_DTO() 
            { AccoutName = txtUserName.Text, Password = txtPassword.Text, Role = cbRole.Text };

            if (account_BLL.CheckAccount(accountDTO))
            {
                FormLoading formLoading = new FormLoading();
                formLoading.ShowDialog();
                openNewForm(accountDTO);
            }
            else
            {
                MessageBox.Show("User Name & Password & Role is incorrect","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void linkLabelFogetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deleteControl();
        }
    }
}
