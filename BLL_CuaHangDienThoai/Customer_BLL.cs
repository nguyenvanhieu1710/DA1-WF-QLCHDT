using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_CuaHangDienThoai;
using DAL_CuaHangDienThoai;

namespace BLL_CuaHangDienThoai
{
    public class Customer_BLL
    {
        Customer_DAL Customer_DAL = new Customer_DAL();
        public List<Customer_DTO> customerList()
        {
            List<Customer_DTO> list = Customer_DAL.CustomerList();
            return list;
        }
        public bool CheckExit(Customer_DTO customer_DTO)
        {
            List<Customer_DTO > list = customerList();
            foreach (Customer_DTO item in list)
            {
                if(customer_DTO.IdCustomer == item.IdCustomer)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddCustomer(Customer_DTO customer)
        {
            Customer_DAL.AddCustomer(customer);
        }
        public int addCustomer(Customer_DTO customer)
        {
            int result = Customer_DAL.addCustomer(customer);
            return result;
        }
    }
}
