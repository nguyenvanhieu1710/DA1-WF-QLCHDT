namespace QuanLyCuaHangDienThoai
{
    partial class FormProduct
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
            this.flpContainerCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.flpContainerProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContainerProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picImageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuyNow = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchProduct = new Guna.UI2.WinForms.Guna2Button();
            this.txtProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.flpContainerCategory.SuspendLayout();
            this.flpContainerProduct.SuspendLayout();
            this.pnlContainerProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpContainerCategory
            // 
            this.flpContainerCategory.AutoScroll = true;
            this.flpContainerCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpContainerCategory.Controls.Add(this.btnCategory);
            this.flpContainerCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpContainerCategory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainerCategory.Location = new System.Drawing.Point(0, 0);
            this.flpContainerCategory.Name = "flpContainerCategory";
            this.flpContainerCategory.Size = new System.Drawing.Size(893, 82);
            this.flpContainerCategory.TabIndex = 40;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.BorderColor = System.Drawing.Color.Transparent;
            this.btnCategory.BorderThickness = 1;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.No;
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.FillColor = System.Drawing.Color.White;
            this.btnCategory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCategory.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCategory.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCategory.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCategory.Location = new System.Drawing.Point(3, 3);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(173, 67);
            this.btnCategory.TabIndex = 50;
            this.btnCategory.Text = "Category:";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // flpContainerProduct
            // 
            this.flpContainerProduct.AutoScroll = true;
            this.flpContainerProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpContainerProduct.Controls.Add(this.pnlContainerProduct);
            this.flpContainerProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpContainerProduct.Location = new System.Drawing.Point(0, 82);
            this.flpContainerProduct.Name = "flpContainerProduct";
            this.flpContainerProduct.Size = new System.Drawing.Size(893, 521);
            this.flpContainerProduct.TabIndex = 45;
            // 
            // pnlContainerProduct
            // 
            this.pnlContainerProduct.BorderThickness = 1;
            this.pnlContainerProduct.Controls.Add(this.lblProductPrice);
            this.pnlContainerProduct.Controls.Add(this.lblProductName);
            this.pnlContainerProduct.Controls.Add(this.picImageProduct);
            this.pnlContainerProduct.Controls.Add(this.btnAddToCart);
            this.pnlContainerProduct.Controls.Add(this.btnBuyNow);
            this.pnlContainerProduct.Location = new System.Drawing.Point(3, 3);
            this.pnlContainerProduct.Name = "pnlContainerProduct";
            this.pnlContainerProduct.Size = new System.Drawing.Size(201, 319);
            this.pnlContainerProduct.TabIndex = 49;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(9, 219);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(121, 24);
            this.lblProductPrice.TabIndex = 41;
            this.lblProductPrice.Text = "30.000.000đ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(9, 185);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(179, 24);
            this.lblProductName.TabIndex = 41;
            this.lblProductName.Text = "Iphone 15 pro max";
            // 
            // picImageProduct
            // 
            this.picImageProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImageProduct.ImageRotate = 0F;
            this.picImageProduct.Location = new System.Drawing.Point(9, 13);
            this.picImageProduct.Name = "picImageProduct";
            this.picImageProduct.Size = new System.Drawing.Size(179, 169);
            this.picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageProduct.TabIndex = 40;
            this.picImageProduct.TabStop = false;
            this.picImageProduct.Click += new System.EventHandler(this.picImageProduct_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AutoRoundedCorners = true;
            this.btnAddToCart.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToCart.BorderRadius = 21;
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
            this.btnAddToCart.Location = new System.Drawing.Point(9, 259);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(78, 45);
            this.btnAddToCart.TabIndex = 36;
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.AutoRoundedCorners = true;
            this.btnBuyNow.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuyNow.BorderRadius = 21;
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
            this.btnBuyNow.Location = new System.Drawing.Point(110, 259);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(78, 45);
            this.btnBuyNow.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.btnSearchProduct);
            this.panel2.Controls.Add(this.txtProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 69);
            this.panel2.TabIndex = 46;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "1.000.000đ - 10.000.000đ",
            "10.000.000đ - 20.000.000đ",
            "20.000.000đ - 30.000.000đ",
            "30.000.000đ - 40.000.000đ",
            "40.000.000đ - 50.000.000đ",
            "Apple",
            "Oppo",
            "Xiaomi",
            "Samsung"});
            this.cbFilter.Location = new System.Drawing.Point(462, 16);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(274, 36);
            this.cbFilter.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFilter.BorderThickness = 1;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.White;
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFilter.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_filter_white;
            this.btnFilter.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_filter;
            this.btnFilter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFilter.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnFilter.Location = new System.Drawing.Point(742, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(137, 49);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.btnSearchProduct.Location = new System.Drawing.Point(220, 7);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(180, 45);
            this.btnSearchProduct.TabIndex = 7;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
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
            this.txtProduct.Location = new System.Drawing.Point(11, 12);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.PasswordChar = '\0';
            this.txtProduct.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtProduct.PlaceholderText = "Product Name";
            this.txtProduct.SelectedText = "";
            this.txtProduct.Size = new System.Drawing.Size(202, 40);
            this.txtProduct.TabIndex = 6;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpContainerProduct);
            this.Controls.Add(this.flpContainerCategory);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.flpContainerCategory.ResumeLayout(false);
            this.flpContainerProduct.ResumeLayout(false);
            this.pnlContainerProduct.ResumeLayout(false);
            this.pnlContainerProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpContainerCategory;
        private System.Windows.Forms.FlowLayoutPanel flpContainerProduct;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnSearchProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtProduct;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2Panel pnlContainerProduct;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private Guna.UI2.WinForms.Guna2PictureBox picImageProduct;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2Button btnBuyNow;
    }
}