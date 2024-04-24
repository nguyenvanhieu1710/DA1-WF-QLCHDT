namespace QuanLyCuaHangDienThoai
{
    partial class FormUserManagement
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
            this.label4 = new System.Windows.Forms.Label();
            this.cboGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GroupBoxUser = new Guna.UI2.WinForms.Guna2GroupBox();
            this.picCustomerImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DateTimePickerBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseImage = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnFixUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchUser = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.flpContainerCustomer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefrech = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(44, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender";
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.Color.Transparent;
            this.cboGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGender.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGender.ItemHeight = 30;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(17, 165);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(140, 36);
            this.cboGender.StartIndex = 0;
            this.cboGender.TabIndex = 14;
            // 
            // GroupBoxUser
            // 
            this.GroupBoxUser.Controls.Add(this.picCustomerImage);
            this.GroupBoxUser.Controls.Add(this.DateTimePickerBirthday);
            this.GroupBoxUser.Controls.Add(this.label1);
            this.GroupBoxUser.Controls.Add(this.label4);
            this.GroupBoxUser.Controls.Add(this.btnChooseImage);
            this.GroupBoxUser.Controls.Add(this.cboGender);
            this.GroupBoxUser.Controls.Add(this.txtIdUser);
            this.GroupBoxUser.Controls.Add(this.txtPhoneNumber);
            this.GroupBoxUser.Controls.Add(this.txtUserName);
            this.GroupBoxUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupBoxUser.Location = new System.Drawing.Point(12, 6);
            this.GroupBoxUser.Name = "GroupBoxUser";
            this.GroupBoxUser.Size = new System.Drawing.Size(869, 234);
            this.GroupBoxUser.TabIndex = 21;
            this.GroupBoxUser.Text = "User infomation";
            // 
            // picCustomerImage
            // 
            this.picCustomerImage.BackColor = System.Drawing.Color.Transparent;
            this.picCustomerImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCustomerImage.ImageRotate = 0F;
            this.picCustomerImage.Location = new System.Drawing.Point(676, 60);
            this.picCustomerImage.Name = "picCustomerImage";
            this.picCustomerImage.Size = new System.Drawing.Size(175, 150);
            this.picCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomerImage.TabIndex = 17;
            this.picCustomerImage.TabStop = false;
            this.picCustomerImage.UseTransparentBackground = true;
            // 
            // DateTimePickerBirthday
            // 
            this.DateTimePickerBirthday.BorderColor = System.Drawing.Color.Transparent;
            this.DateTimePickerBirthday.Checked = true;
            this.DateTimePickerBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePickerBirthday.FillColor = System.Drawing.Color.White;
            this.DateTimePickerBirthday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DateTimePickerBirthday.ForeColor = System.Drawing.Color.Gray;
            this.DateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerBirthday.Location = new System.Drawing.Point(181, 165);
            this.DateTimePickerBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerBirthday.Name = "DateTimePickerBirthday";
            this.DateTimePickerBirthday.Size = new System.Drawing.Size(248, 36);
            this.DateTimePickerBirthday.TabIndex = 1;
            this.DateTimePickerBirthday.Value = new System.DateTime(2024, 4, 5, 21, 44, 54, 397);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(259, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Birthday";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.AutoRoundedCorners = true;
            this.btnChooseImage.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseImage.BorderRadius = 21;
            this.btnChooseImage.BorderThickness = 1;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseImage.FillColor = System.Drawing.Color.White;
            this.btnChooseImage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChooseImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImage.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseImage.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnChooseImage.Location = new System.Drawing.Point(470, 156);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(173, 45);
            this.btnChooseImage.TabIndex = 15;
            this.btnChooseImage.Text = "Choose image";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // txtIdUser
            // 
            this.txtIdUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUser.DefaultText = "";
            this.txtIdUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIdUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdUser.Location = new System.Drawing.Point(24, 60);
            this.txtIdUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.PasswordChar = '\0';
            this.txtIdUser.PlaceholderText = "ID User";
            this.txtIdUser.SelectedText = "";
            this.txtIdUser.Size = new System.Drawing.Size(125, 58);
            this.txtIdUser.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(435, 60);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "Phone number";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(173, 58);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(166, 60);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(246, 58);
            this.txtUserName.TabIndex = 13;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AutoRoundedCorners = true;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteUser.BorderRadius = 21;
            this.btnDeleteUser.BorderThickness = 1;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteUser.FillColor = System.Drawing.Color.White;
            this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteUser.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(332, 246);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(146, 45);
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQuantity.Location = new System.Drawing.Point(12, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(132, 24);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity User";
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoRoundedCorners = true;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.BorderRadius = 21;
            this.btnAddUser.BorderThickness = 1;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.White;
            this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(50, 246);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(133, 45);
            this.btnAddUser.TabIndex = 18;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnFixUser
            // 
            this.btnFixUser.AutoRoundedCorners = true;
            this.btnFixUser.BackColor = System.Drawing.Color.Transparent;
            this.btnFixUser.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFixUser.BorderRadius = 21;
            this.btnFixUser.BorderThickness = 1;
            this.btnFixUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFixUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFixUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFixUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFixUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFixUser.FillColor = System.Drawing.Color.White;
            this.btnFixUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFixUser.ForeColor = System.Drawing.Color.Black;
            this.btnFixUser.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFixUser.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFixUser.Location = new System.Drawing.Point(189, 246);
            this.btnFixUser.Name = "btnFixUser";
            this.btnFixUser.Size = new System.Drawing.Size(137, 45);
            this.btnFixUser.TabIndex = 16;
            this.btnFixUser.Text = "Fix";
            this.btnFixUser.Click += new System.EventHandler(this.btnFixUser_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.AutoRoundedCorners = true;
            this.btnSearchUser.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchUser.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchUser.BorderRadius = 21;
            this.btnSearchUser.BorderThickness = 1;
            this.btnSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchUser.FillColor = System.Drawing.Color.White;
            this.btnSearchUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearchUser.ForeColor = System.Drawing.Color.Black;
            this.btnSearchUser.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchUser.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(484, 246);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(146, 45);
            this.btnSearchUser.TabIndex = 17;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 55);
            this.panel2.TabIndex = 15;
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
            "Male",
            "Female"});
            this.cbFilter.Location = new System.Drawing.Point(607, 12);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(140, 36);
            this.cbFilter.TabIndex = 6;
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
            this.btnFilter.Location = new System.Drawing.Point(753, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(137, 49);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // flpContainerCustomer
            // 
            this.flpContainerCustomer.AutoScroll = true;
            this.flpContainerCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpContainerCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpContainerCustomer.Location = new System.Drawing.Point(0, 55);
            this.flpContainerCustomer.Name = "flpContainerCustomer";
            this.flpContainerCustomer.Size = new System.Drawing.Size(893, 308);
            this.flpContainerCustomer.TabIndex = 22;
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
            this.btnRefrech.Location = new System.Drawing.Point(636, 246);
            this.btnRefrech.Name = "btnRefrech";
            this.btnRefrech.Size = new System.Drawing.Size(146, 45);
            this.btnRefrech.TabIndex = 17;
            this.btnRefrech.Text = "Refrech";
            this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GroupBoxUser);
            this.panel1.Controls.Add(this.btnRefrech);
            this.panel1.Controls.Add(this.btnSearchUser);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnFixUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 304);
            this.panel1.TabIndex = 23;
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpContainerCustomer);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserManagement";
            this.Load += new System.EventHandler(this.FormUserManagement_Load);
            this.GroupBoxUser.ResumeLayout(false);
            this.GroupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picCustomerImage;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cboGender;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxUser;
        private Guna.UI2.WinForms.Guna2Button btnChooseImage;
        private Guna.UI2.WinForms.Guna2TextBox txtIdUser;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private System.Windows.Forms.Label lblQuantity;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnFixUser;
        private Guna.UI2.WinForms.Guna2Button btnSearchUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpContainerCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerBirthday;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnRefrech;
        private System.Windows.Forms.Panel panel1;
    }
}