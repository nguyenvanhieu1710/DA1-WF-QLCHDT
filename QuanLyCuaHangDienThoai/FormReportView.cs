using DTO_CuaHangDienThoai;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormReportView : Form
    {
        public FormReportView()
        {
            InitializeComponent();
        }
        DataTable orderTable = new DataTable();
        public void getOrder(OrderTable_DTO orderTable_DTO)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=CuaHangDienThoai;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"bill '{orderTable_DTO.IdOrderTable}'", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {                       
                        adapter.Fill(orderTable);
                    }
                }
            }
        }
        private void FormReportView_Load(object sender, EventArgs e)
        {
            try
            {
                // lấy đường dẫn file rdlc cho vô reportViewer1
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangDienThoai.DesignReportBill.rdlc";
                // ReportDataSource là một lớp giúp kết nối dữ liệu với báo cáo
                ReportDataSource reportDataSource = new ReportDataSource();
                // Name này phải khớp với tên của DataSet được định nghĩa trong tệp rdlc
                reportDataSource.Name = "DataSet1";
                // alue này là dữ liệu thực tế sẽ được sử dụng trong báo cáo
                reportDataSource.Value = orderTable;
                // thêm reportDataSource vào danh sách DataSources của LocalReport trong reportViewer1. Điều này nghĩa là báo cáo sẽ sử dụng dữ liệu từ reportDataSource
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                // Điều này làm mới và hiển thị báo cáo với dữ liệu mới nhất từ DataSources
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}
