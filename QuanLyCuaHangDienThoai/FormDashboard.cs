using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_CuaHangDienThoai;

namespace QuanLyCuaHangDienThoai
{
    public partial class FormDashboard : Form
    {
        // Fields
        private Dashboard_BLL model;

        // Constructer
        public FormDashboard()
        {
            InitializeComponent();
            // Default - Last 7 days
            dtpStartDate.Value = DateTime.Now.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            model = new Dashboard_BLL();
            LoadData();
        }

        // private methods
        private void LoadData()
        {
            
        }
    }
}
