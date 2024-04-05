using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class Product_DTO
    {
        public int IdProduct { get; set; } = 0;
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public decimal Price { get; set; } = 0;
        public string TradeMark { get; set; } = string.Empty;
        public DateTime LaunchTime { get; set; } = DateTime.Now;
        public string Imageproduct { get; set; } = string.Empty;
        public DateTime DayCreated { get; set; } = DateTime.Now;
        public int IdCategory {  get; set; } = 0; 
        public string ProductDetail { get; set; } = string.Empty;
    }
}
