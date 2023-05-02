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
    public partial class frmDSBangDiemLop : Form
    {
        public frmDSBangDiemLop()
        {
            InitializeComponent();
        }

        DataTable tblDiemHSTheoLop;
        private void frmDSBangDiemLop_Load(object sender, EventArgs e)
        {
            string proc = "thongTinBD";
            tblDiemHSTheoLop = Function.Functions.getReport(proc);
            Report.rptBangDiem report = new Report.rptBangDiem();
            report.SetDataSource(tblDiemHSTheoLop);
            rptDiemHSLop.ReportSource = report;
            rptDiemHSLop.Refresh();
            string sql = "select sMaLop, sTenLop from tblLop";
            Function.Functions.fillCombo(sql, cboLop, "sMaLop", "sTenLop");
            sql = "select sMaMonHoc, sTenMonHoc from tblMonHoc";
            Function.Functions.fillCombo(sql, cboMon, "sMaMonHoc", "sTenMonHoc");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string proc = "diemHSTheoLop";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@TenLop", cboLop.SelectedValue);
            cmd.Parameters.AddWithValue("@TenMon", cboMon.SelectedValue);
            tblDiemHSTheoLop = Function.Functions.timKiem(proc, cmd);
            rptDSDiemHSTheoLop report = new rptDSDiemHSTheoLop();
            report.SetDataSource(tblDiemHSTheoLop);
            rptDiemHSLop.ReportSource = report;
            rptDiemHSLop.Refresh();
        }
    }
}
