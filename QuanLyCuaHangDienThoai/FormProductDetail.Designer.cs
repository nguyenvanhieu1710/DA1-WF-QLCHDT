﻿namespace QuanLyCuaHangDienThoai
{
    partial class FormProductDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picImageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuyNow = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProductSpecifications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSpecifications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProductName.Location = new System.Drawing.Point(12, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(221, 40);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // picImageProduct
            // 
            this.picImageProduct.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_mobile_phone_blue;
            this.picImageProduct.ImageRotate = 0F;
            this.picImageProduct.Location = new System.Drawing.Point(28, 79);
            this.picImageProduct.Name = "picImageProduct";
            this.picImageProduct.Size = new System.Drawing.Size(333, 255);
            this.picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageProduct.TabIndex = 1;
            this.picImageProduct.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPrice.Location = new System.Drawing.Point(19, 15);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 40);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AutoRoundedCorners = true;
            this.btnAddToCart.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToCart.BorderRadius = 25;
            this.btnAddToCart.BorderThickness = 1;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.FillColor = System.Drawing.Color.White;
            this.btnAddToCart.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToCart.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_cart_white;
            this.btnAddToCart.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_cart_blue;
            this.btnAddToCart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddToCart.Location = new System.Drawing.Point(26, 185);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(396, 53);
            this.btnAddToCart.TabIndex = 37;
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.AutoRoundedCorners = true;
            this.btnBuyNow.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuyNow.BorderRadius = 25;
            this.btnBuyNow.BorderThickness = 1;
            this.btnBuyNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuyNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuyNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuyNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuyNow.FillColor = System.Drawing.Color.White;
            this.btnBuyNow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBuyNow.ForeColor = System.Drawing.Color.Black;
            this.btnBuyNow.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnBuyNow.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuyNow.HoverState.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_basket_white;
            this.btnBuyNow.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_basket_blue;
            this.btnBuyNow.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBuyNow.Location = new System.Drawing.Point(26, 126);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(396, 53);
            this.btnBuyNow.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.btnBuyNow);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Location = new System.Drawing.Point(429, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 255);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProductSpecifications);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(19, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 294);
            this.panel2.TabIndex = 40;
            // 
            // dgvProductSpecifications
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvProductSpecifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductSpecifications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSpecifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductSpecifications.ColumnHeadersHeight = 4;
            this.dgvProductSpecifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductSpecifications.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductSpecifications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProductSpecifications.Location = new System.Drawing.Point(23, 71);
            this.dgvProductSpecifications.Name = "dgvProductSpecifications";
            this.dgvProductSpecifications.RowHeadersVisible = false;
            this.dgvProductSpecifications.RowHeadersWidth = 51;
            this.dgvProductSpecifications.RowTemplate.Height = 24;
            this.dgvProductSpecifications.Size = new System.Drawing.Size(809, 208);
            this.dgvProductSpecifications.TabIndex = 3;
            this.dgvProductSpecifications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductSpecifications.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProductSpecifications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProductSpecifications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProductSpecifications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProductSpecifications.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductSpecifications.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProductSpecifications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProductSpecifications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductSpecifications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvProductSpecifications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductSpecifications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProductSpecifications.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProductSpecifications.ThemeStyle.ReadOnly = false;
            this.dgvProductSpecifications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductSpecifications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductSpecifications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvProductSpecifications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProductSpecifications.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProductSpecifications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProductSpecifications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specifications";
            // 
            // FormProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picImageProduct);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProductDetail";
            this.Text = "FormProductDetail";
            this.Load += new System.EventHandler(this.FormProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSpecifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2PictureBox picImageProduct;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2Button btnBuyNow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProductSpecifications;
        private System.Windows.Forms.Label label3;
    }
}