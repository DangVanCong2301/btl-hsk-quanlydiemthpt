
namespace BTL_QuanLyDiemTHPT.BaoCao
{
    partial class frmNgayTrongKhoang
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
            this.rptNgayTrongKhoang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptNgayTrongKhoang
            // 
            this.rptNgayTrongKhoang.ActiveViewIndex = -1;
            this.rptNgayTrongKhoang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptNgayTrongKhoang.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptNgayTrongKhoang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptNgayTrongKhoang.Location = new System.Drawing.Point(0, 0);
            this.rptNgayTrongKhoang.Name = "rptNgayTrongKhoang";
            this.rptNgayTrongKhoang.Size = new System.Drawing.Size(800, 450);
            this.rptNgayTrongKhoang.TabIndex = 0;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(44, 87);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 22);
            this.txtThang.TabIndex = 1;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(44, 134);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 22);
            this.txtNam.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(44, 178);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmNgayTrongKhoang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.rptNgayTrongKhoang);
            this.Name = "frmNgayTrongKhoang";
            this.Text = "frmNgayTrongKhoang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptNgayTrongKhoang;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnIn;
    }
}