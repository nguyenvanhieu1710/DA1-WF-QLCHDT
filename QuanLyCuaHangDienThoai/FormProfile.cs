using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }
        Customer_BLL customer_BLL = new Customer_BLL();
        Account_BLL account_BLL = new Account_BLL();
        private void Refrech()
        {

        }
        private void LoadData()
        {
            List<Account_DTO> accountList = account_BLL.accountList();
            List<Customer_DTO> customerList = customer_BLL.customerList();
            int idOnline = 0;
            foreach (Account_DTO account in accountList)
            {
                if (account.Status == "Online")
                {
                    idOnline = account.IdAccount;
                }
            }
            foreach (Customer_DTO customer in customerList)
            {
                if (customer.IdCustomer == idOnline)
                {
                    picImageCustomer.ImageLocation = customer.ImageCustomer;
                    txtUserName.Text = customer.CustomerName;
                    cboGender.Text = customer.Gender;
                    DateTimePickerBirthday.Text = customer.Birthday.ToString();
                    txtPhoneNumber.Text = customer.PhoneNumber;
                }
            }
        }
        private void FormProfile_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Refrech();
            txtUserName.Text = "";
            txtPhoneNumber.Text = "";
            picImageCustomer.Image = null;
        }
        string saveImage; // đường dẫn đầy đủ tới nơi lưu ảnh
        string fileName; // tên file ảnh được chọn
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picImageCustomer.Image = new Bitmap(openFileDialog.FileName);
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
        private bool CheckRegex()
        {
            //if (txtIdUser.Text.Trim() == "")
            //{
            //    MessageBox.Show("Please enter ID Customer");
            //    return false;
            //}
            //if (!RegexData.IsValidId(txtIdUser.Text.Trim()))
            //{
            //    MessageBox.Show("ID Customer not valid");
            //    return false;
            //}
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Customer name");
                return false;
            }
            if (picImageCustomer.Image == null)
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
            //customer_DTO.IdCustomer = int.Parse(txtIdUser.Text);
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
                picImageCustomer.Image.Save($@"{saveImage}");
            }
            else
            {
                // lưu vô đối tượng DTO để cho vào cơ sở dữ liệu
                customer_DTO.ImageCustomer = saveImage;
                picImageCustomer.Image.Save($@"{saveImage}");
            }
        }
        private void NoChooseImage(Customer_DTO customer_DTO)
        {
            // nghĩa là ảnh cũ đã được lưu vào pictureBox từ trước rồi
            // thì dùng luôn đường dẫn cũ rồi cho vào database luôn
            customer_DTO.ImageCustomer = picImageCustomer.ImageLocation;
            string OldPath = picImageCustomer.ImageLocation;

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
                    picImageCustomer.Image.Save($@"{OldPath}");
                }
                // nếu đường dẫn đã tồn tại thì không cần save lại nữa
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }

            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();

            Customer_DTO customer_DTO = AssignDataDTO();
            customer_DTO.IdCustomer = accountOnline.IdAccount;

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
                MessageBox.Show("Save customers successfully");
                //Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Save failed customers");
                //Refrech();
                return;
            }
        }
    }
}
