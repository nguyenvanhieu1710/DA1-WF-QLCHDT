using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using Guna.UI2.WinForms;
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
    public partial class FormVoucher : Form
    {
        public FormVoucher()
        {
            InitializeComponent();
        }
        Voucher_BLL Voucher_BLL = new Voucher_BLL();
        private void Refrech()
        {
            flpContainerVoucher.Controls.Clear();
            List<Voucher_DTO> voucher_DTO = Voucher_BLL.VoucherList();
            foreach(Voucher_DTO vouchers in voucher_DTO)
            {
                flpContainerVoucher.Controls.Add(GenerateVoucher(vouchers));
            }
        }
        private void FormVoucher_Load(object sender, EventArgs e)
        {
            Refrech();
        }
        private Guna2Panel GenerateVoucher(Voucher_DTO voucher_DTO)
        {
            // 
            // pnlContainerVoucher
            // 
            Guna2Panel pnlContainerVoucher = new Guna2Panel();
            pnlContainerVoucher.BorderColor = System.Drawing.Color.LightSteelBlue;
            pnlContainerVoucher.BorderThickness = 1;           
            pnlContainerVoucher.Location = new System.Drawing.Point(3, 3);
            pnlContainerVoucher.Name = "pnlContainerVoucher";
            pnlContainerVoucher.Size = new System.Drawing.Size(887, 124);
            pnlContainerVoucher.TabIndex = 0;
            // 
            // btnSave
            // 
            Guna2Button btnSave = new Guna2Button();
            btnSave.BorderColor = System.Drawing.Color.Transparent;
            btnSave.BorderRadius = 5;
            btnSave.BorderThickness = 1;
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            btnSave.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(654, 38);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(180, 45);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.Click += (s, e) =>
            {
                MessageBox.Show("Function is updating");
            };
            // 
            // lblFixedPrice
            // 
            Label lblFixedPrice = new Label();
            lblFixedPrice.AutoSize = true;
            lblFixedPrice.Location = new System.Drawing.Point(183, 17);
            lblFixedPrice.Name = "lblFixedPrice";
            lblFixedPrice.Size = new System.Drawing.Size(94, 24);
            lblFixedPrice.TabIndex = 1;
            lblFixedPrice.Text = "Giảm " + voucher_DTO.FixedPrice + "đ";
            // 
            // lblStartDayAndEndDate
            // 
            Label lblStartDayAndEndDate = new Label();
            lblStartDayAndEndDate.AutoSize = true;
            lblStartDayAndEndDate.Location = new System.Drawing.Point(183, 85);
            lblStartDayAndEndDate.Name = "lblStartDayAndEndDate";
            lblStartDayAndEndDate.Size = new System.Drawing.Size(207, 24);
            lblStartDayAndEndDate.TabIndex = 1;
            lblStartDayAndEndDate.Text = "Có hiệu lực từ " + voucher_DTO.StartDay + " đến " + voucher_DTO.EndDate;
            // 
            // lblMinimumPrice
            // 
            Label lblMinimumPrice = new Label();
            lblMinimumPrice.AutoSize = true;
            lblMinimumPrice.Location = new System.Drawing.Point(183, 50);
            lblMinimumPrice.Name = "lblMinimumPrice";
            lblMinimumPrice.Size = new System.Drawing.Size(154, 24);
            lblMinimumPrice.TabIndex = 1;
            lblMinimumPrice.Text = "Đơn tối thiểu " + voucher_DTO.Minimumprice + "đ";
            // 
            // picImageVoucher
            // 
            Guna2PictureBox picImageVoucher = new Guna2PictureBox();
            picImageVoucher.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_voucher_blue;
            picImageVoucher.ImageRotate = 0F;
            picImageVoucher.Location = new System.Drawing.Point(39, 3);
            picImageVoucher.Name = "picImageVoucher";
            picImageVoucher.Size = new System.Drawing.Size(113, 118);
            picImageVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picImageVoucher.TabIndex = 0;
            picImageVoucher.TabStop = false;

            pnlContainerVoucher.Controls.Add(btnSave);
            pnlContainerVoucher.Controls.Add(lblFixedPrice);
            pnlContainerVoucher.Controls.Add(lblStartDayAndEndDate);
            pnlContainerVoucher.Controls.Add(lblMinimumPrice);
            pnlContainerVoucher.Controls.Add(picImageVoucher);
            return pnlContainerVoucher;
        }
    }
}
