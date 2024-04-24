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
            lblPrice.Text = Product_DTO.Price.ToString("N0") + "đ";
            LoadDataGridView();
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
    }
}
