using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class Customer_DTO
    {
        public int IdCustomer { get; set; } = 0;
        public string CustomerName { get; set; } = string.Empty;
        public DateTime Birthday { get; set; } = DateTime.Now;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ImageCustomer { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
    }
}
