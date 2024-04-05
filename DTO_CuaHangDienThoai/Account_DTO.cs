using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class Account_DTO
    {
        // private int IdAccount;
        public string AccoutName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role {  get; set; } = string.Empty ;
        public DateTime DayCreaeted {  get; set; } = DateTime.Now;
        public string RememberPassword { get; set; } = string.Empty;
        public string Email {  get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
