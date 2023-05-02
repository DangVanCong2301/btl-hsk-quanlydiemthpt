using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmKhoangDiem : Form
    {
        public frmKhoangDiem()
        {
            InitializeComponent();
        }

        private void frmKhoangDiem_Load(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            document.Load(@"E:\Documents\BTL - HSK\BTL_QuanLyDiemTHPT\BTL_QuanLyDiemTHPT\Report\rptBangDiem.rpt");
            rptKhoangDiem.ReportSource = document;
            rptKhoangDiem.Refresh();
            string sql = "select sMaLop, sTenLop from tblLop";
            Function.Functions.fillCombo(sql, cboLop, "sMaLop", "sTenLop");
            sql = "select sMaMonHoc, sTenMonHoc from tblMonHoc";
            Function.Functions.fillCombo(sql, cboMon, "sMaMonHoc", "sTenMonHoc");
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
                cmd.CommandText = "diemTrongKhoang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenLop", cboLop.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@TenMon", cboMon.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@DiemDau", txtDiemDau.Text.Trim());
                cmd.Parameters.AddWithValue("@DiemCuoi", txtDiemCuoi.Text.Trim());
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                rptDSDiemTrongKhoang report = new rptDSDiemTrongKhoang();
                report.SetDataSource(table);
                rptKhoangDiem.ReportSource = report; ;
                rptKhoangDiem.Refresh();
            }
        }
    }
}
