using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_CuaHangDienThoai;

namespace DAL_CuaHangDienThoai
{
    public class DatabaseAccess
    {
        static string strConnect = @"Data Source=MSI;Initial Catalog=CuaHangDienThoai;Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(strConnect);
        static SqlCommand sqlCommand;
        public static void OpenConnect()
        {
            sqlConnection.Open();
        }
        public static void CloseConnect()
        {
            sqlConnection.Close();
        }
        public static void ExecuteCommand(string command)
        {
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery(); // dùng để thực thi lệnh bình thường
        }
        public static int ExcuteNonQuery(string command)
        {
            sqlCommand = new SqlCommand(command, sqlConnection);            
            int result = sqlCommand.ExecuteNonQuery(); // trả về kết quả là số dòng dữ liệu bị ảnh hưởng
            return result;
        }
        public static object ExecuteScalar(string command)
        {
            sqlCommand = new SqlCommand(command, sqlConnection);
            var result = sqlCommand.ExecuteScalar(); // trả về một giá trị duy nhất là cột đầu tiên của dòng đầu tiên
            return result;
        }
        public static SqlDataReader ExecuteReader()
        {
            return sqlCommand.ExecuteReader(); // đọc được dữ liệu trả về
        }
    }
}
