using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormStaffManagement : Form
    {
        public FormStaffManagement()
        {
            InitializeComponent();
        }
        Staff_BLL Staff_BLL = new Staff_BLL();
        private bool CheckRegex()
        {
            if (txtIdStaff.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID Staff");
                return false;
            }
            if (!RegexData.IsValidId(txtIdStaff.Text.Trim()))
            {
                MessageBox.Show("ID Staff not valid");
                return false;
            }
            if (txtStaffName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Staff name");
                return false;
            }
            //if (!RegexData.IsValidName(txtStaffName.Text))
            //{
            //    MessageBox.Show("Staff Name not valid");
            //    return false;
            //}
            //if (cboGender.Text.Trim() == "")
            //{
            //    MessageBox.Show("Please enter gender");
            //    return false;
            //}
            if (picStaffImage.Image == null)
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
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please enter address");
                return false;
            }
            //if (txtAddress.Text.Trim() == "")
            //{
            //    MessageBox.Show("Please enter Address");
            //    return false;
            //}
            //if (!RegexData.IsValidName(txtAddress.Text))
            //{
            //    MessageBox.Show("Addess not valid");
            //    return false;
            //}
            return true;
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Staff_DTO staff_DTO = AssignDataDTO();

            if (Staff_BLL.CheckExit(staff_DTO))
            {
                MessageBox.Show("The Staff already exists");
                return;
            }
            if (saveImage == null || saveImage == "")
            {
                // không chọn ảnh -> đường dẫn trống
                NoChooseImage(staff_DTO);
            }
            else
            {
                // chọn ảnh -> có đường dẫn
                ChooseImage(staff_DTO);
            }
            int result = 2; //kiểm tra số bản ghi thêm vào có đúng không
            // lưu vào database
            if (Staff_BLL.addStaff(staff_DTO) == result)
            {
                MessageBox.Show("Added Staffs successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Adding failed Staffs");
                Refrech();
                return;
            }
        }
        private void Refrech()
        {
            flpContainerStaff.Controls.Clear();
            List<Staff_DTO> StaffList = Staff_BLL.staffList();
            foreach (Staff_DTO Staff in StaffList)
            {
                // 2 là dữ liệu ảo
                if (Staff.IdStaff != 2)
                {
                    // StaffList.Remove(Staff);
                    flpContainerStaff.Controls.Add(GenerateStaff(Staff));
                }
            }
            // số lượng user
            lblQuantityStaff.Text = StaffList.Count.ToString() + " Staff";
            // cập nhật lại để tránh khi không chọn ảnh
            // mà vẫn có đường dẫn được lưu vào biến này sau lần nhấn trước đó
            saveImage = "";
        }
        private void FormStaffManagement_Load(object sender, EventArgs e)
        {
            Refrech();
        }
        string saveImage; // đường dẫn đầy đủ tới nơi lưu ảnh
        string fileName; // tên file ảnh được chọn
        private void btnChooseImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picStaffImage.Image = new Bitmap(openFileDialog.FileName);
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
        private void ChooseImage(Staff_DTO Staff_DTO)
        {
            if (!Directory.Exists(saveImage))
            {
                // MessageBox.Show("Path is not exists or not valid");
                saveImage = saveImage.Replace(@"\\", @"\");
                picStaffImage.Image.Save($@"{saveImage}");
            }
            else
            {
                // lưu vô đối tượng DTO để cho vào cơ sở dữ liệu
                Staff_DTO.ImageStaff = saveImage;
                picStaffImage.Image.Save($@"{saveImage}");
            }
        }
        private void NoChooseImage(Staff_DTO Staff_DTO)
        {
            // nghĩa là ảnh cũ đã được lưu vào pictureBox từ trước rồi
            // thì dùng luôn đường dẫn cũ rồi cho vào database luôn
            Staff_DTO.ImageStaff = picStaffImage.ImageLocation;
            string OldPath = picStaffImage.ImageLocation;

            // nếu đường dẫn đã tồn tại thì không cần save lại nữa
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
                    picStaffImage.Image.Save($@"{OldPath}");
                }
                // nếu đường dẫn đã tồn tại thì không cần save lại nữa
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Panel GenerateStaff(Staff_DTO staff_DTO)
        {
            // 
            // pnlContainerStaff
            // 
            Panel panel = new Panel();

            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "pnlContainerStaff";
            panel.Size = new System.Drawing.Size(169, 198);
            panel.TabIndex = 0;
            // 
            // lblNameStaff
            // 
            Label labelNameStaff = new Label();
            labelNameStaff.AutoSize = true;
            labelNameStaff.Location = new System.Drawing.Point(9, 165);
            labelNameStaff.Name = "lblNameStaff";
            labelNameStaff.Size = new System.Drawing.Size(62, 24);
            labelNameStaff.TabIndex = 2;
            labelNameStaff.Text = staff_DTO.StaffName;
            // 
            // lblIdStaff
            // 
            Label labelIdStaff = new Label();
            labelIdStaff.AutoSize = true;
            labelIdStaff.Location = new System.Drawing.Point(9, 141);
            labelIdStaff.Name = "lblIdStaff";
            labelIdStaff.Size = new System.Drawing.Size(31, 24);
            labelIdStaff.TabIndex = 2;
            labelIdStaff.Text = staff_DTO.IdStaff.ToString();
            // 
            // picImageStaff
            // 
            PictureBox pictureBox = new PictureBox();
            pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox.Location = new System.Drawing.Point(9, 3);
            pictureBox.Name = "picImageStaff";
            pictureBox.Size = new System.Drawing.Size(149, 135);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.ImageLocation = staff_DTO.ImageStaff; // đường dẫn cục bộ
            pictureBox.Click += (s, e) =>
            {
                int id = staff_DTO.IdStaff;
                txtIdStaff.Text = id.ToString();
                txtStaffName.Text = staff_DTO.StaffName;
                txtPhoneNumber.Text = staff_DTO.PhoneNumber;
                cboGender.Text = staff_DTO.Gender;
                DateTimePickerBirthday.Text = staff_DTO.Birthday.ToString();
                picStaffImage.ImageLocation = staff_DTO.ImageStaff;
                txtAddress.Text = staff_DTO.Address;
            };

            panel.Controls.Add(labelNameStaff);
            panel.Controls.Add(labelIdStaff);
            panel.Controls.Add(pictureBox);
            return panel;
        }
        private Staff_DTO AssignDataDTO()
        {
            // Hàm gán dữ liệu trở lại đối tượng DTO
            Staff_DTO Staff_DTO = new Staff_DTO();
            Staff_DTO.IdStaff = int.Parse(txtIdStaff.Text);
            Staff_DTO.StaffName = txtStaffName.Text;
            Staff_DTO.Birthday = DateTime.Parse(DateTimePickerBirthday.Text);
            Staff_DTO.PhoneNumber = txtPhoneNumber.Text;
            Staff_DTO.ImageStaff = saveImage;
            Staff_DTO.Gender = cboGender.Text;
            Staff_DTO.Address = txtAddress.Text;
            return Staff_DTO;
        }

        private void btnFixStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Staff_DTO Staff_DTO = AssignDataDTO();

            if (!Staff_BLL.CheckExit(Staff_DTO))
            {
                MessageBox.Show("Staff does not exist");
                return;
            }

            if (saveImage == null || saveImage == "")
            {
                // không chọn ảnh -> đường dẫn trống
                NoChooseImage(Staff_DTO);
            }
            else
            {
                // chọn ảnh -> có đường dẫn
                ChooseImage(Staff_DTO);
            }

            int result = 1; //kiểm tra số bản ghi sửa có đúng không
            if (Staff_BLL.fixStaff(Staff_DTO) == result)
            {
                MessageBox.Show("Fixed Staffs successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Fix failed Staffs");
                Refrech();
                return;
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Staff_DTO Staff_DTO = AssignDataDTO();

            if (!Staff_BLL.CheckExit(Staff_DTO))
            {
                MessageBox.Show("Staff does not exist");
                return;
            }

            // vì không xác định được chính xác số bản ghi bị ảnh hưởng nên cứ để chạy bình thường thôi
            Staff_BLL.deleteStaff(Staff_DTO);

            if (!Staff_BLL.CheckExit(Staff_DTO))
            {
                MessageBox.Show("Delete Staff success");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Delete fail Staff");
                Refrech();
                return;
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text.Trim() == "")
            {
                MessageBox.Show("please enter staff name");
                return;
            }
            Staff_DTO Staff = new Staff_DTO();
            Staff.StaffName = txtStaffName.Text.Trim();
            List<Staff_DTO> StaffList_search = Staff_BLL.searchStaff(Staff);
            flpContainerStaff.Controls.Clear();
            foreach (Staff_DTO Staffs in StaffList_search)
            {
                flpContainerStaff.Controls.Add(GenerateStaff(Staffs));
            }
            // số lượng user
            lblQuantityStaff.Text = StaffList_search.Count.ToString() + " User";
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            Refrech();
            txtIdStaff.Text = "";
            txtStaffName.Text = "";
            txtPhoneNumber.Text = "";
            picStaffImage.Image = null;
            txtAddress.Text = "";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbFilter.Text == "")
            {
                MessageBox.Show("Please choose combobox");
                return;
            }

            List<Staff_DTO> staffFilter = Staff_BLL.filterStaff(cbFilter.Text);
            flpContainerStaff.Controls.Clear();
            foreach (Staff_DTO staffs in staffFilter)
            {
                flpContainerStaff.Controls.Add(GenerateStaff(staffs));
            }
            // số lượng user
            lblQuantityStaff.Text = staffFilter.Count.ToString() + " User";
        }
    }
}
