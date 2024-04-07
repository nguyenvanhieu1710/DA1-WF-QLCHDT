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


        public List<Product_DTO> searchProduct(Product_DTO Product)
        {
            List<Product_DTO> Products = ProductList();
            List<Product_DTO> list = new List<Product_DTO>();
            foreach (Product_DTO item in Products)
            {
                if (item.ProductName == Product.ProductName)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<Product_DTO> searchProductByIdCategory(int id)
        {
            List<Product_DTO> Products = ProductList();
            List<Product_DTO> list = new List<Product_DTO>();
            foreach (Product_DTO item in Products)
            {
                if (item.IdCategory == id)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
