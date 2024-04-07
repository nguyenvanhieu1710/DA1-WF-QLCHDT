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
                List<Staff_DTO> list = new List<Staff_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader("selectStaff");
                while (sqlDataReader.Read())
                {
                    Staff_DTO staff_DTO = new Staff_DTO()
                    {
                        IdStaff = int.Parse(sqlDataReader["IdStaff"].ToString()),
                        StaffName = sqlDataReader["StaffName"].ToString(),
                        Birthday = DateTime.Parse(sqlDataReader["Birthday"].ToString()),
                        PhoneNumber = sqlDataReader["PhoneNumber"].ToString(),
                        ImageStaff = sqlDataReader["ImageStaff"].ToString(),
                        Gender = sqlDataReader["Gender"].ToString(),
                        Address = sqlDataReader["Address"].ToString(),
                    };
                    list.Add(staff_DTO);
                }
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public int addStaff(Staff_DTO Staff_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"insertStaff N'{Staff_DTO.StaffName}', " +
                $"'{Staff_DTO.Birthday}', N'{Staff_DTO.PhoneNumber}'," +
                $"N'{Staff_DTO.ImageStaff}'," +
                $"N'{Staff_DTO.Gender}', N'{Staff_DTO.Address}' ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int fixStaff(Staff_DTO Staff_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"updateStaff '{Staff_DTO.IdStaff}', " +
                    $"N'{Staff_DTO.StaffName}', " +
                    $"'{Staff_DTO.Birthday}', N'{Staff_DTO.PhoneNumber}'," +
                    $"N'{Staff_DTO.ImageStaff}'," +
                    $"N'{Staff_DTO.Gender}', N'{Staff_DTO.Address}'  ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deleteStaff(Staff_DTO Staff_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"deleteAccountStaff '{Staff_DTO.IdStaff}'");
                return result; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
