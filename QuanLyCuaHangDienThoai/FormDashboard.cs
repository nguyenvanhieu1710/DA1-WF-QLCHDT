using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormDashboard : Form
    {
        // Fields

        // Constructer
        public FormDashboard()
        {
            InitializeComponent();
            // Default - Last 7 days
            dateTimePicker_startedDate.Value = DateTime.Now.AddDays(-7);
            dateTimePicker_endedDate.Value = DateTime.Now;
            btnLast7Days.Select();
            InitializeDataset();
            LoadDataOnChart();
        }

        // Khai báo resultTable như biến toàn cục
        private List<KeyValuePair<DateTime, decimal>> ResultTable;

        public struct RevenueByDate
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }
        }

        //Fields & Properties
        //private DateTime startDate;
        //private DateTime endDate;
        //private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }


        Product_BLL product_BLL = new Product_BLL();
        List<Product_DTO> products;
        OrderTable_BLL orderTable_BLL = new OrderTable_BLL();
        List<OrderTable_DTO> orders;
        List<OrderDetail_DTO> orderDetails;
        Customer_BLL customer_BLL = new Customer_BLL();
        List <Customer_DTO> customers;
        private void InitializeDataset()
        {
            products = product_BLL.ProductList();
            orders = orderTable_BLL.OrderList();
            orderDetails = orderTable_BLL.OrderDetailList();
            customers = customer_BLL.customerList();
            //get all product belongs to this shop
            //products = Product.GetProducts().Where(pro => pro.ShopID == shop.ShopId).ToArray();
            //get all order detail related to these products
            //orderDetails = OrderDetail.GetOrderDetails().Join(products, orderdetail => orderdetail.ProductId, pro => pro.ProductId, (orderdetail, pro) => orderdetail).ToArray();
            //get  all order belongs to these order detail
            //orders = Order.GetOrders().Join(orderDetails, order => order.OrderId, orderdetail => orderdetail.OrderId, (order, orderdetail) => order).ToArray();
            //get all customer has made these order
            //customers = Customer.GetCustomers().Join(orders, customer => customer.CustomerId, order => order.CustomerID, (customer, order) => customer).ToArray();
            //get all comment has made by these customer and orderdetail;
        }

        #region   Statistic
        private void StatisticOrderByDay(string StartedDay, string EndedDay)
        {
            //process day as 
        }

        #endregion

        private DateTime TurnToDate(string stringformatDate)
        {
            string[] date = stringformatDate.Split('-');
            return new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]), 00, 00, 00);
        }


        private void LoadDataOnChart()
        {

            DateTime startDate = dateTimePicker_startedDate.Value;
            DateTime endDate = dateTimePicker_endedDate.Value;
            int numberDays = (endDate - startDate).Days;

            //
            label_customers.Text = customers.Count().ToString();
            label_products.Text = products.Count().ToString();
            label_orders.Text = orders.Where(order => startDate < order.DayBuy && order.DayBuy < endDate).Count().ToString();


            // filter top 5 product has a highest selling quantity
            //int totalQuanity = 0;
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            foreach (Product_DTO product in products)
            {
                TopProductsList.Add(new KeyValuePair<string, int>(product.ProductName, orderDetails.Where(orderdetail => orderdetail.IdProduct == product.IdProduct).Sum(orderdetail => orderdetail.QuantityProduct)));
            }
            ;
            //TopProductsList = new List<KeyValuePair<string, int>>(new KeyValuePair<string, int>());
            chart_bestSellingProduct.DataSource = TopProductsList.OrderBy(x => x.Value).Take(5).ToList();
            chart_bestSellingProduct.Series[0].XValueMember = "Key";
            chart_bestSellingProduct.Series[0].YValueMembers = "Value";
            //chart_bestSellingProduct.DataBind();


            //get lower Stock
            foreach (Product_DTO product1 in products.OrderBy(pro => pro.Quantity).Take(5))
            {
                UnderstockList.Add(
                                new KeyValuePair<string, int>(product1.ProductName, product1.Quantity));
            }
            dataGridView_underStock.DataSource = UnderstockList;
            dataGridView_underStock.Columns[0].HeaderText = "Item";
            dataGridView_underStock.Columns[1].HeaderText = "Units";




            //get grossrevenue
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            var resultTable = new List<KeyValuePair<DateTime, decimal>>();

            foreach (var Groupp in orders.GroupBy(order => order.DayBuy))
            {
                int totalAmount = 0; // total Amount in a day 
                //filter all ordertail belongs to these order at that day
                OrderDetail_DTO[] orderDetailsTemp = orderDetails.Join(Groupp, orderdetail => orderdetail.IdOrder, order => order.IdOrderTable, (orderdetail, order) => orderdetail).ToArray();
                //filter those products which was sold by this shop, because 1 order can have a lot orderdetail and form alot different shop;
                orderDetailsTemp = orderDetailsTemp.Where(orderdetail => products.Any(pro => pro.IdProduct == orderdetail.IdProduct)).ToArray();
                orderDetailsTemp.ToList().ForEach(orderdetail => totalAmount += ((int)(orderdetail.Price) - orderdetail.DiscountAmount));
                resultTable.Add(new KeyValuePair<DateTime, decimal>(Groupp.Key, totalAmount));
                TotalRevenue += totalAmount;
            }
            TotalProfit = TotalRevenue * 0.2m;//20%



            //legacy code
            if (numberDays <= 1)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("hh tt")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Days
            else if (numberDays <= 30)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("dd MMM")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Weeks
            else if (numberDays <= 92)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = "Week " + order.Key.ToString(),
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Months
            else if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365 ? true : false;
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("MMM yyyy")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Years
            else
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("yyyy")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }




            label_totalRevenue.Text = "$" + TotalRevenue.ToString();
            label_totalProfit.Text = "$" + TotalProfit.ToString();
            chart_grossRevenue.DataSource = GrossRevenueList;
            chart_grossRevenue.Series[0].XValueMember = "Date";
            chart_grossRevenue.Series[0].YValueMembers = "TotalAmount";
            chart_grossRevenue.DataBind();

            // gán ra toàn cục để lưu vào excel
            ResultTable = resultTable;
        }


        //private void SubViewShopDashBoard_Resize(object sender, EventArgs e)
        //{
        //    double averageWitdth = (this.Width - 60) / 3;
        //    panel_orders.Size = new Size((int)averageWitdth, panel_orders.Size.Height);

        //    panel_totalProfit.Size = new Size((int)averageWitdth, panel_totalProfit.Size.Height);
        //    panel_totalProfit.Location = new Point(panel_orders.Size.Width + panel_orders.Location.X + 10, panel_totalProfit.Location.Y);

        //    panel_totalRevenue.Size = new Size((int)averageWitdth, panel_totalRevenue.Size.Height);
        //    panel_totalRevenue.Location = new Point(panel_totalProfit.Size.Width + panel_totalProfit.Location.X + 10, panel_totalRevenue.Location.Y);




        //}

        private void DateTimePicker_endedDate_ValueChanged(object sender, EventArgs e)
        {

            label_endedDate.Text = dateTimePicker_endedDate.Text;
        }

        private void DateTimePicker_startedDate_ValueChanged(object sender, EventArgs e)
        {
            label_startedDate.Text = dateTimePicker_startedDate.Text;

        }

        private void Label_startedDate_Click(object sender, EventArgs e)
        {
            dateTimePicker_startedDate.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void Label_endedDate_Click(object sender, EventArgs e)
        {
            dateTimePicker_endedDate.Select();
            SendKeys.Send("%{DOWN}");
        }


        private void RjButton9_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, null);

        }
        private void ActivatedButton(object sender, EventArgs e)
        {

            //RJButton currentBUtton = (RJButton)sender;
            //foreach (RJButton rJButton in panel_OptionHolder.Controls)
            //{
            //    rJButton.BackColor = Color.White;
            //    rJButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            //}
            //currentBUtton.BackColor = Color.MediumSlateBlue;
            //currentBUtton.ForeColor = Color.White;
        }

        private void SubViewShopDashBoard_Load(object sender, EventArgs e)
        {
            //dataGridView_underStock.Columns[1].Width = 50;
        }

        private void DateTimePicker_startedDate_ValueChanged_1(object sender, EventArgs e)
        {
            label_startedDate.Text = dateTimePicker_startedDate.Text;

        }

        private void DateTimePicker_endedDate_ValueChanged_1(object sender, EventArgs e)
        {
            label_endedDate.Text = dateTimePicker_endedDate.Text;
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dateTimePicker_startedDate.Value = DateTime.Today.AddDays(-30);
            dateTimePicker_endedDate.Value = DateTime.Now;
            LoadDataOnChart();
            ActivatedButton(sender, null);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dateTimePicker_startedDate.Value = DateTime.Today.AddDays(-7);
            dateTimePicker_endedDate.Value = DateTime.Now;
            LoadDataOnChart();
            ActivatedButton(sender, null);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dateTimePicker_startedDate.Value = DateTime.Today;
            dateTimePicker_endedDate.Value = DateTime.Now;
            LoadDataOnChart();
            ActivatedButton(sender, null);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            //check datetime picker
            if (dateTimePicker_startedDate.Value > dateTimePicker_endedDate.Value)
            {
                MessageBox.Show("Started  day cannot higher than ended daay !");
                return;
            }
            if (label_endedDate.Text == "Ended day")
            {
                MessageBox.Show("Please choose ended day!   ");
                return;
            }
            if (label_startedDate.Text == "Started day")
            {
                MessageBox.Show("Please choose started day!");
                return;
            }

            LoadDataOnChart();
            ActivatedButton(sender, null);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            // Lấy đường dẫn lưu tệp Excel
            string filePath = GetExcelSavePath();

            if (String.IsNullOrEmpty(filePath))
            {
                // Xử lý trường hợp người dùng hủy chọn đường dẫn tệp
                return;
            }

            // Khai báo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelworkBook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            //Microsoft.Office.Interop.Excel.Range excelCellrange;

            // Viết tiêu đề cho Sản phẩm Nổi bật, Doanh thu Hàng ngày và các thông tin bổ sung
            excelSheet.Cells[1, 1] = "Top 5 Sản phẩm";
            excelSheet.Cells[8, 1] = "Doanh thu Hàng ngày";
            excelSheet.Cells[1, 4] = "Số lượng đơn hàng";
            excelSheet.Cells[3, 4] = "Tổng doanh thu";
            excelSheet.Cells[5, 4] = "Tổng lợi nhuận";
            excelSheet.Cells[7, 4] = "Số lượng khách hàng";
            excelSheet.Cells[9, 4] = "Số lượng sản phẩm";

            // Định dạng cột Sản phẩm Nổi bật
            excelSheet.Columns[1].AutoFit(); // Tự động điều chỉnh độ rộng cột 1 (Tên sản phẩm)
            //excelSheet.Columns[2].ColumnWidth = 20; // Cài đặt độ rộng cố định 20 cho cột 2 (Số lượng)

            // Định dạng cột Doanh thu Hàng ngày
            excelSheet.Columns[1].AutoFit(); // Tự động điều chỉnh độ rộng cột 1 (Ngày)
            //excelSheet.Columns[2].ColumnWidth = 20; // Cài đặt độ rộng cố định 20 cho cột 2 (Tổng doanh thu)

            // Điều chỉnh độ rộng cột 3 (chứa tiêu đề và dữ liệu)
            excelSheet.Columns[3].AutoFit();
            // Điều chỉnh độ rộng cột 4 (chứa tiêu đề và dữ liệu)
            excelSheet.Columns[4].AutoFit();

            // Viết dữ liệu Sản phẩm Nổi bật
            int row = 2;
            foreach (var item in TopProductsList.OrderByDescending(p => p.Value).Take(5))
            {
                excelSheet.Cells[row, 1] = item.Key;
                excelSheet.Cells[row, 2] = item.Value;
                row++;
            }

            // Viết dữ liệu Doanh thu Hàng ngày
            row = 9;
            foreach (var item in ResultTable)
            {
                excelSheet.Cells[row, 1] = item.Key.ToString("dd/MM/yyyy");
                excelSheet.Cells[row, 2] = item.Value;
                row++;
            }

            // Viết dữ liệu Số lượng đơn hàng
            excelSheet.Cells[2, 4] = NumOrders;

            // Viết dữ liệu Tổng doanh thu (đã lấy trước đó)
            excelSheet.Cells[4, 4] = TotalRevenue;

            // Viết dữ liệu Tổng lợi nhuận (đã lấy trước đó)
            excelSheet.Cells[6, 4] = TotalProfit;

            // Viết dữ liệu Số lượng khách hàng
            excelSheet.Cells[8, 4] = NumCustomers;

            // Viết dữ liệu Số lượng sản phẩm
            excelSheet.Cells[10, 4] = products.Count();

            // Lưu và đóng tệp Excel
            excelworkBook.SaveAs(filePath);
            excelworkBook.Close();
            excel.Quit();
        }
        private string GetExcelSavePath()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save Statistics to Excel";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
            }
            return null;
        }
    }
}
