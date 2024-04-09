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
        public bool CheckImage(Customer_DTO customer_DTO)
        {
            List<Customer_DTO> list = customerList();
            foreach (Customer_DTO item in list)
            {
                if (customer_DTO.ImageCustomer == item.ImageCustomer)
                {
                    return true;
                }
            }
            return false;
        }
        public int addCustomer(Customer_DTO customer)
        {
            int result = Customer_DAL.addCustomer(customer);
            return result;
        }
        public int fixCustomer(Customer_DTO customer)
        {
            int result = Customer_DAL.fixCustomer(customer);
            return result;
        }
        public int deleteCustomer(Customer_DTO customer)
        {
            int result = Customer_DAL.deleteCustomer(customer);
            return result;
        }
        public List<Customer_DTO> searchCustomer(Customer_DTO customer)
        {
            List <Customer_DTO> customers = customerList();
            List<Customer_DTO> list = new List<Customer_DTO>();   
            foreach(Customer_DTO item in customers)
            {
                if(item.CustomerName == customer.CustomerName)
                {
                    list.Add(item);
                }
                if (item.CustomerName.Contains(customer.CustomerName))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public List<Customer_DTO> filterCustomer(string filter)
        {
            List<Customer_DTO> customers = customerList();
            List<Customer_DTO> list = new List<Customer_DTO>();
            foreach (Customer_DTO item in customers)
            {
                if (item.Gender == filter)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
