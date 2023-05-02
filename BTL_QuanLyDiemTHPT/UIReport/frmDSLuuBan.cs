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
using BTL_QuanLyDiemTHPT.Report;

namespace BTL_QuanLyDiemTHPT.BaoCao
{
    public partial class frmDSLuuBan : Form
    {
        public frmDSLuuBan()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = Connection.DBConnection.getConnection())
            {
                conn.Open();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DSLuuBan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenKhoi", txtTenKhoi.Text.Trim());
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                rptDSLuuBan report = new rptDSLuuBan();
                report.SetDataSource(table);
                rptLuuBan.ReportSource = report;
                rptLuuBan.Refresh();
            }
        }
    }
}
