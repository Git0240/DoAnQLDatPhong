using DoAnQLDatPhong.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAnQLDatPhong.Models;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DoAnQLDatPhong
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ConnectionString connectDB;
        public Form1()
        {
            InitializeComponent();
            connectDB = new ConnectionString();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Money Twins";
        }
        String msg;
        public Form1(string loianguoidung): this()
        {
            msg = loianguoidung;
        }
        public void OnOff(Form frm)
        {
            Form1 f = (Form1)frm;
            if (msg == "2")
            {
                f.btnPhanQuyen.Enabled = false;
                f.btnDichVu.Enabled = false;
                f.btnPhong.Enabled = false;
                f.btnThietBi.Enabled = false;
                f.btnLoaiPhong.Enabled = false;
                f.Visible = false;
            }

        }
        
            
        private void Form1_Load(object sender, EventArgs e)
        {
            OnOff(this);
            skin();
            XtraMessageBox.Show("Xin chào "+frmDangNhap.user,"Hệ thống");
        }
        
        private void btnDangKi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangKi frmDK = new frmDangKi();
            frmDK.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.ShowDialog();
        }

        private void btnThietBi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThietBi frmTB = new frmThietBi();
            frmTB.ShowDialog();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
        }

        private void btnDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDichVu frmDV = new frmDichVu();
            frmDV.ShowDialog();
        }

        private void btnPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhong frmP = new frmPhong();
            frmP.ShowDialog();
        }

        private void btnDkPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhieuThuePhong ptp = new frmPhieuThuePhong();
            ptp.ShowDialog();
        }

        private void btnNhanPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanPhong np = new frmNhanPhong();
            np.ShowDialog();
        }

        private void btnLoaiPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiPhong lp = new frmLoaiPhong();
            lp.ShowDialog();
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMK doimk = new frmDoiMK();
            doimk.ShowDialog();
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanQuyen pq = new frmPhanQuyen();
            pq.ShowDialog();
        }

        private void btnTongQuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
        }

        private void btnHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTraPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TraPhong tp = new TraPhong();
            tp.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThietBi tb = new frmThietBi();
            tb.ShowDialog();
        }
    }
}
