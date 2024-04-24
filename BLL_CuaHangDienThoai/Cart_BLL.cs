using DAL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CuaHangDienThoai
{
    public class Cart_BLL
    {
        Cart_DAL Cart_DAL = new Cart_DAL();
        public List<Cart_DTO> CartList()
        {
            List<Cart_DTO> list = Cart_DAL.CartList();
            return list;
        }
        public List<int> getIdProductOfCustomer(Account_DTO account)
        {
            List<int> list = new List<int>();
            List<Cart_DTO> cartList = Cart_DAL.CartList();
            foreach(Cart_DTO cart in cartList)
            {
                if(cart.IdCustomer == account.IdAccount)
                {
                    list.Add(cart.IdProduct);
                }
            }
            return list;
        }
        public List<Product_DTO> getProductOfCustomer(Account_DTO account_DTO)
        {
            List<Product_DTO> list = new List<Product_DTO>();
            List<int> listIdProductOfCustomer = getIdProductOfCustomer(account_DTO);
            Product_BLL product_BLL = new Product_BLL();
            List<Product_DTO> productList = product_BLL.ProductList();
            foreach (Product_DTO product in productList)
            {
                foreach (int productId in listIdProductOfCustomer)
                {
                    if (productId == product.IdProduct)
                    {
                        list.Add(product);
                    }
                }
            }
            return list;
        }
        public bool CheckExit(Cart_DTO Cart_DTO)
        {
            List<Cart_DTO> list = CartList();
            foreach (Cart_DTO item in list)
            {
                if (Cart_DTO.IdProduct == item.IdProduct && Cart_DTO.IdCustomer == item.IdCustomer)
                {
                    return true;
                }
            }
            return false;
        }
        public int addCart(Product_DTO product_DTO, Account_DTO account_DTO)
        {
            int result = Cart_DAL.addCart(product_DTO, account_DTO);
            return result;
        }
        //public int fixCart(Cart_DTO Cart)
        //{
        //    int result = Cart_DAL.fixCart(Cart);
        //    return result;
        //}
        public int deleteCart(Product_DTO product_DTO, Account_DTO account_DTO)
        {
            int result = Cart_DAL.deleteCart(product_DTO, account_DTO);
            return result;
        }
    }
}
