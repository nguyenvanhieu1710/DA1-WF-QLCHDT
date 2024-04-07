using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_CuaHangDienThoai;

namespace DAL_CuaHangDienThoai
{
    public class Customer_DAL
    {
        public List<Customer_DTO> CustomerList()
        {
            try
            {
                List<Customer_DTO> list = new List<Customer_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader("selectCustomer");
                while (sqlDataReader.Read())
                {
                    Customer_DTO customer = new Customer_DTO()
                    {
                        IdCustomer = int.Parse(sqlDataReader["IdCustomer"].ToString()),
                        CustomerName = sqlDataReader["CustomerName"].ToString(),
                        Birthday = DateTime.Parse(sqlDataReader["Birthday"].ToString()),
                        PhoneNumber = sqlDataReader["PhoneNumber"].ToString(),
                        ImageCustomer = sqlDataReader["ImageCustomer"].ToString(),
                        Gender = sqlDataReader["Gender"].ToString()
                    };
                    list.Add(customer);
                }
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public int addCustomer(Customer_DTO customer_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"insertCustomer N'{customer_DTO.CustomerName}', " +
                $"'{customer_DTO.Birthday}', N'{customer_DTO.PhoneNumber}'," +
                $"N'{customer_DTO.ImageCustomer}'," +
                $"N'{customer_DTO.Gender}' ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int fixCustomer(Customer_DTO customer_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"updateCustomer '{customer_DTO.IdCustomer}', " +
                    $"N'{customer_DTO.CustomerName}', " +
                    $"'{customer_DTO.Birthday}', N'{customer_DTO.PhoneNumber}'," +
                    $"N'{customer_DTO.ImageCustomer}'," +
                    $"N'{customer_DTO.Gender}' ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deleteCustomer(Customer_DTO customer_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"deleteAccountCustomer '{customer_DTO.IdCustomer}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
