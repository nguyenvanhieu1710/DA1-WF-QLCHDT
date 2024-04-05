using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;

namespace BLL_CuaHangDienThoai
{
    public class Product_BLL
    {
        Product_DAL Product_DAL = new Product_DAL();
        public List<Product_DTO> ProductList()
        {
            List<Product_DTO> productList = Product_DAL.ProductList();
            return productList;
        }
    }
}
