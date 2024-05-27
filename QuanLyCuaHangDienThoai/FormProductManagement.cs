using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormProductManagement : Form
    {
        public FormProductManagement()
        {
            InitializeComponent();
        }
        Product_BLL Product_BLL = new Product_BLL();
        Product_DTO product_DTO = new Product_DTO();
        private void FormProductManagement_Load(object sender, EventArgs e)
        {
            Refrech();
        }
        private bool CheckRegex()
        {
            if (txtIdProduct.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID Product");
                return false;
            }
            if (!RegexData.IsValidId(txtIdProduct.Text.Trim()))
            {
                MessageBox.Show("ID Product not valid");
                return false;
            }
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Product name");
                return false;
            }
            if (picProductImage.Image == null)
            {
                MessageBox.Show("Please choose image");
                return false;
            }
            if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("Please enter quantity");
                return false;
            }
            if (int.Parse(txtQuantity.Text.Trim()) < 0)
            {
                MessageBox.Show("Quantity is not valid");
                return false;
            }
            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Please enter price");
                return false;
            }
            if (int.Parse(txtPrice.Text.Trim()) < 0)
            {
                MessageBox.Show("Price is not valid");
                return false;
            }
            if (txtIdTradeMark.Text.Trim() == "")
            {
                MessageBox.Show("Please enter trade mark");
                return false;
            }
            if (txtIdProduct.Text.Trim() == "")
            {
                MessageBox.Show("Please enter id Product");
                return false;
            }
            if (txtProductDetail.Text.Trim() == "")
            {
                MessageBox.Show("Please enter product detail");
                return false;
            }
            if (cbIdCategory.Text == "")
            {
                MessageBox.Show("Please choose id category");
                return false;
            }
            return true;
        }
        private Product_DTO AssignDataDTO()
        {
            // Hàm gán dữ liệu trở lại đối tượng DTO
            Product_DTO Product_DTO = new Product_DTO();
            Product_DTO.IdProduct = int.Parse(txtIdProduct.Text);
            Product_DTO.ProductName = txtProductName.Text;
            Product_DTO.Quantity = int.Parse(txtQuantity.Text);
            Product_DTO.Price = decimal.Parse(txtPrice.Text);
            Product_DTO.TradeMark = txtIdTradeMark.Text;
            Product_DTO.ImageProduct = saveImage;
            Product_DTO.IdCategory = int.Parse(cbIdCategory.Text);
            Product_DTO.ProductDetail = txtProductDetail.Text;
            Product_DTO.LaunchTime = DateTime.Parse(DateTimePickerLaunchTime.Text);
            Product_DTO.DayCreated = DateTime.Parse(DateTimePickerDayCreated.Text);
            return Product_DTO;
        }
        private void ChooseImage(Product_DTO Product_DTO)
        {
            if (!Directory.Exists(saveImage))
            {
                // MessageBox.Show("Path is not exists or not valid");
                saveImage = saveImage.Replace(@"\\", @"\");
                //Directory.CreateDirectory(saveImage); // tạo thư mục luôn trước khi lưu
                picProductImage.Image.Save($@"{saveImage}");
            }
            else
            {
                // lưu vô đối tượng DTO để cho vào cơ sở dữ liệu
                Product_DTO.ImageProduct = saveImage;
                //Directory.CreateDirectory(saveImage);
                picProductImage.Image.Save($@"{saveImage}");
            }
        }
        private void NoChooseImage(Product_DTO Product_DTO)
        {
            // nghĩa là ảnh cũ đã được lưu vào pictureBox từ trước rồi
            // thì dùng luôn đường dẫn cũ rồi cho vào database luôn
            Product_DTO.ImageProduct = picProductImage.ImageLocation;
            string OldPath = picProductImage.ImageLocation;

            if (OldPath == "" || OldPath == null || OldPath == "No Image")
            {
                // nếu trong database là ảnh trống thì cứ để nguyên và thoát ra thôi
                return;
            }

            try
            {
                // Kiểm tra xem đường dẫn cũ tồn tại không
                var directory = Path.GetDirectoryName(OldPath);
                if (!Directory.Exists(directory)) // nếu đường dẫn không tồn tại
                {
                    MessageBox.Show("Path is not exists or not valid");
                    // Tạo đường dẫn nếu nó không tồn tại
                    Directory.CreateDirectory(directory);
                    picProductImage.Image.Save($@"{OldPath}");
                }
                // nếu đường dẫn đã tồn tại thì không cần save lại nữa
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Product_DTO product_DTO = AssignDataDTO();

            if (Product_BLL.CheckExit(product_DTO))
            {
                MessageBox.Show("The Product already exists");
                return;
            }
            if (saveImage == null || saveImage == "")
            {
                // không chọn ảnh -> đường dẫn trống
                NoChooseImage(product_DTO);
            }
            else
            {
                // chọn ảnh -> có đường dẫn
                ChooseImage(product_DTO);
            }
            int result = 1; //kiểm tra số bản ghi thêm vào có đúng không
            // lưu vào database
            if (Product_BLL.addProduct(product_DTO) == result)
            {
                MessageBox.Show("Added Products successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Adding failed Products");
                Refrech();
                return;
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Product_DTO Product_DTO = AssignDataDTO();

            if (!Product_BLL.CheckExit(Product_DTO))
            {
                MessageBox.Show("Product does not exist");
                return;
            }

            if (saveImage == null || saveImage == "")
            {
                // không chọn ảnh -> đường dẫn trống
                NoChooseImage(Product_DTO);
            }
            else
            {
                // chọn ảnh -> có đường dẫn
                ChooseImage(Product_DTO);
            }

            int result = 1; //kiểm tra số bản ghi sửa có đúng không
            if (Product_BLL.fixProduct(Product_DTO) == result)
            {
                MessageBox.Show("Fixed Products successfully");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Fix failed Products");
                Refrech();
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRegex())
            {
                return;
            }
            Product_DTO Product_DTO = AssignDataDTO();

            if (!Product_BLL.CheckExit(Product_DTO))
            {
                MessageBox.Show("Product does not exist");
                return;
            }

            // vì không xác định được chính xác số bản ghi bị ảnh hưởng nên cứ để chạy bình thường thôi
            Product_BLL.deleteProduct(Product_DTO);

            if (!Product_BLL.CheckExit(Product_DTO))
            {
                MessageBox.Show("Delete Product success");
                Refrech();
                return;
            }
            else
            {
                MessageBox.Show("Delete fail Product");
                Refrech();
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("please enter Product name");
                return;
            }
            Product_DTO Product = new Product_DTO();
            Product.ProductName = txtProductName.Text.Trim();
            List<Product_DTO> ProductList_search = Product_BLL.searchProduct(Product);
            DataTable dataTable = ConvertData.ConvertToDataTable(ProductList_search);
            dgvProduct.DataSource = dataTable;
            // số lượng product
            lblQuantityProduct.Text = ProductList_search.Count.ToString() + " Product";
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            Refrech();
            txtIdProduct.Text = "";
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtIdTradeMark.Text = "";
            picProductImage.Image = null;
            txtIdProduct.Text = "";
            txtProductDetail.Text = "";
        }
        private void Refrech()
        {
            List<Product_DTO> ProductList = Product_BLL.ProductList();
            dgvProduct.DataSource = Product_BLL.productList();
            // số lượng product
            lblQuantityProduct.Text = ProductList.Count.ToString() + " Product";
            // cập nhật lại để tránh khi không chọn ảnh
            // mà vẫn có đường dẫn được lưu vào biến này sau lần nhấn trước đó
            saveImage = "";
            LoadDataComboBox();
        }
        string saveImage; // đường dẫn đầy đủ tới nơi lưu ảnh
        string fileName; // tên file ảnh được chọn
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //string img = openFileDialog.FileName;
                //picProductImage.ImageLocation = img;
                picProductImage.Image = new Bitmap(openFileDialog.FileName);
                // MessageBox.Show("Đường dẫn của tệp hình ảnh đã chọn: " + openFileDialog.FileName);
                fileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                // MessageBox.Show("Tên của tệp hình ảnh đã chọn: " + fileName);
                // Application.StartupPath là cắm đường dẫn tới folder Debug trong folder bin
                saveImage = Application.StartupPath + @"\Image\" + fileName;
                // MessageBox.Show(saveImage);
            }
            else
            {
                //MessageBox.Show("Không chọn ảnh nào");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbFilter.Text == "")
            {
                MessageBox.Show("Please choose combobox");
                return;
            }

            List<Product_DTO> productFilter = Product_BLL.filterProduct(cbFilter.Text);
            DataTable dataTable = ConvertData.ConvertToDataTable(productFilter);
            dgvProduct.DataSource = dataTable;
            // số lượng product
            lblQuantityProduct.Text = productFilter.Count.ToString() + " Product";
        }
        private void LoadDataComboBox()
        {
            cbIdCategory.Items.Clear();
            Category_BLL category_BLL = new Category_BLL();
            List<Category_DTO> categoryList = category_BLL.CategoryList();
            foreach (Category_DTO category_DTO in categoryList)
            {
                cbIdCategory.Items.Add(category_DTO.IdCategory);
            }
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvProduct.Rows[e.RowIndex];
            txtIdProduct.Text = row.Cells[0].Value.ToString();
            txtProductName.Text = row.Cells[1].Value.ToString();
            txtQuantity.Text = row.Cells[2].Value.ToString();
            txtPrice.Text = row.Cells[3].Value.ToString();
            txtIdTradeMark.Text = row.Cells[4].Value.ToString();
            DateTimePickerLaunchTime.Text = row.Cells[5].Value.ToString();
            picProductImage.ImageLocation = row.Cells[6].Value.ToString();
            DateTimePickerDayCreated.Text = row.Cells[7].Value.ToString();
            cbIdCategory.SelectedIndex = cbIdCategory.FindStringExact(row.Cells[8].Value.ToString());
            txtProductDetail.Text = row.Cells[9].Value.ToString();
        }
    }
}
