using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CuaHangDienThoai
{
    // doanh thu theo ngày
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmout { get; set; }
    }
    public class Dashboard_BLL
    {
        // field & properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumberCustomers { get; private set; }
        // Số lượng nhà cung cấp
        public int NumberSuppliers { get; private set; }
        public int NumberProducts { get; private set; }
        // Danh sách sản phẩm hàng đầu
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        // danh sách thiếu hàng
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        // Tổng doanh thu
        public List<RevenueByDate> GrossRevenue { get; private set; }
        public int NumOrders { get; set; }
        // Tổng doanh thu
        public int TotalRevenue { get; set; }
        // Tổng lợi nhuận
        public decimal TotalProfit { get; set; }

        // Constructer
        public Dashboard_BLL()
        {

        }

        // private methods
        private void GetNumberItems()
        {

        }
    }
}
