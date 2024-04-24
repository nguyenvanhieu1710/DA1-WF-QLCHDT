using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using static QuanLyCuaHangDienThoai.FormProduct;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        Product_BLL product_BLL = new Product_BLL();
        Category_BLL Category_BLL = new Category_BLL();
        // người dùng định nghĩa 1 con trỏ hàm 
        // public event EventHandler openNewForm;
        // người dùng định nghĩa 1 con trỏ hàm 
        public delegate void MoveInFormProductDetail(Product_DTO product_DTO);
        public MoveInFormProductDetail moveInFormProductDetail;
        public delegate void MoveInFormCart(Product_DTO product_DTO);
        public MoveInFormCart moveInFormCart;
        private Panel GenerateProduct(Product_DTO product)
        {
            Panel panel = new Panel();

            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "pnlContainerProduct";
            panel.Size = new System.Drawing.Size(201, 319);
            panel.TabIndex = 49;

            Guna2PictureBox pictureBox = new Guna2PictureBox();
            // pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox.ImageRotate = 0F;
            pictureBox.Location = new System.Drawing.Point(9, 13);
            pictureBox.Name = "picImageProduct";
            pictureBox.Size = new System.Drawing.Size(179, 169);
            pictureBox.TabIndex = 40;
            pictureBox.TabStop = false;
            pictureBox.ImageLocation = product.ImageProduct;
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox.Click += (s, e) =>
            {
                // MessageBox.Show("Feature is updating");
                // Product_DTO product_DTO = product;
                moveInFormProductDetail(product);
                // openNewForm(this, new EventArgs());
            };

            Label labelProductName = new Label();
            labelProductName.AutoSize = true;
            labelProductName.Location = new System.Drawing.Point(9, 185);
            labelProductName.Name = "lblProductName";
            labelProductName.Size = new System.Drawing.Size(179, 24);
            labelProductName.TabIndex = 41;
            labelProductName.Text = product.ProductName;

            Label labelProductPrice = new Label();
            labelProductPrice.AutoSize = true;
            labelProductPrice.Location = new System.Drawing.Point(9, 219);
            labelProductPrice.Name = "lblProductPrice";
            labelProductPrice.Size = new System.Drawing.Size(121, 24);
            labelProductPrice.TabIndex = 41;
            labelProductPrice.Text = product.Price.ToString("N0") +"đ";

            Guna2Button buttonAddToCart = new Guna2Button();
            buttonAddToCart.AutoRoundedCorners = true;
            buttonAddToCart.BorderColor = System.Drawing.Color.DodgerBlue;
            buttonAddToCart.BorderRadius = 21;
            buttonAddToCart.BorderThickness = 1;
            buttonAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            buttonAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            buttonAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            buttonAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            buttonAddToCart.FillColor = System.Drawing.Color.White;
            buttonAddToCart.Font = new System.Drawing.Font("Tahoma", 12F);
            buttonAddToCart.ForeColor = System.Drawing.Color.Black;
            buttonAddToCart.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            buttonAddToCart.HoverState.ForeColor = System.Drawing.Color.White;
            buttonAddToCart.HoverState.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_cart_white;
            buttonAddToCart.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_cart_blue;
            buttonAddToCart.ImageSize = new System.Drawing.Size(30, 30);
            buttonAddToCart.Location = new System.Drawing.Point(9, 259);
            buttonAddToCart.Name = "btnAddToCart";
            buttonAddToCart.Size = new System.Drawing.Size(78, 45);
            buttonAddToCart.TabIndex = 36;
            buttonAddToCart.Click += (s, e) =>
            {
                MessageBox.Show("Feature is updating");
                addToCart(product);
            };

            Guna2Button buttonBuyNow = new Guna2Button();
            buttonBuyNow.AutoRoundedCorners = true;
            buttonBuyNow.BorderColor = System.Drawing.Color.DodgerBlue;
            buttonBuyNow.BorderRadius = 21;
            buttonBuyNow.BorderThickness = 1;
            buttonBuyNow.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonBuyNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            buttonBuyNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            buttonBuyNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            buttonBuyNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            buttonBuyNow.FillColor = System.Drawing.Color.White;
            buttonBuyNow.Font = new System.Drawing.Font("Tahoma", 12F);
            buttonBuyNow.ForeColor = System.Drawing.Color.Black;
            buttonBuyNow.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            buttonBuyNow.HoverState.ForeColor = System.Drawing.Color.White;
            buttonBuyNow.HoverState.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_basket_white;
            buttonBuyNow.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_basket_blue;
            buttonBuyNow.ImageSize = new System.Drawing.Size(30, 30);
            buttonBuyNow.Location = new System.Drawing.Point(110, 259);
            buttonBuyNow.Name = "btnBuyNow";
            buttonBuyNow.Size = new System.Drawing.Size(78, 45);
            buttonBuyNow.TabIndex = 36;
            buttonBuyNow.Click += (s, e) =>
            {
                MessageBox.Show("Feature is updating");
            };

            panel.Controls.Add(labelProductName);
            panel.Controls.Add(labelProductPrice);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(buttonAddToCart);
            panel.Controls.Add(buttonBuyNow);
            return panel;
        }
        private Guna2Button GenerateCategory(Category_DTO category)
        {
            Guna2Button button = new Guna2Button();
            button.BorderColor = System.Drawing.Color.DodgerBlue;
            button.BorderThickness = 1;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
            button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            button.FillColor = System.Drawing.Color.White;
            button.Font = new System.Drawing.Font("Tahoma", 12F);
            button.ForeColor = System.Drawing.Color.Black;
            button.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            button.HoverState.ForeColor = System.Drawing.Color.White;
            button.Location = new System.Drawing.Point(182, 3);
            button.Name = "btnCategoryName";
            button.Size = new System.Drawing.Size(173, 67);
            button.TabIndex = 51;
            button.Text = category.CategoryName;
            button.Click += (s, e) =>
            {
                searchCategory(category);
            };
            return button;
        }
        private void addToCart(Product_DTO product_DTO)
        {
            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();

            if (quantityAccountOnline <= 0)
            {
                MessageBox.Show("Not logged in yet", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cart_BLL cart_BLL = new Cart_BLL();
            // vì id account và id customer là như nhau lên thêm cái nào cũng thế
            int result = 1;
            if(result == cart_BLL.addCart(product_DTO, accountOnline))
            {
                MessageBox.Show("Successfully added to cart", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Add to cart failed", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // chuyển form
            // moveInFormCart(product_DTO);
        }
        private void searchCategory(Category_DTO category_DTO)
        {
            List<Product_DTO> productList_search = product_BLL.searchProductByIdCategory(category_DTO.IdCategory);
            flpContainerProduct.Controls.Clear();
            foreach (Product_DTO product in productList_search)
            {
                flpContainerProduct.Controls.Add(GenerateProduct(product));
            }
        }
        private void Refrech()
        {
            flpContainerProduct.Controls.Clear();
            List<Category_DTO> list = Category_BLL.CategoryList();
            foreach (Category_DTO category in list)
            {
                flpContainerCategory.Controls.Add(GenerateCategory(category));
            }
            List<Product_DTO> products = product_BLL.ProductList();
            foreach (Product_DTO product in products)
            {
                flpContainerProduct.Controls.Add(GenerateProduct(product));
            }
        }
        private void turnOffHorizontalScrollbar()
        {
            // tắt thanh cuộn ngang
            flpContainerCategory.AutoScroll = false;
            flpContainerCategory.HorizontalScroll.Enabled = false;
            flpContainerCategory.HorizontalScroll.Visible = false;
            flpContainerCategory.HorizontalScroll.Maximum = 0;
            flpContainerCategory.AutoScroll = true;
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
        private void FormProduct_Load(object sender, EventArgs e)
        {
            Refrech();
            turnOffHorizontalScrollbar();
        }

        private void picImageProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnCategory.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text.Trim() == "")
            {
                MessageBox.Show("please enter product name");
                return;
            }
            Product_DTO Product = new Product_DTO();
            Product.ProductName = txtProduct.Text.Trim();
            List<Product_DTO> ProductList_search = product_BLL.searchProduct(Product);
            flpContainerProduct.Controls.Clear();
            foreach (Product_DTO Products in ProductList_search)
            {
                flpContainerProduct.Controls.Add(GenerateProduct(Products));
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbFilter.Text == "")
            {
                MessageBox.Show("Please choose combobox");
                return;
            }

            List<Product_DTO> productFilter = product_BLL.filterProduct(cbFilter.Text);
            flpContainerProduct.Controls.Clear();
            foreach (Product_DTO Products in productFilter)
            {
                flpContainerProduct.Controls.Add(GenerateProduct(Products));
            }
        }
    }
}
