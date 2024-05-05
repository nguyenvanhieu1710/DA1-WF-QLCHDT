using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
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

namespace QuanLyCuaHangDienThoai
{
    public partial class FormOrderDetailcs : Form
    {
        public FormOrderDetailcs()
        {
            InitializeComponent();
        }
        OrderTable_DTO orderTable_DTO = new OrderTable_DTO();
        public void getOrder(OrderTable_DTO OrderTable_DTO)
        {
            orderTable_DTO = OrderTable_DTO;
        }
        private void FormOrderDetailcs_Load(object sender, EventArgs e)
        {
            flpContainerProduct.Controls.Clear();
            // nếu đơn hàng đang chờ xác nhận
            if (orderTable_DTO.OrderStatus == "Wait for confirmation")
            {
                lblOrderStatus.Text = "Order is awaiting confirmation";
            }
            // nếu đơn hàng đã được xác nhận
            else if (orderTable_DTO.OrderStatus == "Confirmed")
            {
                lblOrderStatus.Text = "Order is awaiting shipping";
            }
            // nếu đơn hàng đã giao thành công
            else if (orderTable_DTO.OrderStatus == "Confirm receipt of order")
            {
                lblOrderStatus.Text = "order has been received";
            }
            lblDeliveryAddress.Text = orderTable_DTO.DeliveryAddress;

            // lấy danh sách order detail
            OrderTable_BLL orderTable_BLL = new OrderTable_BLL();
            List<OrderDetail_DTO> orderDetailList = orderTable_BLL.OrderDetailList();
            // lấy danh sách product
            Product_BLL product_BLL = new Product_BLL();
            List<Product_DTO> productList = product_BLL.ProductList();

            // duyệt danh sách order detai trước
            foreach(OrderDetail_DTO orderDetail_DTO in orderDetailList)
            {
                // nếu đúng các order detail của order
                if(orderTable_DTO.IdOrderTable == orderDetail_DTO.IdOrder)
                {
                    // duyệt danh sách product
                    foreach(Product_DTO product_DTO in productList)
                    {
                        // nếu đúng là product trong order detail
                        if(product_DTO.IdProduct == orderDetail_DTO.IdProduct)
                        {
                            // thì hiển thị ra màn hình các thứ cần thiết
                            flpContainerProduct.Controls.Add(GenerateProduct(product_DTO, orderDetail_DTO));
                        }
                    }
                }
            }
        }
        private Panel GenerateProduct(Product_DTO product_DTO, OrderDetail_DTO orderDetail_DTO)
        {
            Panel pnlProduct = new Panel();
            // 
            // pnlProduct
            // 
            pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            pnlProduct.Location = new System.Drawing.Point(3, 3);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new System.Drawing.Size(883, 104);
            pnlProduct.TabIndex = 3;
            // 
            // lblPrice
            // 
            Label lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(676, 33);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(53, 24);
            lblPrice.TabIndex = 4;
            lblPrice.Text = orderDetail_DTO.Price.ToString("N0") + "đ";
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
            // 
            // lblQuantityproduct
            // 
            Label lblQuantityproduct = new Label();
            lblQuantityproduct.AutoSize = true;
            lblQuantityproduct.Location = new System.Drawing.Point(382, 33);
            lblQuantityproduct.Name = "lblQuantityproduct";
            lblQuantityproduct.Size = new System.Drawing.Size(86, 24);
            lblQuantityproduct.TabIndex = 4;
            lblQuantityproduct.Text = "Quantity: "+ orderDetail_DTO.QuantityProduct.ToString();

            pnlProduct.Controls.Add(lblPrice);
            pnlProduct.Controls.Add(lblProductName);
            pnlProduct.Controls.Add(picImageProduct);
            pnlProduct.Controls.Add(lblQuantityproduct);
            return pnlProduct;
        }

        private void btnContactShop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Function is updating. Do you still want to continue watching?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
        }

        private void btnSeeReviews_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Function is updating. Do you still want to continue watching?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
        }
    }
}
