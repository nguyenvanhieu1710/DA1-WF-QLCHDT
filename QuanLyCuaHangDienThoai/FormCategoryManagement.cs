using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_CuaHangDienThoai;
using BLL_CuaHangDienThoai;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormCategoryManagement : Form
    {
        public FormCategoryManagement()
        {
            InitializeComponent();
        }
        Category_BLL Category_BLL = new Category_BLL();
        private void Refrech()
        {
            List<Category_DTO> categoryList = Category_BLL.CategoryList();
            foreach (Category_DTO category in categoryList)
            {
                // 1 là dữ liệu ảo
                if (category.IdCategory == 1)
                {
                    categoryList.Remove(category);
                    break;
                }
            }
            dgvCategory.DataSource = categoryList;
            lblQuantityCategory.Text = categoryList.Count.ToString() + " Category";
        }
        private void FormCategoryManagement_Load(object sender, EventArgs e)
        {
            Refrech();
        }
        private bool CheckRegex()
        {
            if (txtIdCategory.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID Category");
                return false;
            }
            if (!RegexData.IsValidId(txtIdCategory.Text.Trim()))
            {
                MessageBox.Show("ID Category is not valid");
                return false;
            }
            if (txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Category name");
                return false;
            }
            if (txtProductDetail.Text.Trim() == "")
            {
                MessageBox.Show("Please enter phone number");
                return false;
            }
            if (txtIdCategoryDad.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID Category dad");
                return false;
            }
            if (!RegexData.IsValidId(txtIdCategoryDad.Text.Trim()))
            {
                MessageBox.Show("ID Category dad is not valid");
                return false;
            }
            return true;
        }
        private Category_DTO AssignDataDTO()
        {
            // Hàm gán dữ liệu trở lại đối tượng DTO
            Category_DTO Category_DTO = new Category_DTO();
            Category_DTO.IdCategory = int.Parse(txtIdCategory.Text);
            Category_DTO.CategoryName = txtCategoryName.Text;
            Category_DTO.ProductDetail = txtProductDetail.Text;
            Category_DTO.IdCategoryDad = int.Parse(txtIdCategoryDad.Text);
            return Category_DTO;
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Category_DTO Category_DTO = AssignDataDTO();

            if (Category_BLL.CheckExit(Category_DTO))
            {
                MessageBox.Show("The Category already exists");
                return;
            }

            int result = 1; //kiểm tra số bản ghi thêm vào có đúng không
            // lưu vào database và so sánh
            if (Category_BLL.addCategory(Category_DTO) == result)
            {
                MessageBox.Show("Added Categorys successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Adding failed Categorys");
                Refrech();
                return;
            }
        }

        private void btnFixCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Category_DTO Category_DTO = AssignDataDTO();

            if (!Category_BLL.CheckExit(Category_DTO))
            {
                MessageBox.Show("Category does not exist");
                return;
            }

            int result = 1; //kiểm tra số bản ghi sửa có đúng không
            if (Category_BLL.fixCategory(Category_DTO) == result)
            {
                MessageBox.Show("Fixed Categorys successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Fix failed Categorys");
                Refrech();
                return;
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Category_DTO Category_DTO = AssignDataDTO();

            if (!Category_BLL.CheckExit(Category_DTO))
            {
                MessageBox.Show("Category does not exist");
                return;
            }

            // vì không xác định được chính xác số bản ghi bị ảnh hưởng nên cứ để chạy bình thường thôi
            Category_BLL.deleteCategory(Category_DTO);

            if (!Category_BLL.CheckExit(Category_DTO))
            {
                MessageBox.Show("Delete Category success");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Delete fail Category");
                Refrech();
                return;
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("please enter category name");
                return;
            }
            Category_DTO Category = new Category_DTO();
            Category.CategoryName = txtCategoryName.Text.Trim();
            List<Category_DTO> CategoryList_search = Category_BLL.searchCategory(Category);
            DataTable dataTable = ConvertData.ConvertToDataTable(CategoryList_search);
            dgvCategory.DataSource = dataTable;
            // số lượng user
            lblQuantityCategory.Text = CategoryList_search.Count.ToString() + " Category";
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            Refrech();
            txtIdCategory.Text = "";
            txtCategoryName.Text = "";
            txtProductDetail.Text = "";
            txtIdCategoryDad.Text = "";
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //gets a collection that contains all the rows
            DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            txtIdCategory.Text = row.Cells[0].Value.ToString();
            txtCategoryName.Text = row.Cells[1].Value.ToString();
            txtProductDetail.Text = row.Cells[2].Value.ToString();
            txtIdCategoryDad.Text = row.Cells[3].Value.ToString();
        }
    }
}
