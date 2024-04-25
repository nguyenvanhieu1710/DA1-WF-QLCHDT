using DTO_CuaHangDienThoai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormPay : Form
    {
        public FormPay()
        {
            InitializeComponent();
        }
        List<Product_DTO> listProductSelected = new List<Product_DTO>();
        public void getProduct(Product_DTO product_DTO)
        {

        }
        public void getlistProductSelected(List<Product_DTO> list)
        {
            listProductSelected = list;
        }

        private void FormPay_Load(object sender, EventArgs e)
        {
            foreach (Product_DTO product in listProductSelected)
            {
                MessageBox.Show(product.ProductName);
            }
        }
    }
}
