using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormUserManagement : Form
    {
        
        public FormUserManagement()
        {
            InitializeComponent();
        }
        Customer_BLL customer_BLL = new Customer_BLL();
        string saveImage;
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picCustomerImage.Image = new Bitmap(openFileDialog.FileName);
                // MessageBox.Show("Đường dẫn của tệp hình ảnh đã chọn: " + openFileDialog.FileName);
            }
            string fileName = System.IO.Path.GetFileName(openFileDialog.FileName);
            // MessageBox.Show("Tên của tệp hình ảnh đã chọn: " + fileName);
            // Application.StartupPath là cắm đường dẫn tới folder Debug trong folder bin
            saveImage = Application.StartupPath + @"\Image\" + fileName;
            // MessageBox.Show(saveImage);
        }
        private Panel GennerateCustomer(Customer_DTO customer_DTO)
        {
            // 
            // pnlContainerUser
            // 
            Panel panel = new Panel();

            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "pnlContainerUser";
            panel.Size = new System.Drawing.Size(169, 198);
            panel.TabIndex = 0;
            // 
            // picImageUser
            // 
            PictureBox pictureBox = new PictureBox();
            pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox.Location = new System.Drawing.Point(9, 3);
            pictureBox.Name = "picImageUser";
            pictureBox.Size = new System.Drawing.Size(149, 135);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.ImageLocation = customer_DTO.ImageCustomer;
            // 
            // lblIdUser
            // 
            Label labelIdUser = new Label();
            labelIdUser.AutoSize = true;
            labelIdUser.Location = new System.Drawing.Point(9, 141);
            labelIdUser.Name = "lblIdUser";
            labelIdUser.Size = new System.Drawing.Size(31, 24);
            labelIdUser.TabIndex = 2;
            labelIdUser.Text = customer_DTO.IdCustomer.ToString();
            // 
            // lblNameUser
            // 
            Label labelNameUser = new Label();
            labelNameUser.AutoSize = true;
            labelNameUser.Location = new System.Drawing.Point(9, 165);
            labelNameUser.Name = "lblNameUser";
            labelNameUser.Size = new System.Drawing.Size(62, 24);
            labelNameUser.TabIndex = 2;
            labelNameUser.Text = customer_DTO.CustomerName;

            panel.Controls.Add(labelNameUser);
            panel.Controls.Add(labelIdUser);
            panel.Controls.Add(pictureBox);
            return panel;
        }
        private void Refrech()
        {
            List<Customer_DTO> customerList = customer_BLL.customerList();
            foreach (Customer_DTO customer in customerList)
            {
                flpContainerCustomer.Controls.Add(GennerateCustomer(customer));
            }
            lblQuantity.Text = customerList.Count.ToString() + " User";
        }
        private void FormUserManagement_Load(object sender, EventArgs e)
        {
            Refrech();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtIdUser.Text == "")
            {
                MessageBox.Show("Please enter ID Customer");
                return;
            }
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter Customer name");
                return;
            }
            if (cboGender.Text == "")
            {
                MessageBox.Show("Please enter gender");
                return;
            }
            if(picCustomerImage.Image == null)
            {
                MessageBox.Show("Please choose image");
                return;
            }
            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter phone number");
                return;
            }
            Customer_DTO customer_DTO = new Customer_DTO();
            customer_DTO.IdCustomer = int.Parse(txtIdUser.Text);
            customer_DTO.CustomerName = txtUserName.Text;
            customer_DTO.Birthday = DateTime.Parse(DateTimePickerBirthday.Text);
            customer_DTO.PhoneNumber = txtPhoneNumber.Text;
            customer_DTO.ImageCustomer = saveImage;
            customer_DTO.Gender = cboGender.Text;

            if(customer_BLL.CheckExit(customer_DTO))
            {
                MessageBox.Show("The customer already exists");
                return;
            }
            else
            {
                int result = 2;
                if(customer_BLL.addCustomer(customer_DTO) == result) 
                {
                    MessageBox.Show("Added customers successfully");
                    picCustomerImage.Image.Save($@"{saveImage}");
                    Refrech();
                    return;
                }
                else
                {
                    MessageBox.Show("Adding failed customers");
                    Refrech();
                    return;
                }
                customer_BLL.AddCustomer(customer_DTO);
                picCustomerImage.Image.Save($@"{saveImage}");
                // MessageBox.Show("susscess");
                if (customer_BLL.CheckExit(customer_DTO))
                {
                    MessageBox.Show("Added customers successfully");
                    Refrech();
                    return;
                }
                else
                {
                    MessageBox.Show("Adding failed customers");
                    return;
                }
            }         
        }
    }
}
