using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BLL_CuaHangDienThoai;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
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

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

        private bool CheckRegex()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter User Name");
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password");
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter Email");
                return false;
            }
            if (txtVerificationCode.Text == "")
            {
                MessageBox.Show("Please enter Verification Code");
                return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return ;
            }
            Account_BLL account_BLL = new Account_BLL();
            if (account_BLL.CheckExited(txtUserName.Text))
            {
                MessageBox.Show("User Name exited");
                return;
            }
            if (txtVerificationCode.Text != code.ToString())
            {
                MessageBox.Show("Verification Code is incorrect");
                return;                
            }
            account_BLL.insertAccountCustomer_BLL(txtUserName.Text, txtPassword.Text, txtEmail.Text);
            if (account_BLL.CheckExited(txtUserName.Text))
            {
                MessageBox.Show("Register Finish");
                return;
            }
            else
            {
                MessageBox.Show("Register Fail");
                return;
            }
        }
        int code;
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Email");
                return;
            }
            Account_BLL account_BLL = new Account_BLL();
            code = account_BLL.SendCode(txtEmail.Text.Trim());
        }
    }
}
