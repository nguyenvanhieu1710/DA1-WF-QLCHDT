using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class Staff_DTO
    {
        public int idStaff { get; set; } = 0;
        public string StaffName { get; set; } = string.Empty;
        public DateTime Birthday { get; set; } = DateTime.Parse(string.Empty);
        public string PhoneNumber { get; set; } = string.Empty;
        public string ImageStaff { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
