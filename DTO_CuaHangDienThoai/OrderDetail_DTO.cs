using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class OrderDetail_DTO
    {
        public int IdOrderDetail { get; set; } = 0;
        public int IdOrder { get; set; } = 0;
        public int IdProduct { get; set; } = 0;
        public int QuantityProduct { get; set; } = 0;
        public decimal Price {  get; set; } = 0;
        public int DiscountAmount { get; set; } = 0;
        public int IdVoucher { get; set; } = 0;
    }
}
