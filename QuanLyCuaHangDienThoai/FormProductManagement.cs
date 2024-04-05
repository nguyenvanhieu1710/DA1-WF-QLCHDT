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

namespace QuanLyCuaHangDienThoai
{
    public partial class FormProductManagement : Form
    {
        public FormProductManagement()
        {
            InitializeComponent();
        }

        private void FormProductManagement_Load(object sender, EventArgs e)
        {
            Product_BLL product_BLL = new Product_BLL();
            //dgvProduct.DataSource = product_BLL.ProductList();
        }
    }
}
