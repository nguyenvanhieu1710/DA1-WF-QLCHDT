using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }
        Cart_BLL cart_BLL = new Cart_BLL();
        Product_BLL product_BLL = new Product_BLL();
        Product_DTO product_DTO = new Product_DTO();
        public void getProduct(Product_DTO product)
        {
            product_DTO = product;
        }
        private void refrech(Account_DTO account_DTO)
        {
            flpContainerProduct.Controls.Clear();
            List<Product_DTO> productOfCustomerList = cart_BLL.getProductOfCustomer(account_DTO);
            foreach (Product_DTO product in productOfCustomerList)
            {
                flpContainerProduct.Controls.Add(GenerateProduct(product));
            }
        }
        private void checkAccount()
        {
            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();

            if (quantityAccountOnline <= 0)
            {
                MessageBox.Show("Not logged in yet", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            refrech(accountOnline);
        }
        private void turnOffHorizontalScrollbar(FlowLayoutPanel flowLayoutPanel)
        {
            // tắt thanh cuộn ngang
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Maximum = 0;

            // tắt thanh cuộn dọc
            flowLayoutPanel.VerticalScroll.Enabled = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.VerticalScroll.Maximum = 0;

            flowLayoutPanel.AutoScroll = true;
        }
        private void FormCart_Load(object sender, EventArgs e)
        {
            flpContainerProduct.Controls.Clear();
            turnOffHorizontalScrollbar(flpContainerProduct);
            checkAccount();          
        }
        int totalMoney;
        private Panel GenerateProduct(Product_DTO product_DTO)
        {
            // 
            // pnlProduct
            // 
            Panel pnlProduct = new Panel();

            pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlProduct.Location = new System.Drawing.Point(3, 3);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new System.Drawing.Size(880, 104);
            pnlProduct.TabIndex = 2;
            // 
            // chkChooseProduct
            // 
            Guna2CheckBox chkChooseProduct = new Guna2CheckBox();
            chkChooseProduct.AutoSize = true;
            chkChooseProduct.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            chkChooseProduct.CheckedState.BorderRadius = 0;
            chkChooseProduct.CheckedState.BorderThickness = 0;
            chkChooseProduct.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            chkChooseProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            chkChooseProduct.Location = new System.Drawing.Point(32, 40);
            chkChooseProduct.Name = "chkChooseProduct";
            chkChooseProduct.Size = new System.Drawing.Size(18, 17);
            chkChooseProduct.TabIndex = 8;
            chkChooseProduct.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            chkChooseProduct.UncheckedState.BorderRadius = 0;
            chkChooseProduct.UncheckedState.BorderThickness = 0;
            chkChooseProduct.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnDeleteProduct
            // 
            Guna2Button btnDeleteProduct = new Guna2Button();
            btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnDeleteProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnDeleteProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnDeleteProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnDeleteProduct.FillColor = System.Drawing.Color.Transparent;
            btnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            btnDeleteProduct.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_delete_blue;
            btnDeleteProduct.ImageSize = new System.Drawing.Size(50, 50);
            btnDeleteProduct.Location = new System.Drawing.Point(794, 27);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new System.Drawing.Size(61, 49);
            btnDeleteProduct.TabIndex = 7;
            btnDeleteProduct.Click += (s, e) =>
            {
                if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                // xóa trong database
                deleteProduct(product_DTO);
                checkAccount(); // load lại các product
                chkChooseAll.Checked = false;
                lblTotalMoney.Text = "0đ";
                listProductSelected.Clear();// xóa list
            };
            // 
            // lblPrice
            // 
            decimal priceFixed = product_DTO.Price;
            decimal newPice = 0;
            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(638, 40);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(53, 24);
            lblPrice.TabIndex = 4;
            lblPrice.Text = product_DTO.Price.ToString("N0") + "đ";
            // 
            // txtQuantityProduct
            // 
            int selectedQuantity;
            Guna2TextBox txtQuantityProduct = new Guna2TextBox();
            txtQuantityProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtQuantityProduct.DefaultText = "";
            txtQuantityProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            txtQuantityProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            txtQuantityProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtQuantityProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtQuantityProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtQuantityProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtQuantityProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            txtQuantityProduct.Location = new System.Drawing.Point(495, 31);
            txtQuantityProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtQuantityProduct.Name = "txtQuantityProduct";
            txtQuantityProduct.PasswordChar = '\0';
            txtQuantityProduct.PlaceholderText = "";
            txtQuantityProduct.SelectedText = "";
            txtQuantityProduct.Size = new System.Drawing.Size(39, 45);
            txtQuantityProduct.TabIndex = 3;
            txtQuantityProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtQuantityProduct.Text = "1";
            txtQuantityProduct.TextChanged += (s, e) =>
            {
                int quantity;
                bool isNumber = Int32.TryParse(txtQuantityProduct.Text, out quantity);

                if (!isNumber)
                {
                    MessageBox.Show("Quantity is not valid", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantityProduct.Text = "1";
                }
                string oldPrice = "0";
                // oldPrice coi là số tiền trước khi chỉnh sửa lại số lượng
                oldPrice = lblPrice.Text.Replace(",", "").Replace("đ", "").Trim();

                if (checkQuantityMax(product_DTO, txtQuantityProduct.Text))
                {
                    // số lượng tối đa
                    txtQuantityProduct.Text = product_DTO.Quantity.ToString();

                    lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";
                    //txtQuantityProduct.Leave += null;
                    return;
                }

                // lblPrice.Text bên dưới coi là giá tiền mới sau khi chỉnh sửa số lượng
                lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";

                // sau khi click và chạy đến đây thì tổng tiền hiện tại vẫn chưa thay đổi nhé
                string currentPrice = lblTotalMoney.Text;

                if (chkChooseProduct.Checked == true)
                {
                    if (lblPrice.Text.Replace(",", "").Replace("đ", "").Trim() != oldPrice)
                    {
                        // khi mà sản phẩm không check thì không ảnh hưởng gì đến tổng tiền
                        // nhưng khi đã check rồi mà chỉnh sửa số lượng thì sẽ ảnh hưởng đến tổng tiền
                        // trừ đi tiền cũ để dùng tiền mới sau khi thay đổi số lượng
                        totalMoney -= int.Parse(oldPrice);
                        // tổng tiền lại cộng với giá mới vào(sử dụng tiền mới)
                        totalMoney += int.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
                        lblTotalMoney.Text = totalMoney.ToString("N0") + "đ";
                    }

                }
                // cập nhật lại số lượng sau khi thay đổi
                selectedQuantity = int.Parse(txtQuantityProduct.Text.Trim());
                // cập nhật lại giá mới
                newPice = decimal.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
                // xử lý list và số lượng mới và tiền mới mà khách chọn
                handleDataMoveInFormPay(chkChooseProduct, product_DTO, selectedQuantity, newPice);
            };
            // 
            // btnPlus
            // 
            Guna2Button btnPlus = new Guna2Button();
            btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnPlus.FillColor = System.Drawing.Color.White;
            btnPlus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            btnPlus.ForeColor = System.Drawing.Color.Black;
            btnPlus.Location = new System.Drawing.Point(552, 31);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new System.Drawing.Size(40, 45);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.Click += (s, e) =>
            {
                if (!checkRegex(txtQuantityProduct.Text))
                {
                    //btnPlus.Click += null;
                    return;
                }
                int quantity = int.Parse(txtQuantityProduct.Text.ToString());
                txtQuantityProduct.Text = (quantity + 1).ToString();
                if (int.Parse(txtQuantityProduct.Text.ToString()) == 0
                    || int.Parse(txtQuantityProduct.Text.ToString()) < 0)
                {
                    txtQuantityProduct.Text = "1";
                }
                if (checkQuantityMax(product_DTO, txtQuantityProduct.Text))
                {
                    // nếu max
                    txtQuantityProduct.Text = product_DTO.Quantity.ToString();
                    //btnPlus.Click += null;
                    return;
                }
                string oldPrice = "0";
                // oldPrice coi là số tiền trước khi chỉnh sửa lại số lượng
                oldPrice = lblPrice.Text.Replace(",", "").Replace("đ", "").Trim();
                // lblPrice.Text bên dưới coi là giá tiền mới sau khi chỉnh sửa số lượng
                lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";

                // sau khi click và chạy đến đây thì tổng tiền hiện tại vẫn chưa thay đổi nhé
                string currentPrice = lblTotalMoney.Text;

                if (chkChooseProduct.Checked == true)
                {
                    if (lblPrice.Text.Replace(",", "").Replace("đ", "").Trim() != oldPrice)
                    {
                        // khi mà sản phẩm không check thì không ảnh hưởng gì đến tổng tiền
                        // nhưng khi đã check rồi mà chỉnh sửa số lượng thì sẽ ảnh hưởng đến tổng tiền
                        // trừ đi tiền cũ để dùng tiền mới sau khi thay đổi số lượng
                        totalMoney -= int.Parse(oldPrice);
                        // tổng tiền lại cộng với giá mới vào(sử dụng tiền mới)
                        totalMoney += int.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
                        lblTotalMoney.Text = totalMoney.ToString("N0") + "đ";
                    }
                   
                }
                // cập nhật lại số lượng sau khi thay đổi
                selectedQuantity = int.Parse(txtQuantityProduct.Text.Trim());
                // cập nhật lại giá mới
                newPice = decimal.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
                // xử lý list và số lượng mới và tiền mới mà khách chọn
                handleDataMoveInFormPay(chkChooseProduct, product_DTO, selectedQuantity, newPice);
            };
            // 
            // btnMinus
            // 
            Guna2Button btnMinus = new Guna2Button();
            btnMinus.BackColor = System.Drawing.Color.White;
            btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnMinus.FillColor = System.Drawing.Color.White;
            btnMinus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            btnMinus.ForeColor = System.Drawing.Color.Black;
            btnMinus.Location = new System.Drawing.Point(431, 31);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new System.Drawing.Size(40, 45);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.Click += (s, e) =>
            {               
                if (!checkRegex(txtQuantityProduct.Text))
                {
                    btnMinus.Click += null;
                    return;
                }
                int quantity = int.Parse(txtQuantityProduct.Text.ToString());
                txtQuantityProduct.Text = (quantity - 1).ToString();
                if(int.Parse(txtQuantityProduct.Text.ToString()) == 0 
                    || int.Parse(txtQuantityProduct.Text.ToString()) < 0)
                {
                    txtQuantityProduct.Text = "1";
                }

                string oldPrice = "0";
                // oldPrice coi là số tiền trước khi chỉnh sửa lại số lượng
                oldPrice = lblPrice.Text.Replace(",", "").Replace("đ", "").Trim();
                // lblPrice.Text bên dưới coi là giá tiền mới sau khi chỉnh sửa số lượng
                lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";

                // sau khi click và chạy đến đây thì tổng tiền hiện tại vẫn chưa thay đổi nhé
                string currentTotalPrice = lblTotalMoney.Text;

                if(chkChooseProduct.Checked == true)
                {
                    // khi mà sản phẩm không check thì không ảnh hưởng gì đến tổng tiền
                    // nhưng khi đã check rồi mà chỉnh sửa số lượng thì sẽ ảnh hưởng đến tổng tiền
                    // trừ đi tiền cũ để dùng tiền mới sau khi thay đổi số lượng
                    totalMoney -= int.Parse(oldPrice.ToString());
                    // sử dụng tiền mới
                    totalMoney += int.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
                    lblTotalMoney.Text = totalMoney.ToString("N0") + "đ";
                }
                // cập nhật lại số lượng sau khi thay đổi
                selectedQuantity = int.Parse(txtQuantityProduct.Text.Trim());
                // cập nhật lại giá mới
                newPice = decimal.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
                // xử lý list và số lượng mới và tiền mới mà khách chọn
                handleDataMoveInFormPay(chkChooseProduct, product_DTO, selectedQuantity, newPice);
            };
            // 
            // lblProductName
            // 
            Label lblProductName = new Label();
            lblProductName.AutoSize = true;
            lblProductName.Location = new System.Drawing.Point(150, 33);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(135, 24);
            lblProductName.TabIndex = 1;
            lblProductName.Text = product_DTO.ProductName;
            // 
            // picImageProduct
            // 
            Guna2PictureBox picImageProduct = new Guna2PictureBox();
            picImageProduct.ImageRotate = 0F;
            picImageProduct.Location = new System.Drawing.Point(69, 12);
            picImageProduct.Name = "picImageProduct";
            picImageProduct.Size = new System.Drawing.Size(75, 75);
            picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picImageProduct.TabIndex = 0;
            picImageProduct.TabStop = false;
            picImageProduct.ImageLocation = product_DTO.ImageProduct;

            chkChooseProduct.CheckedChanged += (s, e) =>
            {
                string oldPrice = "0";
                // oldPrice coi là số tiền trước khi chỉnh sửa lại số lượng
                oldPrice = lblPrice.Text.Replace(",", "").Replace("đ", "").Trim();
                // lblPrice.Text bên dưới coi là giá tiền mới sau khi chỉnh sửa số lượng
                lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";


                // cập nhật lại số lượng sau khi thay đổi
                selectedQuantity = int.Parse(txtQuantityProduct.Text.Trim());

                handleCheckbox();
                handleMoney(chkChooseProduct, lblPrice, product_DTO, oldPrice, selectedQuantity);
                //product_DTO.Price = decimal.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
            };

            pnlProduct.Controls.Add(chkChooseProduct);
            pnlProduct.Controls.Add(btnDeleteProduct);
            pnlProduct.Controls.Add(lblPrice);
            pnlProduct.Controls.Add(txtQuantityProduct);
            pnlProduct.Controls.Add(btnPlus);
            pnlProduct.Controls.Add(btnMinus);
            pnlProduct.Controls.Add(lblProductName);
            pnlProduct.Controls.Add(picImageProduct);
            return pnlProduct;
        }
        
        private bool checkRegex(string quantityProduct)
        {
            if(quantityProduct.Trim() == "")
            {
                MessageBox.Show("Quantity is blank", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(int.Parse(quantityProduct.Trim()) <= 0)
            {
                MessageBox.Show("Quantity is not valid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private bool checkQuantityMax(Product_DTO product_DTO, string quantityProduct)
        {
            int quantity = int.Parse(quantityProduct.ToString());
            int quantityProductInDatabase = product_DTO.Quantity;
            if(quantityProductInDatabase < quantity)
            {
                MessageBox.Show("Quantity is maximum", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        private void chkChooseAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChooseAll.Checked == true)
            {
                foreach (Control control in flpContainerProduct.Controls)
                {
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl is CheckBox)
                        {
                            ((CheckBox)subControl).Checked = true;
                        }
                    }
                }
            }
            else
            {
                foreach (Control control in flpContainerProduct.Controls)
                {
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl is CheckBox)
                        {
                            ((CheckBox)subControl).Checked = false;
                        }
                    }
                }
                // cập nhật lại giá tiền
                totalMoney = 0;
                lblTotalMoney.Text = totalMoney.ToString("N0") + "đ";
            }
        }
        private void handleCheckbox()
        {
            // xử lý checkbox all
            int quantityCheckbox = 0;
            int quantityCheckboxTrue = 0;
            foreach (CheckBox control in flpContainerProduct.Controls.Find("chkChooseProduct", true))
            {
                quantityCheckbox++;
                // nếu checkbox bật 
                if (control.Checked == true)
                {
                    quantityCheckboxTrue++;
                }
            }
            if (quantityCheckbox == quantityCheckboxTrue)
            {
                // toàn bộ checkbox đều được check -> bật checkAll
                chkChooseAll.Checked = true;
            }
            if(quantityCheckboxTrue == 0)
            {
                chkChooseAll.Checked = false;
                // cập nhật lại giá tiền
                totalMoney = 0;
                lblTotalMoney.Text = totalMoney.ToString("N0") + "đ";
            }
            //MessageBox.Show("quantity checkbox: " + quantityCheckbox.ToString());
        }
        private void handleMoney(CheckBox chkChooseProduct, Label lblPrice, Product_DTO product_DTO, string oldPrice, int selectedQuantity)
        {
            Product_DTO productSelected = new Product_DTO();
            productSelected.IdProduct = product_DTO.IdProduct;
            productSelected.ProductName = product_DTO.ProductName;
            // cập nhật lại số lượng mà khách hàng mua(sau khi thay đổi)
            productSelected.Quantity = selectedQuantity;
            productSelected.Price = decimal.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
            productSelected.TradeMark = product_DTO.TradeMark;
            productSelected.LaunchTime = product_DTO.LaunchTime;
            productSelected.ImageProduct = product_DTO.ImageProduct;
            productSelected.DayCreated = product_DTO.DayCreated;
            productSelected.IdCategory = product_DTO.IdCategory;
            productSelected.ProductDetail = product_DTO.ProductDetail;
            
            // xử lý total money
            if (chkChooseProduct.Checked == true)
            {
                if(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim() != oldPrice)
                {
                    // khi mà sản phẩm không check thì không ảnh hưởng gì đến tổng tiền
                    // nhưng khi đã check rồi mà chỉnh sửa số lượng thì sẽ ảnh hưởng đến tổng tiền
                    // trừ đi tiền cũ để dùng tiền mới sau khi thay đổi số lượng
                    totalMoney -= int.Parse(oldPrice);
                }
                else
                {

                }             
                // vì lblPrice ở dạng 1,000,000đ
                totalMoney += int.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
                lblTotalMoney.Text = totalMoney.ToString("N0") + "đ";
                // kiểm tra xem product này đã được chọn hay chưa
                int index = listProductSelected.FindIndex(p => p.IdProduct == productSelected.IdProduct);
                if (index == -1)
                {
                    // Đối tượng không tồn tại trong danh sách, thêm nó vào
                    listProductSelected.Add(productSelected);
                }
                else if(index != -1)
                {
                    // Đối tượng tồn tại trong danh sách
                    listProductSelected.RemoveAt(index);
                }
            }
            else
            {
                // khi không check 
                // phải kiểm tra trước là do trước đấy hay cập nhật tổng tiền về 0
                if (totalMoney < 0 || totalMoney == 0)
                {
                    totalMoney = 0;
                    lblTotalMoney.Text = "0đ";
                }
                else
                {
                    totalMoney -= int.Parse(lblPrice.Text.Replace(",", "").Replace("đ", "").Trim());
                    lblTotalMoney.Text = totalMoney.ToString("N0") + "đ";
                }
                // kiểm tra xem product này đã được chọn hay chưa
                int index = listProductSelected.FindIndex(p => p.IdProduct == productSelected.IdProduct);
                if (index == -1)
                {
                    // Đối tượng không tồn tại trong danh sách, thêm nó vào
                    listProductSelected.Add(productSelected);
                }
                else if (index != -1)
                {
                    // Đối tượng tồn tại trong danh sách
                    listProductSelected.RemoveAt(index);
                }
            }
        }
        private void handleDataMoveInFormPay(CheckBox chkChooseProduct, Product_DTO product_DTO, int selectedQuantity, decimal newPrice)
        {
            Product_DTO productSelected = new Product_DTO();
            productSelected.IdProduct = product_DTO.IdProduct;
            productSelected.ProductName = product_DTO.ProductName;
            // cập nhật lại số lượng mà khách hàng mua(sau khi thay đổi)
            productSelected.Quantity = selectedQuantity;
            productSelected.Price = newPrice;
            productSelected.TradeMark = product_DTO.TradeMark;
            productSelected.LaunchTime = product_DTO.LaunchTime;
            productSelected.ImageProduct = product_DTO.ImageProduct;
            productSelected.DayCreated = product_DTO.DayCreated;
            productSelected.IdCategory = product_DTO.IdCategory;
            productSelected.ProductDetail = product_DTO.ProductDetail;

            if (chkChooseProduct.Checked == true)
            {
                // khi check
                // kiểm tra xem product này đã được chọn hay chưa
                int index = listProductSelected.FindIndex(p => p.IdProduct == productSelected.IdProduct);
                if (index == -1)
                {
                    // Đối tượng không tồn tại trong danh sách, thêm nó vào
                    listProductSelected.Add(productSelected);
                }
                else if (index != -1)
                {
                    // Đối tượng tồn tại trong danh sách
                    listProductSelected.RemoveAt(index);
                }
            }
            else
            {
                // khi không check 
                // kiểm tra xem product này đã được chọn hay chưa
                int index = listProductSelected.FindIndex(p => p.IdProduct == productSelected.IdProduct);
                if (index == -1)
                {
                    // Đối tượng không tồn tại trong danh sách, thêm nó vào
                    listProductSelected.Add(productSelected);
                }
                else if (index != -1)
                {
                    // Đối tượng tồn tại trong danh sách
                    listProductSelected.RemoveAt(index);
                }
            }
        }
        private void refreshMoney()
        {
            int totalPrice = 0;
            foreach (CheckBox control in flpContainerProduct.Controls.Find("chkChooseProduct", true))
            {
                if(control.Checked == true)
                {
                    Label price = control.Parent.Controls.Find("lblPrice", true)[0] as Label;
                    totalPrice +=  int.Parse(price.Text.Replace(",", "").Replace("đ", ""));
                    
                }
            }
            lblTotalMoney.Text = totalPrice.ToString();
        }
        private void deleteProduct(Product_DTO product_DTO)
        {
            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();

            int result = 1;
            if (result == cart_BLL.deleteCart(product_DTO, accountOnline))
            {
                MessageBox.Show("delete cart is success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("delete cart is fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text.Trim() == "")
            {
                MessageBox.Show("Please enter product name");
                return;
            }

            Product_DTO Product = new Product_DTO();
            Product.ProductName = txtProduct.Text.Trim();
            List<Product_DTO> listProductInCartSearch = cart_BLL.searchProductInCart(Product);
            flpContainerProduct.Controls.Clear();
            foreach (Product_DTO Products in listProductInCartSearch)
            {
                flpContainerProduct.Controls.Add(GenerateProduct(Products));
            }
        }

        //public delegate void MoveInFormPay(Product_DTO product_DTO);
        //public MoveInFormPay moveInFormPay;
        List<Product_DTO> listProductSelected = new List<Product_DTO>();
        public delegate void MoveProductToFormPay(List<Product_DTO> list);
        public MoveProductToFormPay moveProductToFormPay;
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(lblTotalMoney.Text == "0đ" || lblTotalMoney.Text == "Tổng tiền")
            {
                MessageBox.Show("Please choose product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chkChooseAll.Checked == true)
            {
                // chuyển form và chuyển dữ liệu đi
                moveProductToFormPay(listProductSelected);
            }
            else
            {
                // check lại data
                //foreach(Product_DTO Products in listProductSelected)
                //{
                //    MessageBox.Show(Products.ProductName + ": "+Products.Quantity.ToString() + ", "+Products.Price);
                //}
                // chuyển form và chuyển dữ liệu đi
                moveProductToFormPay(listProductSelected);
            }
            //moveInFormPay(product_DTO);
        }
    }
}
