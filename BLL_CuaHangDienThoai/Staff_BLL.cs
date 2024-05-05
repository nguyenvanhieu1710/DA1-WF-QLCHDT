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
        Staff_DAL Staff_DAL = new Staff_DAL();
        public List<Staff_DTO> staffList()
        {
            List<Staff_DTO> list = Staff_DAL.staffList();
            return list;
        }
        public bool CheckExit(Staff_DTO Staff_DTO)
        {
            List<Staff_DTO> list = staffList();
            foreach (Staff_DTO item in list)
            {
                if (Staff_DTO.IdStaff == item.IdStaff)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckImage(Staff_DTO Staff_DTO)
        {
            List<Staff_DTO> list = staffList();
            foreach (Staff_DTO item in list)
            {
                if (Staff_DTO.ImageStaff == item.ImageStaff)
                {
                    return true;
                }
            }
            return false;
        }
        public int addStaff(Staff_DTO Staff)
        {
            int result = Staff_DAL.addStaff(Staff);
            return result;
        }
        public int fixStaff(Staff_DTO Staff)
        {
            int result = Staff_DAL.fixStaff(Staff);
            return result;
        }
        public int deleteStaff(Staff_DTO Staff)
        {
            int result = Staff_DAL.deleteStaff(Staff);
            return result;
        }
        public List<Staff_DTO> searchStaff(Staff_DTO Staff)
        {
            List<Staff_DTO> Staffs = staffList();
            List<Staff_DTO> list = new List<Staff_DTO>();
            foreach (Staff_DTO item in Staffs)
            {
                if (item.StaffName == Staff.StaffName)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public List<Staff_DTO> filterStaff(string filter)
        {
            List<Staff_DTO> Staffs = staffList();
            List<Staff_DTO> list = new List<Staff_DTO>();
            foreach (Staff_DTO item in Staffs)
            {
                if (item.Gender == filter)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public List<int> getIdStaff()
        {
            List<Staff_DTO> StaffList = staffList();
            List<int> list = new List<int>();
            foreach (Staff_DTO item in StaffList)
            {
                list.Add(item.IdStaff);
            }
            return list;
        }
    }
}
