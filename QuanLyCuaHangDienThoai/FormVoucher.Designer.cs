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
            this.flpContainerVoucher = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlVoucher = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.picImageVoucher = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblVoucherName = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.flpContainerVoucher.SuspendLayout();
            this.pnlVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // flpContainerVoucher
            // 
            this.flpContainerVoucher.AutoScroll = true;
            this.flpContainerVoucher.Controls.Add(this.pnlVoucher);
            this.flpContainerVoucher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpContainerVoucher.Location = new System.Drawing.Point(0, 39);
            this.flpContainerVoucher.Name = "flpContainerVoucher";
            this.flpContainerVoucher.Size = new System.Drawing.Size(893, 627);
            this.flpContainerVoucher.TabIndex = 1;
            // 
            // pnlVoucher
            // 
            this.pnlVoucher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVoucher.Controls.Add(this.lblDate);
            this.pnlVoucher.Controls.Add(this.lblVoucherName);
            this.pnlVoucher.Controls.Add(this.lblPrice);
            this.pnlVoucher.Controls.Add(this.btnChoose);
            this.pnlVoucher.Controls.Add(this.picImageVoucher);
            this.pnlVoucher.Location = new System.Drawing.Point(3, 3);
            this.pnlVoucher.Name = "pnlVoucher";
            this.pnlVoucher.Size = new System.Drawing.Size(883, 116);
            this.pnlVoucher.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(136, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 24);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(136, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // btnChoose
            // 
            this.btnChoose.AutoRoundedCorners = true;
            this.btnChoose.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnChoose.BorderRadius = 21;
            this.btnChoose.BorderThickness = 1;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoose.FillColor = System.Drawing.Color.White;
            this.btnChoose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChoose.ForeColor = System.Drawing.Color.Black;
            this.btnChoose.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnChoose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Location = new System.Drawing.Point(649, 32);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(180, 45);
            this.btnChoose.TabIndex = 8;
            this.btnChoose.Text = "Choose";
            // 
            // picImageVoucher
            // 
            this.picImageVoucher.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_voucher_blue;
            this.picImageVoucher.ImageRotate = 0F;
            this.picImageVoucher.Location = new System.Drawing.Point(36, 7);
            this.picImageVoucher.Name = "picImageVoucher";
            this.picImageVoucher.Size = new System.Drawing.Size(94, 97);
            this.picImageVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageVoucher.TabIndex = 0;
            this.picImageVoucher.TabStop = false;
            // 
            // lblVoucherName
            // 
            this.lblVoucherName.AutoSize = true;
            this.lblVoucherName.Location = new System.Drawing.Point(136, 7);
            this.lblVoucherName.Name = "lblVoucherName";
            this.lblVoucherName.Size = new System.Drawing.Size(140, 24);
            this.lblVoucherName.TabIndex = 4;
            this.lblVoucherName.Text = "Voucher Name";
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(841, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✖️";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flpContainerVoucher);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVoucher";
            this.Load += new System.EventHandler(this.FormVoucher_Load);
            this.flpContainerVoucher.ResumeLayout(false);
            this.pnlVoucher.ResumeLayout(false);
            this.pnlVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageVoucher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainerVoucher;
        private System.Windows.Forms.Panel pnlVoucher;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button btnChoose;
        private Guna.UI2.WinForms.Guna2PictureBox picImageVoucher;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVoucherName;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}