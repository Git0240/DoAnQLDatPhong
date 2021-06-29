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
    public partial class frmNhanPhong : DevExpress.XtraEditors.XtraForm
    {
        BLPhieuNhan blpn;
        public frmNhanPhong()
        {
            InitializeComponent();
            blpn = new BLPhieuNhan();
        }
        public void HienThiDLPNP()
        {
            DataTable dt = blpn.LayDLPNP();
            dgvPNP.DataSource = dt;
        }
        public void LoadKH()
        {
            DataSet dt = blpn.LoadKH();
            cbTenKH.DataSource = dt.Tables[0];
            cbTenKH.DisplayMember = "TenKH";
            cbTenKH.ValueMember = "MaKH";


        }
        public void LoadPT()
        {
            DataTable dt = blpn.LoadPT();
            cbPhieuThue.DataSource = dt;
            cbPhieuThue.DisplayMember = "MaPhieuThue";
            cbPhieuThue.ValueMember = "MaPhieuThue";
        }
        public void LoadPhong()
        {
            DataTable dt = blpn.LoadPhong();
            cbSoPhong.DataSource = dt;
            cbSoPhong.DisplayMember = "MaPhong";
            cbSoPhong.ValueMember = "MaPhong";
        }
        private void frmNhanPhong_Load(object sender, EventArgs e)
        {
            HienThiDLPNP();
            LoadKH();
            LoadPhong();
            LoadPT();
        }
    }
}