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
    public partial class FormProductDetail : Form
    {
        public FormProductDetail()
        {
            InitializeComponent();
        }
        Product_DTO Product_DTO = new Product_DTO();
        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            lblProductName.Text = Product_DTO.ProductName;
            picImageProduct.ImageLocation = Product_DTO.ImageProduct;
            priceFixed = Product_DTO.Price;
            lblPrice.Text = Product_DTO.Price.ToString("N0") + "đ";
            LoadDataGridView();
            txtQuantityProduct.Text = "1";
        }
        public void getProduct(Product_DTO product_DTO)
        {
            Product_DTO = product_DTO;
        }
        private void LoadDataGridView()
        {
            string specificationInProduct = Product_DTO.ProductDetail;
            string specificationInCategory = "";
            Category_BLL category_BLL = new Category_BLL();
            List<Category_DTO> categories = category_BLL.CategoryList();
            foreach (Category_DTO category in categories)
            {
                if(Product_DTO.IdCategory == category.IdCategory)
                {
                    specificationInCategory = category.ProductDetail;
                }
            }
            string[] specificationsInProduct = specificationInProduct.Split(',');
            string[] specificationsInCategory = specificationInCategory.Split(',');

            // Đảm bảo DataGridView có đủ số cột:
            dgvProductSpecifications.ColumnCount = 2;

            // Thêm từng cặp giá trị vào DataGridView:
            for (int i = 0; i < specificationsInProduct.Length && i < specificationsInCategory.Length; i++)
            {
                dgvProductSpecifications.Rows.Add(specificationsInProduct[i], specificationsInCategory[i]);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!checkRegex(txtQuantityProduct.Text))
            {
                btnMinus.Click += null;
                return;
            }
            int quantity = int.Parse(txtQuantityProduct.Text.ToString());
            txtQuantityProduct.Text = (quantity - 1).ToString();
            if (int.Parse(txtQuantityProduct.Text.ToString()) == 0
                || int.Parse(txtQuantityProduct.Text.ToString()) < 0)
            {
                txtQuantityProduct.Text = "1";
            }
            lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!checkRegex(txtQuantityProduct.Text))
            {
                btnPlus.Click += null;
                return;
            }
            int quantity = int.Parse(txtQuantityProduct.Text.ToString());
            txtQuantityProduct.Text = (quantity + 1).ToString();
            if (int.Parse(txtQuantityProduct.Text.ToString()) == 0
                || int.Parse(txtQuantityProduct.Text.ToString()) < 0)
            {
                txtQuantityProduct.Text = "1";
            }
            if (checkQuantityMax(Product_DTO, txtQuantityProduct.Text))
            {
                txtQuantityProduct.Text = Product_DTO.Quantity.ToString();
                btnPlus.Click += null;
                return;
            }

            lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";

        }
        decimal priceFixed;
        private void txtQuantityProduct_Leave(object sender, EventArgs e)
        {
            int quantity;
            bool isNumber = Int32.TryParse(txtQuantityProduct.Text, out quantity);

            if (!isNumber)
            {
                MessageBox.Show("Quantity is not valid", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantityProduct.Text = "1";
            }
            if (checkQuantityMax(Product_DTO, txtQuantityProduct.Text))
            {
                txtQuantityProduct.Text = Product_DTO.Quantity.ToString();
                lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";
                //txtQuantityProduct.Leave += null;
                return;
            }
            lblPrice.Text = (decimal.Parse(txtQuantityProduct.Text) * priceFixed).ToString("N0") + "đ";
        }
        private bool checkRegex(string quantityProduct)
        {
            if (quantityProduct.Trim() == "")
            {
                MessageBox.Show("Quantity is blank", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (int.Parse(quantityProduct.Trim()) <= 0)
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
            if (quantityProductInDatabase < quantity)
            {
                MessageBox.Show("Quantity is maximum", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        public delegate void MoveInFormCart();
        public MoveInFormCart moveInFormCart;
        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            addToCart(Product_DTO);
            // chuyển form
            moveInFormCart();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            addToCart(Product_DTO);
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
            if (cart_BLL.CheckExit(product_DTO, accountOnline))
            {
                MessageBox.Show("Products already in the cart", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // vì id account và id customer là như nhau lên thêm cái nào cũng thế
            int result = 1;
            if (result == cart_BLL.addCart(product_DTO, accountOnline))
            {
                MessageBox.Show("Successfully added to cart", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Add to cart failed", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
