namespace QuanLyCuaHangDienThoai
{
    partial class FormVoucher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContainerVoucher = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblFixedPrice = new System.Windows.Forms.Label();
            this.lblStartDayAndEndDate = new System.Windows.Forms.Label();
            this.lblMinimumPrice = new System.Windows.Forms.Label();
            this.picImageVoucher = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flpContainerVoucher = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdCustomer = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainerVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageVoucher)).BeginInit();
            this.flpContainerVoucher.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainerVoucher
            // 
            this.pnlContainerVoucher.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.pnlContainerVoucher.BorderThickness = 1;
            this.pnlContainerVoucher.Controls.Add(this.btnSave);
            this.pnlContainerVoucher.Controls.Add(this.lblFixedPrice);
            this.pnlContainerVoucher.Controls.Add(this.lblStartDayAndEndDate);
            this.pnlContainerVoucher.Controls.Add(this.lblMinimumPrice);
            this.pnlContainerVoucher.Controls.Add(this.picImageVoucher);
            this.pnlContainerVoucher.Location = new System.Drawing.Point(3, 3);
            this.pnlContainerVoucher.Name = "pnlContainerVoucher";
            this.pnlContainerVoucher.Size = new System.Drawing.Size(887, 124);
            this.pnlContainerVoucher.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderThickness = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(654, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            // 
            // lblFixedPrice
            // 
            this.lblFixedPrice.AutoSize = true;
            this.lblFixedPrice.Location = new System.Drawing.Point(183, 17);
            this.lblFixedPrice.Name = "lblFixedPrice";
            this.lblFixedPrice.Size = new System.Drawing.Size(94, 24);
            this.lblFixedPrice.TabIndex = 1;
            this.lblFixedPrice.Text = "Giảm 13k";
            // 
            // lblStartDayAndEndDate
            // 
            this.lblStartDayAndEndDate.AutoSize = true;
            this.lblStartDayAndEndDate.Location = new System.Drawing.Point(183, 85);
            this.lblStartDayAndEndDate.Name = "lblStartDayAndEndDate";
            this.lblStartDayAndEndDate.Size = new System.Drawing.Size(207, 24);
            this.lblStartDayAndEndDate.TabIndex = 1;
            this.lblStartDayAndEndDate.Text = "Có hiệu lực từ 1 đến 4";
            // 
            // lblMinimumPrice
            // 
            this.lblMinimumPrice.AutoSize = true;
            this.lblMinimumPrice.Location = new System.Drawing.Point(183, 50);
            this.lblMinimumPrice.Name = "lblMinimumPrice";
            this.lblMinimumPrice.Size = new System.Drawing.Size(154, 24);
            this.lblMinimumPrice.TabIndex = 1;
            this.lblMinimumPrice.Text = "Đơn tối thiểu 0đ";
            // 
            // picImageVoucher
            // 
            this.picImageVoucher.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_voucher_blue;
            this.picImageVoucher.ImageRotate = 0F;
            this.picImageVoucher.Location = new System.Drawing.Point(39, 3);
            this.picImageVoucher.Name = "picImageVoucher";
            this.picImageVoucher.Size = new System.Drawing.Size(113, 118);
            this.picImageVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageVoucher.TabIndex = 0;
            this.picImageVoucher.TabStop = false;
            // 
            // flpContainerVoucher
            // 
            this.flpContainerVoucher.Controls.Add(this.pnlContainerVoucher);
            this.flpContainerVoucher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpContainerVoucher.Location = new System.Drawing.Point(0, 71);
            this.flpContainerVoucher.Name = "flpContainerVoucher";
            this.flpContainerVoucher.Size = new System.Drawing.Size(893, 595);
            this.flpContainerVoucher.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblIdCustomer);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 74);
            this.panel1.TabIndex = 2;
            // 
            // lblIdCustomer
            // 
            this.lblIdCustomer.AutoSize = true;
            this.lblIdCustomer.Location = new System.Drawing.Point(686, 29);
            this.lblIdCustomer.Name = "lblIdCustomer";
            this.lblIdCustomer.Size = new System.Drawing.Size(122, 24);
            this.lblIdCustomer.TabIndex = 11;
            this.lblIdCustomer.Text = "ID Customer";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.User;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(814, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(71, 56);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your Voucher";
            // 
            // FormVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpContainerVoucher);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVoucher";
            this.Text = "FormVoucher";
            this.Load += new System.EventHandler(this.FormVoucher_Load);
            this.pnlContainerVoucher.ResumeLayout(false);
            this.pnlContainerVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageVoucher)).EndInit();
            this.flpContainerVoucher.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlContainerVoucher;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblFixedPrice;
        private System.Windows.Forms.Label lblStartDayAndEndDate;
        private System.Windows.Forms.Label lblMinimumPrice;
        private Guna.UI2.WinForms.Guna2PictureBox picImageVoucher;
        private System.Windows.Forms.FlowLayoutPanel flpContainerVoucher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIdCustomer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
    }
}