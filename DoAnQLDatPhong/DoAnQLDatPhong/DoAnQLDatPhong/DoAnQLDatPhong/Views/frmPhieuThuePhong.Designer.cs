namespace DoAnQLDatPhong.Views
{
    partial class frmPhieuThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThuePhong));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemPT = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaPT = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPT = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiemTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaPT = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiemTB = new DevExpress.XtraEditors.TextEdit();
            this.btnLamMoiTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoatTB = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPTP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPhieuThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDangKi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deNhan = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKH = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.btnPhong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deDki = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPT = new DevExpress.XtraEditors.TextEdit();
            this.SoPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDki.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPT.Properties)).BeginInit();
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.Controls.Add(this.btnThemPT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSuaPT, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInPT, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiemTB, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoaPT, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiemTB, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLamMoiTB, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThoatTB, 7, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 79);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1660, 46);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // btnThemPT
            // 
            this.btnThemPT.ImageOptions.Image = global::DoAnQLDatPhong.Properties.Resources.insert;
            this.btnThemPT.Location = new System.Drawing.Point(4, 4);
            this.btnThemPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(100, 38);
            this.btnThemPT.TabIndex = 0;
            this.btnThemPT.Text = "Thêm";
            // 
            // btnSuaPT
            // 
            this.btnSuaPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPT.ImageOptions.Image")));
            this.btnSuaPT.Location = new System.Drawing.Point(316, 4);
            this.btnSuaPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaPT.Name = "btnSuaPT";
            this.btnSuaPT.Size = new System.Drawing.Size(100, 38);
            this.btnSuaPT.TabIndex = 2;
            this.btnSuaPT.Text = "Sửa";
            // 
            // btnInPT
            // 
            this.btnInPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInPT.ImageOptions.Image")));
            this.btnInPT.Location = new System.Drawing.Point(501, 4);
            this.btnInPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnInPT.Name = "btnInPT";
            this.btnInPT.Size = new System.Drawing.Size(100, 38);
            this.btnInPT.TabIndex = 3;
            this.btnInPT.Text = "In";
            // 
            // btnTimKiemTB
            // 
            this.btnTimKiemTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemTB.ImageOptions.Image")));
            this.btnTimKiemTB.Location = new System.Drawing.Point(723, 4);
            this.btnTimKiemTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemTB.Name = "btnTimKiemTB";
            this.btnTimKiemTB.Size = new System.Drawing.Size(139, 38);
            this.btnTimKiemTB.TabIndex = 4;
            this.btnTimKiemTB.Text = "Tìm kiếm";
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPT.ImageOptions.Image")));
            this.btnXoaPT.Location = new System.Drawing.Point(153, 4);
            this.btnXoaPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(100, 38);
            this.btnXoaPT.TabIndex = 1;
            this.btnXoaPT.Text = "Xóa";
            // 
            // txtTimKiemTB
            // 
            this.txtTimKiemTB.Location = new System.Drawing.Point(892, 4);
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
            this.btnLamMoiTB.Location = new System.Drawing.Point(1262, 4);
            this.btnLamMoiTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoiTB.Name = "btnLamMoiTB";
            this.btnLamMoiTB.Size = new System.Drawing.Size(136, 38);
            this.btnLamMoiTB.TabIndex = 6;
            this.btnLamMoiTB.Text = "Làm mới";
            // 
            // btnThoatTB
            // 
            this.btnThoatTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatTB.ImageOptions.Image")));
            this.btnThoatTB.Location = new System.Drawing.Point(1483, 4);
            this.btnThoatTB.LookAndFeel.SkinName = "Liquid Sky";
            this.btnThoatTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatTB.Name = "btnThoatTB";
            this.btnThoatTB.Size = new System.Drawing.Size(100, 38);
            this.btnThoatTB.TabIndex = 7;
            this.btnThoatTB.Text = "Thoát";
            // 
            // dgvPTP
            // 
            this.dgvPTP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPTP.Location = new System.Drawing.Point(13, 132);
            this.dgvPTP.MainView = this.gridView1;
            this.dgvPTP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPTP.Name = "dgvPTP";
            this.dgvPTP.Size = new System.Drawing.Size(1660, 450);
            this.dgvPTP.TabIndex = 33;
            this.dgvPTP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPhieuThue,
            this.TenKH,
            this.NgayDangKi,
            this.NgayNhan,
            this.MaPhong});
            this.gridView1.GridControl = this.dgvPTP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaPhieuThue
            // 
            this.MaPhieuThue.AppearanceHeader.Options.UseTextOptions = true;
            this.MaPhieuThue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaPhieuThue.Caption = "Mã phiếu thuê";
            this.MaPhieuThue.FieldName = "MaPhieuThue";
            this.MaPhieuThue.Name = "MaPhieuThue";
            this.MaPhieuThue.Visible = true;
            this.MaPhieuThue.VisibleIndex = 0;
            this.MaPhieuThue.Width = 259;
            // 
            // TenKH
            // 
            this.TenKH.AppearanceHeader.Options.UseTextOptions = true;
            this.TenKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenKH.Caption = "Tên khách hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            this.TenKH.Width = 744;
            // 
            // NgayDangKi
            // 
            this.NgayDangKi.Caption = "Ngày đăng kí";
            this.NgayDangKi.FieldName = "NgayDangKi";
            this.NgayDangKi.Name = "NgayDangKi";
            this.NgayDangKi.Visible = true;
            this.NgayDangKi.VisibleIndex = 2;
            this.NgayDangKi.Width = 249;
            // 
            // NgayNhan
            // 
            this.NgayNhan.Caption = "Ngày nhận";
            this.NgayNhan.FieldName = "NgayNhan";
            this.NgayNhan.Name = "NgayNhan";
            this.NgayNhan.Visible = true;
            this.NgayNhan.VisibleIndex = 3;
            this.NgayNhan.Width = 268;
            // 
            // MaPhong
            // 
            this.MaPhong.Caption = "Số phòng";
            this.MaPhong.FieldName = "MaPhong";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Visible = true;
            this.MaPhong.VisibleIndex = 4;
            this.MaPhong.Width = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.09934F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.90067F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 522F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.Controls.Add(this.deNhan, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbKH, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKH, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPhong, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPhong, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deDki, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMaPT, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1660, 79);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // deNhan
            // 
            this.deNhan.EditValue = null;
            this.deNhan.Location = new System.Drawing.Point(428, 41);
            this.deNhan.Name = "deNhan";
            this.deNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNhan.Size = new System.Drawing.Size(193, 22);
            this.deNhan.TabIndex = 35;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(301, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 17);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Ngày nhận:";
            // 
            // cbKH
            // 
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(428, 3);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(480, 24);
            this.cbKH.TabIndex = 35;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(302, 4);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên khách hàng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu thuê:";
            // 
            // btnKH
            // 
            this.btnKH.Location = new System.Drawing.Point(950, 3);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(89, 32);
            this.btnKH.TabIndex = 36;
            this.btnKH.Text = "Khách hàng";
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(1236, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(138, 17);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Số phòng(Còn trống):";
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(1395, 3);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(108, 24);
            this.cbPhong.TabIndex = 38;
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(1509, 3);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(104, 32);
            this.btnPhong.TabIndex = 39;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 16);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Ngày đăng kí:";
            // 
            // deDki
            // 
            this.deDki.EditValue = null;
            this.deDki.Location = new System.Drawing.Point(107, 41);
            this.deDki.Name = "deDki";
            this.deDki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDki.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDki.Size = new System.Drawing.Size(182, 22);
            this.deDki.TabIndex = 44;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(108, 4);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaPT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMaPT.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaPT.Properties.Appearance.Options.UseFont = true;
            this.txtMaPT.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaPT.Size = new System.Drawing.Size(181, 24);
            this.txtMaPT.TabIndex = 15;
            // 
            // SoPhong
            // 
            this.SoPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.SoPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoPhong.Caption = "Số phòng";
            this.SoPhong.FieldName = "SoPhong";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Visible = true;
            this.SoPhong.VisibleIndex = 2;
            this.SoPhong.Width = 316;
            // 
            // frmPhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 580);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgvPTP);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPhieuThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuThuePhong";
            this.Load += new System.EventHandler(this.frmPhieuThuePhong_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDki.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnThemPT;
        private DevExpress.XtraEditors.SimpleButton btnSuaPT;
        private DevExpress.XtraEditors.SimpleButton btnInPT;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemTB;
        private DevExpress.XtraEditors.SimpleButton btnXoaPT;
        private DevExpress.XtraEditors.TextEdit txtTimKiemTB;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiTB;
        private DevExpress.XtraEditors.SimpleButton btnThoatTB;
        private DevExpress.XtraGrid.GridControl dgvPTP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieuThue;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public DevExpress.XtraEditors.TextEdit txtMaPT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDangKi;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbKH;
        private DevExpress.XtraEditors.SimpleButton btnKH;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbPhong;
        private DevExpress.XtraEditors.SimpleButton btnPhong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhong;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhong;
        private DevExpress.XtraEditors.DateEdit deNhan;
        private DevExpress.XtraEditors.DateEdit deDki;
    }
}