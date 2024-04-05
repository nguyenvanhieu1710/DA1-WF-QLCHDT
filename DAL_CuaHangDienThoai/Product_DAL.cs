using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_CuaHangDienThoai;

namespace DAL_CuaHangDienThoai
{
    public class Product_DAL
    {
        public List<Product_DTO> ProductList()
        {
            try
            {
                DatabaseAccess.OpenConnect();
                List<Product_DTO> list = new List<Product_DTO>();
                DatabaseAccess.ExecuteCommand("selectProduct");
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Product_DTO product = new Product_DTO()
                    {
                        IdProduct = int.Parse(sqlDataReader["IdProduct"].ToString()),
                        ProductName = sqlDataReader["ProductName"].ToString(),
                        Quantity = int.Parse(sqlDataReader["Quantity"].ToString()),
                        Price = int.Parse(sqlDataReader["Price"].ToString()),
                        TradeMark = sqlDataReader["TradeMark"].ToString(),
                        LaunchTime = DateTime.Parse(sqlDataReader["LaunchTime"].ToString()),
                        Imageproduct = sqlDataReader["Imageproduct"].ToString(),
                        DayCreated = DateTime.Parse(sqlDataReader["DayCreated"].ToString()),
                        IdCategory = int.Parse(sqlDataReader["IdCategory"].ToString()),
                        ProductDetail = sqlDataReader["ProductDetail"].ToString()
                    };
                    list.Add(product);
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
