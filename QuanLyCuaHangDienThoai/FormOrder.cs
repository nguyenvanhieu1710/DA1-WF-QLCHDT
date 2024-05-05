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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        OrderTable_BLL OrderTable_BLL = new OrderTable_BLL();
        List<OrderTable_DTO> orderTable_DTOs = new List<OrderTable_DTO>();
        List<OrderDetail_DTO> orderDetail_DTOs = new List<OrderDetail_DTO>();
        private void FormOrder_Load(object sender, EventArgs e)
        {
            // asign date 
            orderTable_DTOs = OrderTable_BLL.OrderList();
            orderDetail_DTOs = OrderTable_BLL.OrderDetailList();

            // hiển thị giao diện mặc định của order
            loadInterfaceDefault();
        }
        private void loadInterfaceDefault()
        {
            flpContainerProduct.Controls.Clear();
            // bật button 1
            turnButton(1);
            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();
            if (quantityAccountOnline <= 0)
            {
                MessageBox.Show("Not logged in yet", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // display product
            foreach (OrderTable_DTO orderTable_DTO in orderTable_DTOs)
            {
                if (orderTable_DTO.OrderStatus == "Wait for confirmation")
                {
                    flpContainerProduct.Controls.Add(GenerateProduct(orderTable_DTO, accountOnline.Role));
                }
            }
        }
        public delegate void MoveInFormOrderDetail(OrderTable_DTO orderTable_DTO);
        public MoveInFormOrderDetail moveInFormOrderDetail;
        private Panel GenerateProduct(OrderTable_DTO orderTable_DTO, string role)
        {
            // 
            // pnlProduct
            // 
            Panel pnlProduct = new Panel();
            pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlProduct.Location = new System.Drawing.Point(3, 3);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new System.Drawing.Size(883, 103);
            pnlProduct.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            Label lblTotalPrice = new Label();
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new System.Drawing.Point(150, 32);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new System.Drawing.Size(105, 24);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = orderTable_DTO.TotalPrice.ToString("N0") + "đ";
            // 
            // btnStatus
            // 
            Guna2Button btnStatus = new Guna2Button();
            btnStatus.AutoRoundedCorners = true;
            btnStatus.BorderColor = System.Drawing.Color.DodgerBlue;
            btnStatus.BorderRadius = 21;
            btnStatus.BorderThickness = 1;
            btnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnStatus.FillColor = System.Drawing.Color.White;
            btnStatus.Font = new System.Drawing.Font("Tahoma", 12F);
            btnStatus.ForeColor = System.Drawing.Color.Black;
            btnStatus.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            btnStatus.HoverState.ForeColor = System.Drawing.Color.White;
            btnStatus.Location = new System.Drawing.Point(649, 32);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new System.Drawing.Size(180, 45);
            btnStatus.TabIndex = 8;

            // nếu là nhân viên
            if (role == "Staff")
            {
                // nếu đơn hàng đang chờ xác nhận
                if (orderTable_DTO.OrderStatus == "Wait for confirmation")
                {
                    // bật button 1
                    turnButton(1);
                    btnStatus.Text = "Order confirmation";
                    btnStatus.Enabled = true;
                    btnStatus.Click += (s, e) =>
                    {
                        // hàm xác nhân đơn hàng của nhân viên
                        OrderConfirmation(orderTable_DTO);
                        btnStatus.Enabled = false;
                    };
                }
                // nếu đơn hàng đã được xác nhận
                else if (orderTable_DTO.OrderStatus == "Confirmed")
                {
                    btnStatus.Enabled = false;
                }
                // nếu đơn hàng đã giao thành công
                else if (orderTable_DTO.OrderStatus == "Confirm receipt of order")
                {
                    btnStatus.Enabled = false;
                }
                
            }

            // nếu là khách hàng
            if (role == "Customer")
            {
                // nếu đơn hàng đang chờ xác nhận
                if (orderTable_DTO.OrderStatus == "Wait for confirmation")
                {
                    btnStatus.Text = "Wait for confirmation";
                    btnStatus.Enabled = false;
                }
                // nếu đơn hàng đã được xác nhận
                else if (orderTable_DTO.OrderStatus == "Confirmed")
                {
                    // bật button 2
                    turnButton(2);
                    btnStatus.Enabled = true;
                    // hiện chữ đã nhận được hàng
                    btnStatus.Text = "Goods received";
                    // click để xác nhận đã nhận hàng 
                    btnStatus.Click += (s, e) =>
                    {
                        // hàm xác nhận đã nhận hàng của khách hàng
                        confirmReceiptOfOrder(orderTable_DTO);
                        // bật button 3
                        turnButton(3);
                        btnStatus.Text = "Rate";
                    };
                }
                // nếu đơn hàng đã giao thành công
                else if (orderTable_DTO.OrderStatus == "Confirm receipt of order")
                {
                    // bật button 3
                    turnButton(3);
                    btnStatus.Text = "Rate";
                    btnStatus.Click += (s, e) =>
                    {
                        MessageBox.Show("Function is updating", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    };
                }

            }

            // 
            // picImageProduct
            // 
            Guna2PictureBox picImageProduct = new Guna2PictureBox();
            picImageProduct.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_order_blue;
            picImageProduct.ImageRotate = 0F;
            picImageProduct.Location = new System.Drawing.Point(69, 12);
            picImageProduct.Name = "picImageProduct";
            picImageProduct.Size = new System.Drawing.Size(75, 75);
            picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picImageProduct.TabIndex = 0;
            picImageProduct.TabStop = false;
            picImageProduct.Click += (s, e) =>
            {
                moveInFormOrderDetail(orderTable_DTO);
            };

            pnlProduct.Controls.Add(lblTotalPrice);
            pnlProduct.Controls.Add(btnStatus);
            pnlProduct.Controls.Add(picImageProduct);
            return pnlProduct;
        }
        // xác nhận đơn hàng của nhân viên á
        public void OrderConfirmation(OrderTable_DTO orderTable_DTO)
        {
            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();
            // lấy ra id của nhân viên xác nhận đơn hàng này
            orderTable_DTO.IdStaff = accountOnline.IdAccount;
            // gán "Confirmed" để truyền xuống update
            orderTable_DTO.OrderStatus = "Confirmed";

            // check result
            int result = 1;
            if(result == OrderTable_BLL.updateOrder(orderTable_DTO))
            {
                MessageBox.Show("Order confirmation success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Order confirmation fail", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        // hàm xác nhận đã nhận đơn hàng của khách hàng
        public void confirmReceiptOfOrder(OrderTable_DTO orderTable_DTO)
        {
            // gán chữ(xác nhận đã nhận đơn hàng) để truyền xuống update
            orderTable_DTO.OrderStatus = "Confirm receipt of order";

            // check result
            int result = 1;
            if (result == OrderTable_BLL.updateOrder(orderTable_DTO))
            {
                MessageBox.Show("Confirm receipt of order success", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Confirm receipt of order fail", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            flpContainerProduct.Controls.Clear();
            // bật button 3
            turnButton(3);
            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();
            if (quantityAccountOnline <= 0)
            {
                MessageBox.Show("Not logged in yet", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // display product
            foreach (OrderTable_DTO orderTable_DTO in orderTable_DTOs)
            {
                if (orderTable_DTO.OrderStatus == "Confirm receipt of order")
                {
                    flpContainerProduct.Controls.Add(GenerateProduct(orderTable_DTO, accountOnline.Role));
                }
            }
        }

        private void btnWaitingForDelivery_Click(object sender, EventArgs e)
        {
            flpContainerProduct.Controls.Clear();
            // bật button 2
            turnButton(2);
            // kiểm tra login và lấy ra tài khoản đang online
            Account_BLL account_BLL = new Account_BLL();
            (int quantityAccountOnline, Account_DTO accountOnline) = account_BLL.checkAndGetAccountOnline();
            if (quantityAccountOnline <= 0)
            {
                MessageBox.Show("Not logged in yet", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // display product
            foreach (OrderTable_DTO orderTable_DTO in orderTable_DTOs)
            {
                if (orderTable_DTO.OrderStatus == "Confirmed")
                {
                    flpContainerProduct.Controls.Add(GenerateProduct(orderTable_DTO, accountOnline.Role));
                }
            }
        }

        private void btnWaitForConfirmation_Click(object sender, EventArgs e)
        {
            // hiển thị giao diện mặc định của order
            loadInterfaceDefault();
        }
        private void turnButton(int number)
        {
            if(number == 1)
            {
                // bật nút 1
                btnWaitForConfirmation.ForeColor = System.Drawing.Color.White;
                btnWaitForConfirmation.FillColor = System.Drawing.Color.DodgerBlue;
                // tắt nút 2
                btnWaitingForDelivery.ForeColor = System.Drawing.Color.Black;
                btnWaitingForDelivery.FillColor = System.Drawing.Color.White;
                // tắt nút 3
                btnDelivered.ForeColor = System.Drawing.Color.Black;
                btnDelivered.FillColor = System.Drawing.Color.White;
            }
            else if(number == 2)
            {
                // tắt nút 1
                btnWaitForConfirmation.ForeColor = System.Drawing.Color.Black;
                btnWaitForConfirmation.FillColor = System.Drawing.Color.White;
                // bật nút 2
                btnWaitingForDelivery.ForeColor = System.Drawing.Color.White;
                btnWaitingForDelivery.FillColor = System.Drawing.Color.DodgerBlue;
                // tắt nút 3
                btnDelivered.ForeColor = System.Drawing.Color.Black;
                btnDelivered.FillColor = System.Drawing.Color.White;
            }
            else if(number == 3)
            {
                // tắt nút 1
                btnWaitForConfirmation.ForeColor = System.Drawing.Color.Black;
                btnWaitForConfirmation.FillColor = System.Drawing.Color.White;
                // tắt nút 2
                btnWaitingForDelivery.ForeColor = System.Drawing.Color.Black;
                btnWaitingForDelivery.FillColor = System.Drawing.Color.White;
                // bật nút 3
                btnDelivered.ForeColor = System.Drawing.Color.White;
                btnDelivered.FillColor = System.Drawing.Color.DodgerBlue;
            }
        }
    }
}
