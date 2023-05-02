
namespace BTL_QuanLyDiemTHPT
{
    partial class frmMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTepTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBangDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.iinBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSThi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSBangDiemLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInDSHSLuuBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSDiemHS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSDiemTrongKhoang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThangNamNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheoLop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTepTin,
            this.mnuDanhMuc,
            this.iinBáoCáoToolStripMenuItem,
            this.quảnLýĐiểmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1332, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTepTin
            // 
            this.mnuTepTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuTepTin.Name = "mnuTepTin";
            this.mnuTepTin.Size = new System.Drawing.Size(69, 24);
            this.mnuTepTin.Text = "Tệp tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(130, 26);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGiaoVien,
            this.mnuMonHoc,
            this.mnuLop,
            this.mnuHocSinh,
            this.mnuBangDiem,
            this.mnuTaiKhoan});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuGiaoVien
            // 
            this.mnuGiaoVien.Name = "mnuGiaoVien";
            this.mnuGiaoVien.Size = new System.Drawing.Size(164, 26);
            this.mnuGiaoVien.Text = "Giáo Viên";
            this.mnuGiaoVien.Click += new System.EventHandler(this.mnuGiaoVien_Click);
            // 
            // mnuMonHoc
            // 
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(164, 26);
            this.mnuMonHoc.Text = "Môn học";
            this.mnuMonHoc.Click += new System.EventHandler(this.mnuMonHoc_Click);
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(164, 26);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuHocSinh
            // 
            this.mnuHocSinh.Name = "mnuHocSinh";
            this.mnuHocSinh.Size = new System.Drawing.Size(164, 26);
            this.mnuHocSinh.Text = "Học sinh";
            this.mnuHocSinh.Click += new System.EventHandler(this.mnuHocSinh_Click);
            // 
            // mnuBangDiem
            // 
            this.mnuBangDiem.Name = "mnuBangDiem";
            this.mnuBangDiem.Size = new System.Drawing.Size(164, 26);
            this.mnuBangDiem.Text = "Bảng điểm";
            this.mnuBangDiem.Click += new System.EventHandler(this.mnuBangDiem_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(164, 26);
            this.mnuTaiKhoan.Text = "Tài khoản";
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // iinBáoCáoToolStripMenuItem
            // 
            this.iinBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSThi,
            this.mnuDSBangDiemLop,
            this.mnuInDSHSLuuBan,
            this.mnuDSDiemHS,
            this.mnuDSDiemTrongKhoang,
            this.mnuThangNamNhap});
            this.iinBáoCáoToolStripMenuItem.Name = "iinBáoCáoToolStripMenuItem";
            this.iinBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.iinBáoCáoToolStripMenuItem.Text = "In báo cáo";
            this.iinBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.iinBáoCáoToolStripMenuItem_Click);
            // 
            // mnuDSThi
            // 
            this.mnuDSThi.Name = "mnuDSThi";
            this.mnuDSThi.Size = new System.Drawing.Size(412, 26);
            this.mnuDSThi.Text = "Danh sách thi";
            this.mnuDSThi.Click += new System.EventHandler(this.mnuDSThi_Click);
            // 
            // mnuDSBangDiemLop
            // 
            this.mnuDSBangDiemLop.Name = "mnuDSBangDiemLop";
            this.mnuDSBangDiemLop.Size = new System.Drawing.Size(412, 26);
            this.mnuDSBangDiemLop.Text = "Danh sách bảng điểm theo lớp";
            this.mnuDSBangDiemLop.Click += new System.EventHandler(this.mnuDSBangDiemLop_Click);
            // 
            // mnuInDSHSLuuBan
            // 
            this.mnuInDSHSLuuBan.Name = "mnuInDSHSLuuBan";
            this.mnuInDSHSLuuBan.Size = new System.Drawing.Size(412, 26);
            this.mnuInDSHSLuuBan.Text = "Danh sách bị cảnh báo học tập";
            this.mnuInDSHSLuuBan.Click += new System.EventHandler(this.mnuInDSHSLuuBan_Click);
            // 
            // mnuDSDiemHS
            // 
            this.mnuDSDiemHS.Name = "mnuDSDiemHS";
            this.mnuDSDiemHS.Size = new System.Drawing.Size(412, 26);
            this.mnuDSDiemHS.Text = "Danh sách điểm từng môn của học sinh theo lớp";
            this.mnuDSDiemHS.Click += new System.EventHandler(this.mnuDSDiemHS_Click);
            // 
            // mnuDSDiemTrongKhoang
            // 
            this.mnuDSDiemTrongKhoang.Name = "mnuDSDiemTrongKhoang";
            this.mnuDSDiemTrongKhoang.Size = new System.Drawing.Size(412, 26);
            this.mnuDSDiemTrongKhoang.Text = "Danh sách điềm học sinh trong khoảng nào đó";
            this.mnuDSDiemTrongKhoang.Click += new System.EventHandler(this.mnuDSDiemTrongKhoang_Click);
            // 
            // mnuThangNamNhap
            // 
            this.mnuThangNamNhap.Name = "mnuThangNamNhap";
            this.mnuThangNamNhap.Size = new System.Drawing.Size(412, 26);
            this.mnuThangNamNhap.Text = "Danh sách điểm học sinh tháng năm nhập";
            this.mnuThangNamNhap.Click += new System.EventHandler(this.mnuThangNamNhap_Click);
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            this.quảnLýĐiểmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTheoLop});
            this.quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            this.quảnLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.quảnLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
            // 
            // mnuTheoLop
            // 
            this.mnuTheoLop.Name = "mnuTheoLop";
            this.mnuTheoLop.Size = new System.Drawing.Size(151, 26);
            this.mnuTheoLop.Text = "Theo lớp";
            this.mnuTheoLop.Click += new System.EventHandler(this.mnuTheoLop_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1332, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 855);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1332, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 20);
            this.toolStripStatusLabel1.Text = "Đã sẵn sàng";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1332, 881);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản ý điểm học sinh THPT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTepTin;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaoVien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuBangDiem;
        private System.Windows.Forms.ToolStripMenuItem iinBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDSThi;
        private System.Windows.Forms.ToolStripMenuItem mnuDSBangDiemLop;
        private System.Windows.Forms.ToolStripMenuItem mnuInDSHSLuuBan;
        private System.Windows.Forms.ToolStripMenuItem mnuDSDiemHS;
        private System.Windows.Forms.ToolStripMenuItem mnuDSDiemTrongKhoang;
        private System.Windows.Forms.ToolStripMenuItem mnuThangNamNhap;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTheoLop;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
    }
}

