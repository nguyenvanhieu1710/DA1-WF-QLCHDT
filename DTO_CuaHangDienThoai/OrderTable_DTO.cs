using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class OrderTable_DTO
    {
        private int idOrderTable;
        public int idCustomer { get; set; } = 0;
        public int idStaff { get; set; } = 0;
        public string Orderstatus { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; } = 0;
        public DateTime DayBuy { get; set; } = DateTime.Now;
        public string DeliveryAddress { get; set; } = string.Empty;
    }
}
