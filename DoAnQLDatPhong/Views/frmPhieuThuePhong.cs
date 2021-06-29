using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAnQLDatPhong.Controller;

namespace DoAnQLDatPhong.Views
{
    public partial class frmPhieuThuePhong : DevExpress.XtraEditors.XtraForm
    {
        BLPhieuThuePhong blptp;
        public frmPhieuThuePhong()
        {
            InitializeComponent();
            blptp = new BLPhieuThuePhong();
        }
        public void LoadKH()
        {
            DataTable dt = blptp.LoadKH();
            cbKH.DataSource = dt;
            cbKH.DisplayMember = "TenKH";
            cbKH.ValueMember = "MaKH";
        }
        public void LoadPhong()
        {
            DataTable dt = blptp.LoadPhong();
            cbPhong.DataSource = dt;
            cbPhong.DisplayMember = "MaPhong";
            cbPhong.ValueMember = "MaPhong";
        }
        public void HienThiDLPTP()
        {
            DataTable dt = blptp.LayDLPTP();
            dgvPTP.DataSource = dt;
        }

        private void frmPhieuThuePhong_Load(object sender, EventArgs e)
        {
            HienThiDLPTP();
            LoadKH();
            LoadPhong();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            frmPhong p = new frmPhong();
            p.ShowDialog();
        }
    }
}