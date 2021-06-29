namespace DoAnQLDatPhong.Views
{
    partial class frmPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiemPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaPhong = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiemPhong = new DevExpress.XtraEditors.TextEdit();
            this.btnLamMoiPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoatPhong = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNguoiChuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNguoiToiDa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lkTT = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSoNToiDa = new DevExpress.XtraEditors.TextEdit();
            this.txtSoNChuan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lkLoaiPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.quanLiDatPhongDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiDatPhongDataSet1 = new DoAnQLDatPhong.QuanLiDatPhongDataSet1();
            this.quanLiDatPhongDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiDatPhongDataSet = new DoAnQLDatPhong.QuanLiDatPhongDataSet();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNToiDa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNChuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDatPhongDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDatPhongDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDatPhongDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDatPhongDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.74775F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.25225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel2.Controls.Add(this.btnLoc, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnThemPhong, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSuaPhong, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInPhong, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiemPhong, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoaPhong, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiemPhong, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLamMoiPhong, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThoatPhong, 7, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1472, 104);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(3, 56);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(129, 40);
            this.btnLoc.TabIndex = 9;
            this.btnLoc.Text = "Lọc phòng trống";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.ImageOptions.Image = global::DoAnQLDatPhong.Properties.Resources.insert;
            this.btnThemPhong.Location = new System.Drawing.Point(3, 3);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(87, 40);
            this.btnThemPhong.TabIndex = 0;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPhong.ImageOptions.Image")));
            this.btnSuaPhong.Location = new System.Drawing.Point(286, 3);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(87, 40);
            this.btnSuaPhong.TabIndex = 2;
            this.btnSuaPhong.Text = "Sửa";
            // 
            // btnInPhong
            // 
            this.btnInPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhong.ImageOptions.Image")));
            this.btnInPhong.Location = new System.Drawing.Point(448, 3);
            this.btnInPhong.Name = "btnInPhong";
            this.btnInPhong.Size = new System.Drawing.Size(87, 40);
            this.btnInPhong.TabIndex = 3;
            this.btnInPhong.Text = "In";
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemPhong.ImageOptions.Image")));
            this.btnTimKiemPhong.Location = new System.Drawing.Point(642, 3);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(121, 40);
            this.btnTimKiemPhong.TabIndex = 4;
            this.btnTimKiemPhong.Text = "Tìm kiếm";
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhong.ImageOptions.Image")));
            this.btnXoaPhong.Location = new System.Drawing.Point(138, 3);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(87, 40);
            this.btnXoaPhong.TabIndex = 1;
            this.btnXoaPhong.Text = "Xóa";
            // 
            // txtTimKiemPhong
            // 
            this.txtTimKiemPhong.Location = new System.Drawing.Point(790, 3);
            this.txtTimKiemPhong.Name = "txtTimKiemPhong";
            this.txtTimKiemPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemPhong.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiemPhong.Size = new System.Drawing.Size(303, 24);
            this.txtTimKiemPhong.TabIndex = 5;
            // 
            // btnLamMoiPhong
            // 
            this.btnLamMoiPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiPhong.ImageOptions.Image")));
            this.btnLamMoiPhong.Location = new System.Drawing.Point(1114, 3);
            this.btnLamMoiPhong.Name = "btnLamMoiPhong";
            this.btnLamMoiPhong.Size = new System.Drawing.Size(119, 40);
            this.btnLamMoiPhong.TabIndex = 6;
            this.btnLamMoiPhong.Text = "Làm mới";
            // 
            // btnThoatPhong
            // 
            this.btnThoatPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatPhong.ImageOptions.Image")));
            this.btnThoatPhong.Location = new System.Drawing.Point(1308, 3);
            this.btnThoatPhong.LookAndFeel.SkinName = "Liquid Sky";
            this.btnThoatPhong.Name = "btnThoatPhong";
            this.btnThoatPhong.Size = new System.Drawing.Size(87, 40);
            this.btnThoatPhong.TabIndex = 7;
            this.btnThoatPhong.Text = "Thoát";
            // 
            // dgvPhong
            // 
            this.dgvPhong.Location = new System.Drawing.Point(14, 198);
            this.dgvPhong.MainView = this.gridView1;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(1472, 332);
            this.dgvPhong.TabIndex = 27;
            this.dgvPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPhong,
            this.TenLoaiPhong,
            this.TenLoaiTT,
            this.SoNguoiChuan,
            this.SoNguoiToiDa,
            this.DonGia});
            this.gridView1.GridControl = this.dgvPhong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaPhong
            // 
            this.MaPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.MaPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaPhong.Caption = "Mã phòng";
            this.MaPhong.FieldName = "MaPhong";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Visible = true;
            this.MaPhong.VisibleIndex = 0;
            this.MaPhong.Width = 118;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.TenLoaiPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenLoaiPhong.Caption = "Loại phòng";
            this.TenLoaiPhong.FieldName = "TenLoaiPhong";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.Visible = true;
            this.TenLoaiPhong.VisibleIndex = 1;
            this.TenLoaiPhong.Width = 232;
            // 
            // TenLoaiTT
            // 
            this.TenLoaiTT.AppearanceHeader.Options.UseTextOptions = true;
            this.TenLoaiTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenLoaiTT.Caption = "Tình trạng";
            this.TenLoaiTT.FieldName = "TenLoaiTT";
            this.TenLoaiTT.Name = "TenLoaiTT";
            this.TenLoaiTT.Visible = true;
            this.TenLoaiTT.VisibleIndex = 2;
            this.TenLoaiTT.Width = 166;
            // 
            // SoNguoiChuan
            // 
            this.SoNguoiChuan.Caption = "Số người chuẩn";
            this.SoNguoiChuan.FieldName = "SoNguoiChuan";
            this.SoNguoiChuan.Name = "SoNguoiChuan";
            this.SoNguoiChuan.Visible = true;
            this.SoNguoiChuan.VisibleIndex = 3;
            // 
            // SoNguoiToiDa
            // 
            this.SoNguoiToiDa.Caption = "Số người tối đa";
            this.SoNguoiToiDa.FieldName = "SoNguoiToiDa";
            this.SoNguoiToiDa.Name = "SoNguoiToiDa";
            this.SoNguoiToiDa.Visible = true;
            this.SoNguoiToiDa.VisibleIndex = 4;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.79803F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.20197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.Controls.Add(this.lkTT, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSoNToiDa, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSoNChuan, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaPhong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDonGia, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.lkLoaiPhong, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1472, 54);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // lkTT
            // 
            this.lkTT.Location = new System.Drawing.Point(533, 3);
            this.lkTT.Name = "lkTT";
            this.lkTT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTT.Size = new System.Drawing.Size(117, 22);
            this.lkTT.TabIndex = 18;
            // 
            // txtSoNToiDa
            // 
            this.txtSoNToiDa.Location = new System.Drawing.Point(1296, 3);
            this.txtSoNToiDa.Name = "txtSoNToiDa";
            this.txtSoNToiDa.Size = new System.Drawing.Size(142, 22);
            this.txtSoNToiDa.TabIndex = 14;
            // 
            // txtSoNChuan
            // 
            this.txtSoNChuan.Location = new System.Drawing.Point(1042, 3);
            this.txtSoNChuan.Name = "txtSoNChuan";
            this.txtSoNChuan.Size = new System.Drawing.Size(142, 22);
            this.txtSoNChuan.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(447, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tình trạng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(190, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Loại phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Location = new System.Drawing.Point(90, 3);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMaPhong.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaPhong.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhong.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaPhong.Size = new System.Drawing.Size(94, 24);
            this.txtMaPhong.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phòng:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(699, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(778, 3);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(142, 22);
            this.txtDonGia.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(932, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 17);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Số người chuẩn:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(1197, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(98, 17);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Số người tối đa:";
            // 
            // lkLoaiPhong
            // 
            this.lkLoaiPhong.Location = new System.Drawing.Point(277, 3);
            this.lkLoaiPhong.Name = "lkLoaiPhong";
            this.lkLoaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiPhong.Size = new System.Drawing.Size(164, 22);
            this.lkLoaiPhong.TabIndex = 17;
            this.lkLoaiPhong.EditValueChanged += new System.EventHandler(this.lkLoaiPhong_EditValueChanged);
            // 
            // quanLiDatPhongDataSet1BindingSource
            // 
            this.quanLiDatPhongDataSet1BindingSource.DataSource = this.quanLiDatPhongDataSet1;
            this.quanLiDatPhongDataSet1BindingSource.Position = 0;
            // 
            // quanLiDatPhongDataSet1
            // 
            this.quanLiDatPhongDataSet1.DataSetName = "QuanLiDatPhongDataSet1";
            this.quanLiDatPhongDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLiDatPhongDataSetBindingSource
            // 
            this.quanLiDatPhongDataSetBindingSource.DataSource = this.quanLiDatPhongDataSet;
            this.quanLiDatPhongDataSetBindingSource.Position = 0;
            // 
            // quanLiDatPhongDataSet
            // 
            this.quanLiDatPhongDataSet.DataSetName = "QuanLiDatPhongDataSet";
            this.quanLiDatPhongDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmPhong
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 541);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNToiDa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNChuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDatPhongDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDatPhongDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDatPhongDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDatPhongDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnThemPhong;
        private DevExpress.XtraEditors.SimpleButton btnSuaPhong;
        private DevExpress.XtraEditors.SimpleButton btnInPhong;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemPhong;
        private DevExpress.XtraEditors.SimpleButton btnXoaPhong;
        private DevExpress.XtraEditors.TextEdit txtTimKiemPhong;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiPhong;
        private DevExpress.XtraEditors.SimpleButton btnThoatPhong;
        private DevExpress.XtraGrid.GridControl dgvPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiTT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoNToiDa;
        private DevExpress.XtraEditors.TextEdit txtSoNChuan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.TextEdit txtMaPhong;
        private System.Windows.Forms.BindingSource quanLiDatPhongDataSetBindingSource;
        private QuanLiDatPhongDataSet quanLiDatPhongDataSet;
        private System.Windows.Forms.BindingSource quanLiDatPhongDataSet1BindingSource;
        private QuanLiDatPhongDataSet1 quanLiDatPhongDataSet1;
        public DevExpress.XtraEditors.LookUpEdit lkLoaiPhong;
        public DevExpress.XtraEditors.LookUpEdit lkTT;
        private DevExpress.XtraGrid.Columns.GridColumn SoNguoiChuan;
        private DevExpress.XtraGrid.Columns.GridColumn SoNguoiToiDa;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraEditors.SimpleButton btnLoc;


    }
}