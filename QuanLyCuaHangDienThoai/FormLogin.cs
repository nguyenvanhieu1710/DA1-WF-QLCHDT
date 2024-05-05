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
using Guna.UI2.WinForms;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        Account_BLL account_BLL = new Account_BLL();
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
            // check xem còn ai online hay không
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();
            if (quantityAccountOnline > 0)
            {
                // vẫn còn tài khoản đang online
                account_BLL.UpdateStatusOffline();
            }

            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Account_DTO accountDTO = new Account_DTO() 
            { AccoutName = txtUserName.Text, Password = txtPassword.Text, Role = cbRole.Text };

            if (account_BLL.CheckAccount(accountDTO))
            {
                account_BLL.updateStatusOnline(accountDTO);
                FormLoading formLoading = new FormLoading();
                formLoading.ShowDialog();
                openNewForm(accountDTO);
                deleteControl();
            }
            else
            {
                MessageBox.Show("User Name & Password & Role is incorrect","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void linkLabelFogetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deleteControl();
            this.Controls.Add(GeneratePasswordRetrieval());
        }
        private Panel GeneratePasswordRetrieval()
        {
            Panel pnlFogetPassword = new Panel();
            // 
            // pnlFogetPassword
            // 
            
            pnlFogetPassword.Location = new System.Drawing.Point(113, 115);
            pnlFogetPassword.Name = "pnlFogetPassword";
            pnlFogetPassword.Size = new System.Drawing.Size(670, 344);
            pnlFogetPassword.TabIndex = 24;
            // 
            // btnSendCode
            // 
            Guna2Button btnSendCode = new Guna2Button();
            btnSendCode.AutoRoundedCorners = true;
            btnSendCode.BorderRadius = 26;
            btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSendCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnSendCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnSendCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnSendCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnSendCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            btnSendCode.ForeColor = System.Drawing.Color.White;
            btnSendCode.Location = new System.Drawing.Point(440, 128);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new System.Drawing.Size(155, 55);
            btnSendCode.TabIndex = 13;
            btnSendCode.Text = "Send Code";
            
            // 
            // txtVerificationCode
            // 
            Guna2TextBox txtVerificationCode = new Guna2TextBox();
            txtVerificationCode.BorderColor = System.Drawing.Color.DeepSkyBlue;
            txtVerificationCode.BorderThickness = 2;
            txtVerificationCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtVerificationCode.DefaultText = "";
            txtVerificationCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            txtVerificationCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            txtVerificationCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtVerificationCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtVerificationCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtVerificationCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            txtVerificationCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtVerificationCode.IconLeftSize = new System.Drawing.Size(35, 35);
            txtVerificationCode.Location = new System.Drawing.Point(386, 200);
            txtVerificationCode.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.PasswordChar = '\0';
            txtVerificationCode.PlaceholderText = "Verification Code";
            txtVerificationCode.SelectedText = "";
            txtVerificationCode.Size = new System.Drawing.Size(209, 45);
            txtVerificationCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtVerificationCode.TabIndex = 12;
            // 
            // txtEmail
            // 
            Guna2TextBox txtEmail = new Guna2TextBox();
            txtEmail.BorderColor = System.Drawing.Color.DeepSkyBlue;
            txtEmail.BorderThickness = 2;
            txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtEmail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtEmail.IconLeft = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_email_blue;
            txtEmail.IconLeftSize = new System.Drawing.Size(35, 35);
            txtEmail.Location = new System.Drawing.Point(34, 123);
            txtEmail.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.Size = new System.Drawing.Size(406, 60);
            txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtEmail.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            Guna2TextBox txtCustomerName = new Guna2TextBox();
            txtCustomerName.BorderColor = System.Drawing.Color.DeepSkyBlue;
            txtCustomerName.BorderThickness = 2;
            txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCustomerName.DefaultText = "";
            txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtCustomerName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtCustomerName.IconLeft = global::QuanLyCuaHangDienThoai.Properties.Resources.User;
            txtCustomerName.IconLeftSize = new System.Drawing.Size(35, 35);
            txtCustomerName.Location = new System.Drawing.Point(34, 35);
            txtCustomerName.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PasswordChar = '\0';
            txtCustomerName.PlaceholderText = "User name";
            txtCustomerName.SelectedText = "";
            txtCustomerName.Size = new System.Drawing.Size(561, 70);
            txtCustomerName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCustomerName.TabIndex = 9;
            // 
            // btnCheck
            // 
            Guna2Button btnCheck = new Guna2Button();
            btnCheck.AutoRoundedCorners = true;
            btnCheck.BorderRadius = 27;
            btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnCheck.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            btnCheck.ForeColor = System.Drawing.Color.White;
            btnCheck.Location = new System.Drawing.Point(208, 271);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new System.Drawing.Size(204, 57);
            btnCheck.TabIndex = 14;
            btnCheck.Text = "Check";

            pnlFogetPassword.Controls.Add(btnCheck);
            pnlFogetPassword.Controls.Add(btnSendCode);
            pnlFogetPassword.Controls.Add(txtVerificationCode);
            pnlFogetPassword.Controls.Add(txtEmail);
            pnlFogetPassword.Controls.Add(txtCustomerName);

            
            btnSendCode.Click += (s, e) =>
            {
                handleEventSendCode(txtEmail.Text);
            };

            btnCheck.Click += (s, e) =>
            {
                handleEventCheck(txtCustomerName.Text, txtEmail.Text, txtVerificationCode.Text);
            };

            return pnlFogetPassword;
        }
        int code;
        private void handleEventSendCode(string email)
        {

            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (email.Trim() == "")
            {
                MessageBox.Show("Please enter Email");
                return;
            }

            code = account_BLL.SendCode(email.Trim());
        }
        private void handleEventCheck(string customerName, string email, string verificationCode)
        {
            if (customerName.Trim() == "")
            {
                MessageBox.Show("Please enter User Name");
                return;
            }
            if (email.Trim() == "")
            {
                MessageBox.Show("Please enter email");
                return;
            }
            if (verificationCode.Trim() == "")
            {
                MessageBox.Show("Please enter Verification Code");
                return;
            }
            if (!account_BLL.CheckExited(customerName.Trim()))
            {
                MessageBox.Show("User Name not exit");
                return;
            }
            if (verificationCode.Trim() != code.ToString())
            {
                MessageBox.Show("Verification Code is incorrect");
                return;
            }
            deleteControl();
            this.Controls.Add(GenerateContainerNewPassword());
            // sau khi hiện chỗ nhập password lên thì truyền luôn customer name
            // để biết ai đang định thay đổi mật khẩu
            CustomerName = customerName.Trim();
        }
        string CustomerName;
        private Panel GenerateContainerNewPassword()
        {
            Panel pnlFogetPassword = new Panel();
            // 
            // pnlFogetPassword
            // 
            pnlFogetPassword.Location = new System.Drawing.Point(113, 115);
            pnlFogetPassword.Name = "pnlFogetPassword";
            pnlFogetPassword.Size = new System.Drawing.Size(670, 344);
            pnlFogetPassword.TabIndex = 25;
            // 
            // btnSaveNewPassword
            // 
            Guna2Button btnSaveNewPassword = new Guna2Button();
            btnSaveNewPassword.AutoRoundedCorners = true;
            btnSaveNewPassword.BorderRadius = 27;
            btnSaveNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSaveNewPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnSaveNewPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnSaveNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnSaveNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnSaveNewPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            btnSaveNewPassword.ForeColor = System.Drawing.Color.White;
            btnSaveNewPassword.Location = new System.Drawing.Point(208, 271);
            btnSaveNewPassword.Name = "btnSaveNewPassword";
            btnSaveNewPassword.Size = new System.Drawing.Size(204, 57);
            btnSaveNewPassword.TabIndex = 14;
            btnSaveNewPassword.Text = "Save";
            // 
            // txtNewPassword
            // 
            Guna2TextBox txtNewPassword = new Guna2TextBox();
            txtNewPassword.BorderColor = System.Drawing.Color.DeepSkyBlue;
            txtNewPassword.BorderThickness = 2;
            txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNewPassword.DefaultText = "";
            txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtNewPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            txtNewPassword.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            txtNewPassword.IconLeft = global::QuanLyCuaHangDienThoai.Properties.Resources.Password;
            txtNewPassword.IconLeftSize = new System.Drawing.Size(35, 35);
            txtNewPassword.IconRight = global::QuanLyCuaHangDienThoai.Properties.Resources.eye_close;
            txtNewPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            txtNewPassword.IconRightSize = new System.Drawing.Size(35, 35);
            txtNewPassword.Location = new System.Drawing.Point(141, 52);
            txtNewPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            txtNewPassword.PlaceholderText = "New Password";
            txtNewPassword.SelectedText = "";
            txtNewPassword.Size = new System.Drawing.Size(377, 66);
            txtNewPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtNewPassword.TabIndex = 15;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            Guna2TextBox txtConfirmPassword = new Guna2TextBox();
            txtConfirmPassword.BorderColor = System.Drawing.Color.DeepSkyBlue;
            txtConfirmPassword.BorderThickness = 2;
            txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            txtConfirmPassword.IconLeft = global::QuanLyCuaHangDienThoai.Properties.Resources.Password;
            txtConfirmPassword.IconLeftSize = new System.Drawing.Size(35, 35);
            txtConfirmPassword.IconRight = global::QuanLyCuaHangDienThoai.Properties.Resources.eye_close;
            txtConfirmPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            txtConfirmPassword.IconRightSize = new System.Drawing.Size(35, 35);
            txtConfirmPassword.Location = new System.Drawing.Point(141, 142);
            txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.Size = new System.Drawing.Size(377, 66);
            txtConfirmPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtConfirmPassword.TabIndex = 15;
            txtConfirmPassword.UseSystemPasswordChar = true;

            pnlFogetPassword.Controls.Add(txtConfirmPassword);
            pnlFogetPassword.Controls.Add(txtNewPassword);
            pnlFogetPassword.Controls.Add(btnSaveNewPassword);

            txtNewPassword.IconRightClick += (s, e) =>
            {
                if (txtNewPassword.UseSystemPasswordChar)
                {
                    txtNewPassword.PasswordChar = '\0';
                    txtNewPassword.UseSystemPasswordChar = false;
                    txtNewPassword.IconRight = Properties.Resources.eye_open;
                }
                else
                {
                    txtNewPassword.UseSystemPasswordChar = true;
                    txtNewPassword.IconRight = Properties.Resources.eye_close;
                    txtNewPassword.PasswordChar = '\0';
                }
            };
            txtConfirmPassword.IconRightClick += (s, e) =>
            {
                if (txtConfirmPassword.UseSystemPasswordChar)
                {
                    txtConfirmPassword.PasswordChar = '\0';
                    txtConfirmPassword.UseSystemPasswordChar = false;
                    txtConfirmPassword.IconRight = Properties.Resources.eye_open;
                }
                else
                {
                    txtConfirmPassword.UseSystemPasswordChar = true;
                    txtConfirmPassword.IconRight = Properties.Resources.eye_close;
                    txtConfirmPassword.PasswordChar = '\0';
                }
            };

            btnSaveNewPassword.Click += (s, e) =>
            {
                handleEventSaveNewPassword(txtNewPassword.Text, txtConfirmPassword.Text);
            };

            return pnlFogetPassword;
        }
        private void handleEventSaveNewPassword(string newPassword, string confirmPassword)
        {
            if(newPassword.Trim() == "")
            {
                MessageBox.Show("Please enter new password");
                return;
            }
            if (confirmPassword.Trim() == "")
            {
                MessageBox.Show("Please enter confirm password");
                return;
            }
            if (newPassword.Trim() != confirmPassword.Trim())
            {
                MessageBox.Show("Password is not the same");
                return;
            }
            int result = 1;
            if (account_BLL.updatePassword(CustomerName, newPassword) == result)
            {
                MessageBox.Show("Change password success");
                deleteControl();
            }
            else
            {
                MessageBox.Show("Change password fail");
            }
        }
    }
}
