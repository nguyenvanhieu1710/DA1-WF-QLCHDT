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
    public class Category_DAL
    {
        public List<Category_DTO> CategoryList()
        {
            try
            {
                List<Category_DTO> list = new List<Category_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader("selectCategory");
                while (sqlDataReader.Read())
                {
                    Category_DTO Category = new Category_DTO()
                    {
                        IdCategory = int.Parse(sqlDataReader["IdCategory"].ToString()),
                        CategoryName = sqlDataReader["CategoryName"].ToString(),
                        ProductDetail = sqlDataReader["ProductDetail"].ToString(),
                        IdCategoryDad = int.Parse(sqlDataReader["IdCategoryDad"].ToString())
                    };
                    list.Add(Category);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public DataTable categoryList()
        {
            try
            {
                DataTable dataTable = DatabaseAccess.GetDataTable("selectCategory");
                return dataTable;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int addCategory(Category_DTO Category_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"insertCategory N'{Category_DTO.CategoryName}', " +
                $"N'{Category_DTO.ProductDetail}'," +
                $"'{Category_DTO.IdCategoryDad}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int fixCategory(Category_DTO Category_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"updateCategory '{Category_DTO.IdCategory}', " +
                    $"N'{Category_DTO.CategoryName}', " +
                    $"N'{Category_DTO.ProductDetail}'," +
                    $"'{Category_DTO.IdCategoryDad}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deleteCategory(Category_DTO Category_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"deleteCategory '{Category_DTO.IdCategory}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
