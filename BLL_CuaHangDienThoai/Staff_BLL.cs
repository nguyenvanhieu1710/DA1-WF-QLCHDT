using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_CuaHangDienThoai;
using DAL_CuaHangDienThoai;

namespace BLL_CuaHangDienThoai
{
    public class Staff_BLL
    {
        Staff_DAL staff = new Staff_DAL();
        public List<Staff_DTO> staffList()
        {
            List<Staff_DTO> list = staff.staffList();
            return list;
        }
    }
}
