using DAL_CuaHangDienThoai;
using DTO_CuaHangDienThoai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CuaHangDienThoai
{
    public class OrderTable_BLL
    {
        OrderTable_DAL OrderTable_DAL = new OrderTable_DAL();
        public List<OrderTable_DTO> OrderList()
        {
            List<OrderTable_DTO> list = OrderTable_DAL.OrderList();
            return list;
        }public List<OrderDetail_DTO> OrderDetailList()
        {
            List<OrderDetail_DTO> list = OrderTable_DAL.OrderDetailList();
            return list;
        }
        public int addOrder(OrderTable_DTO orderTable_DTO)
        {
            int result = OrderTable_DAL.addOrderTable(orderTable_DTO);
            return result;
        }
        public int addOrderDetail(OrderDetail_DTO orderDetail_DTO)
        {
            int result = OrderTable_DAL.addOrderDetail(orderDetail_DTO);
            return result;
        }
        public int updateOrder(OrderTable_DTO orderTable_DTO)
        {
            int result = OrderTable_DAL.updateOrder(orderTable_DTO);
            return result;
        }
    }
}
