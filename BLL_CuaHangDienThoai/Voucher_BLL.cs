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
    public class Voucher_BLL
    {
        Voucher_DAL Voucher_DAL = new Voucher_DAL();
        public List<Voucher_DTO> VoucherList()
        {
            List<Voucher_DTO> list = Voucher_DAL.VoucherList();
            return list;
        }
        public DataTable voucherList()
        {
            DataTable dataTable = Voucher_DAL.voucherList();
            return dataTable;
        }
        public bool CheckExit(Voucher_DTO Voucher_DTO)
        {
            List<Voucher_DTO> list = VoucherList();
            foreach (Voucher_DTO item in list)
            {
                if (Voucher_DTO.IdVoucher == item.IdVoucher)
                {
                    return true;
                }
            }
            return false;
        }
        public int addVoucher(Voucher_DTO Voucher)
        {
            int result = Voucher_DAL.addVoucher(Voucher);
            return result;
        }
        public int fixVoucher(Voucher_DTO Voucher)
        {
            int result = Voucher_DAL.fixVoucher(Voucher);
            return result;
        }
        public int deleteVoucher(Voucher_DTO Voucher)
        {
            int result = Voucher_DAL.deleteVoucher(Voucher);
            return result;
        }
        public List<Voucher_DTO> searchVoucher(Voucher_DTO Voucher)
        {
            List<Voucher_DTO> Vouchers = VoucherList();
            List<Voucher_DTO> list = new List<Voucher_DTO>();
            foreach (Voucher_DTO item in Vouchers)
            {
                if (item.VoucherName == Voucher.VoucherName)
                {
                    list.Add(item);
                }
                // tương đối
                if (item.VoucherName.Contains(Voucher.VoucherName))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
