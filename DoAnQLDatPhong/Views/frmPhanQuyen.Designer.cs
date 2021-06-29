namespace DoAnQLDatPhong.Views
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.cbPQ = new System.Windows.Forms.ComboBox();
            this.cbTk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnXacNhan);
            this.groupControl1.Controls.Add(this.cbPQ);
            this.groupControl1.Controls.Add(this.cbTk);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(31, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 253);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Phân quyền";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(288, 175);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(115, 45);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
            this.btnXacNhan.Location = new System.Drawing.Point(26, 175);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(115, 45);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cbPQ
            // 
            this.cbPQ.FormattingEnabled = true;
            this.cbPQ.Location = new System.Drawing.Point(148, 115);
            this.cbPQ.Name = "cbPQ";
            this.cbPQ.Size = new System.Drawing.Size(255, 24);
            this.cbPQ.TabIndex = 3;
            // 
            // cbTk
            // 
            this.cbTk.FormattingEnabled = true;
            this.cbTk.Location = new System.Drawing.Point(148, 55);
            this.cbTk.Name = "cbTk";
            this.cbTk.Size = new System.Drawing.Size(255, 24);
            this.cbTk.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phân quyền";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tài khoản";
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 306);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private System.Windows.Forms.ComboBox cbPQ;
        private System.Windows.Forms.ComboBox cbTk;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}