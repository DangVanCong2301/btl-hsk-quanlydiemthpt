using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyDiemTHPT.Function;

namespace BTL_QuanLyDiemTHPT
{
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }

        DataTable tblHocSinh;
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            txtMaHS.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            string sql = "select sMaLop, sTenLop from tblLop";
            Function.Functions.fillCombo(sql, cboLop, "sMaLop", "sTenLop");
            loadDataGridView();
            Console.WriteLine(dtpNgaySinh.Value.Year);
        }

        private void loadDataGridView()
        {
            string sql = "select  tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen, tblHocSinh.sGioiTinh, tblHocSinh.dNgaySinh, tblHocSinh.sQueQuan from tblHocSinh_tblLop "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "where tblLop.sMaLop = N'" + cboLop.SelectedValue + "'";
            tblHocSinh = Functions.getDataToTable(sql);
            dgvHocSinh.DataSource = tblHocSinh;
            dgvHocSinh.Columns[0].HeaderText = "Mã học sinh";
            dgvHocSinh.Columns[1].HeaderText = "Họ tên";
            dgvHocSinh.Columns[2].HeaderText = "Giới tính";
            dgvHocSinh.Columns[3].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns[4].HeaderText = "Quê quán";
            dgvHocSinh.Columns[0].Width = 100;
            dgvHocSinh.Columns[1].Width = 150;
            dgvHocSinh.Columns[2].Width = 100;
            dgvHocSinh.Columns[3].Width = 80;
            dgvHocSinh.Columns[4].Width = 200;
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHS.Enabled = true;
            txtMaHS.Focus();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            resetValues();
        }

        private void resetValues()
        {
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            chkGioiTinh.Checked = false;
            txtQueQuan.Text = "";
            // dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            string match = "^[a-zA-Z0-9 ]*$";
            Regex rg = new Regex(match);
            if (!rg.IsMatch(this.txtMaHS.Text))
            {
                MessageBox.Show("Mã học sinh không được có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHS.Text = "";
                txtMaHS.Focus();
                return;
            }
            if (txtMaHS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHS.Focus();
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            sql = "select sMaHocSinh from tblHocSinh where sMaHocSinh = N'" + txtMaHS.Text + "'";
            if (Functions.checkKey(sql))
            {
                MessageBox.Show("Mã học sinh này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHS.Focus();
                txtMaHS.Text = "";
                return;
            }
            sql = "set dateformat dmy insert into tblHocSinh(sMaHocSinh, sHoTen, sGioiTinh, dNgaySinh, sQueQuan) values (N'" + txtMaHS.Text.Trim() + "', N'" + txtHoTen.Text.Trim() + "', N'" + gt + "', '" + dtpNgaySinh.Text + "', N'" + txtQueQuan.Text.Trim() + "')";
            Functions.runSql(sql);
            sql = "insert into tblHocSinh_tblLop (sMaHocSinh, sMaLop) values (N'" + txtMaHS.Text.Trim() + "', N'" + cboLop.SelectedValue + "')";
            Functions.runSql(sql);
            sql = "select count(tblHocSinh.sMaHocSinh) from tblHocSinh_tblLop "
                + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                + "inner join tblGiaoVien on tblGiaoVien.sMaGiaoVien = tblLop.sMaGiaoVien "
                +" where tblLop.sMaLop = '" + cboLop.SelectedValue + "'";
            int soLuongHS = Convert.ToInt32(Functions.getFileValues(sql));
            sql = "update tblLop set iSoLuongHocSinh = " + soLuongHS + " where sMaLop = '" + cboLop.SelectedValue + "'";
            Functions.runSql(sql);
            loadDataGridView();
            resetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHS.Enabled = false;
        }

        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvHocSinh_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHS.Focus();
                return;
            }
            if (tblHocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHS.Text = dgvHocSinh.CurrentRow.Cells["sMaHocSinh"].Value.ToString();
            txtHoTen.Text = dgvHocSinh.CurrentRow.Cells["sHoTen"].Value.ToString();
            if (dgvHocSinh.CurrentRow.Cells["sGioiTinh"].Value.ToString() == "Nam")
            {
                chkGioiTinh.Checked = true;
            }
            else
            {
                chkGioiTinh.Checked = false;
            }
            dtpNgaySinh.Text = dgvHocSinh.CurrentRow.Cells["dNgaySinh"].Value.ToString();
            txtQueQuan.Text = dgvHocSinh.CurrentRow.Cells["sQueQuan"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select  tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen, tblHocSinh.sGioiTinh, tblHocSinh.dNgaySinh, tblHocSinh.sQueQuan from tblHocSinh_tblLop "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "where tblLop.sMaLop = N'" + cboLop.SelectedValue + "'";
            tblHocSinh = Functions.getDataToTable(sql);
            dgvHocSinh.DataSource = tblHocSinh;
            dgvHocSinh.Columns[0].HeaderText = "Mã học sinh";
            dgvHocSinh.Columns[1].HeaderText = "Họ tên";
            dgvHocSinh.Columns[2].HeaderText = "Giới tính";
            dgvHocSinh.Columns[3].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns[4].HeaderText = "Quê quán";
            dgvHocSinh.Columns[0].Width = 100;
            dgvHocSinh.Columns[1].Width = 150;
            dgvHocSinh.Columns[2].Width = 100;
            dgvHocSinh.Columns[3].Width = 80;
            dgvHocSinh.Columns[4].Width = 200;
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblHocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHS.Focus();
                return;
            }
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá bản ghi ngày không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "select * from tblHocSinh_Lop where sMaHocSinh = N'" + txtMaHS.Text.Trim() + "'";
                if (Functions.checkKey(sql))
                {
                    MessageBox.Show("Mã học sinh này đang bị ràng buộc, bạn không thể xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql = "delete tblHocSinh_tblLop where sMaHocSinh = N'" + txtMaHS.Text.Trim() + "' and sMaLop = N'" + cboLop.SelectedValue + "'";
                Functions.runSqlDel(sql);
                sql = "delete tblHocSinh where sMaHocSinh = N'" + txtMaHS.Text.Trim() + "'";
                Functions.runSqlDel(sql);
                sql = "select count(tblHocSinh.sMaHocSinh) from tblHocSinh_tblLop "
                + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                + "inner join tblGiaoVien on tblGiaoVien.sMaGiaoVien = tblLop.sMaGiaoVien "
                + " where tblLop.sMaLop = '" + cboLop.SelectedValue + "'";
                int soLuongHS = Convert.ToInt32(Functions.getFileValues(sql));
                sql = "update tblLop set iSoLuongHocSinh = " + soLuongHS + " where sMaLop = '" + cboLop.SelectedValue + "'";
                Functions.runSql(sql);
                loadDataGridView();
                resetValues();
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
            txtMaHS.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtMaHS.Text == "" && txtHoTen.Text == "" && txtQueQuan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "select  tblHocSinh.sMaHocSinh, tblHocSinh.sHoTen, tblHocSinh.sGioiTinh, tblHocSinh.dNgaySinh, tblHocSinh.sQueQuan from tblHocSinh_tblLop "
                       + "inner join tblLop on tblLop.sMaLop = tblHocSinh_tblLop.sMaLop "
                       + "inner join tblHocSinh on tblHocSinh.sMaHocSinh = tblHocSinh_tblLop.sMaHocSinh "
                       + "where 1=1 and tblLop.sMaLop = N'" + cboLop.SelectedValue + "' ";
            if (txtMaHS.Text != "")
            {
                sql += "and sMaHocSinh like N'%" + txtMaHS.Text.Trim() + "%'";
            }
            if (txtHoTen.Text != "")
            {
                sql += "and sHoTen like N'%" + txtHoTen.Text.Trim() + "%'";
            }
            if (txtQueQuan.Text != "")
            {
                sql += "and sQueQuan like N'%" + txtQueQuan.Text.Trim() + "%'";
            }
            tblHocSinh = Functions.getDataToTable(sql);
            if (tblHocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else
            {
                MessageBox.Show("Có " + tblHocSinh.Rows.Count + " bản ghi thoả mã điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHocSinh.DataSource = tblHocSinh;
                dgvHocSinh.Columns[0].HeaderText = "Mã học sinh";
                dgvHocSinh.Columns[1].HeaderText = "Họ tên";
                dgvHocSinh.Columns[2].HeaderText = "Giới tính";
                dgvHocSinh.Columns[3].HeaderText = "Ngày sinh";
                dgvHocSinh.Columns[4].HeaderText = "Quê quán";
                dgvHocSinh.Columns[0].Width = 100;
                dgvHocSinh.Columns[1].Width = 150;
                dgvHocSinh.Columns[2].Width = 100;
                dgvHocSinh.Columns[3].Width = 80;
                dgvHocSinh.Columns[4].Width = 200;
                dgvHocSinh.AllowUserToAddRows = false;
                dgvHocSinh.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        private void btnHienThiDS_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void txtMaHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '%')
            {
                e.Handled = true;
            } else
            {
                e.Handled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblHocSinh set sHoTen = N'" + txtHoTen.Text.Trim() + "', sGioiTinh";
        }
    }
}
