
namespace BTL_QuanLyDiemTHPT.BaoCao
{
    partial class frmKhoangDiem
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
            this.rptKhoangDiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemCuoi = new System.Windows.Forms.TextBox();
            this.txtDiemDau = new System.Windows.Forms.TextBox();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rptKhoangDiem
            // 
            this.rptKhoangDiem.ActiveViewIndex = -1;
            this.rptKhoangDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptKhoangDiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptKhoangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptKhoangDiem.Location = new System.Drawing.Point(0, 0);
            this.rptKhoangDiem.Name = "rptKhoangDiem";
            this.rptKhoangDiem.Size = new System.Drawing.Size(800, 450);
            this.rptKhoangDiem.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(36, 318);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 41);
            this.btnIn.TabIndex = 24;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "đến";
            // 
            // txtDiemCuoi
            // 
            this.txtDiemCuoi.Location = new System.Drawing.Point(121, 260);
            this.txtDiemCuoi.Name = "txtDiemCuoi";
            this.txtDiemCuoi.Size = new System.Drawing.Size(36, 22);
            this.txtDiemCuoi.TabIndex = 22;
            // 
            // txtDiemDau
            // 
            this.txtDiemDau.Location = new System.Drawing.Point(33, 260);
            this.txtDiemDau.Name = "txtDiemDau";
            this.txtDiemDau.Size = new System.Drawing.Size(36, 22);
            this.txtDiemDau.TabIndex = 21;
            // 
            // cboMon
            // 
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(36, 208);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(121, 24);
            this.cboMon.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhập tên môn:";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(33, 129);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(112, 24);
            this.cboLop.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhập tên lớp:";
            // 
            // frmKhoangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiemCuoi);
            this.Controls.Add(this.txtDiemDau);
            this.Controls.Add(this.cboMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptKhoangDiem);
            this.Name = "frmKhoangDiem";
            this.Text = "frmKhoangDiem";
            this.Load += new System.EventHandler(this.frmKhoangDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptKhoangDiem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemCuoi;
        private System.Windows.Forms.TextBox txtDiemDau;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label1;
    }
}