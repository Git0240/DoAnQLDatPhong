namespace DoAnQLDatPhong.Views
{
    partial class frmDoiMK
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbtendn = new System.Windows.Forms.ComboBox();
            this.txtMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtMKCu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuayLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cbtendn);
            this.groupControl1.Controls.Add(this.txtMKMoi);
            this.groupControl1.Controls.Add(this.txtMKCu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(34, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(567, 214);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Đổi mật khẩu";
            // 
            // cbtendn
            // 
            this.cbtendn.FormattingEnabled = true;
            this.cbtendn.Location = new System.Drawing.Point(157, 56);
            this.cbtendn.Name = "cbtendn";
            this.cbtendn.Size = new System.Drawing.Size(355, 29);
            this.cbtendn.TabIndex = 6;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(157, 156);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMKMoi.Properties.Appearance.Options.UseFont = true;
            this.txtMKMoi.Properties.UseSystemPasswordChar = true;
            this.txtMKMoi.Size = new System.Drawing.Size(355, 28);
            this.txtMKMoi.TabIndex = 5;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(157, 102);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMKCu.Properties.Appearance.Options.UseFont = true;
            this.txtMKCu.Properties.UseSystemPasswordChar = true;
            this.txtMKCu.Size = new System.Drawing.Size(355, 28);
            this.txtMKCu.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu mới:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu cũ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // btnDoi
            // 
            this.btnDoi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDoi.Appearance.Options.UseFont = true;
            this.btnDoi.Location = new System.Drawing.Point(34, 270);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(122, 42);
            this.btnDoi.TabIndex = 3;
            this.btnDoi.Text = "Đổi mật khẩu";
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnQuayLai.Appearance.Options.UseFont = true;
            this.btnQuayLai.Location = new System.Drawing.Point(234, 270);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(182, 42);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay lại đăng nhập";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(479, 270);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 42);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 363);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtMKMoi;
        private DevExpress.XtraEditors.TextEdit txtMKCu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDoi;
        private DevExpress.XtraEditors.SimpleButton btnQuayLai;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ComboBox cbtendn;
    }
}