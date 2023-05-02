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

namespace BTL_QuanLyDiemTHPT
{
    public partial class frmBangDiem : Form
    {
        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            cboMaLop.Enabled = true;
            cboMaHS.Enabled = true;
            cboMaMH.Enabled = true;
            cboMaHS.Enabled = true;
            cboMaGV.Enabled = true;
            cboHocKy.Enabled = true;
            txtNamHoc.Enabled = true;
            resetValues();
        }

        private void resetValues()
        {
            //cboMaLop.Text = "";
            //cboMaHS.Text = "";
            //cboMaMH.Text = "";
            //cboMaGV.Text = "";
            cboHocKy.Text = "Học kỳ 2";
            txtNamHoc.Text = "2022 - 2023";
            txtNamHoc.Enabled = false;
            txtDiem15Phut.Text = "";
            txtDiem45Phut.Text = "";
            txtDiemHocKi.Text = "";
            txtXetHocLuc.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblBangDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string maHS = dgvBangDiemMH.CurrentRow.Cells["sMaHocSinh"].Value.ToString();
            if (txtDiemHocKi.Text == "")
            {
                sql = "update tblBangDiem set fDiem15Phut = " + txtDiem15Phut.Text.Trim() + ", fDiem45Phut = " + txtDiem45Phut.Text.Trim() + " where sMaHocSinh = N'" + maHS + "' and sMaMonHoc = N'" + cboMaMH.SelectedValue.ToString() + "' and sMaGiaoVien = N'" + cboMaGV.SelectedValue.ToString() + "' and sNamHoc = N'" + txtNamHoc.Text.Trim() + "' and sHocKy = N'" + cboHocKy.Text.Trim() + "'";
            } else
            {
                sql = "update tblBangDiem set sXepLoai = N'" + txtXetHocLuc.Text.Trim() + "', fDiem15Phut = " + txtDiem15Phut.Text.Trim() + ", fDiem45Phut = " + txtDiem45Phut.Text.Trim() + ", fDiemThi = " + txtDiemHocKi.Text.Trim() + " where sMaHocSinh = N'" + maHS + "' and sMaMonHoc = N'" + cboMaMH.SelectedValue.ToString() + "' and sMaGiaoVien = N'" + cboMaGV.SelectedValue.ToString() + "' and sNamHoc = N'" + txtNamHoc.Text.Trim() + "' and sHocKy = N'" + cboHocKy.Text.Trim() + "'";
            }
            Functions.runSql(sql);
            loadDataGridView();
        }

