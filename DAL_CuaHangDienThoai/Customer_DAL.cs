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
                DatabaseAccess.OpenConnect();
                List<Customer_DTO> list = new List<Customer_DTO>();
                DatabaseAccess.ExecuteCommand("selectCustomer");
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader();
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
            finally { DatabaseAccess.CloseConnect(); }
        }
        public void AddCustomer(Customer_DTO customer_DTO)
        {
            try
            {
                DatabaseAccess.OpenConnect();
                DatabaseAccess.ExecuteCommand($"insertCustomer '{customer_DTO.CustomerName}', " +
                $"'{customer_DTO.Birthday}', '{customer_DTO.PhoneNumber}'," +
                $"'{customer_DTO.ImageCustomer}'," +
                $"'{customer_DTO.Gender}' ");
            }
            catch (Exception ex)
            {
                throw ex ;
            }
            finally { DatabaseAccess.CloseConnect(); }
        }
        public int addCustomer(Customer_DTO customer_DTO)
        {
            try
            {
                DatabaseAccess.OpenConnect();
                int result = DatabaseAccess.ExcuteNonQuery($"insertCustomer '{customer_DTO.CustomerName}', " +
                $"'{customer_DTO.Birthday}', '{customer_DTO.PhoneNumber}'," +
                $"'{customer_DTO.ImageCustomer}'," +
                $"'{customer_DTO.Gender}' ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnect(); }
        }
    }
}
