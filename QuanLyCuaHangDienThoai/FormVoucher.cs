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
        private void loadVoucher()
        {
            flpContainerVoucher.Controls.Clear();
            List<Voucher_DTO> voucherList = Voucher_BLL.VoucherList();
            foreach (Voucher_DTO voucher in voucherList)
            {
                if(voucher.Quantity > 0)
                {
                    flpContainerVoucher.Controls.Add(GenerateVoucher(voucher));
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            // nếu khách hàng không chọn voucher nào mà thoát ra luôn
            // thì lấy đại 1 cái voucher nào đấy
            Voucher_BLL voucher_BLL = new Voucher_BLL();
            List<int> idVoucherList = voucher_BLL.getIdVoucher();
            voucherGlobal.IdVoucher = idVoucherList[0];
            Close();
        }
        Voucher_DTO voucherGlobal = new Voucher_DTO();
        public Voucher_DTO returnvoucherselected()
        {
            Voucher_DTO voucher = new Voucher_DTO();
            voucher = voucherGlobal;
            return voucher;
        }
        private Panel GenerateVoucher(Voucher_DTO voucher_DTO)
        {
            // 
            // pnlVoucher
            // 
            Panel pnlVoucher = new Panel();
            pnlVoucher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlVoucher.Location = new System.Drawing.Point(3, 3);
            pnlVoucher.Name = "pnlVoucher";
            pnlVoucher.Size = new System.Drawing.Size(883, 116);
            pnlVoucher.TabIndex = 3;
            // 
            // lblDate
            // 
            Label lblDate = new Label();
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(136, 80);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(53, 24);
            lblDate.TabIndex = 4;
            lblDate.Text = voucher_DTO.StartDay.ToLongDateString()+ " "+ voucher_DTO.StartDay.ToShortTimeString() + " -> " 
                + voucher_DTO.EndDate.ToLongDateString() +" "+ voucher_DTO.EndDate.ToShortTimeString();
            // 
            // lblPrice
            // 
            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(136, 44);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(53, 24);
            lblPrice.TabIndex = 4;
            lblPrice.Text ="Discount: "+ voucher_DTO.FixedPrice.ToString("N0")+"đ";
            // 
            // btnChoose
            // 
            Guna2Button btnChoose = new Guna2Button();
            btnChoose.AutoRoundedCorners = true;
            btnChoose.BorderColor = System.Drawing.Color.DodgerBlue;
            btnChoose.BorderRadius = 21;
            btnChoose.BorderThickness = 1;
            btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnChoose.FillColor = System.Drawing.Color.White;
            btnChoose.Font = new System.Drawing.Font("Tahoma", 12F);
            btnChoose.ForeColor = System.Drawing.Color.Black;
            btnChoose.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            btnChoose.HoverState.ForeColor = System.Drawing.Color.White;
            btnChoose.Location = new System.Drawing.Point(649, 32);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new System.Drawing.Size(180, 45);
            btnChoose.TabIndex = 8;
            btnChoose.Text = "Choose";
            btnChoose.Click += (s, e) =>
            {
                voucherGlobal = voucher_DTO;
                this.Close();
            };
            // 
            // picImageVoucher
            // 
            Guna2PictureBox picImageVoucher = new Guna2PictureBox();
            picImageVoucher.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_voucher_blue;
            picImageVoucher.ImageRotate = 0F;
            picImageVoucher.Location = new System.Drawing.Point(36, 7);
            picImageVoucher.Name = "picImageVoucher";
            picImageVoucher.Size = new System.Drawing.Size(94, 97);
            picImageVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picImageVoucher.TabIndex = 0;
            picImageVoucher.TabStop = false;
            // 
            // lblVoucherName
            // 
            Label lblVoucherName = new Label();
            lblVoucherName.AutoSize = true;
            lblVoucherName.Location = new System.Drawing.Point(136, 7);
            lblVoucherName.Name = "lblVoucherName";
            lblVoucherName.Size = new System.Drawing.Size(140, 24);
            lblVoucherName.TabIndex = 4;
            lblVoucherName.Text = "Voucher name: "+ voucher_DTO.VoucherName;

            pnlVoucher.Controls.Add(lblDate);
            pnlVoucher.Controls.Add(lblVoucherName);
            pnlVoucher.Controls.Add(lblPrice);
            pnlVoucher.Controls.Add(btnChoose);
            pnlVoucher.Controls.Add(picImageVoucher);
            return pnlVoucher;
        }

        private void FormVoucher_Load(object sender, EventArgs e)
        {
            loadVoucher();
        }
    }
}
