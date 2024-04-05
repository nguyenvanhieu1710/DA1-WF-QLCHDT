using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_CuaHangDienThoai;

namespace DAL_CuaHangDienThoai
{
    public class Staff_DAL
    {
        public List<Staff_DTO> staffList()
        {
            try
            {
                DatabaseAccess.OpenConnect();
                DatabaseAccess.ExecuteCommand("selectStaff");
                List<Staff_DTO> list = new List<Staff_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Staff_DTO staff_DTO = new Staff_DTO()
                    {
                        idStaff = int.Parse(sqlDataReader["idStaff"].ToString()),
                        StaffName = sqlDataReader["StaffName"].ToString(),
                        Birthday = DateTime.Parse(sqlDataReader["Birthday"].ToString()),
                        PhoneNumber = sqlDataReader["PhoneNumber"].ToString(),
                        ImageStaff = sqlDataReader["ImageStaff"].ToString(),
                        Gender = sqlDataReader["Gender"].ToString(),
                        Address = sqlDataReader["Address"].ToString(),
                    };
                }
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnect(); }
        }
    }
}
