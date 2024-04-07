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

        // đối tượng kết nối toàn cục(toàn cầu) chỉ phục vụ cho SqlDataReader
        static SqlConnection sqlConnectionGlobal = new SqlConnection(strConnect);
        /// <summary>
        /// Phương thức thực thi câu lệnh SQL và trả về một SqlDataReader chứa kết quả
        /// </summary>
        /// /// <param name="command">Chuỗi câu lệnh SQL mà bạn muốn thực hiện</param>
        public static SqlDataReader ExecuteReader(string command)
        {
            sqlConnectionGlobal.Open();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnectionGlobal);
            // Thực thi câu lệnh SQL và trả về một SqlDataReader chứa kết quả
            return sqlCommand.ExecuteReader();
            // nếu đóng kết nối ở đây thì SqlDataReader cũng sẽ bị xóa hết dữ liệu luôn
        }
        /// <summary>
        /// Phương thức đóng chuỗi kết nối toàn cục
        /// </summary>
        public static void CloseConnecGlobal()
        {
            sqlConnectionGlobal.Close();
        }
        /// <summary>
        /// Phương thức thực thi câu lệnh SQL không trả về kết quả gì
        /// </summary>
        /// <param name="command">Chuỗi câu lệnh SQL mà bạn muốn thực hiện</param>
        public static void ExecuteCommand(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnect))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();// trả về kết quả là số dòng dữ liệu bị ảnh hưởng
                }
            }
        }
        /// <summary>
        /// Phương thức thực thi câu lệnh SQL trả về số dòng dữ liệu bị ảnh hưởng
        /// </summary>
        /// <param name="command">Chuỗi câu lệnh SQL mà bạn muốn thực hiện</param>
        public static int ExcuteNonQuery(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnect))
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    int result = sqlCommand.ExecuteNonQuery();// trả về kết quả là số dòng dữ liệu bị ảnh hưởng
                    return result;
                }
            }       
        }
        /// <summary>
        /// Phương thức thực thi câu lệnh SQL trả về số một giá trị duy nhất là cột đầu tiên của dòng đầu tiên
        /// </summary>
        /// <param name="command">Chuỗi câu lệnh SQL mà bạn muốn thực hiện</param>
        public static int ExecuteScalar(string command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnect))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    int result = (int) sqlCommand.ExecuteScalar();// trả về một giá trị duy nhất là cột đầu tiên của dòng đầu tiên
                    return result;
                }
            }
        }
    }
}
