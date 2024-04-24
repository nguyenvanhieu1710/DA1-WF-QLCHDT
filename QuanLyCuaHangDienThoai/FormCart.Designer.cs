﻿namespace QuanLyCuaHangDienThoai
{
    partial class FormCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.chkChooseProduct = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnDeleteProduct = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantityProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinus = new Guna.UI2.WinForms.Guna2Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picImageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchProduct = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkChooseAll = new Guna.UI2.WinForms.Guna2CheckBox();
            this.flpContainerProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpContainerProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Cart";
            // 
            // pnlProduct
            // 
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProduct.Controls.Add(this.chkChooseProduct);
            this.pnlProduct.Controls.Add(this.btnDeleteProduct);
            this.pnlProduct.Controls.Add(this.lblPrice);
            this.pnlProduct.Controls.Add(this.txtQuantityProduct);
            this.pnlProduct.Controls.Add(this.btnPlus);
            this.pnlProduct.Controls.Add(this.btnMinus);
            this.pnlProduct.Controls.Add(this.lblProductName);
            this.pnlProduct.Controls.Add(this.picImageProduct);
            this.pnlProduct.Location = new System.Drawing.Point(3, 3);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(883, 104);
            this.pnlProduct.TabIndex = 2;
            // 
            // chkChooseProduct
            // 
            this.chkChooseProduct.AutoSize = true;
            this.chkChooseProduct.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkChooseProduct.CheckedState.BorderRadius = 0;
            this.chkChooseProduct.CheckedState.BorderThickness = 0;
            this.chkChooseProduct.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkChooseProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkChooseProduct.Location = new System.Drawing.Point(32, 40);
            this.chkChooseProduct.Name = "chkChooseProduct";
            this.chkChooseProduct.Size = new System.Drawing.Size(18, 17);
            this.chkChooseProduct.TabIndex = 8;
            this.chkChooseProduct.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkChooseProduct.UncheckedState.BorderRadius = 0;
            this.chkChooseProduct.UncheckedState.BorderThickness = 0;
            this.chkChooseProduct.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_delete_blue;
            this.btnDeleteProduct.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteProduct.Location = new System.Drawing.Point(794, 27);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(61, 49);
            this.btnDeleteProduct.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(638, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtQuantityProduct
            // 
            this.txtQuantityProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantityProduct.DefaultText = "";
            this.txtQuantityProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantityProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantityProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantityProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantityProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantityProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantityProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantityProduct.Location = new System.Drawing.Point(495, 31);
            this.txtQuantityProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantityProduct.Name = "txtQuantityProduct";
            this.txtQuantityProduct.PasswordChar = '\0';
            this.txtQuantityProduct.PlaceholderText = "";
            this.txtQuantityProduct.SelectedText = "";
            this.txtQuantityProduct.Size = new System.Drawing.Size(39, 45);
            this.txtQuantityProduct.TabIndex = 3;
            this.txtQuantityProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlus.FillColor = System.Drawing.Color.White;
            this.btnPlus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Location = new System.Drawing.Point(552, 31);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 45);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinus.FillColor = System.Drawing.Color.White;
            this.btnMinus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinus.Location = new System.Drawing.Point(431, 31);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 45);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
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
            this.picImageProduct.ImageRotate = 0F;
            this.picImageProduct.Location = new System.Drawing.Point(69, 12);
            this.picImageProduct.Name = "picImageProduct";
            this.picImageProduct.Size = new System.Drawing.Size(75, 75);
            this.picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageProduct.TabIndex = 0;
            this.picImageProduct.TabStop = false;
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button4.BorderRadius = 21;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(691, 17);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(180, 45);
            this.guna2Button4.TabIndex = 1;
            this.guna2Button4.Text = "Pay";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.AutoRoundedCorners = true;
            this.btnSearchProduct.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchProduct.BorderRadius = 21;
            this.btnSearchProduct.BorderThickness = 1;
            this.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchProduct.FillColor = System.Drawing.Color.White;
            this.btnSearchProduct.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.btnSearchProduct.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchProduct.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(691, 9);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(180, 45);
            this.btnSearchProduct.TabIndex = 5;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 76);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tạm tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng tiền";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtProduct);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnSearchProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 69);
            this.panel3.TabIndex = 8;
            // 
            // txtProduct
            // 
            this.txtProduct.AutoRoundedCorners = true;
            this.txtProduct.BorderRadius = 19;
            this.txtProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProduct.DefaultText = "";
            this.txtProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProduct.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtProduct.ForeColor = System.Drawing.Color.DimGray;
            this.txtProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProduct.IconLeft = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_search;
            this.txtProduct.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtProduct.Location = new System.Drawing.Point(482, 14);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.PasswordChar = '\0';
            this.txtProduct.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtProduct.PlaceholderText = "Product Name";
            this.txtProduct.SelectedText = "";
            this.txtProduct.Size = new System.Drawing.Size(202, 40);
            this.txtProduct.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.flpContainerProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(893, 509);
            this.panel4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkChooseAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 37);
            this.panel1.TabIndex = 8;
            // 
            // chkChooseAll
            // 
            this.chkChooseAll.AutoSize = true;
            this.chkChooseAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkChooseAll.CheckedState.BorderRadius = 0;
            this.chkChooseAll.CheckedState.BorderThickness = 0;
            this.chkChooseAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkChooseAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkChooseAll.Location = new System.Drawing.Point(10, 3);
            this.chkChooseAll.Name = "chkChooseAll";
            this.chkChooseAll.Size = new System.Drawing.Size(124, 28);
            this.chkChooseAll.TabIndex = 7;
            this.chkChooseAll.Text = "Choose all";
            this.chkChooseAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkChooseAll.UncheckedState.BorderRadius = 0;
            this.chkChooseAll.UncheckedState.BorderThickness = 0;
            this.chkChooseAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkChooseAll.CheckedChanged += new System.EventHandler(this.chkChooseAll_CheckedChanged);
            // 
            // flpContainerProduct
            // 
            this.flpContainerProduct.AutoScroll = true;
            this.flpContainerProduct.Controls.Add(this.pnlProduct);
            this.flpContainerProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpContainerProduct.Location = new System.Drawing.Point(0, 37);
            this.flpContainerProduct.Name = "flpContainerProduct";
            this.flpContainerProduct.Size = new System.Drawing.Size(889, 468);
            this.flpContainerProduct.TabIndex = 3;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 654);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCart";
            this.Text = "FormCart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpContainerProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantityProduct;
        private Guna.UI2.WinForms.Guna2Button btnPlus;
        private Guna.UI2.WinForms.Guna2Button btnMinus;
        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2PictureBox picImageProduct;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnSearchProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flpContainerProduct;
        private Guna.UI2.WinForms.Guna2Button btnDeleteProduct;
        private Guna.UI2.WinForms.Guna2CheckBox chkChooseAll;
        private Guna.UI2.WinForms.Guna2CheckBox chkChooseProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtProduct;
        private System.Windows.Forms.Panel panel1;
    }
}