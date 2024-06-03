namespace QuanLyCuaHangDienThoai
{
    partial class FormCategoryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuantityCategory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefrech = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnFixCategory = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtIdCategoryDad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductDetail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblQuantityCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 41);
            this.panel1.TabIndex = 0;
            // 
            // lblQuantityCategory
            // 
            this.lblQuantityCategory.AutoSize = true;
            this.lblQuantityCategory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQuantityCategory.Location = new System.Drawing.Point(3, 7);
            this.lblQuantityCategory.Name = "lblQuantityCategory";
            this.lblQuantityCategory.Size = new System.Drawing.Size(172, 24);
            this.lblQuantityCategory.TabIndex = 4;
            this.lblQuantityCategory.Text = "Quantity Category";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnRefrech);
            this.panel2.Controls.Add(this.btnSearchCategory);
            this.panel2.Controls.Add(this.btnDeleteCategory);
            this.panel2.Controls.Add(this.btnAddCategory);
            this.panel2.Controls.Add(this.btnFixCategory);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 214);
            this.panel2.TabIndex = 0;
            // 
            // btnRefrech
            // 
            this.btnRefrech.AutoRoundedCorners = true;
            this.btnRefrech.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrech.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRefrech.BorderRadius = 21;
            this.btnRefrech.BorderThickness = 1;
            this.btnRefrech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrech.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefrech.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefrech.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefrech.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefrech.FillColor = System.Drawing.Color.White;
            this.btnRefrech.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRefrech.ForeColor = System.Drawing.Color.Black;
            this.btnRefrech.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRefrech.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRefrech.Location = new System.Drawing.Point(660, 148);
            this.btnRefrech.Name = "btnRefrech";
            this.btnRefrech.Size = new System.Drawing.Size(146, 45);
            this.btnRefrech.TabIndex = 24;
            this.btnRefrech.Text = "Refresh";
            this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.AutoRoundedCorners = true;
            this.btnSearchCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCategory.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchCategory.BorderRadius = 21;
            this.btnSearchCategory.BorderThickness = 1;
            this.btnSearchCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchCategory.FillColor = System.Drawing.Color.White;
            this.btnSearchCategory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCategory.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchCategory.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearchCategory.Location = new System.Drawing.Point(508, 148);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(146, 45);
            this.btnSearchCategory.TabIndex = 25;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.AutoRoundedCorners = true;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteCategory.BorderRadius = 21;
            this.btnDeleteCategory.BorderThickness = 1;
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCategory.FillColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCategory.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteCategory.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(356, 148);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(146, 45);
            this.btnDeleteCategory.TabIndex = 27;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AutoRoundedCorners = true;
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCategory.BorderRadius = 21;
            this.btnAddCategory.BorderThickness = 1;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCategory.FillColor = System.Drawing.Color.White;
            this.btnAddCategory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAddCategory.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCategory.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(74, 148);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(133, 45);
            this.btnAddCategory.TabIndex = 26;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnFixCategory
            // 
            this.btnFixCategory.AutoRoundedCorners = true;
            this.btnFixCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnFixCategory.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFixCategory.BorderRadius = 21;
            this.btnFixCategory.BorderThickness = 1;
            this.btnFixCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFixCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFixCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFixCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFixCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFixCategory.FillColor = System.Drawing.Color.White;
            this.btnFixCategory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFixCategory.ForeColor = System.Drawing.Color.Black;
            this.btnFixCategory.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFixCategory.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFixCategory.Location = new System.Drawing.Point(213, 148);
            this.btnFixCategory.Name = "btnFixCategory";
            this.btnFixCategory.Size = new System.Drawing.Size(137, 45);
            this.btnFixCategory.TabIndex = 23;
            this.btnFixCategory.Text = "Fix";
            this.btnFixCategory.Click += new System.EventHandler(this.btnFixCategory_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtIdCategoryDad);
            this.guna2GroupBox1.Controls.Add(this.txtIdCategory);
            this.guna2GroupBox1.Controls.Add(this.txtProductDetail);
            this.guna2GroupBox1.Controls.Add(this.txtCategoryName);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(869, 138);
            this.guna2GroupBox1.TabIndex = 22;
            this.guna2GroupBox1.Text = "Category infomation";
            // 
            // txtIdCategoryDad
            // 
            this.txtIdCategoryDad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCategoryDad.DefaultText = "";
            this.txtIdCategoryDad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCategoryDad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCategoryDad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCategoryDad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCategoryDad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCategoryDad.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIdCategoryDad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCategoryDad.Location = new System.Drawing.Point(671, 60);
            this.txtIdCategoryDad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCategoryDad.Name = "txtIdCategoryDad";
            this.txtIdCategoryDad.PasswordChar = '\0';
            this.txtIdCategoryDad.PlaceholderText = "ID Category Dad";
            this.txtIdCategoryDad.SelectedText = "";
            this.txtIdCategoryDad.Size = new System.Drawing.Size(175, 58);
            this.txtIdCategoryDad.TabIndex = 13;
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCategory.DefaultText = "";
            this.txtIdCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCategory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIdCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCategory.Location = new System.Drawing.Point(24, 60);
            this.txtIdCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.PasswordChar = '\0';
            this.txtIdCategory.PlaceholderText = "ID Category";
            this.txtIdCategory.SelectedText = "";
            this.txtIdCategory.Size = new System.Drawing.Size(139, 58);
            this.txtIdCategory.TabIndex = 13;
            // 
            // txtProductDetail
            // 
            this.txtProductDetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductDetail.DefaultText = "";
            this.txtProductDetail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductDetail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductDetail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtProductDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductDetail.Location = new System.Drawing.Point(409, 60);
            this.txtProductDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductDetail.Name = "txtProductDetail";
            this.txtProductDetail.PasswordChar = '\0';
            this.txtProductDetail.PlaceholderText = "Product Detail";
            this.txtProductDetail.SelectedText = "";
            this.txtProductDetail.Size = new System.Drawing.Size(254, 58);
            this.txtProductDetail.TabIndex = 13;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.DefaultText = "";
            this.txtCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryName.Location = new System.Drawing.Point(171, 60);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.PlaceholderText = "Category Name";
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.Size = new System.Drawing.Size(230, 58);
            this.txtCategoryName.TabIndex = 13;
            // 
            // dgvCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.ColumnHeadersHeight = 26;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategory.Location = new System.Drawing.Point(0, 41);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(893, 411);
            this.dgvCategory.TabIndex = 1;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategory.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvCategory.ThemeStyle.ReadOnly = false;
            this.dgvCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategory.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // FormCategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoryManagement";
            this.Load += new System.EventHandler(this.FormCategoryManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQuantityCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategory;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCategoryDad;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtProductDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
        private Guna.UI2.WinForms.Guna2Button btnRefrech;
        private Guna.UI2.WinForms.Guna2Button btnSearchCategory;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddCategory;
        private Guna.UI2.WinForms.Guna2Button btnFixCategory;
    }
}