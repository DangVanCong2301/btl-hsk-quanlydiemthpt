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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void mnuGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien f = new frmGiaoVien();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc f = new frmMonHoc();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh f = new frmHocSinh();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuBangDiem_Click(object sender, EventArgs e)
        {
            frmBangDiem f = new frmBangDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuHocSinh_Lop_Click(object sender, EventArgs e)
        {
            frmHocSinh_Lop f = new frmHocSinh_Lop();
            f.MdiParent = this;
            f.Show();
        }

        private void iinBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuDSThi_Click(object sender, EventArgs e)
        {
            BaoCao.frmDSThi f = new BaoCao.frmDSThi();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuInDSHSLuuBan_Click(object sender, EventArgs e)
        {
            BaoCao.frmDSLuuBan f = new BaoCao.frmDSLuuBan();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuDSDiemHS_Click(object sender, EventArgs e)
        {
            BaoCao.frmDSDiemHS f = new BaoCao.frmDSDiemHS();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuDSDiemTrongKhoang_Click(object sender, EventArgs e)
        {
            BaoCao.frmKhoangDiem f = new BaoCao.frmKhoangDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuThangNamNhap_Click(object sender, EventArgs e)
        {
            BaoCao.frmNgayTrongKhoang f = new BaoCao.frmNgayTrongKhoang();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuDSBangDiemLop_Click(object sender, EventArgs e)
        {
            BaoCao.frmDSBangDiemLop f = new BaoCao.frmDSBangDiemLop();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuTheoLop_Click(object sender, EventArgs e)
        {
            frmBangDiemLop f = new frmBangDiemLop();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan f = new frmTaiKhoan();
            f.MdiParent = this;
            f.Show();
        }
    }
}
