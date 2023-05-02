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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            List<String> lskLoaiTK = new List<string>() { "user", "admin" };
            cboLoaiTK.DataSource = lskLoaiTK;
            loadDataGridView();
        }

        DataTable tblTaiKhoan;
        private void loadDataGridView()
        {
            string sql = "select * from tblTaiKhoan";
            tblTaiKhoan = Functions.getDataToTable(sql);
            tblTaiKhoan.Columns.Add("STT");
            for (int i = 0; i < tblTaiKhoan.Rows.Count; i++)
            {
                tblTaiKhoan.Rows[i]["STT"] = i + 1; // format code: ctrl + K, ctrl + F
                dgvTaiKhoan.DataSource = tblTaiKhoan;
                dgvTaiKhoan.Columns["STT"].DisplayIndex = 0;
                dgvTaiKhoan.Columns[0].HeaderText = "Id";
                dgvTaiKhoan.Columns[1].HeaderText = "Tên tài khoản";
                dgvTaiKhoan.Columns[2].HeaderText = "Email";
                dgvTaiKhoan.Columns[3].HeaderText = "Loại tài khoản";
                dgvTaiKhoan.Columns[4].HeaderText = "Mật khẩu";
                dgvTaiKhoan.Columns[0].Width = 40;
                dgvTaiKhoan.Columns[1].Width = 100;
                dgvTaiKhoan.Columns[2].Width = 200;
                dgvTaiKhoan.Columns[3].Width = 150;
                dgvTaiKhoan.Columns[4].Width = 100;
                dgvTaiKhoan.AllowUserToAddRows = false;
                dgvTaiKhoan.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txtEmail.Focus();
            resetValues();
        }

        private void resetValues()
        {
            txtEmail.Text = "";
            txtTenTK.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn chưa nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex rg = new Regex(match);
            if(!rg.IsMatch(this.txtEmail.Text))
            {
                MessageBox.Show("Email này không hợp lệ, bạn phải nhập email khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }
            if (txtTenTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            string sql = "select * from tblTaiKhoan where sEmail = N'" + txtEmail.Text.Trim() + "'";
            if(Functions.checkKey(sql))
            {
                MessageBox.Show("Email này đã tồn tại, bạn phải nhập email khac!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }
            sql = "insert into tblTaiKhoan (sEmail, sTenTaiKhoan, sLoaiTaiKhoan, sMatKhau) values (N'" + txtEmail.Text.Trim() + "', N'" + txtTenTK.Text.Trim() + "', '" + cboLoaiTK.SelectedValue + "', '" + txtMatKhau.Text.Trim() + "')";
            Functions.runSql(sql);
            loadDataGridView();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
        }
    }
}