        private void frmBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            cboMaLop.Enabled = false;
            cboMaHS.Enabled = false;
            cboMaGV.Enabled = false;
            cboMaMH.Enabled = false;
            cboHocKy.Enabled = false;
            txtNamHoc.Enabled = false;
            loadDataGridView();
            List<string> lstHK = new List<string>() { "Học kỳ 1", "Học kỳ 2" };
            cboHocKy.DataSource = lstHK;
            string sql = "select sMaGiaoVien, sTenGiaoVien from tblGiaoVien";
            Functions.fillCombo(sql, cboMaGV, "sMaGiaoVien", "sTenGiaoVien");
            sql = "select sMaLop, sTenLop from tblLop";
            Functions.fillCombo(sql, cboMaLop, "sMaLop", "sTenLop");
            sql = "select sTenMonHoc, sMaMonHoc from tblMonHoc";
            Functions.fillCombo(sql, cboMaMH, "sMaMonHoc", "sTenMonHoc");
        }

        DataTable tblBangDiem;
        private void loadDataGridView()
        {
            string sql = "select tblLop.sMaLop, tblLop.sTenLop, tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen, tblGiaoVien.sTenGiaoVien, tblMonHoc.sTenMonHoc, tblBangDiem.sNamHoc, sHocKy, fDiem15Phut, fDiem45Phut, fDiemThi, sXepLoai, dNgayNhap "
                       + "from tblBangDiem inner join tblHocSinh_tblLop on tblHocSinh_tblLop.sMaHocSinh = tblBangDiem.sMaHocSinh "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "inner join tblMonHoc on tblMonHoc.sMaMonHoc = tblBangDiem.sMaMonHoc "
                       + "inner join tblGiaoVien on tblGiaoVien.sMaGiaoVien = tblBangDiem.sMaGiaoVien where tblLop.sMaLop = N'" + cboMaLop.SelectedValue + "' and tblMonHoc.sMaMonHoc = N'" + cboMaMH.SelectedValue + "'";
            tblBangDiem = Functions.getDataToTable(sql);
            #region Hiển thị bảng điểm
            tblBangDiem.Columns.Add("STT");
            for (int i = 0; i < tblBangDiem.Rows.Count; i++)
            {
                tblBangDiem.Rows[i]["STT"] = i + 1;
                dgvBangDiemMH.DataSource = tblBangDiem;
                dgvBangDiemMH.Columns["STT"].DisplayIndex = 0;
                dgvBangDiemMH.Columns["STT"].Width = 40;
                dgvBangDiemMH.Columns[0].HeaderText = "Mã lớp";
                dgvBangDiemMH.Columns[1].HeaderText = "Tên lớp";
                dgvBangDiemMH.Columns[2].HeaderText = "Mã học sinh";
                dgvBangDiemMH.Columns[3].HeaderText = "Tên học sinh";
                dgvBangDiemMH.Columns[4].HeaderText = "Tên giáo viên";
                dgvBangDiemMH.Columns[5].HeaderText = "Tên môn học";
                dgvBangDiemMH.Columns[6].HeaderText = "Năm học";
                dgvBangDiemMH.Columns[7].HeaderText = "Học kỳ";
                dgvBangDiemMH.Columns[8].HeaderText = "Điểm 15 phút";
                dgvBangDiemMH.Columns[9].HeaderText = "Điểm 1 tiết";
                dgvBangDiemMH.Columns[10].HeaderText = "Điểm thi";
                dgvBangDiemMH.Columns[11].HeaderText = "Xếp loại";
                dgvBangDiemMH.Columns[12].HeaderText = "Ngày nhập";
                dgvBangDiemMH.Columns[0].Width = 100;
                dgvBangDiemMH.Columns[1].Width = 100;
                dgvBangDiemMH.Columns[2].Width = 100;
                dgvBangDiemMH.Columns[3].Width = 150;
                dgvBangDiemMH.Columns[4].Width = 150;
                dgvBangDiemMH.Columns[5].Width = 100;
                dgvBangDiemMH.Columns[6].Width = 100;
                dgvBangDiemMH.Columns[7].Width = 100;
                dgvBangDiemMH.Columns[8].Width = 100;
                dgvBangDiemMH.Columns[9].Width = 100;
                dgvBangDiemMH.Columns[10].Width = 100;
                dgvBangDiemMH.Columns[11].Width = 100;
                dgvBangDiemMH.Columns[12].Width = 100;
                dgvBangDiemMH.AllowUserToAddRows = false;
                dgvBangDiemMH.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            #endregion
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen from tblHocSinh_tblLop "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "where tblHocSinh_tblLop.sMaLop = N'" + cboMaLop.SelectedValue + "'";
            if (!Functions.checkKey(sql))
            {
                cboMaHS.Text = "";
            }
            Functions.fillCombo(sql, cboMaHS, "sMaHocSinh", "sHoTen");
            sql = "select tblLop.sMaLop, tblLop.sTenLop, tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen, tblGiaoVien.sTenGiaoVien, tblMonHoc.sTenMonHoc, tblBangDiem.sNamHoc, sHocKy, fDiem15Phut, fDiem45Phut, fDiemThi, sXepLoai, dNgayNhap "
                       + "from tblBangDiem inner join tblHocSinh_tblLop on tblHocSinh_tblLop.sMaHocSinh = tblBangDiem.sMaHocSinh "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "inner join tblMonHoc on tblMonHoc.sMaMonHoc = tblBangDiem.sMaMonHoc "
                       + "inner join tblGiaoVien on tblGiaoVien.sMaGiaoVien = tblBangDiem.sMaGiaoVien where tblLop.sMaLop = N'" + cboMaLop.SelectedValue + "' and tblMonHoc.sMaMonHoc = N'" + cboMaMH.SelectedValue + "'";
            tblBangDiem = Functions.getDataToTable(sql);
            #region Hiển thị bảng điểm
            tblBangDiem.Columns.Add("STT");
            for (int i = 0; i < tblBangDiem.Rows.Count; i++)
            {
                tblBangDiem.Rows[i]["STT"] = i + 1;
                dgvBangDiemMH.DataSource = tblBangDiem;
                dgvBangDiemMH.Columns["STT"].DisplayIndex = 0;
                dgvBangDiemMH.Columns["STT"].Width = 10;
                dgvBangDiemMH.Columns[0].HeaderText = "Mã lớp";
                dgvBangDiemMH.Columns[1].HeaderText = "Tên lớp";
                dgvBangDiemMH.Columns[2].HeaderText = "Mã học sinh";
                dgvBangDiemMH.Columns[3].HeaderText = "Tên học sinh";
                dgvBangDiemMH.Columns[4].HeaderText = "Tên giáo viên";
                dgvBangDiemMH.Columns[5].HeaderText = "Tên môn học";
                dgvBangDiemMH.Columns[6].HeaderText = "Năm học";
                dgvBangDiemMH.Columns[7].HeaderText = "Học kỳ";
                dgvBangDiemMH.Columns[8].HeaderText = "Điểm 15 phút";
                dgvBangDiemMH.Columns[9].HeaderText = "Điểm 1 tiết";
                dgvBangDiemMH.Columns[10].HeaderText = "Điểm thi";
                dgvBangDiemMH.Columns[11].HeaderText = "Xếp loại";
                dgvBangDiemMH.Columns[12].HeaderText = "Ngày nhập";
                dgvBangDiemMH.Columns[0].Width = 100;
                dgvBangDiemMH.Columns[1].Width = 100;
                dgvBangDiemMH.Columns[2].Width = 100;
                dgvBangDiemMH.Columns[3].Width = 150;
                dgvBangDiemMH.Columns[4].Width = 150;
                dgvBangDiemMH.Columns[5].Width = 100;
                dgvBangDiemMH.Columns[6].Width = 100;
                dgvBangDiemMH.Columns[7].Width = 100;
                dgvBangDiemMH.Columns[8].Width = 100;
                dgvBangDiemMH.Columns[9].Width = 100;
                dgvBangDiemMH.Columns[10].Width = 100;
                dgvBangDiemMH.Columns[11].Width = 100;
                dgvBangDiemMH.Columns[12].Width = 100;
                dgvBangDiemMH.AllowUserToAddRows = false;
                dgvBangDiemMH.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            #endregion
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "select sMaHocSinh, sMaGiaoVien, sMaMonHoc, sNamHoc, sHocKy from tblBangDiem where sMaHocSinh = N'" + cboMaHS.SelectedValue + "' and sMaGiaoVien = N'" + cboMaGV.SelectedValue + "' and sMaMonHoc = N'" + cboMaMH.SelectedValue + "' and sNamHoc = N'" + txtNamHoc.Text.Trim() + "' and sHocKy = N'" + cboHocKy.Text.Trim() + "'";
            if (Functions.checkKey(sql))
            {
                MessageBox.Show("Bảng điểm này đã tồn tại, bạn phải nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiemHocKi.Text == "")
            {
                sql = "insert into tblBangDiem(sMaHocSinh, sMaGiaoVien, sMaMonHoc, sNamHoc, sHocKy, fDiem15Phut, fDiem45Phut) values (N'" + cboMaHS.SelectedValue.ToString() + "', N'" + cboMaGV.SelectedValue.ToString() + "', N'" + cboMaMH.SelectedValue.ToString() + "', '" + txtNamHoc.Text.Trim() + "', N'" + cboHocKy.Text.Trim() + "', " + txtDiem15Phut.Text.Trim() + ", " + txtDiem45Phut.Text.Trim() + ")";
            } else
            {
                sql = "insert into tblBangDiem(sMaHocSinh, sMaGiaoVien, sMaMonHoc, sNamHoc, sHocKy, fDiem15Phut, fDiem45Phut, fDiemThi, sXepLoai) values (N'" + cboMaHS.SelectedValue.ToString() + "', N'" + cboMaGV.SelectedValue.ToString() + "', N'" + cboMaMH.SelectedValue.ToString() + "', '" + txtNamHoc.Text.Trim() + "', N'" + cboHocKy.Text.Trim() + "', " + txtDiem15Phut.Text.Trim() + ", " + txtDiem45Phut.Text.Trim() + ", " + txtDiemHocKi.Text.Trim() + ", N'" + txtXetHocLuc.Text.Trim() + "')";
            }
            Functions.runSql(sql);
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            cboMaLop.Enabled = false;
            cboMaHS.Enabled = false;
            cboMaGV.Enabled = false;
            cboMaMH.Enabled = false;
            cboHocKy.Enabled = false;
            txtNamHoc.Enabled = false;
            loadDataGridView();
        }

        private void dgvBangDiemMH_Click(object sender, EventArgs e)
        {
            string sql, maHS, maGV, maMH;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem15Phut.Focus();
                return;
            }
            if (tblBangDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            maHS = dgvBangDiemMH.CurrentRow.Cells["sMaHocSinh"].Value.ToString();
            sql = "select sHoTen from tblHocSinh where sMaHocSinh = N'" + maHS + "'";
            cboMaHS.Text = Functions.getFileValues(sql);
            cboMaHS.Enabled = false;
            sql = "select sTenLop from tblLop inner join tblHocSinh_tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop inner join tblHocSinh on tblHocSinh_tblLop.sMaHocSinh = tblHocSinh.sMaHocSinh where tblHocSinh.sHoTen in (select tblHocSinh.sHoTen from tblHocSinh where tblHocSinh.sMaHocSinh = '" + maHS + "')";
            cboMaLop.Text = Functions.getFileValues(sql);
            cboMaLop.Enabled = false;
            maGV = dgvBangDiemMH.CurrentRow.Cells["sTenGiaoVien"].Value.ToString();
            sql = "select sTenGiaoVien from tblGiaoVien where sTenGiaoVien = N'" + maGV + "'";
            cboMaGV.Text = Functions.getFileValues(sql);
            cboMaGV.Enabled = false;
            maMH = dgvBangDiemMH.CurrentRow.Cells["sTenMonHoc"].Value.ToString();
            sql = "select sTenMonHoc from tblMonHoc where sTenMonHoc = N'" + maMH + "'";
            cboMaMH.Text = Functions.getFileValues(sql);
            cboMaMH.Enabled = false;
            cboHocKy.Text = dgvBangDiemMH.CurrentRow.Cells["sHocKy"].Value.ToString();
            cboHocKy.Enabled = false;
            txtNamHoc.Text = dgvBangDiemMH.CurrentRow.Cells["sNamHoc"].Value.ToString();
            txtNamHoc.Enabled = false;
            txtDiem15Phut.Text = dgvBangDiemMH.CurrentRow.Cells["fDiem15Phut"].Value.ToString();
            txtDiem45Phut.Text = dgvBangDiemMH.CurrentRow.Cells["fDiem45Phut"].Value.ToString();
            if (dgvBangDiemMH.CurrentRow.Cells["fDiemThi"].Value.ToString() == "")
            {
                txtDiemTrungBinh.Text = "";
                txtXetHocLuc.Text = "";
            } else
            {
                txtDiemHocKi.Text = dgvBangDiemMH.CurrentRow.Cells["fDiemThi"].Value.ToString();
                txtDiemHocKi_TextChanged(sender, e);
            }
            //txtXetHocLuc.Text = dgvBangDiemMH.CurrentRow.Cells["fXepLoai"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string proc = "timKiemBD";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@TuKhoa", txtTimKiem.Text.Trim());
            tblBangDiem = Functions.timKiem(proc, cmd);
            dgvBangDiemMH.DataSource = tblBangDiem;
            dgvBangDiemMH.Columns[0].HeaderText = "Tên lớp";
            dgvBangDiemMH.Columns[1].HeaderText = "Tên học sinh";
            dgvBangDiemMH.Columns[2].HeaderText = "Tên giáo viên";
            dgvBangDiemMH.Columns[3].HeaderText = "Tên môn học";
            dgvBangDiemMH.Columns[4].HeaderText = "Năm học";
            dgvBangDiemMH.Columns[5].HeaderText = "Học kỳ";
            dgvBangDiemMH.Columns[6].HeaderText = "Điểm 15 phút";
            dgvBangDiemMH.Columns[7].HeaderText = "Điểm 1 tiết";
            dgvBangDiemMH.Columns[8].HeaderText = "Điểm thi";
            dgvBangDiemMH.Columns[9].HeaderText = "Xếp loại";
            dgvBangDiemMH.Columns[0].Width = 100;
            dgvBangDiemMH.Columns[1].Width = 100;
            dgvBangDiemMH.Columns[2].Width = 100;
            dgvBangDiemMH.Columns[3].Width = 100;
            dgvBangDiemMH.Columns[4].Width = 100;
            dgvBangDiemMH.Columns[5].Width = 100;
            dgvBangDiemMH.Columns[6].Width = 100;
            dgvBangDiemMH.Columns[7].Width = 100;
            dgvBangDiemMH.Columns[8].Width = 100;
            dgvBangDiemMH.Columns[9].Width = 100;
            dgvBangDiemMH.AllowUserToAddRows = false;
            dgvBangDiemMH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnHienDS_Click(object sender, EventArgs e)
        {
            string sql = "select tblLop.sMaLop, tblLop.sTenLop, tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen, tblGiaoVien.sTenGiaoVien, tblMonHoc.sTenMonHoc, tblBangDiem.sNamHoc, sHocKy, fDiem15Phut, fDiem45Phut, fDiemThi "
                       + "from tblBangDiem inner join tblHocSinh_tblLop on tblHocSinh_tblLop.sMaHocSinh = tblBangDiem.sMaHocSinh "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "inner join tblMonHoc on tblMonHoc.sMaMonHoc = tblBangDiem.sMaMonHoc "
                       + "inner join tblGiaoVien on tblGiaoVien.sMaGiaoVien = tblBangDiem.sMaGiaoVien ";
            tblBangDiem = Functions.getDataToTable(sql);
            dgvBangDiemMH.DataSource = tblBangDiem;
        }

        private void dgvBangDiemMH_DoubleClick(object sender, EventArgs e)
        {
            if (tblBangDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maHS = dgvBangDiemMH.CurrentRow.Cells["sMaHocSinh"].Value.ToString();
                string sql = "delete tblBangDiem where sMaHocSinh = N'" + maHS + "' and sMaGiaoVien = N'" + cboMaGV.SelectedValue + "' and sMaMonHoc = N'" + cboMaMH.SelectedValue + "' and sHocKy = N'" + cboHocKy.Text.Trim() + "' and sNamHoc = N'" + txtNamHoc.Text.Trim() + "'";
                Functions.runSql(sql);
                loadDataGridView();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            cboMaLop.Enabled = true;
            cboMaHS.Enabled = true;
            cboMaMH.Enabled = true;
            cboMaHS.Enabled = true;
            cboMaGV.Enabled = true;
            cboHocKy.Enabled = true;
            txtNamHoc.Enabled = true;
        }

        private void txtDiemHocKi_TextChanged(object sender, EventArgs e)
        {
            double diem15Phut, diem45Phut, diemThi, diemTB;
            if (txtDiem15Phut.Text == "")
            {
                diem15Phut = 0;
            }
            else
            {
                diem15Phut = Convert.ToDouble(txtDiem15Phut.Text);
            }
            if (txtDiem45Phut.Text == "")
            {
                diem45Phut = 0;
            }
            else
            {
                diem45Phut = Convert.ToDouble(txtDiem45Phut.Text);
            }
            if (txtDiemHocKi.Text == "")
            {
                diemThi = 0;
            }
            else
            {
                diemThi = Convert.ToDouble(txtDiemHocKi.Text);
            }
            diemTB = Math.Round((diem15Phut * 1 + diem45Phut * 2 + diemThi * 3) / 6, 2);
            txtDiemTrungBinh.Text = diemTB.ToString();
            xetHocLuc();
            txtDiemTrungBinh.Enabled = false;
            txtXetHocLuc.Enabled = false;
        }

        private void xetHocLuc()
        {
            double diemTrungBinh = double.Parse(txtDiemTrungBinh.Text);
            if (diemTrungBinh >= 8 && diemTrungBinh <= 10)
            {
                txtXetHocLuc.Text = "Giỏi";
            }
            else if (diemTrungBinh < 8 && diemTrungBinh >= 7)
            {
                txtXetHocLuc.Text = "Khá";
            }
            else if (diemTrungBinh < 7 && diemTrungBinh >= 6)
            {
                txtXetHocLuc.Text = "Trung bình khá";
            }
            else if (diemTrungBinh < 6 && diemTrungBinh >= 5)
            {
                txtXetHocLuc.Text = "Trung bình";
            }
            else if (diemTrungBinh < 5 && diemTrungBinh >= 0)
            {
                txtXetHocLuc.Text = "Yếu";
            }
        }

        //#region Validating trường điểm 
        //private void txtDiem15Phut_Validating(object sender, CancelEventArgs e)
        //{
        //    if (txtDiem15Phut.Text == "")
        //    {
        //        errDiem15Phut.SetError(txtDiem15Phut, "Bạn phải nhập điểm 15 phút");
        //    }
        //    else
        //    {
        //        errDiem15Phut.SetError(txtDiem15Phut, "");
        //    }
        //}
        //#endregion

        private void cboMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select tblLop.sMaLop, tblLop.sTenLop, tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen, tblGiaoVien.sTenGiaoVien, tblMonHoc.sTenMonHoc, tblBangDiem.sNamHoc, sHocKy, fDiem15Phut, fDiem45Phut, fDiemThi, sXepLoai, dNgayNhap "
                       + "from tblBangDiem inner join tblHocSinh_tblLop on tblHocSinh_tblLop.sMaHocSinh = tblBangDiem.sMaHocSinh "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "inner join tblMonHoc on tblMonHoc.sMaMonHoc = tblBangDiem.sMaMonHoc "
                       + "inner join tblGiaoVien on tblGiaoVien.sMaGiaoVien = tblBangDiem.sMaGiaoVien where tblLop.sMaLop = N'" + cboMaLop.SelectedValue + "' and tblMonHoc.sMaMonHoc = N'" + cboMaMH.SelectedValue + "'";
            tblBangDiem = Functions.getDataToTable(sql);
            #region Hiển thị bảng điểm
            tblBangDiem.Columns.Add("STT");
            for (int i = 0; i < tblBangDiem.Rows.Count; i++)
            {
                tblBangDiem.Rows[i]["STT"] = i + 1;
                dgvBangDiemMH.DataSource = tblBangDiem;
                dgvBangDiemMH.Columns["STT"].DisplayIndex = 0;
                dgvBangDiemMH.Columns["STT"].Width = 40;
                dgvBangDiemMH.Columns[0].HeaderText = "Mã lớp";
                dgvBangDiemMH.Columns[1].HeaderText = "Tên lớp";
                dgvBangDiemMH.Columns[2].HeaderText = "Mã học sinh";
                dgvBangDiemMH.Columns[3].HeaderText = "Tên học sinh";
                dgvBangDiemMH.Columns[4].HeaderText = "Tên giáo viên";
                dgvBangDiemMH.Columns[5].HeaderText = "Tên môn học";
                dgvBangDiemMH.Columns[6].HeaderText = "Năm học";
                dgvBangDiemMH.Columns[7].HeaderText = "Học kỳ";
                dgvBangDiemMH.Columns[8].HeaderText = "Điểm 15 phút";
                dgvBangDiemMH.Columns[9].HeaderText = "Điểm 1 tiết";
                dgvBangDiemMH.Columns[10].HeaderText = "Điểm thi";
                dgvBangDiemMH.Columns[11].HeaderText = "Xếp loại";
                dgvBangDiemMH.Columns[12].HeaderText = "Ngày nhập";
                dgvBangDiemMH.Columns[0].Width = 100;
                dgvBangDiemMH.Columns[1].Width = 100;
                dgvBangDiemMH.Columns[2].Width = 100;
                dgvBangDiemMH.Columns[3].Width = 150;
                dgvBangDiemMH.Columns[4].Width = 150;
                dgvBangDiemMH.Columns[5].Width = 100;
                dgvBangDiemMH.Columns[6].Width = 100;
                dgvBangDiemMH.Columns[7].Width = 100;
                dgvBangDiemMH.Columns[8].Width = 100;
                dgvBangDiemMH.Columns[9].Width = 100;
                dgvBangDiemMH.Columns[10].Width = 100;
                dgvBangDiemMH.Columns[11].Width = 100;
                dgvBangDiemMH.Columns[12].Width = 100;
                dgvBangDiemMH.AllowUserToAddRows = false;
                dgvBangDiemMH.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            #endregion
        }
    }
}
