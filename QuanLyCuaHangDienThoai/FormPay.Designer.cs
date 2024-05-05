namespace QuanLyCuaHangDienThoai
{
    partial class FormPay
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpContainerProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picImageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtDeliveryAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbVoucher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompleteOrder = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiscountVoucher = new System.Windows.Forms.Label();
            this.lblPaymentRequired = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel3.SuspendLayout();
            this.flpContainerProduct.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.flpContainerProduct);
            this.guna2Panel3.Controls.Add(this.txtDeliveryAddress);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(893, 666);
            this.guna2Panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delivery address:";
            // 
            // flpContainerProduct
            // 
            this.flpContainerProduct.AutoScroll = true;
            this.flpContainerProduct.Controls.Add(this.pnlProduct);
            this.flpContainerProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpContainerProduct.Location = new System.Drawing.Point(0, 0);
            this.flpContainerProduct.Name = "flpContainerProduct";
            this.flpContainerProduct.Size = new System.Drawing.Size(893, 467);
            this.flpContainerProduct.TabIndex = 3;
            // 
            // pnlProduct
            // 
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProduct.Controls.Add(this.lblPrice);
            this.pnlProduct.Controls.Add(this.lblProductName);
            this.pnlProduct.Controls.Add(this.picImageProduct);
            this.pnlProduct.Location = new System.Drawing.Point(3, 3);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(883, 104);
            this.pnlProduct.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(676, 33);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(150, 33);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(135, 24);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // picImageProduct
            // 
            this.picImageProduct.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.avatar;
            this.picImageProduct.ImageRotate = 0F;
            this.picImageProduct.Location = new System.Drawing.Point(69, 12);
            this.picImageProduct.Name = "picImageProduct";
            this.picImageProduct.Size = new System.Drawing.Size(75, 75);
            this.picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageProduct.TabIndex = 0;
            this.picImageProduct.TabStop = false;
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryAddress.DefaultText = "";
            this.txtDeliveryAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeliveryAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeliveryAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeliveryAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(199, 484);
            this.txtDeliveryAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.PasswordChar = '\0';
            this.txtDeliveryAddress.PlaceholderText = "";
            this.txtDeliveryAddress.SelectedText = "";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(644, 38);
            this.txtDeliveryAddress.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbVoucher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCompleteOrder);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDiscountVoucher);
            this.panel1.Controls.Add(this.lblPaymentRequired);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 132);
            this.panel1.TabIndex = 2;
            // 
            // cbVoucher
            // 
            this.cbVoucher.BackColor = System.Drawing.Color.Transparent;
            this.cbVoucher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoucher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVoucher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbVoucher.ItemHeight = 30;
            this.cbVoucher.Location = new System.Drawing.Point(124, 3);
            this.cbVoucher.Name = "cbVoucher";
            this.cbVoucher.Size = new System.Drawing.Size(225, 36);
            this.cbVoucher.TabIndex = 41;
            this.cbVoucher.Click += new System.EventHandler(this.cbVoucher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Voucher:";
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.AutoRoundedCorners = true;
            this.btnCompleteOrder.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCompleteOrder.BorderRadius = 27;
            this.btnCompleteOrder.BorderThickness = 1;
            this.btnCompleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleteOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleteOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleteOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompleteOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompleteOrder.FillColor = System.Drawing.Color.White;
            this.btnCompleteOrder.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCompleteOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCompleteOrder.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCompleteOrder.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCompleteOrder.Location = new System.Drawing.Point(505, 59);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(338, 57);
            this.btnCompleteOrder.TabIndex = 39;
            this.btnCompleteOrder.Text = "Complete your order";
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Discount vouchers:";
            // 
            // lblDiscountVoucher
            // 
            this.lblDiscountVoucher.AutoSize = true;
            this.lblDiscountVoucher.Location = new System.Drawing.Point(239, 92);
            this.lblDiscountVoucher.Name = "lblDiscountVoucher";
            this.lblDiscountVoucher.Size = new System.Drawing.Size(32, 24);
            this.lblDiscountVoucher.TabIndex = 0;
            this.lblDiscountVoucher.Text = "0đ";
            // 
            // lblPaymentRequired
            // 
            this.lblPaymentRequired.AutoSize = true;
            this.lblPaymentRequired.Location = new System.Drawing.Point(702, 15);
            this.lblPaymentRequired.Name = "lblPaymentRequired";
            this.lblPaymentRequired.Size = new System.Drawing.Size(110, 24);
            this.lblPaymentRequired.TabIndex = 0;
            this.lblPaymentRequired.Text = "1,000,000đ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Payment required:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(239, 59);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(110, 24);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "1,000,000đ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total amount:";
            // 
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPay";
            this.Text = "FormPay";
            this.Load += new System.EventHandler(this.FormPay_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.flpContainerProduct.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiscountVoucher;
        private System.Windows.Forms.Label lblPaymentRequired;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalAmount;
        private Guna.UI2.WinForms.Guna2Button btnCompleteOrder;
        private Guna.UI2.WinForms.Guna2ComboBox cbVoucher;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDeliveryAddress;
        private System.Windows.Forms.FlowLayoutPanel flpContainerProduct;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2PictureBox picImageProduct;
        private System.Windows.Forms.Label label2;
    }
}