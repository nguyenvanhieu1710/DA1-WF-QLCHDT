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
        string saveImage; // đường dẫn đầy đủ tới nơi lưu ảnh
        string fileName; // tên file ảnh được chọn
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picCustomerImage.Image = new Bitmap(openFileDialog.FileName);
                // MessageBox.Show("Đường dẫn của tệp hình ảnh đã chọn: " + openFileDialog.FileName);
                fileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                // MessageBox.Show("Tên của tệp hình ảnh đã chọn: " + fileName);
                // Application.StartupPath là cắm đường dẫn tới folder Debug trong folder bin
                saveImage = Application.StartupPath + @"\Image\" + fileName;
                // MessageBox.Show(saveImage);
            }
            else
            {
                //MessageBox.Show("Không chọn ảnh nào");
            }
        }
        private Panel GenerateCustomer(Customer_DTO customer_DTO)
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
            pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox.Location = new System.Drawing.Point(9, 3);
            pictureBox.Name = "picImageUser";
            pictureBox.Size = new System.Drawing.Size(149, 135);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.ImageLocation = customer_DTO.ImageCustomer; // đường dẫn cục bộ
            pictureBox.Click += (s, e) =>
            {
                int id = customer_DTO.IdCustomer;
                txtIdUser.Text = id.ToString();
                txtUserName.Text = customer_DTO.CustomerName;
                txtPhoneNumber.Text = customer_DTO.PhoneNumber;
                cboGender.Text = customer_DTO.Gender;
                DateTimePickerBirthday.Text = customer_DTO.Birthday.ToString();
                picCustomerImage.ImageLocation = customer_DTO.ImageCustomer;
            };
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
            flpContainerCustomer.Controls.Clear();
            List<Customer_DTO> customerList = customer_BLL.customerList();
            foreach (Customer_DTO customer in customerList)
            {
                // 3 là dữ liệu ảo
                if (customer.IdCustomer != 3)
                {
                    // customerList.Remove(customer);
                    flpContainerCustomer.Controls.Add(GenerateCustomer(customer));
                }
            }
            // số lượng user
            lblQuantity.Text = customerList.Count.ToString() + " User";
            // cập nhật lại để tránh khi không chọn ảnh
            // mà vẫn có đường dẫn được lưu vào biến này sau lần nhấn trước đó
            saveImage = "";
        }
        private void FormUserManagement_Load(object sender, EventArgs e)
        {
            Refrech();
        }
        private bool CheckRegex()
        {
            if (txtIdUser.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID Customer");
                return false;
            }
            if (!RegexData.IsValidId(txtIdUser.Text.Trim()))
            {
                MessageBox.Show("ID Customer not valid");
                return false;
            }
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Customer name");
                return false;
            }
            //if (!RegexData.IsValidName(txtUserName.Text))
            //{
            //    MessageBox.Show("Customer Name not valid");
            //    return false;
            //}
            //if (cboGender.Text.Trim() == "")
            //{
            //    MessageBox.Show("Please enter gender");
            //    return false;
            //}
            if (picCustomerImage.Image == null)
            {
                MessageBox.Show("Please choose image");
                return false;
            }
            if (txtPhoneNumber.Text.Trim() == "")
            {
                MessageBox.Show("Please enter phone number");
                return false;
            }
            if (!RegexData.IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone number not valid");
                return false;
            }
            return true;
        }
        private Customer_DTO AssignDataDTO()
        {
            // Hàm gán dữ liệu trở lại đối tượng DTO
            Customer_DTO customer_DTO = new Customer_DTO();
            customer_DTO.IdCustomer = int.Parse(txtIdUser.Text);
            customer_DTO.CustomerName = txtUserName.Text;
            customer_DTO.Birthday = DateTime.Parse(DateTimePickerBirthday.Text);
            customer_DTO.PhoneNumber = txtPhoneNumber.Text;
            customer_DTO.ImageCustomer = saveImage;
            customer_DTO.Gender = cboGender.Text;
            return customer_DTO;
        }
        private void ChooseImage(Customer_DTO customer_DTO)
        {
            if (!Directory.Exists(saveImage))
            {
                // MessageBox.Show("Path is not exists or not valid");
                saveImage = saveImage.Replace(@"\\", @"\");
                picCustomerImage.Image.Save($@"{saveImage}");
            }
            else
            {
                // lưu vô đối tượng DTO để cho vào cơ sở dữ liệu
                customer_DTO.ImageCustomer = saveImage;
                picCustomerImage.Image.Save($@"{saveImage}");
            }
        }
        private void NoChooseImage(Customer_DTO customer_DTO)
        {
            // nghĩa là ảnh cũ đã được lưu vào pictureBox từ trước rồi
            // thì dùng luôn đường dẫn cũ rồi cho vào database luôn
            customer_DTO.ImageCustomer = picCustomerImage.ImageLocation;
            string OldPath = picCustomerImage.ImageLocation;

            if (OldPath == "" || OldPath == null || OldPath == "No Image")
            {
                // nếu trong database là ảnh trống thì cứ để nguyên và thoát ra thôi
                return;
            }
            try
            {
                // Kiểm tra xem đường dẫn cũ tồn tại không
                var directory = Path.GetDirectoryName(OldPath);
                if (!Directory.Exists(directory)) // nếu đường dẫn không tồn tại
                {
                    MessageBox.Show("Path is not exists or not valid");
                    // Tạo đường dẫn nếu nó không tồn tại
                    Directory.CreateDirectory(directory);
                    picCustomerImage.Image.Save($@"{OldPath}");
                }
                // nếu đường dẫn đã tồn tại thì không cần save lại nữa
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Customer_DTO customer_DTO = AssignDataDTO();

            if (customer_BLL.CheckExit(customer_DTO))
            {
                MessageBox.Show("The customer already exists");
                return;
            }
            if (saveImage == null || saveImage == "")
            {
                // không chọn ảnh -> đường dẫn trống
                NoChooseImage(customer_DTO);
            }
            else
            {
                // chọn ảnh -> có đường dẫn
                ChooseImage(customer_DTO);
            }
            int result = 2; //kiểm tra số bản ghi thêm vào có đúng không
            // lưu vào database
            if (customer_BLL.addCustomer(customer_DTO) == result)
            {
                MessageBox.Show("Added customers successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Adding failed customers");
                Refrech();
                return;
            }
        }

        private void btnFixUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Customer_DTO customer_DTO = AssignDataDTO();

            if (!customer_BLL.CheckExit(customer_DTO))
            {
                MessageBox.Show("Customer does not exist");
                return;
            }

            if (saveImage == null || saveImage == "")
            {
                // không chọn ảnh -> đường dẫn trống
                NoChooseImage(customer_DTO);
            }
            else
            {
                // chọn ảnh -> có đường dẫn
                ChooseImage(customer_DTO);
            }

            int result = 1; //kiểm tra số bản ghi sửa có đúng không
            if (customer_BLL.fixCustomer(customer_DTO) == result)
            {
                MessageBox.Show("Fixed customers successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Fix failed customers");
                Refrech();
                return;
            }
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            Refrech();
            txtIdUser.Text = "";
            txtUserName.Text = "";
            txtPhoneNumber.Text = "";
            picCustomerImage.Image = null;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Customer_DTO customer_DTO = AssignDataDTO();

            if (!customer_BLL.CheckExit(customer_DTO))
            {
                MessageBox.Show("Customer does not exist");
                return;
            }

            // vì không xác định được chính xác số bản ghi bị ảnh hưởng nên cứ để chạy bình thường thôi
            customer_BLL.deleteCustomer(customer_DTO);

            if (!customer_BLL.CheckExit(customer_DTO))
            {
                MessageBox.Show("Delete customer success");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Delete fail customer");
                Refrech();
                return;
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("please enter customer name");
                return;
            }
            Customer_DTO customer = new Customer_DTO();
            customer.CustomerName = txtUserName.Text.Trim();
            List<Customer_DTO> customerList_search = customer_BLL.searchCustomer(customer);
            flpContainerCustomer.Controls.Clear();
            foreach (Customer_DTO customers in customerList_search)
            {
                flpContainerCustomer.Controls.Add(GenerateCustomer(customers));
            }
            // số lượng user
            lblQuantity.Text = customerList_search.Count.ToString() + " User";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbFilter.Text == "")
            {
                MessageBox.Show("Please choose combobox");
                return;
            }

            List<Customer_DTO> customerFilter = customer_BLL.filterCustomer(cbFilter.Text);
            flpContainerCustomer.Controls.Clear();
            foreach (Customer_DTO customers in customerFilter)
            {
                flpContainerCustomer.Controls.Add(GenerateCustomer(customers));
            }
            // số lượng user
            lblQuantity.Text = customerFilter.Count.ToString() + " User";
        }
    }
}
