using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class OrderDetail_DTO
    {
        private int idOrderDetail;
        public int idOrder { get; set; } = 0;
        public int idProduct { get; set; } = 0;
        public int QuantityProduct { get; set; } = 0;
        public decimal Price {  get; set; } = 0;
        public int DiscountAmount { get; set; } = 0;
        public int idVoucher { get; set; } = 0;
    }
}
