namespace DoAnQLDatPhong.Views
{
    partial class frmNhanPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanPhong));
            this.dgvPNP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPhieuNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaPhieuThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemPT = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaPT = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPT = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiemTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaPT = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiemTB = new DevExpress.XtraEditors.TextEdit();
            this.btnLamMoiTB = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoatTB = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.cbPhieuThue = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemTB.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPNP
            // 
            this.dgvPNP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPNP.Location = new System.Drawing.Point(13, 200);
            this.dgvPNP.MainView = this.gridView1;
            this.dgvPNP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPNP.Name = "dgvPNP";
            this.dgvPNP.Size = new System.Drawing.Size(1660, 426);
            this.dgvPNP.TabIndex = 36;
            this.dgvPNP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPhieuNhan,
            this.TenKH,
            this.MaPhong,
            this.DonGia,
            this.MaPhieuThue,
            this.CMND,
            this.DiaChi,
            this.SDT});
            this.gridView1.GridControl = this.dgvPNP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaPhieuNhan
            // 
            this.MaPhieuNhan.AppearanceHeader.Options.UseTextOptions = true;
            this.MaPhieuNhan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaPhieuNhan.Caption = "Mã phiếu nhận";
            this.MaPhieuNhan.FieldName = "MaPhieuNhan";
            this.MaPhieuNhan.Name = "MaPhieuNhan";
            this.MaPhieuNhan.Visible = true;
            this.MaPhieuNhan.VisibleIndex = 0;
            this.MaPhieuNhan.Width = 148;
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
            this.TenKH.Width = 441;
            // 
            // MaPhong
            // 
            this.MaPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.MaPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaPhong.Caption = "Số phòng";
            this.MaPhong.FieldName = "MaPhong";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Visible = true;
            this.MaPhong.VisibleIndex = 6;
            this.MaPhong.Width = 131;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceCell.Options.UseTextOptions = true;
            this.DonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DonGia.AppearanceHeader.Options.UseTextOptions = true;
            this.DonGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DonGia.Caption = "Ngày nhận";
            this.DonGia.FieldName = "NgayNhan";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 5;
            this.DonGia.Width = 259;
            // 
            // MaPhieuThue
            // 
            this.MaPhieuThue.Caption = "Mã phiếu thuê";
            this.MaPhieuThue.FieldName = "MaPhieuThue";
            this.MaPhieuThue.Name = "MaPhieuThue";
            this.MaPhieuThue.Visible = true;
            this.MaPhieuThue.VisibleIndex = 7;
            this.MaPhieuThue.Width = 102;
            // 
            // CMND
            // 
            this.CMND.Caption = "CMND";
            this.CMND.FieldName = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 2;
            this.CMND.Width = 174;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            this.DiaChi.Width = 162;
            // 
            // SDT
            // 
            this.SDT.Caption = "Số điện thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 4;
            this.SDT.Width = 223;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Location = new System.Drawing.Point(13, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1660, 170);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "Nhận phòng";
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel2.Controls.Add(this.btnThemPT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSuaPT, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInPT, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiemTB, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoaPT, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiemTB, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLamMoiTB, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThoatTB, 7, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 118);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1648, 46);
            this.tableLayoutPanel2.TabIndex = 39;
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
            this.btnSuaPT.Location = new System.Drawing.Point(307, 4);
            this.btnSuaPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaPT.Name = "btnSuaPT";
            this.btnSuaPT.Size = new System.Drawing.Size(100, 38);
            this.btnSuaPT.TabIndex = 2;
            this.btnSuaPT.Text = "Sửa";
            // 
            // btnInPT
            // 
            this.btnInPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInPT.ImageOptions.Image")));
            this.btnInPT.Location = new System.Drawing.Point(492, 4);
            this.btnInPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnInPT.Name = "btnInPT";
            this.btnInPT.Size = new System.Drawing.Size(100, 38);
            this.btnInPT.TabIndex = 3;
            this.btnInPT.Text = "In";
            // 
            // btnTimKiemTB
            // 
            this.btnTimKiemTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemTB.ImageOptions.Image")));
            this.btnTimKiemTB.Location = new System.Drawing.Point(714, 4);
            this.btnTimKiemTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemTB.Name = "btnTimKiemTB";
            this.btnTimKiemTB.Size = new System.Drawing.Size(139, 38);
            this.btnTimKiemTB.TabIndex = 4;
            this.btnTimKiemTB.Text = "Tìm kiếm";
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPT.ImageOptions.Image")));
            this.btnXoaPT.Location = new System.Drawing.Point(149, 4);
            this.btnXoaPT.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(100, 38);
            this.btnXoaPT.TabIndex = 1;
            this.btnXoaPT.Text = "Xóa";
            // 
            // txtTimKiemTB
            // 
            this.txtTimKiemTB.Location = new System.Drawing.Point(883, 4);
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
            this.btnLamMoiTB.Location = new System.Drawing.Point(1253, 4);
            this.btnLamMoiTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoiTB.Name = "btnLamMoiTB";
            this.btnLamMoiTB.Size = new System.Drawing.Size(136, 38);
            this.btnLamMoiTB.TabIndex = 6;
            this.btnLamMoiTB.Text = "Làm mới";
            // 
            // btnThoatTB
            // 
            this.btnThoatTB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatTB.ImageOptions.Image")));
            this.btnThoatTB.Location = new System.Drawing.Point(1474, 4);
            this.btnThoatTB.LookAndFeel.SkinName = "Liquid Sky";
            this.btnThoatTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatTB.Name = "btnThoatTB";
            this.btnThoatTB.Size = new System.Drawing.Size(100, 38);
            this.btnThoatTB.TabIndex = 7;
            this.btnThoatTB.Text = "Thoát";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.59912F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.40088F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 466F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tableLayoutPanel1.Controls.Add(this.txtMaPN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbTenKH, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbSoPhong, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPhieuThue, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateEdit1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1648, 71);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(98, 4);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaPN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMaPN.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaPN.Properties.Appearance.Options.UseFont = true;
            this.txtMaPN.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaPN.Size = new System.Drawing.Size(187, 24);
            this.txtMaPN.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(886, 4);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Số phòng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu nhận:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(1240, 4);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Phiếu thuê:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(293, 4);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên khách hàng:";
            // 
            // cbTenKH
            // 
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(419, 3);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(460, 24);
            this.cbTenKH.TabIndex = 17;
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Location = new System.Drawing.Point(1038, 3);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(150, 24);
            this.cbSoPhong.TabIndex = 18;
            // 
            // cbPhieuThue
            // 
            this.cbPhieuThue.FormattingEnabled = true;
            this.cbPhieuThue.Location = new System.Drawing.Point(1353, 3);
            this.cbPhieuThue.Name = "cbPhieuThue";
            this.cbPhieuThue.Size = new System.Drawing.Size(133, 24);
            this.cbPhieuThue.TabIndex = 19;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 17);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Ngày nhận:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(97, 42);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 22);
            this.dateEdit1.TabIndex = 21;
            // 
            // frmNhanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 713);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgvPNP);
            this.Name = "frmNhanPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanPhong";
            this.Load += new System.EventHandler(this.frmNhanPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemTB.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvPNP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieuNhan;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieuThue;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnThemPT;
        private DevExpress.XtraEditors.SimpleButton btnSuaPT;
        private DevExpress.XtraEditors.SimpleButton btnInPT;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemTB;
        private DevExpress.XtraEditors.SimpleButton btnXoaPT;
        private DevExpress.XtraEditors.TextEdit txtTimKiemTB;
        private DevExpress.XtraEditors.SimpleButton btnLamMoiTB;
        private DevExpress.XtraEditors.SimpleButton btnThoatTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public DevExpress.XtraEditors.TextEdit txtMaPN;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.ComboBox cbPhieuThue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        public System.Windows.Forms.ComboBox cbTenKH;
    }
}