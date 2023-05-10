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

namespace BTL_QuanLyDiemTHPT
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            txtMaGiaoVien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            loadDataGridView();
        }

        DataTable tblGiaoVien;
        private void loadDataGridView()
        {
            string sql = "select * from tblGiaoVien";
            tblGiaoVien = Function.Functions.getDataToTable(sql);
            tblGiaoVien.Columns.Add("STT");
            for (int i = 0; i < tblGiaoVien.Rows.Count; i++)
            {
                tblGiaoVien.Rows[i]["STT"] = i + 1;
                dgvGiaoVien.DataSource = tblGiaoVien;
                dgvGiaoVien.Columns["STT"].DisplayIndex = 0;
                dgvGiaoVien.Columns[0].HeaderText = "Mã giáo viên";
                dgvGiaoVien.Columns[1].HeaderText = "Tên giáo viên";
                dgvGiaoVien.Columns[2].HeaderText = "Giới tính";
                dgvGiaoVien.Columns[3].HeaderText = "Ngày sinh";
                dgvGiaoVien.Columns[4].HeaderText = "Quê quán";
                dgvGiaoVien.Columns[0].Width = 100;
                dgvGiaoVien.Columns[1].Width = 100;
                dgvGiaoVien.Columns[2].Width = 100;
                dgvGiaoVien.Columns[3].Width = 80;
                dgvGiaoVien.Columns[4].Width = 200;
                dgvGiaoVien.AllowUserToAddRows = false;
                dgvGiaoVien.EditMode = DataGridViewEditMode.EditProgrammatically;

            }
        }

        private void dgvGiaoVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiaoVien.Focus();
                return;
            }
            if (tblGiaoVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells["sMaGiaoVien"].Value.ToString();
            txtHoTen.Text = dgvGiaoVien.CurrentRow.Cells["sTenGiaoVien"].Value.ToString();
            if (dgvGiaoVien.CurrentRow.Cells["sGioiTinh"].Value.ToString() == "Nam")
            {
                chkGioiTinh.Checked = true;
            } else
            {
                chkGioiTinh.Checked = false;
            }
            dtpNgaySinh.Text = dgvGiaoVien.CurrentRow.Cells["dNgaySinh"].Value.ToString();
            txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells["sQueQuan"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            resetValue();
            txtMaGiaoVien.Enabled = true;
            txtMaGiaoVien.Focus();
        }

        private void resetValue()
        {
            txtMaGiaoVien.Text = "";
            txtHoTen.Text = "";
            chkGioiTinh.Checked = false;
            txtDiaChi.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaGiaoVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiaoVien.Focus();
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
            {
                gt = "Nam";
            } else
            {
                gt = "Nữ";
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            DateTime ngaySinh = Convert.ToDateTime(dtpNgaySinh.Value);
            DateTime ngayHienTai = Convert.ToDateTime("4/5/2023");
            TimeSpan time = ngayHienTai - ngaySinh;
            int soNgay = time.Days;
            if ((soNgay / 365) < 18)
            {
                MessageBox.Show("Giáo viên này chưa đủ 18 tuổi hoặc sai năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgaySinh.Focus();
                return;
            }
            sql = "select sMaGiaoVien from tblGiaoVien where sMaGiaoVien = N'" + txtMaGiaoVien.Text + "'";
            if (Function.Functions.checkKey(sql))
            {
                MessageBox.Show("Mã này đã tồn tại, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiaoVien.Focus();
                txtMaGiaoVien.Text = "";
                return;
            }
            sql = "set dateformat dmy insert into tblGiaoVien(sMaGiaoVien, sTenGiaoVien, sGioiTinh, dNgaySinh, sQueQuan) values (N'" + txtMaGiaoVien.Text.Trim() + "', N'" + txtHoTen.Text.Trim() + "', N'" + gt + "', '" + dtpNgaySinh.Text + "', N'" + txtDiaChi.Text.Trim() + "')";
            Function.Functions.runSql(sql);
            loadDataGridView();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaGiaoVien.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblGiaoVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGiaoVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGiaoVien.Focus();
                return;
            }
            if (chkGioiTinh.Checked == true)
            {
                gt = "Nam";
            } else
            {
                gt = "Nữ";
            }
            sql = "update tblGiaoVien set sTenGiaoVien = N'" + txtHoTen.Text.Trim().ToString() + "', sGioiTinh = N'" + gt + "', dNgaySinh = '" + dtpNgaySinh.Text + "', sQueQuan = N'" + txtDiaChi.Text.Trim().ToString() + "' where sMaGiaoVien = N'" + txtMaGiaoVien.Text.Trim().ToString() + "'";
            Function.Functions.runSql(sql);
            loadDataGridView();
            resetValue();
            btnBoQua.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (tblGiaoVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Có " + tblGiaoVien.Rows.Count + " bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvGiaoVien.DataSource = tblGiaoVien;
                dgvGiaoVien.Columns[0].HeaderText = "Mã giáo viên";
                dgvGiaoVien.Columns[1].HeaderText = "Tên giáo viên";
                dgvGiaoVien.Columns[2].HeaderText = "Giới tính";
                dgvGiaoVien.Columns[3].HeaderText = "Ngày sinh";
                dgvGiaoVien.Columns[4].HeaderText = "Quê quán";
                dgvGiaoVien.Columns[0].Width = 100;
                dgvGiaoVien.Columns[1].Width = 100;
                dgvGiaoVien.Columns[2].Width = 80;
                dgvGiaoVien.Columns[3].Width = 80;
                dgvGiaoVien.Columns[4].Width = 150;
                dgvGiaoVien.AllowUserToAddRows = false;
                dgvGiaoVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }

        private void btnHienDS_Click(object sender, EventArgs e)
        {
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblGiaoVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            if (txtMaGiaoVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "select sMaGiaoVien from tblLop where sMaGiaoVien = N'" + txtMaGiaoVien.Text.Trim() + "'";
                if (Function.Functions.checkKey(sql))
                {
                    MessageBox.Show("Giáo viên này đang ràng buộc, bạn không thể xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql = "select sMaGiaoVien from tblBangDiem where sMaGiaoVien = N'" + txtMaGiaoVien.Text.Trim() + "'";
                if (Function.Functions.checkKey(sql))
                {
                    MessageBox.Show("Giáo viên này đang ràng buộc, bạn không thể xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql = "delete tblGiaoVien where sMaGiaoVien = N'" + txtMaGiaoVien.Text + "'";
                Function.Functions.runSql(sql);
                loadDataGridView();
                resetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaGiaoVien.Enabled = false;
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            string proc = "timKiemGV";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@TuKhoa", txtTuKhoa.Text.Trim());
            tblGiaoVien = Function.Functions.timKiem(proc, cmd);
            dgvGiaoVien.DataSource = tblGiaoVien;
            tblGiaoVien.Columns.Add("STT");
            for (int i = 0; i < tblGiaoVien.Rows.Count; i++)
            {
                tblGiaoVien.Rows[i]["STT"] = i + 1;
                dgvGiaoVien.DataSource = tblGiaoVien;
                dgvGiaoVien.Columns["STT"].DisplayIndex = 0;
                dgvGiaoVien.Columns[0].HeaderText = "Mã giáo viên";
                dgvGiaoVien.Columns[1].HeaderText = "Tên giáo viên";
                dgvGiaoVien.Columns[2].HeaderText = "Giới tính";
                dgvGiaoVien.Columns[3].HeaderText = "Ngày sinh";
                dgvGiaoVien.Columns[4].HeaderText = "Quê quán";
                dgvGiaoVien.Columns[0].Width = 100;
                dgvGiaoVien.Columns[1].Width = 100;
                dgvGiaoVien.Columns[2].Width = 100;
                dgvGiaoVien.Columns[3].Width = 80;
                dgvGiaoVien.Columns[4].Width = 200;
                dgvGiaoVien.AllowUserToAddRows = false;
                dgvGiaoVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }
    }
}
