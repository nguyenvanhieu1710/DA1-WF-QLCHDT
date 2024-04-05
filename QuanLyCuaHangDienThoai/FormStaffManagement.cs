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
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string id = txtIdStaff.Text;
            AddStaff addStaff = new AddStaff();
            bool message = addStaff.addStaff(txtIdStaff.Text, txtStaffName.Text, txtAddress.Text, cboGender.Text, txtBirthday.Text, txtPhoneNumber.Text);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    picStaffImage.Image = new Bitmap(openFileDialog.FileName);
            //    // In đường dẫn của tệp hình ảnh đã chọn ra màn hình
            //    MessageBox.Show("Đường dẫn của tệp hình ảnh đã chọn: " + openFileDialog.FileName);
            //    // Lưu hình ảnh vào thư mục Image trong thư mục Debug
            //    string debugPath = Path.GetDirectoryName(Application.ExecutablePath);
            //    string targetPath = Path.Combine(debugPath, "Image");
            //    Directory.CreateDirectory(targetPath); // Tạo thư mục nếu nó không tồn tại

            //    string targetFilePath = Path.Combine(targetPath, Path.GetFileName(openFileDialog.FileName));
            //    picStaffImage.Image.Save(targetFilePath);
            //    File.Copy(openFileDialog.FileName, targetFilePath, true);
            //    // In đường dẫn ra màn hình
            //    MessageBox.Show("Đường dẫn của tệp hình ảnh đã lưu: " + targetFilePath);
            //}
            //Image File; // Khai báo biến File
            //OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    File = new Bitmap(f.FileName); // Tạo một đối tượng Bitmap từ tệp đã chọn
            //    picStaffImage.Image = File;

            //    // Lấy đường dẫn đến thư mục Debug
            //    string debugPath = Path.GetDirectoryName(Application.ExecutablePath);

            //    // Tạo đường dẫn đến thư mục Image trong thư mục Debug
            //    string specific_folder = Path.Combine(debugPath, "Image");

            //    //// Tạo thư mục nếu nó chưa tồn tại
            //    //Directory.CreateDirectory(specific_folder);
            //}
            picStaffImage.Image.Save(@"D:\Project 1\100000test.png", ImageFormat.Png);
            MessageBox.Show("susscess");

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
            labelIdStaff.Text = staff_DTO.idStaff.ToString();
            // 
            // picImageStaff
            // 
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Location = new System.Drawing.Point(9, 3);
            pictureBox1.Name = "picImageStaff";
            pictureBox1.Size = new System.Drawing.Size(149, 135);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;

            panel.Controls.Add(labelNameStaff);
            panel.Controls.Add(labelIdStaff);
            panel.Controls.Add(pictureBox1);
            return panel;
        }
        private void FormStaffManagement_Load(object sender, EventArgs e)
        {
            List<Staff_DTO> staffs = Staff_BLL.staffList();
            foreach(Staff_DTO staff in staffs)
            {
                flpContainerStaff.Controls.Add(GenerateStaff(staff));
            }

            lblQuantityStaff.Text = staffs.Count.ToString() + " Staff";
        }
    }
}
