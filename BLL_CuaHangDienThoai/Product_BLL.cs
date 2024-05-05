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
        public DataTable productList()
        {
            DataTable dataTable = Product_DAL.productList();
            return dataTable;
        }
        public bool CheckExit(Product_DTO Product_DTO)
        {
            List<Product_DTO> list = ProductList();
            foreach (Product_DTO item in list)
            {
                if (Product_DTO.IdProduct == item.IdProduct)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckImage(Product_DTO Product_DTO)
        {
            List<Product_DTO> list = ProductList();
            foreach (Product_DTO item in list)
            {
                if (Product_DTO.ImageProduct == item.ImageProduct)
                {
                    return true;
                }
            }
            return false;
        }
        public int addProduct(Product_DTO Product)
        {
            int result = Product_DAL.addProduct(Product);
            return result;
        }
        public int fixProduct(Product_DTO Product)
        {
            int result = Product_DAL.fixProduct(Product);
            return result;
        }
        // cập nhập lại số lượng sau khi mua sản phẩm
        public int updateProductAfterBuy(Product_DTO Product)
        {
            int result = 0;
            List<Product_DTO> productList = ProductList();
            foreach (Product_DTO item in productList)
            {
                // tìm ra sản phẩm cần update sau khi mua
                if(Product.IdProduct == item.IdProduct)
                {
                    // lấy số lượng sản phẩm đã được trừ đi 
                    Product.Quantity = item.Quantity - Product.Quantity;
                    // rồi lưu lại trong database
                    result = Product_DAL.fixProduct(Product);
                }
            }
            return result;
        }
        public int deleteProduct(Product_DTO Product)
        {
            int result = Product_DAL.deleteProduct(Product);
            return result;
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
                // tương đối
                if (item.ProductName.Contains(Product.ProductName))
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
        public List<Product_DTO> filterProduct(string filter)
        {
            // Chia chuỗi filter thành hai phần dựa trên dấu '-'
            string[] priceRange = filter.Split('-');
            int lowerPrice = 0;// giá thấp
            int upperPrice = 0;// giá cao
            if (priceRange.Length == 2)
            {
                // Phải là 2 khoảng
                lowerPrice = int.Parse(priceRange[0].Replace(".", "").Replace("đ", ""));
                upperPrice = int.Parse(priceRange[1].Replace(".", "").Replace("đ", ""));
            }
            
            List<Product_DTO> Products = ProductList();
            List<Product_DTO> list = new List<Product_DTO>();

            foreach (Product_DTO item in Products)
            {
                if (item.TradeMark == filter)
                {
                    list.Add(item);
                }
                // tương đối
                if (item.TradeMark.Contains(filter))
                {
                    list.Add(item);
                }
                // Kiểm tra xem giá của sản phẩm có nằm trong khoảng giá không
                if (item.Price >= lowerPrice && item.Price <= upperPrice)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
