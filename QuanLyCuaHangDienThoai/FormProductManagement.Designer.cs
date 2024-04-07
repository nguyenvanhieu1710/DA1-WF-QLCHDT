namespace QuanLyCuaHangDienThoai
{
    partial class FormProductManagement
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantityProduct = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnFixUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChooseImage = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBirthday = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.picStaffImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaffImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblQuantityProduct);
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 55);
            this.panel2.TabIndex = 22;
            // 
            // lblQuantityProduct
            // 
            this.lblQuantityProduct.AutoSize = true;
            this.lblQuantityProduct.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQuantityProduct.Location = new System.Drawing.Point(12, 12);
            this.lblQuantityProduct.Name = "lblQuantityProduct";
            this.lblQuantityProduct.Size = new System.Drawing.Size(159, 24);
            this.lblQuantityProduct.TabIndex = 9;
            this.lblQuantityProduct.Text = "Quantity Product";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Location = new System.Drawing.Point(607, 12);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(140, 36);
            this.cbFilter.TabIndex = 8;
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
            this.btnFixUser.Location = new System.Drawing.Point(314, 600);
            this.btnFixUser.Name = "btnFixUser";
            this.btnFixUser.Size = new System.Drawing.Size(137, 45);
            this.btnFixUser.TabIndex = 23;
            this.btnFixUser.Text = "Fix";
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
            this.btnSearchUser.Location = new System.Drawing.Point(609, 600);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(146, 45);
            this.btnSearchUser.TabIndex = 24;
            this.btnSearchUser.Text = "Search";
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
            this.btnAddUser.Location = new System.Drawing.Point(175, 600);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(133, 45);
            this.btnAddUser.TabIndex = 25;
            this.btnAddUser.Text = "Add";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(432, 60);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(254, 58);
            this.txtAddress.TabIndex = 13;
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
            this.btnChooseImage.Location = new System.Drawing.Point(125, 156);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(173, 45);
            this.btnChooseImage.TabIndex = 15;
            this.btnChooseImage.Text = "Choose image";
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
            // txtBirthday
            // 
            this.txtBirthday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirthday.DefaultText = "";
            this.txtBirthday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBirthday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBirthday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBirthday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBirthday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirthday.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBirthday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirthday.Location = new System.Drawing.Point(329, 128);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.PasswordChar = '\0';
            this.txtBirthday.PlaceholderText = "Birthday";
            this.txtBirthday.SelectedText = "";
            this.txtBirthday.Size = new System.Drawing.Size(125, 58);
            this.txtBirthday.TabIndex = 13;
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(481, 128);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "Phone number";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(173, 58);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.picStaffImage);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.btnChooseImage);
            this.guna2GroupBox1.Controls.Add(this.cboGender);
            this.guna2GroupBox1.Controls.Add(this.txtIdUser);
            this.guna2GroupBox1.Controls.Add(this.txtBirthday);
            this.guna2GroupBox1.Controls.Add(this.txtPhoneNumber);
            this.guna2GroupBox1.Controls.Add(this.txtAddress);
            this.guna2GroupBox1.Controls.Add(this.txtUserName);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 351);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(869, 234);
            this.guna2GroupBox1.TabIndex = 28;
            this.guna2GroupBox1.Text = "Product infomation";
            // 
            // picStaffImage
            // 
            this.picStaffImage.BackColor = System.Drawing.Color.Transparent;
            this.picStaffImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStaffImage.ImageRotate = 0F;
            this.picStaffImage.Location = new System.Drawing.Point(24, 126);
            this.picStaffImage.Name = "picStaffImage";
            this.picStaffImage.Size = new System.Drawing.Size(95, 93);
            this.picStaffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStaffImage.TabIndex = 17;
            this.picStaffImage.TabStop = false;
            this.picStaffImage.UseTransparentBackground = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(734, 55);
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
            this.cboGender.Location = new System.Drawing.Point(707, 82);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(140, 36);
            this.cboGender.StartIndex = 0;
            this.cboGender.TabIndex = 14;
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
            this.btnDeleteUser.Location = new System.Drawing.Point(457, 600);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(146, 45);
            this.btnDeleteUser.TabIndex = 26;
            this.btnDeleteUser.Text = "Delete";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(893, 290);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // FormProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 654);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFixUser);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnDeleteUser);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProductManagement";
            this.Text = "FormProductManagement";
            this.Load += new System.EventHandler(this.FormProductManagement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaffImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnFixUser;
        private Guna.UI2.WinForms.Guna2Button btnSearchUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2Button btnChooseImage;
        private Guna.UI2.WinForms.Guna2TextBox txtIdUser;
        private Guna.UI2.WinForms.Guna2TextBox txtBirthday;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox picStaffImage;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cboGender;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label lblQuantityProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}