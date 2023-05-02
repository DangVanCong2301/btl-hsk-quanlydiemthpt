using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyDiemTHPT.Function;

namespace BTL_QuanLyDiemTHPT
{
    public partial class frmBangDiemLop : Form
    {
        public frmBangDiemLop()
        {
            InitializeComponent();
        }

        private void frmBangDiemLop_Load(object sender, EventArgs e)
        {
            string sql = "select sMaGiaoVien, sTenGiaoVien from tblGiaoVien";
            Functions.fillCombo(sql, cboMaGV, "sMaGiaoVien", "sTenGiaoVien");
            sql = "select sMaLop, sTenLop from tblLop";
            Functions.fillCombo(sql, cboMaLop, "sMaLop", "sTenLop");
            sql = "select sTenMonHoc, sMaMonHoc from tblMonHoc";
            Functions.fillCombo(sql, cboMaMH, "sMaMonHoc", "sTenMonHoc");
            loadDataGridView();
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
            dgvBangDiemMH.DataSource = tblBangDiem;
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
            dgvBangDiemMH.Columns[1].Width = 150;
            dgvBangDiemMH.Columns[2].Width = 100;
            dgvBangDiemMH.Columns[3].Width = 100;
            dgvBangDiemMH.Columns[4].Width = 100;
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
            dgvBangDiemMH.DataSource = tblBangDiem;
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
            dgvBangDiemMH.Columns[1].Width = 150;
            dgvBangDiemMH.Columns[2].Width = 100;
            dgvBangDiemMH.Columns[3].Width = 100;
            dgvBangDiemMH.Columns[4].Width = 100;
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
    }
}
