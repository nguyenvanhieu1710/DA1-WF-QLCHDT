using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_CuaHangDienThoai;

namespace DAL_CuaHangDienThoai
{
    public class Account_DAL
    {
        public List<Account_DTO> AccoutList()
        {
            try
            {
                List<Account_DTO> list = new List<Account_DTO>();
                SqlDataReader reader = DatabaseAccess.ExecuteReader("selectAccount");
                while (reader.Read())
                {
                    Account_DTO account = new Account_DTO()
                    {
                        AccoutName = reader["AccountName"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        DayCreaeted = DateTime.Parse(reader["DayCreated"].ToString()),
                        RememberPassword = reader["RememberPassword"].ToString(),
                        Email = reader["Email"].ToString(),
                        Status = reader["Status"].ToString(),
                    };
                    list.Add(account);
                }
                return list;
            }
            catch(Exception ex) 
            {
                throw ex;            
            }
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public void insertAccountCustomer_DAL(string Account, string Password, string Email)
        {
            try
            {
                DatabaseAccess.ExecuteCommand($"insertAccountCustomer {Account}, {Password}, {Email} ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
