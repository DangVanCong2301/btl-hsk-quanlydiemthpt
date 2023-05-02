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
using BTL_QuanLyDiemTHPT.Function;
using BTL_QuanLyDiemTHPT.Report;
using BTL_QuanLyDiemTHPT.UIReport;

namespace BTL_QuanLyDiemTHPT
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        DataTable tblLop;
        private void frmLop_Load(object sender, EventArgs e)
        {
            txtMaLop.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnXoa.Enabled = false;
            loadDataGridView();
            string sql = "select sMaGiaoVien, sTenGiaoVien from tblGiaoVien";
            Functions.fillCombo(sql, cboMaGV, "sMaGiaoVien", "sTenGiaoVien");
        }

        private void loadDataGridView()
        {
            string proc = "select * from tblLop";
            tblLop = Functions.getDataToTable(proc);
            dgvLop.DataSource = tblLop;
            dgvLop.Columns[0].HeaderText = "Mã lớp";
            dgvLop.Columns[1].HeaderText = "Mã giáo viên";
            dgvLop.Columns[2].HeaderText = "Số lượng";
            dgvLop.Columns[3].HeaderText = "Năm học";
            dgvLop.Columns[4].HeaderText = "Tên lớp";
            dgvLop.Columns[0].Width = 80;
            dgvLop.Columns[1].Width = 100;
            dgvLop.Columns[2].Width = 100;
            dgvLop.Columns[3].Width = 100;
            dgvLop.Columns[4].Width = 100;
            dgvLop.AllowUserToAddRows = false;
            dgvLop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLop.Enabled = true;
            txtMaLop.Focus();
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            resetValue();
        }

        private void resetValue()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                return;
            }
            string sql = "select sMaLop from tblLop where sMaLop = N'" + txtMaLop.Text + "'";
            if (Function.Functions.checkKey(sql))
            {
                MessageBox.Show("Mã này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                txtMaLop.Text = "";
                return;
            }
            sql = "insert into tblLop(sMaLop, sTenLop, sMaGiaoVien, iSoLuongHocSinh) values (N'" + txtMaLop.Text.Trim() + "', N'" + txtTenLop.Text.Trim() + "', N'" + cboMaGV.SelectedValue + "', " + txtSoLuong.Text.Trim() + ")";
            Function.Functions.runSql(sql);
            loadDataGridView();
            resetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLop.Enabled = false;
        }

        private void dgvLop_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = dgvLop.CurrentRow.Cells["sMaLop"].Value.ToString();
            string maGV = dgvLop.CurrentRow.Cells["sMaGiaoVien"].Value.ToString();
            string sql = "select sTenGiaoVien from tblGiaoVien where sMaGiaoVien = N'" + maGV + "'";
            cboMaGV.Text = Functions.getFileValues(sql);
            txtTenLop.Text = dgvLop.CurrentRow.Cells["sTenLop"].Value.ToString();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void dgvLop_DoubleClick(object sender, EventArgs e)
        {
            string tenLop = dgvLop.CurrentRow.Cells["sTenLop"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn in danh sách học sinh của lớp " + tenLop + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string proc = "danhSachHSTheoLop";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@TenLop", tenLop);
                tblLop = Functions.timKiem(proc, cmd);
                rptHocSinhTheoLop report = new rptHocSinhTheoLop();
                report.SetDataSource(tblLop);
                frmDanhSachHocSinhTheoLop f = new frmDanhSachHocSinhTheoLop();
                f.rptDanhSachHocSinh.ReportSource = report;
                f.rptDanhSachHocSinh.Refresh();
                f.Show();
            }
        }
    }
}
