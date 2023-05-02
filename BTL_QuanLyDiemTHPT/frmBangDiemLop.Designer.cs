
namespace BTL_QuanLyDiemTHPT
{
    partial class frmBangDiemLop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.txtDiemHocKi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiem45Phut = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiem15Phut = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXetHocLuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemTrungBinh = new System.Windows.Forms.TextBox();
            this.cboMaHS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBangDiemMH = new System.Windows.Forms.DataGridView();
            this.btnHienDS = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemMH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaGV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNamHoc);
            this.groupBox1.Controls.Add(this.cboMaMH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboMaLop);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(35, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp, môn ";
            // 
            // cboMaMH
            // 
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(160, 98);
            this.cboMaMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(164, 24);
            this.cboMaMH.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Mã môn học:";
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(160, 36);
            this.cboMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(164, 24);
            this.cboMaLop.TabIndex = 100;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 99;
            this.label10.Text = "Mã lớp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboMaHS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtXetHocLuc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDiemTrungBinh);
            this.groupBox2.Controls.Add(this.txtDiemHocKi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDiem45Phut);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtDiem15Phut);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(35, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin điểm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 105;
            this.label8.Text = "Học kì:";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(500, 97);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(129, 22);
            this.txtHocKy.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 103;
            this.label7.Text = "Năm học:";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(500, 35);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(129, 22);
            this.txtNamHoc.TabIndex = 104;
            // 
            // txtDiemHocKi
            // 
            this.txtDiemHocKi.Location = new System.Drawing.Point(500, 34);
            this.txtDiemHocKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiemHocKi.Name = "txtDiemHocKi";
            this.txtDiemHocKi.Size = new System.Drawing.Size(142, 22);
            this.txtDiemHocKi.TabIndex = 78;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(367, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 77;
            this.label14.Text = "Điểm học kì:";
            // 
            // txtDiem45Phut
            // 
            this.txtDiem45Phut.Location = new System.Drawing.Point(138, 97);
            this.txtDiem45Phut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiem45Phut.Name = "txtDiem45Phut";
            this.txtDiem45Phut.Size = new System.Drawing.Size(139, 22);
            this.txtDiem45Phut.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 75;
            this.label13.Text = "Điểm 45\':";
            // 
            // txtDiem15Phut
            // 
            this.txtDiem15Phut.Location = new System.Drawing.Point(790, 36);
            this.txtDiem15Phut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiem15Phut.Name = "txtDiem15Phut";
            this.txtDiem15Phut.Size = new System.Drawing.Size(139, 22);
            this.txtDiem15Phut.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(679, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 73;
            this.label11.Text = "Điểm 15\':";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 112;
            this.label9.Text = "Xếp loại:";
            // 
            // txtXetHocLuc
            // 
            this.txtXetHocLuc.Location = new System.Drawing.Point(790, 99);
            this.txtXetHocLuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXetHocLuc.Name = "txtXetHocLuc";
            this.txtXetHocLuc.Size = new System.Drawing.Size(129, 22);
            this.txtXetHocLuc.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 110;
            this.label6.Text = "Điểm trung bình:";
            // 
            // txtDiemTrungBinh
            // 
            this.txtDiemTrungBinh.Location = new System.Drawing.Point(500, 97);
            this.txtDiemTrungBinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            this.txtDiemTrungBinh.Size = new System.Drawing.Size(129, 22);
            this.txtDiemTrungBinh.TabIndex = 111;
            // 
            // cboMaHS
            // 
            this.cboMaHS.FormattingEnabled = true;
            this.cboMaHS.Location = new System.Drawing.Point(138, 34);
            this.cboMaHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaHS.Name = "cboMaHS";
            this.cboMaHS.Size = new System.Drawing.Size(164, 24);
            this.cboMaHS.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 114;
            this.label3.Text = "Mã học sinh:";
            // 
            // dgvBangDiemMH
            // 
            this.dgvBangDiemMH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBangDiemMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiemMH.Location = new System.Drawing.Point(35, 375);
            this.dgvBangDiemMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBangDiemMH.Name = "dgvBangDiemMH";
            this.dgvBangDiemMH.RowHeadersWidth = 51;
            this.dgvBangDiemMH.RowTemplate.Height = 24;
            this.dgvBangDiemMH.Size = new System.Drawing.Size(959, 296);
            this.dgvBangDiemMH.TabIndex = 86;
            // 
            // btnHienDS
            // 
            this.btnHienDS.Location = new System.Drawing.Point(611, 706);
            this.btnHienDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienDS.Name = "btnHienDS";
            this.btnHienDS.Size = new System.Drawing.Size(138, 45);
            this.btnHienDS.TabIndex = 112;
            this.btnHienDS.Text = "Hiện danh sách";
            this.btnHienDS.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(919, 706);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 45);
            this.btnDong.TabIndex = 111;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(809, 706);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 45);
            this.btnBoQua.TabIndex = 110;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(474, 706);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 45);
            this.btnLuu.TabIndex = 109;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(319, 706);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 45);
            this.btnSua.TabIndex = 108;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(165, 706);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 107;
            this.btnXoa.Text = "Xoá ";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 706);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 106;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // cboMaGV
            // 
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(793, 35);
            this.cboMaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(164, 24);
            this.cboMaGV.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 107;
            this.label4.Text = "Mã giáo viên:";
            // 
            // frmBangDiemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 776);
            this.Controls.Add(this.btnHienDS);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvBangDiemMH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBangDiemLop";
            this.Text = "Quản lý điểm theo lớp";
            this.Load += new System.EventHandler(this.frmBangDiemLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.TextBox txtDiemHocKi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiem45Phut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiem15Phut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXetHocLuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemTrungBinh;
        private System.Windows.Forms.ComboBox cboMaHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBangDiemMH;
        private System.Windows.Forms.Button btnHienDS;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.Label label4;
    }
}