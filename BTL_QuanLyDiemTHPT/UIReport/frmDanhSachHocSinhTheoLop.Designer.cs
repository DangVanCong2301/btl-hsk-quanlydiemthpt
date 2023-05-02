
namespace BTL_QuanLyDiemTHPT.UIReport
{
    partial class frmDanhSachHocSinhTheoLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptDanhSachHocSinh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptDanhSachHocSinh
            // 
            this.rptDanhSachHocSinh.ActiveViewIndex = -1;
            this.rptDanhSachHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptDanhSachHocSinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptDanhSachHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptDanhSachHocSinh.Location = new System.Drawing.Point(0, 0);
            this.rptDanhSachHocSinh.Name = "rptDanhSachHocSinh";
            this.rptDanhSachHocSinh.Size = new System.Drawing.Size(800, 450);
            this.rptDanhSachHocSinh.TabIndex = 0;
            // 
            // frmDanhSachHocSinhTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptDanhSachHocSinh);
            this.Name = "frmDanhSachHocSinhTheoLop";
            this.Text = "Danh sách học sinh theo lớp";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptDanhSachHocSinh;
    }
}