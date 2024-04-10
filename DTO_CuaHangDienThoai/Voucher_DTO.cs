using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class Voucher_DTO
    {
        public int IdVoucher {get;set;} = 0;
        public string VoucherName { get; set; } = string.Empty;
        public int FixedPrice { get; set; } = 0;
        public int Minimumprice { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public DateTime StartDay { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);
        public int IdCategory { get; set; } = 0;
    }
}
