namespace DoAnQLDatPhong.Views
{
    partial class frmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiemDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDV = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiemDV = new DevExpress.XtraEditors.TextEdit();
            this.btnLamMoiDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoatDV = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaDV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.74775F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.25225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.Controls.Add(this.btnThemDV, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSuaDV, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInDV, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiemDV, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoaDV, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiemDV, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLamMoiDV, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThoatDV, 7, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 87);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1472, 47);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // btnThemDV
            // 
            this.btnThemDV.ImageOptions.Image = global::DoAnQLDatPhong.Properties.Resources.insert;
            this.btnThemDV.Location = new System.Drawing.Point(3, 4);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(87, 39);
            this.btnThemDV.TabIndex = 0;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDV.ImageOptions.Image")));
            this.btnSuaDV.Location = new System.Drawing.Point(304, 4);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(87, 39);
            this.btnSuaDV.TabIndex = 2;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnInDV
            // 
            this.btnInDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDV.ImageOptions.Image")));
            this.btnInDV.Location = new System.Drawing.Point(466, 4);
            this.btnInDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInDV.Name = "btnInDV";
            this.btnInDV.Size = new System.Drawing.Size(87, 39);
            this.btnInDV.TabIndex = 3;
            this.btnInDV.Text = "In";
            this.btnInDV.Click += new System.EventHandler(this.btnInDV_Click);
            // 
            // btnTimKiemDV
            // 
            this.btnTimKiemDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemDV.ImageOptions.Image")));
            this.btnTimKiemDV.Location = new System.Drawing.Point(661, 4);
            this.btnTimKiemDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiemDV.Name = "btnTimKiemDV";
            this.btnTimKiemDV.Size = new System.Drawing.Size(121, 39);
            this.btnTimKiemDV.TabIndex = 4;
            this.btnTimKiemDV.Text = "Tìm kiếm";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDV.ImageOptions.Image")));
            this.btnXoaDV.Location = new System.Drawing.Point(147, 4);
            this.btnXoaDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(87, 39);
            this.btnXoaDV.TabIndex = 1;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // txtTimKiemDV
            // 
            this.txtTimKiemDV.Location = new System.Drawing.Point(809, 4);
            this.txtTimKiemDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemDV.Name = "txtTimKiemDV";
            this.txtTimKiemDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemDV.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiemDV.Size = new System.Drawing.Size(303, 24);
            this.txtTimKiemDV.TabIndex = 5;
            this.txtTimKiemDV.EditValueChanged += new System.EventHandler(this.txtTimKiemDV_EditValueChanged);
            // 
            // btnLamMoiDV
            // 
            this.btnLamMoiDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiDV.ImageOptions.Image")));
            this.btnLamMoiDV.Location = new System.Drawing.Point(1132, 4);
            this.btnLamMoiDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoiDV.Name = "btnLamMoiDV";
            this.btnLamMoiDV.Size = new System.Drawing.Size(119, 39);
            this.btnLamMoiDV.TabIndex = 6;
            this.btnLamMoiDV.Text = "Làm mới";
            this.btnLamMoiDV.Click += new System.EventHandler(this.btnLamMoiDV_Click);
            // 
            // btnThoatDV
            // 
            this.btnThoatDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatDV.ImageOptions.Image")));
            this.btnThoatDV.Location = new System.Drawing.Point(1326, 4);
            this.btnThoatDV.LookAndFeel.SkinName = "Liquid Sky";
            this.btnThoatDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoatDV.Name = "btnThoatDV";
            this.btnThoatDV.Size = new System.Drawing.Size(87, 39);
            this.btnThoatDV.TabIndex = 7;
            this.btnThoatDV.Text = "Thoát";
            this.btnThoatDV.Click += new System.EventHandler(this.btnThoatDV_Click);
            // 
            // dgvDV
            // 
            this.dgvDV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDV.Location = new System.Drawing.Point(14, 142);
            this.dgvDV.MainView = this.gridView1;
            this.dgvDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.Size = new System.Drawing.Size(1472, 439);
            this.dgvDV.TabIndex = 30;
            this.dgvDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvDV.DoubleClick += new System.EventHandler(this.dgvDV_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDV,
            this.TenDV,
            this.DonVi,
            this.DonGia});
            this.gridView1.GridControl = this.dgvDV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaDV
            // 
            this.MaDV.AppearanceHeader.Options.UseTextOptions = true;
            this.MaDV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaDV.Caption = "Mã dịch vụ";
            this.MaDV.FieldName = "MaDV";
            this.MaDV.Name = "MaDV";
            this.MaDV.Visible = true;
            this.MaDV.VisibleIndex = 0;
            this.MaDV.Width = 204;
            // 
            // TenDV
            // 
            this.TenDV.AppearanceHeader.Options.UseTextOptions = true;
            this.TenDV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenDV.Caption = "Tên dịch vụ";
            this.TenDV.FieldName = "TenDV";
            this.TenDV.Name = "TenDV";
            this.TenDV.Visible = true;
            this.TenDV.VisibleIndex = 1;
            this.TenDV.Width = 546;
            // 
            // DonVi
            // 
            this.DonVi.AppearanceHeader.Options.UseTextOptions = true;
            this.DonVi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DonVi.Caption = "Đơn vị";
            this.DonVi.FieldName = "DonVi";
            this.DonVi.Name = "DonVi";
            this.DonVi.Visible = true;
            this.DonVi.VisibleIndex = 2;
            this.DonVi.Width = 210;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            this.DonGia.Width = 360;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.72489F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.27511F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
            this.tableLayoutPanel1.Controls.Add(this.txtMaDV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDonGia, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDonVi, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTenDV, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1472, 54);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(114, 4);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMaDV.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaDV.Properties.Appearance.Options.UseFont = true;
            this.txtMaDV.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaDV.Size = new System.Drawing.Size(108, 24);
            this.txtMaDV.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã dịch vụ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(952, 4);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(1077, 4);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(195, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(761, 4);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Properties.Appearance.Options.UseFont = true;
            this.txtDonVi.Size = new System.Drawing.Size(141, 24);
            this.txtDonVi.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(662, 4);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Đơn vị:";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(366, 4);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Properties.Appearance.Options.UseFont = true;
            this.txtTenDV.Size = new System.Drawing.Size(273, 24);
            this.txtTenDV.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(241, 4);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên dịch vụ:";
            // 
            // frmDichVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1475, 846);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1280);
            this.MinimumSize = new System.Drawing.Size(1280, 726);
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDichVu";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnThemDV;
        private DevExpress.XtraEditors.SimpleButton btnSuaDV;
        private DevExpress.XtraEditors.SimpleButton btnInDV;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemDV;
        private DevExpress.XtraEditors.SimpleButton btnXoaDV;
        private DevExpress.XtraEditors.TextEdit txtTimKiemDV;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiDV;
        private DevExpress.XtraEditors.SimpleButton btnThoatDV;
        private DevExpress.XtraGrid.GridControl dgvDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDV;
        private DevExpress.XtraGrid.Columns.GridColumn TenDV;
        private DevExpress.XtraGrid.Columns.GridColumn DonVi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        public DevExpress.XtraEditors.TextEdit txtDonVi;
        public DevExpress.XtraEditors.TextEdit txtDonGia;
        public DevExpress.XtraEditors.TextEdit txtMaDV;
        public DevExpress.XtraEditors.TextEdit txtTenDV;
    }
}