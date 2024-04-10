using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_CuaHangDienThoai;

namespace DAL_CuaHangDienThoai
{
    public class Voucher_DAL
    {
        public List<Voucher_DTO> VoucherList()
        {
            try
            {
                List<Voucher_DTO> list = new List<Voucher_DTO>();
                SqlDataReader sqlDataReader = DatabaseAccess.ExecuteReader("selectVoucher");
                while (sqlDataReader.Read())
                {
                    Voucher_DTO Voucher = new Voucher_DTO()
                    {
                        IdVoucher = int.Parse(sqlDataReader["IdVoucher"].ToString()),
                        VoucherName = sqlDataReader["VoucherName"].ToString(),
                        FixedPrice = int.Parse(sqlDataReader["FixedPrice"].ToString()),
                        Minimumprice = int.Parse(sqlDataReader["Minimumprice"].ToString()),
                        Quantity = int.Parse(sqlDataReader["Quantity"].ToString()),
                        StartDay = DateTime.Parse(sqlDataReader["StartDay"].ToString()),
                        EndDate = DateTime.Parse(sqlDataReader["EndDate"].ToString()),
                        IdCategory = int.Parse(sqlDataReader["IdCategory"].ToString())
                    };
                    list.Add(Voucher);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { DatabaseAccess.CloseConnecGlobal(); }
        }
        public DataTable voucherList()
        {
            try
            {
                DataTable dataTable = DatabaseAccess.GetDataTable("selectVoucher");
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int addVoucher(Voucher_DTO Voucher_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"insertVoucher N'{Voucher_DTO.VoucherName}', " +
                $"N'{Voucher_DTO.FixedPrice}'," +
                $"N'{Voucher_DTO.Minimumprice}', '{Voucher_DTO.Quantity}', " +
                $"'{Voucher_DTO.StartDay}', '{Voucher_DTO.EndDate}', " +
                $"'{Voucher_DTO.IdCategory}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int fixVoucher(Voucher_DTO Voucher_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"updateVoucher '{Voucher_DTO.IdVoucher}', " +
                    $"N'{Voucher_DTO.VoucherName}', " +
                $"N'{Voucher_DTO.VoucherName}', N'{Voucher_DTO.FixedPrice}'," +
                $"N'{Voucher_DTO.Minimumprice}', '{Voucher_DTO.Quantity}', " +
                $"'{Voucher_DTO.StartDay}', '{Voucher_DTO.EndDate}', " +
                $"'{Voucher_DTO.IdCategory}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deleteVoucher(Voucher_DTO Voucher_DTO)
        {
            try
            {
                int result = DatabaseAccess.ExcuteNonQuery($"deleteVoucher '{Voucher_DTO.IdVoucher}'");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
