
namespace BTL_QuanLyDiemTHPT.BaoCao
{
    partial class frmDSLuuBan
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
            this.rptLuuBan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhoi = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptLuuBan
            // 
            this.rptLuuBan.ActiveViewIndex = -1;
            this.rptLuuBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptLuuBan.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptLuuBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptLuuBan.Location = new System.Drawing.Point(0, 0);
            this.rptLuuBan.Name = "rptLuuBan";
            this.rptLuuBan.Size = new System.Drawing.Size(800, 450);
            this.rptLuuBan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên khối:";
            // 
            // txtTenKhoi
            // 
            this.txtTenKhoi.Location = new System.Drawing.Point(12, 96);
            this.txtTenKhoi.Name = "txtTenKhoi";
            this.txtTenKhoi.Size = new System.Drawing.Size(100, 22);
            this.txtTenKhoi.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(15, 142);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 36);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmDSLuuBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtTenKhoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptLuuBan);
            this.Name = "frmDSLuuBan";
            this.Text = "frmDSLuuBan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptLuuBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhoi;
        private System.Windows.Forms.Button btnIn;
    }
}