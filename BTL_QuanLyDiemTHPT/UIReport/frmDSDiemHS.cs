using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class frmDSDiemHS : Form
    {
        public frmDSDiemHS()
        {
            InitializeComponent();
        }

        DataTable tblBangDiem;
        private void frmDSDiemHS_Load(object sender, EventArgs e)
        {
            string proc = "thongTinBD";
            tblBangDiem = Function.Functions.getReport(proc);
            Report.rptBangDiem report = new Report.rptBangDiem();
            report.SetDataSource(tblBangDiem);
            rptDSDiemMonHS.ReportSource = report;
            rptDSDiemMonHS.Refresh();
            string sql = "select sMaLop, sTenLop from tblLop";
            Function.Functions.fillCombo(sql, cboLop, "sMaLop", "sTenLop");
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen from tblHocSinh_tblLop "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "where tblHocSinh_tblLop.sMaLop = N'" + cboLop.SelectedValue + "'";
            if (!Function.Functions.checkKey(sql))
            {
                cboHocSinh.Text = "";
            }
            Function.Functions.fillCombo(sql, cboHocSinh, "sMaHocSinh", "sHoTen");
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
                cmd.CommandText = "diemMonHS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLop", cboLop.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaHocSinh", cboHocSinh.SelectedValue.ToString());
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                rptDSDiemHS report = new rptDSDiemHS();
                report.SetDataSource(table);
                rptDSDiemMonHS.ReportSource = report; ;
                rptDSDiemMonHS.Refresh();
            }
        }
    }
                //ParameterFieldDefinition pfd = report.DataDefinition.ParameterFields["sNguoiLap"];
                //ParameterValues pv = new ParameterValues();
                //ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                //pdv.Value = txtNguoiLap.Text;
                //pv.Add(pdv);
                //pfd.CurrentValues.Clear();
                //pfd.ApplyCurrentValues(pv);
}
