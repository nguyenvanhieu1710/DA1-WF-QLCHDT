using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLL_CuaHangDienThoai
{
    public class RegexData
    {
        /// <summary>
        /// Phương thức kiểm tra một ID
        /// </summary>
        /// <param name="id">Chuỗi dữ liệu đầu vào</param>
        public static bool IsValidId(string id)
        {
            // chuỗi chỉ chứa các chữ số, không bắt đầu bằng số 0 và không vượt quá 10 chữ số (tức là không vượt quá giới hạn của kiểu int) -> true
            Regex regex = new Regex(@"^[0-9][0-9]{0,9}$");
            return regex.IsMatch(id);
        }
        /// <summary>
        /// Phương thức kiểm tra Name
        /// </summary>
        /// <param name="name">Chuỗi dữ liệu đầu vào</param>
        public static bool IsValidName(string name)
        {
            // một chuỗi chỉ chứa các chữ cái và số, không chứa ký tự đặc biệt hoặc khoảng trắng, và có độ dài từ 1 đến 100 -> true
            Regex regex = new Regex(@"^[\p{L}\s\p{P}0-9]{1,100}$");
            return regex.IsMatch(name);
        }
        /// <summary>
        /// Phương thức kiểm tra phone number
        /// </summary>
        /// <param name="phoneNumber">Chuỗi dữ liệu đầu vào</param>
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
            return regex.IsMatch(phoneNumber);
        }

    }
}
