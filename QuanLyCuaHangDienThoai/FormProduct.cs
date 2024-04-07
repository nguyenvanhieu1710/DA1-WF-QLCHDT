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

namespace QuanLyCuaHangDienThoai
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        Product_BLL product_BLL = new Product_BLL();
        private Panel GenerateProduct(Product_DTO product)
        {
            Panel panel = new Panel();
            
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "pnlContainerProduct";
            panel.Size = new System.Drawing.Size(201, 319);
            panel.TabIndex = 49;
            Guna2PictureBox pictureBox = new Guna2PictureBox();
            pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox.ImageRotate = 0F;
            pictureBox.Location = new System.Drawing.Point(9, 13);
            pictureBox.Name = "picImageProduct";
            pictureBox.Size = new System.Drawing.Size(179, 169);
            pictureBox.TabIndex = 40;
            pictureBox.TabStop = false;
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
            labelProductPrice.Text = product.Price.ToString();
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

            panel.Controls.Add(labelProductName);
            panel.Controls.Add(labelProductPrice);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(buttonAddToCart);
            panel.Controls.Add(buttonBuyNow);
            return panel;
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            List<Product_DTO> products = product_BLL.ProductList();
            foreach (Product_DTO product in products)
            {
                flpContainerProduct.Controls.Add(GenerateProduct(product));
            }
        }
        public event EventHandler openNewForm;
        private void picImageProduct_Click(object sender, EventArgs e)
        {
            openNewForm(this, new EventArgs());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnCategory.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
