using DTO_CuaHangDienThoai;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_CuaHangDienThoai
{
    public class OrderTable_DAL
    {
        public List<OrderTable_DTO> OrderList()
        {
            try
            {
                List<OrderTable_DTO> list = new List<OrderTable_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader("selectOrderTable");
                while (sqlDataReader.Read())
                {
                    OrderTable_DTO OrderTable = new OrderTable_DTO()
                    {
                        IdOrderTable = int.Parse(sqlDataReader["IdOrder"].ToString()),
                        IdCustomer = int.Parse(sqlDataReader["IdCustomer"].ToString()),
                        IdStaff = int.Parse(sqlDataReader["IdStaff"].ToString()),
                        OrderStatus = sqlDataReader["OrderStatus"].ToString(),
                        TotalPrice = decimal.Parse(sqlDataReader["TotalPrice"].ToString()),
                        DayBuy = DateTime.Parse(sqlDataReader["DayBuy"].ToString()),
                        DeliveryAddress = sqlDataReader["DeliveryAddress"].ToString(),
                    };
                    list.Add(OrderTable);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public List<OrderDetail_DTO> OrderDetailList()
        {
            try
            {
                List<OrderDetail_DTO> list = new List<OrderDetail_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader("selectOrderDetail");
                while (sqlDataReader.Read())
                {
                    OrderDetail_DTO orderDetail_DTO = new OrderDetail_DTO()
                    {

                        IdOrderDetail = int.Parse(sqlDataReader["IdOrderDetail"].ToString()),
                        IdOrder = int.Parse(sqlDataReader["IdOrder"].ToString()),
                        IdProduct = int.Parse(sqlDataReader["IdProduct"].ToString()),
                        QuantityProduct = int.Parse(sqlDataReader["QuantityProduct"].ToString()),
                        Price = decimal.Parse(sqlDataReader["Price"].ToString()),
                        DiscountAmount = int.Parse(sqlDataReader["DiscountAmount"].ToString()),
                        IdVoucher = int.Parse(sqlDataReader["IdVoucher"].ToString()),
                    };
                    list.Add(orderDetail_DTO);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public int addOrderTable(OrderTable_DTO OrderTable_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"insertOrder '{OrderTable_DTO.IdCustomer}', " +
                $"'{OrderTable_DTO.IdStaff}', N'{OrderTable_DTO.OrderStatus}'," +
                $"'{OrderTable_DTO.TotalPrice}', '{OrderTable_DTO.DayBuy}', " +
                $"N'{OrderTable_DTO.DeliveryAddress}' ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int addOrderDetail(OrderDetail_DTO OrderDetail_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"insertOrderDetail '{OrderDetail_DTO.IdOrder}', " +
                $"'{OrderDetail_DTO.IdProduct}', '{OrderDetail_DTO.QuantityProduct}', '{OrderDetail_DTO.Price}'," +
                $"'{OrderDetail_DTO.DiscountAmount}', '{OrderDetail_DTO.IdVoucher}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int updateOrder(OrderTable_DTO OrderTable_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"updateOrderTable '{OrderTable_DTO.IdOrderTable}', '{OrderTable_DTO.IdCustomer}', " +
                $"'{OrderTable_DTO.IdStaff}', N'{OrderTable_DTO.OrderStatus}'," +
                $"'{OrderTable_DTO.TotalPrice}', '{OrderTable_DTO.DayBuy}', " +
                $"N'{OrderTable_DTO.DeliveryAddress}' ");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
