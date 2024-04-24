using DTO_CuaHangDienThoai;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_CuaHangDienThoai
{
    public class Cart_DAL
    {
        public List<Cart_DTO> CartList()
        {
            try
            {
                List<Cart_DTO> list = new List<Cart_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader("selectCart");
                while (sqlDataReader.Read())
                {
                    Cart_DTO Cart = new Cart_DTO()
                    {
                        IdProduct = int.Parse(sqlDataReader["IdProduct"].ToString()),
                        IdCustomer = int.Parse(sqlDataReader["IdCustomer"].ToString())
                    };
                    list.Add(Cart);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public int addCart(Product_DTO product_DTO, Account_DTO account_DTO)
        {
            try
            {
                // vì id account và id customer là như nhau lên thêm cái nào cũng thế
                int result = DatabaseAccess.ExcuteNonQuery($"insertCart '{product_DTO.IdProduct}', " +
                $"'{account_DTO.IdAccount}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int deleteCart(Product_DTO product_DTO, Account_DTO account_DTO)
        {
            try
            {
                // vì id account và id customer là như nhau lên thêm cái nào cũng thế
                int result = DatabaseAccess.ExcuteNonQuery($"deleteCart '{product_DTO.IdProduct}', " +
                    $"'{account_DTO.IdAccount}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
