using DAL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CuaHangDienThoai
{
    public class Category_BLL
    {
        Category_DAL Category_DAL = new Category_DAL();
        public List<Category_DTO> CategoryList()
        {
            List<Category_DTO> list = Category_DAL.CategoryList();
            return list;
        }
        public DataTable categoryList()
        {
            DataTable dataTable = Category_DAL.categoryList();
            return dataTable;
        }
        public bool CheckExit(Category_DTO Category_DTO)
        {
            List<Category_DTO> list = CategoryList();
            foreach (Category_DTO item in list)
            {
                if (Category_DTO.IdCategory == item.IdCategory)
                {
                    return true;
                }
            }
            return false;
        }
        public int addCategory(Category_DTO Category)
        {
            int result = Category_DAL.addCategory(Category);
            return result;
        }
        public int fixCategory(Category_DTO Category)
        {
            int result = Category_DAL.fixCategory(Category);
            return result;
        }
        public int deleteCategory(Category_DTO Category)
        {
            int result = Category_DAL.deleteCategory(Category);
            return result;
        }
        public List<Category_DTO> searchCategory(Category_DTO Category)
        {
            List<Category_DTO> Categorys = CategoryList();
            List<Category_DTO> list = new List<Category_DTO>();
            foreach (Category_DTO item in Categorys)
            {
                if (item.CategoryName == Category.CategoryName)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
