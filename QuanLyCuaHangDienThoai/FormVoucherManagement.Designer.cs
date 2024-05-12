namespace QuanLyCuaHangDienThoai
{
    partial class FormVoucherManagement
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
            this.dgvVoucher = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuantityVoucher = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefrech = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.btnFixVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbIdCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePickerEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimePickerStartDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtIdVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMinimumPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFixedPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVoucherName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVoucher
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVoucher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVoucher.ColumnHeadersHeight = 26;
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVoucher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVoucher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVoucher.Location = new System.Drawing.Point(0, 41);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.RowHeadersVisible = false;
            this.dgvVoucher.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVoucher.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVoucher.RowTemplate.Height = 24;
            this.dgvVoucher.Size = new System.Drawing.Size(893, 362);
            this.dgvVoucher.TabIndex = 4;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVoucher.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVoucher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVoucher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVoucher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVoucher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvVoucher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVoucher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVoucher.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvVoucher.ThemeStyle.ReadOnly = false;
            this.dgvVoucher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVoucher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVoucher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvVoucher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVoucher.ThemeStyle.RowsStyle.Height = 24;
            this.dgvVoucher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVoucher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblQuantityVoucher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 41);
            this.panel1.TabIndex = 2;
            // 
            // lblQuantityVoucher
            // 
            this.lblQuantityVoucher.AutoSize = true;
            this.lblQuantityVoucher.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQuantityVoucher.Location = new System.Drawing.Point(3, 7);
            this.lblQuantityVoucher.Name = "lblQuantityVoucher";
            this.lblQuantityVoucher.Size = new System.Drawing.Size(164, 24);
            this.lblQuantityVoucher.TabIndex = 4;
            this.lblQuantityVoucher.Text = "Quantity Voucher";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnRefrech);
            this.panel2.Controls.Add(this.btnSearchVoucher);
            this.panel2.Controls.Add(this.btnDeleteVoucher);
            this.panel2.Controls.Add(this.btnAddVoucher);
            this.panel2.Controls.Add(this.btnFixVoucher);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 263);
            this.panel2.TabIndex = 3;
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
            this.btnRefrech.Location = new System.Drawing.Point(662, 204);
            this.btnRefrech.Name = "btnRefrech";
            this.btnRefrech.Size = new System.Drawing.Size(146, 45);
            this.btnRefrech.TabIndex = 24;
            this.btnRefrech.Text = "Refrech";
            this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
            // 
            // btnSearchVoucher
            // 
            this.btnSearchVoucher.AutoRoundedCorners = true;
            this.btnSearchVoucher.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchVoucher.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchVoucher.BorderRadius = 21;
            this.btnSearchVoucher.BorderThickness = 1;
            this.btnSearchVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchVoucher.FillColor = System.Drawing.Color.White;
            this.btnSearchVoucher.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearchVoucher.ForeColor = System.Drawing.Color.Black;
            this.btnSearchVoucher.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchVoucher.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearchVoucher.Location = new System.Drawing.Point(510, 204);
            this.btnSearchVoucher.Name = "btnSearchVoucher";
            this.btnSearchVoucher.Size = new System.Drawing.Size(146, 45);
            this.btnSearchVoucher.TabIndex = 25;
            this.btnSearchVoucher.Text = "Search";
            this.btnSearchVoucher.Click += new System.EventHandler(this.btnSearchVoucher_Click);
            // 
            // btnDeleteVoucher
            // 
            this.btnDeleteVoucher.AutoRoundedCorners = true;
            this.btnDeleteVoucher.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteVoucher.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteVoucher.BorderRadius = 21;
            this.btnDeleteVoucher.BorderThickness = 1;
            this.btnDeleteVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteVoucher.FillColor = System.Drawing.Color.White;
            this.btnDeleteVoucher.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeleteVoucher.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteVoucher.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteVoucher.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVoucher.Location = new System.Drawing.Point(358, 204);
            this.btnDeleteVoucher.Name = "btnDeleteVoucher";
            this.btnDeleteVoucher.Size = new System.Drawing.Size(146, 45);
            this.btnDeleteVoucher.TabIndex = 27;
            this.btnDeleteVoucher.Text = "Delete";
            this.btnDeleteVoucher.Click += new System.EventHandler(this.btnDeleteVoucher_Click);
            // 
            // btnAddVoucher
            // 
            this.btnAddVoucher.AutoRoundedCorners = true;
            this.btnAddVoucher.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVoucher.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddVoucher.BorderRadius = 21;
            this.btnAddVoucher.BorderThickness = 1;
            this.btnAddVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddVoucher.FillColor = System.Drawing.Color.White;
            this.btnAddVoucher.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddVoucher.ForeColor = System.Drawing.Color.Black;
            this.btnAddVoucher.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddVoucher.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddVoucher.Location = new System.Drawing.Point(76, 204);
            this.btnAddVoucher.Name = "btnAddVoucher";
            this.btnAddVoucher.Size = new System.Drawing.Size(133, 45);
            this.btnAddVoucher.TabIndex = 26;
            this.btnAddVoucher.Text = "Add";
            this.btnAddVoucher.Click += new System.EventHandler(this.btnAddVoucher_Click);
            // 
            // btnFixVoucher
            // 
            this.btnFixVoucher.AutoRoundedCorners = true;
            this.btnFixVoucher.BackColor = System.Drawing.Color.Transparent;
            this.btnFixVoucher.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFixVoucher.BorderRadius = 21;
            this.btnFixVoucher.BorderThickness = 1;
            this.btnFixVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFixVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFixVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFixVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFixVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFixVoucher.FillColor = System.Drawing.Color.White;
            this.btnFixVoucher.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFixVoucher.ForeColor = System.Drawing.Color.Black;
            this.btnFixVoucher.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFixVoucher.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFixVoucher.Location = new System.Drawing.Point(215, 204);
            this.btnFixVoucher.Name = "btnFixVoucher";
            this.btnFixVoucher.Size = new System.Drawing.Size(137, 45);
            this.btnFixVoucher.TabIndex = 23;
            this.btnFixVoucher.Text = "Fix";
            this.btnFixVoucher.Click += new System.EventHandler(this.btnFixVoucher_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbIdCategory);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.DateTimePickerEndDate);
            this.guna2GroupBox1.Controls.Add(this.DateTimePickerStartDay);
            this.guna2GroupBox1.Controls.Add(this.txtIdVoucher);
            this.guna2GroupBox1.Controls.Add(this.txtQuantity);
            this.guna2GroupBox1.Controls.Add(this.txtMinimumPrice);
            this.guna2GroupBox1.Controls.Add(this.txtFixedPrice);
            this.guna2GroupBox1.Controls.Add(this.txtVoucherName);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(869, 194);
            this.guna2GroupBox1.TabIndex = 22;
            this.guna2GroupBox1.Text = "Voucher infomation";
            // 
            // cbIdCategory
            // 
            this.cbIdCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbIdCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIdCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIdCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIdCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbIdCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIdCategory.ItemHeight = 30;
            this.cbIdCategory.Location = new System.Drawing.Point(563, 149);
            this.cbIdCategory.Name = "cbIdCategory";
            this.cbIdCategory.Size = new System.Drawing.Size(276, 36);
            this.cbIdCategory.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(648, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(359, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(79, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Start Day";
            // 
            // DateTimePickerEndDate
            // 
            this.DateTimePickerEndDate.BorderColor = System.Drawing.Color.Transparent;
            this.DateTimePickerEndDate.Checked = true;
            this.DateTimePickerEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePickerEndDate.FillColor = System.Drawing.Color.White;
            this.DateTimePickerEndDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DateTimePickerEndDate.ForeColor = System.Drawing.Color.Gray;
            this.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerEndDate.Location = new System.Drawing.Point(290, 149);
            this.DateTimePickerEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerEndDate.Name = "DateTimePickerEndDate";
            this.DateTimePickerEndDate.Size = new System.Drawing.Size(248, 36);
            this.DateTimePickerEndDate.TabIndex = 16;
            this.DateTimePickerEndDate.Value = new System.DateTime(2024, 4, 5, 21, 44, 54, 397);
            // 
            // DateTimePickerStartDay
            // 
            this.DateTimePickerStartDay.BorderColor = System.Drawing.Color.Transparent;
            this.DateTimePickerStartDay.Checked = true;
            this.DateTimePickerStartDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePickerStartDay.FillColor = System.Drawing.Color.White;
            this.DateTimePickerStartDay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DateTimePickerStartDay.ForeColor = System.Drawing.Color.Gray;
            this.DateTimePickerStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerStartDay.Location = new System.Drawing.Point(24, 149);
            this.DateTimePickerStartDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerStartDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerStartDay.Name = "DateTimePickerStartDay";
            this.DateTimePickerStartDay.Size = new System.Drawing.Size(248, 36);
            this.DateTimePickerStartDay.TabIndex = 15;
            this.DateTimePickerStartDay.Value = new System.DateTime(2024, 4, 5, 21, 44, 54, 397);
            // 
            // txtIdVoucher
            // 
            this.txtIdVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdVoucher.DefaultText = "";
            this.txtIdVoucher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdVoucher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdVoucher.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIdVoucher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdVoucher.Location = new System.Drawing.Point(28, 59);
            this.txtIdVoucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdVoucher.Name = "txtIdVoucher";
            this.txtIdVoucher.PasswordChar = '\0';
            this.txtIdVoucher.PlaceholderText = "ID Voucher";
            this.txtIdVoucher.SelectedText = "";
            this.txtIdVoucher.Size = new System.Drawing.Size(139, 58);
            this.txtIdVoucher.TabIndex = 13;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(737, 59);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(102, 58);
            this.txtQuantity.TabIndex = 13;
            // 
            // txtMinimumPrice
            // 
            this.txtMinimumPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimumPrice.DefaultText = "";
            this.txtMinimumPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMinimumPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMinimumPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinimumPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinimumPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinimumPrice.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMinimumPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinimumPrice.Location = new System.Drawing.Point(575, 59);
            this.txtMinimumPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinimumPrice.Name = "txtMinimumPrice";
            this.txtMinimumPrice.PasswordChar = '\0';
            this.txtMinimumPrice.PlaceholderText = "Minimum Price";
            this.txtMinimumPrice.SelectedText = "";
            this.txtMinimumPrice.Size = new System.Drawing.Size(154, 58);
            this.txtMinimumPrice.TabIndex = 13;
            // 
            // txtFixedPrice
            // 
            this.txtFixedPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFixedPrice.DefaultText = "";
            this.txtFixedPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFixedPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFixedPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFixedPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFixedPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFixedPrice.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFixedPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFixedPrice.Location = new System.Drawing.Point(413, 59);
            this.txtFixedPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFixedPrice.Name = "txtFixedPrice";
            this.txtFixedPrice.PasswordChar = '\0';
            this.txtFixedPrice.PlaceholderText = "Fixed Price";
            this.txtFixedPrice.SelectedText = "";
            this.txtFixedPrice.Size = new System.Drawing.Size(154, 58);
            this.txtFixedPrice.TabIndex = 13;
            // 
            // txtVoucherName
            // 
            this.txtVoucherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVoucherName.DefaultText = "";
            this.txtVoucherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVoucherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVoucherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoucherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVoucherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVoucherName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtVoucherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVoucherName.Location = new System.Drawing.Point(175, 59);
            this.txtVoucherName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVoucherName.Name = "txtVoucherName";
            this.txtVoucherName.PasswordChar = '\0';
            this.txtVoucherName.PlaceholderText = "Voucher Name";
            this.txtVoucherName.SelectedText = "";
            this.txtVoucherName.Size = new System.Drawing.Size(230, 58);
            this.txtVoucherName.TabIndex = 13;
            // 
            // FormVoucherManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.dgvVoucher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVoucherManagement";
            this.Text = "FormVoucherManagement";
            this.Load += new System.EventHandler(this.FormVoucherManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvVoucher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuantityVoucher;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRefrech;
        private Guna.UI2.WinForms.Guna2Button btnSearchVoucher;
        private Guna.UI2.WinForms.Guna2Button btnDeleteVoucher;
        private Guna.UI2.WinForms.Guna2Button btnAddVoucher;
        private Guna.UI2.WinForms.Guna2Button btnFixVoucher;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtIdVoucher;
        private Guna.UI2.WinForms.Guna2TextBox txtFixedPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtVoucherName;
        private Guna.UI2.WinForms.Guna2TextBox txtMinimumPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerStartDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbIdCategory;
    }
}