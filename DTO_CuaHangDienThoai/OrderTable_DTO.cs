using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class OrderTable_DTO
    {
        public int IdOrderTable { get; set; } = 0;
        public int IdCustomer { get; set; } = 0;
        public int IdStaff { get; set; } = 0;
        public string OrderStatus { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; } = 0;
        public DateTime DayBuy { get; set; } = DateTime.Now;
        public string DeliveryAddress { get; set; } = string.Empty;
    }
}
