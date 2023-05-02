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
    public partial class frmHocSinh_Lop : Form
    {
        public frmHocSinh_Lop()
        {
            InitializeComponent();
        }

        DataTable tblHocSinh_Lop;
        private void frmHocSinh_Lop_Load(object sender, EventArgs e)
        {
            cboMaHS.Enabled = false;
            cboMaLop.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            string sql = "select tblHocSinh.sHoTen, tblLop.sTenLop " 
                       + "from tblHocSinh_tblLop inner join tblHocSinh on tblHocSinh_tblLop.sMaHocSinh = tblHocSinh.sMaHocSinh "
                       + "inner join tblLop on tblHocSinh_tblLop.sMaLop = tblLop.sMaLop";
            tblHocSinh_Lop = Functions.getDataToTable(sql);
            dgvHocSinh_Lop.DataSource = tblHocSinh_Lop;
            dgvHocSinh_Lop.Columns[0].HeaderText = "Tên học sinh";
            dgvHocSinh_Lop.Columns[1].HeaderText = "Tên lớp";
            dgvHocSinh_Lop.Columns[0].Width = 120;
            dgvHocSinh_Lop.Columns[1].Width = 100;
            dgvHocSinh_Lop.AllowUserToAddRows = false;
            dgvHocSinh_Lop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboMaHS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
