using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyDiemTHPT
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        DataTable tblTaiKhoan;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            string sql = "select * from tblTaiKhoan where sTenTaiKhoan = N'" + txtTenTK.Text.Trim() + "' and sMatKhau = '" + txtMatKhau.Text.Trim() + "'";
            tblTaiKhoan = Function.Functions.getDataToTable(sql);
            if(tblTaiKhoan.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMainForm f = new frmMainForm();
                f.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void lblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau f = new frmQuenMatKhau();
            f.ShowDialog();
        }
    }
}
