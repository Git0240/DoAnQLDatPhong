namespace DoAnQLDatPhong.Views
{
    partial class frmThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThietBi));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnInTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiemTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTB = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiemTB = new DevExpress.XtraEditors.TextEdit();
            this.btnLamMoiTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoatTB = new DevExpress.XtraEditors.SimpleButton();
            this.dgvThietBi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.lkLoaiPhongtb = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiPhongtb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.74775F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.25225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.Controls.Add(this.btnThemTB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSuaTB, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInTB, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiemTB, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoaTB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiemTB, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLamMoiTB, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThoatTB, 7, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 88);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1660, 46);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // btnThemTB
            // 
            this.btnThemTB.ImageOptions.Image = global::DoAnQLDatPhong.Properties.Resources.insert;
            this.btnThemTB.Location = new System.Drawing.Point(4, 4);
            this.btnThemTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(100, 38);
            this.btnThemTB.TabIndex = 0;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTB.ImageOptions.Image")));
            this.btnSuaTB.Location = new System.Drawing.Point(332, 4);
            this.btnSuaTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(100, 38);
            this.btnSuaTB.TabIndex = 2;
            this.btnSuaTB.Text = "Sửa";
            // 
            // btnInTB
            // 
            this.btnInTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInTB.ImageOptions.Image")));
            this.btnInTB.Location = new System.Drawing.Point(517, 4);
            this.btnInTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnInTB.Name = "btnInTB";
            this.btnInTB.Size = new System.Drawing.Size(100, 38);
            this.btnInTB.TabIndex = 3;
            this.btnInTB.Text = "In";
            // 
            // btnTimKiemTB
            // 
            this.btnTimKiemTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemTB.ImageOptions.Image")));
            this.btnTimKiemTB.Location = new System.Drawing.Point(739, 4);
            this.btnTimKiemTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemTB.Name = "btnTimKiemTB";
            this.btnTimKiemTB.Size = new System.Drawing.Size(139, 38);
            this.btnTimKiemTB.TabIndex = 4;
            this.btnTimKiemTB.Text = "Tìm kiếm";
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTB.ImageOptions.Image")));
            this.btnXoaTB.Location = new System.Drawing.Point(161, 4);
            this.btnXoaTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(100, 38);
            this.btnXoaTB.TabIndex = 1;
            this.btnXoaTB.Text = "Xóa";
            // 
            // txtTimKiemTB
            // 
            this.txtTimKiemTB.Location = new System.Drawing.Point(908, 4);
            this.txtTimKiemTB.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemTB.Name = "txtTimKiemTB";
            this.txtTimKiemTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTB.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiemTB.Size = new System.Drawing.Size(347, 24);
            this.txtTimKiemTB.TabIndex = 5;
            // 
            // btnLamMoiTB
            // 
            this.btnLamMoiTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiTB.ImageOptions.Image")));
            this.btnLamMoiTB.Location = new System.Drawing.Point(1278, 4);
            this.btnLamMoiTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoiTB.Name = "btnLamMoiTB";
            this.btnLamMoiTB.Size = new System.Drawing.Size(136, 38);
            this.btnLamMoiTB.TabIndex = 6;
            this.btnLamMoiTB.Text = "Làm mới";
            // 
            // btnThoatTB
            // 
            this.btnThoatTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatTB.ImageOptions.Image")));
            this.btnThoatTB.Location = new System.Drawing.Point(1499, 4);
            this.btnThoatTB.LookAndFeel.SkinName = "Liquid Sky";
            this.btnThoatTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatTB.Name = "btnThoatTB";
            this.btnThoatTB.Size = new System.Drawing.Size(100, 38);
            this.btnThoatTB.TabIndex = 7;
            this.btnThoatTB.Text = "Thoát";
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThietBi.Location = new System.Drawing.Point(14, 141);
            this.dgvThietBi.MainView = this.gridView1;
            this.dgvThietBi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.Size = new System.Drawing.Size(1660, 450);
            this.dgvThietBi.TabIndex = 30;
            this.dgvThietBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaThietBi,
            this.TenThietBi,
            this.TenLoaiPhong,
            this.SoLuong});
            this.gridView1.GridControl = this.dgvThietBi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaThietBi
            // 
            this.MaThietBi.AppearanceHeader.Options.UseTextOptions = true;
            this.MaThietBi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaThietBi.Caption = "Mã thiết bị";
            this.MaThietBi.FieldName = "MaThietBi";
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.Visible = true;
            this.MaThietBi.VisibleIndex = 0;
            this.MaThietBi.Width = 284;
            // 
            // TenThietBi
            // 
            this.TenThietBi.AppearanceHeader.Options.UseTextOptions = true;
            this.TenThietBi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenThietBi.Caption = "Tên thiết bị";
            this.TenThietBi.FieldName = "TenThietBi";
            this.TenThietBi.Name = "TenThietBi";
            this.TenThietBi.Visible = true;
            this.TenThietBi.VisibleIndex = 1;
            this.TenThietBi.Width = 411;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.TenLoaiPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenLoaiPhong.Caption = "Tên loại phòng";
            this.TenLoaiPhong.FieldName = "TenLoaiPhong";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.Visible = true;
            this.TenLoaiPhong.VisibleIndex = 2;
            this.TenLoaiPhong.Width = 507;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.SoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 118;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.59912F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.40088F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 490F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel1.Controls.Add(this.txtMaTB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTenTB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSoLuong, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lkLoaiPhongtb, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1660, 54);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(106, 4);
            this.txtMaTB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTB.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMaTB.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaTB.Properties.Appearance.Options.UseFont = true;
            this.txtMaTB.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaTB.Size = new System.Drawing.Size(195, 24);
            this.txtMaTB.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(911, 4);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Số lượng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã thiết bị:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(1265, 4);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Loại phòng:";
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(421, 4);
            this.txtTenTB.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTB.Properties.Appearance.Options.UseFont = true;
            this.txtTenTB.Size = new System.Drawing.Size(456, 24);
            this.txtTenTB.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(318, 4);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên thiết bị:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(1064, 4);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(162, 22);
            this.txtSoLuong.TabIndex = 10;
            // 
            // lkLoaiPhongtb
            // 
            this.lkLoaiPhongtb.Location = new System.Drawing.Point(1379, 4);
            this.lkLoaiPhongtb.Margin = new System.Windows.Forms.Padding(4);
            this.lkLoaiPhongtb.Name = "lkLoaiPhongtb";
            this.lkLoaiPhongtb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiPhongtb.Size = new System.Drawing.Size(133, 22);
            this.lkLoaiPhongtb.TabIndex = 16;
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1687, 602);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgvThietBi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1709, 873);
            this.MinimumSize = new System.Drawing.Size(1140, 649);
            this.Name = "frmThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThietBi";
            this.Load += new System.EventHandler(this.frmThietBi_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiPhongtb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnThemTB;
        private DevExpress.XtraEditors.SimpleButton btnSuaTB;
        private DevExpress.XtraEditors.SimpleButton btnInTB;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemTB;
        private DevExpress.XtraEditors.SimpleButton btnXoaTB;
        private DevExpress.XtraEditors.TextEdit txtTimKiemTB;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiTB;
        private DevExpress.XtraEditors.SimpleButton btnThoatTB;
        private DevExpress.XtraGrid.GridControl dgvThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn TenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtMaTB;
        public DevExpress.XtraEditors.TextEdit txtTenTB;
        public DevExpress.XtraEditors.TextEdit txtSoLuong;
        public DevExpress.XtraEditors.LookUpEdit lkLoaiPhongtb;
    }
}