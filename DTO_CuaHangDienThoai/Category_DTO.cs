using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CuaHangDienThoai
{
    public class Category_DTO
    {
        public int IdCategory { get; set; } = 0;
        public string CategoryName { get; set; } = string.Empty;
        public string ProductDetail { get; set; } = string.Empty;
        public int IdCategoryDad { get; set; } = 0;
    }
}
