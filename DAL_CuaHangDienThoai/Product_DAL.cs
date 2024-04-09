using System;
using System.Collections.Generic;
using System.Data;
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
                List<Product_DTO> list = new List<Product_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader("selectProduct");
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
                        ImageProduct = sqlDataReader["Imageproduct"].ToString(),
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
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public DataTable productList()
        {
            try
            {
                DataTable dataTable = DatabaseAccess.GetDataTable("selectproduct");
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int addProduct(Product_DTO Product_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"insertProduct N'{Product_DTO.ProductName}', " +
                $"'{Product_DTO.Quantity}', '{Product_DTO.Price}'," +
                $"N'{Product_DTO.TradeMark}', '{Product_DTO.LaunchTime}', " +
                $"N'{Product_DTO.ImageProduct}', '{Product_DTO.DayCreated}', " +
                $"'{Product_DTO.IdCategory}', N'{Product_DTO.ProductDetail}' ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int fixProduct(Product_DTO Product_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"updateProduct '{Product_DTO.IdProduct}', " +
                    $"N'{Product_DTO.ProductName}', " +
                $"'{Product_DTO.Quantity}', '{Product_DTO.Price}'," +
                $"N'{Product_DTO.TradeMark}', '{Product_DTO.LaunchTime}'," +
                $"N'{Product_DTO.ImageProduct}', '{Product_DTO.DayCreated}'," +
                $"'{Product_DTO.IdCategory}', N'{Product_DTO.ProductDetail}' ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deleteProduct(Product_DTO Product_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"deleteProduct '{Product_DTO.IdProduct}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
