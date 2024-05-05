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
using Guna.UI2.WinForms;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            flpContainer.Controls.Clear();
            turnOffScrollBars(flpContainer);

            Customer_BLL customer_BLL = new Customer_BLL();
            List<Customer_DTO> customerList = customer_BLL.customerList();
            foreach(Customer_DTO customer in customerList)
            {
                flpContainer.Controls.Add(GenerateCustomer(customer));
            }
        }
        private Panel GenerateCustomer(Customer_DTO customer_DTO)
        {
            // 
            // pnlCustomer
            // 
            Panel pnlCustomer = new Panel();
            pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlCustomer.Location = new System.Drawing.Point(3, 3);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new System.Drawing.Size(883, 103);
            pnlCustomer.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            Label lblCustomerName = new Label();
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new System.Drawing.Point(150, 32);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new System.Drawing.Size(153, 24);
            lblCustomerName.TabIndex = 4;
            lblCustomerName.Text = customer_DTO.CustomerName;
            // 
            // btnChoose
            // 
            Guna2Button btnChoose = new Guna2Button();
            btnChoose.AutoRoundedCorners = true;
            btnChoose.BorderColor = System.Drawing.Color.DodgerBlue;
            btnChoose.BorderRadius = 21;
            btnChoose.BorderThickness = 1;
            btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnChoose.FillColor = System.Drawing.Color.White;
            btnChoose.Font = new System.Drawing.Font("Tahoma", 12F);
            btnChoose.ForeColor = System.Drawing.Color.Black;
            btnChoose.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            btnChoose.HoverState.ForeColor = System.Drawing.Color.White;
            btnChoose.Location = new System.Drawing.Point(649, 32);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new System.Drawing.Size(180, 45);
            btnChoose.TabIndex = 8;
            btnChoose.Text = "Choose";
            btnChoose.Click += (s, e) =>
            {
                // lấy ra danh sách các đơn hàng của khách hàng đó
                getOrderOfCustomer(customer_DTO);
            };
            // 
            // picImageCustomer
            // 
            Guna2PictureBox picImageCustomer = new Guna2PictureBox();
            picImageCustomer.ImageLocation = customer_DTO.ImageCustomer;
            picImageCustomer.ImageRotate = 0F;
            picImageCustomer.Location = new System.Drawing.Point(69, 12);
            picImageCustomer.Name = "picImageCustomer";
            picImageCustomer.Size = new System.Drawing.Size(75, 75);
            picImageCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picImageCustomer.TabIndex = 0;
            picImageCustomer.TabStop = false;

            pnlCustomer.Controls.Add(lblCustomerName);
            pnlCustomer.Controls.Add(btnChoose);
            pnlCustomer.Controls.Add(picImageCustomer);
            return pnlCustomer;
        }
        private Panel GenerateOrder(OrderTable_DTO orderTable_DTO) 
        {
            // 
            // pnlOrder
            // 
            Panel pnlOrder = new Panel();
            pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlOrder.Location = new System.Drawing.Point(3, 3);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new System.Drawing.Size(883, 103);
            pnlOrder.TabIndex = 4;
            // 
            // lblTotalPrice
            // 
            Label lblTotalPrice = new Label();
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new System.Drawing.Point(150, 32);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new System.Drawing.Size(153, 24);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = orderTable_DTO.TotalPrice.ToString("N0") + "đ";
            // 
            // btnExportBill
            // 
            Guna2Button btnExportBill = new Guna2Button();
            btnExportBill.AutoRoundedCorners = true;
            btnExportBill.BorderColor = System.Drawing.Color.DodgerBlue;
            btnExportBill.BorderRadius = 21;
            btnExportBill.BorderThickness = 1;
            btnExportBill.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnExportBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnExportBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnExportBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnExportBill.FillColor = System.Drawing.Color.White;
            btnExportBill.Font = new System.Drawing.Font("Tahoma", 12F);
            btnExportBill.ForeColor = System.Drawing.Color.Black;
            btnExportBill.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            btnExportBill.HoverState.ForeColor = System.Drawing.Color.White;
            btnExportBill.Location = new System.Drawing.Point(649, 32);
            btnExportBill.Name = "btnExportBill";
            btnExportBill.Size = new System.Drawing.Size(180, 45);
            btnExportBill.TabIndex = 8;
            btnExportBill.Text = "Export Bill";
            btnExportBill.Click += (s, e) =>
            { 
                // xuất ra mỗi 1 đơn hàng mà mình cần thôi
                FormReportView formReportView = new FormReportView();
                // lấy ra đơn hàng đã rồi mới cho lên hóa đơn
                formReportView.getOrder(orderTable_DTO);
                formReportView.ShowDialog();
            };
            // 
            // picImageOrder
            // 
            Guna2PictureBox picImageOrder = new Guna2PictureBox();
            picImageOrder.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_order_blue;
            picImageOrder.ImageRotate = 0F;
            picImageOrder.Location = new System.Drawing.Point(69, 12);
            picImageOrder.Name = "picImageOrder";
            picImageOrder.Size = new System.Drawing.Size(75, 75);
            picImageOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picImageOrder.TabIndex = 0;
            picImageOrder.TabStop = false;

            pnlOrder.Controls.Add(lblTotalPrice);
            pnlOrder.Controls.Add(btnExportBill);
            pnlOrder.Controls.Add(picImageOrder);
            return pnlOrder;
        }
        private void turnOffScrollBars(FlowLayoutPanel flowLayoutPanel)
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
        private void getOrderOfCustomer(Customer_DTO customer_DTO)
        {
            flpContainer.Controls.Clear();

            OrderTable_BLL orderTable_BLL = new OrderTable_BLL();
            List<OrderTable_DTO> orderList = orderTable_BLL.OrderList();
            foreach (OrderTable_DTO orderTable in  orderList)
            {
                if(orderTable.IdCustomer == customer_DTO.IdCustomer)
                {
                    flpContainer.Controls.Add(GenerateOrder(orderTable));
                }
            }
        }
    }
}
