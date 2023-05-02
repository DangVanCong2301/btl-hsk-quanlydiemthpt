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
    public partial class frmNgayTrongKhoang : Form
    {
        public frmNgayTrongKhoang()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection.DBConnection.getConnection())
            {
                conn.Open();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "khoangNhayNhap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ThangNhap", txtThang.Text.Trim());
                cmd.Parameters.AddWithValue("@NamNhap", txtNam.Text.Trim());
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                rptKhoangNgayNhap report = new rptKhoangNgayNhap();
                report.SetDataSource(table);
                rptNgayTrongKhoang.ReportSource = report; ;
                rptNgayTrongKhoang.Refresh();

            }
        }
    }
}
