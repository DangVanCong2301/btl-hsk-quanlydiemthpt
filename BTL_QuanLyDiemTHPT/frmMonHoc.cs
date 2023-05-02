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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            txtMaMH.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            loadDataGridView();
        }

        DataTable tblMonHoc;
        private void loadDataGridView()
        {
            string sql = "select * from tblMonHoc";
            tblMonHoc = Functions.getDataToTable(sql);
            dgvMonHoc.DataSource = tblMonHoc;
            dgvMonHoc.Columns[0].HeaderText = "Mã môn học";
            dgvMonHoc.Columns[1].HeaderText = "Tên môn học";
            dgvMonHoc.Columns[0].Width = 100;
            dgvMonHoc.Columns[1].Width = 150;
            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvMonHoc_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMH.Focus();
                return;
            }
            if (tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaMH.Text = dgvMonHoc.CurrentRow.Cells["sMaMonHoc"].Value.ToString();
            txtTenMonHoc.Text = dgvMonHoc.CurrentRow.Cells["sTenMon"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            resetValues();
            txtMaMH.Enabled = true;
            txtMaMH.Focus();
        }

        private void resetValues()
        {
            txtMaMH.Text = "";
            txtTenMonHoc.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            loadDataGridView();
            resetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaMH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaMH.Text.Trim();
            string ten = txtTenMonHoc.Text.Trim();
            if (tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            loadDataGridView();
            resetValues();
            btnBoQua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaMH.Text.Trim();
            if (tblMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá bản ghi này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loadDataGridView();
                resetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaMH.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaMH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
