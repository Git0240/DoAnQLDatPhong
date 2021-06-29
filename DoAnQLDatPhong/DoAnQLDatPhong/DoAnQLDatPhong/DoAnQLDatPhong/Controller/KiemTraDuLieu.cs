using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace DoAnQLDatPhong.Controller
{
    class KiemTraDuLieu
    {
        public static bool KtraKieuDL(TextEdit txt, String tb)
        {
            if (txt.Text == "")
            {
                XtraMessageBox.Show(txt, "Bạn chưa nhập " + tb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.Focus();
                txt.SelectAll();
                return false;
            }

            try
            {
                int a = int.Parse(txt.Text);
                return true;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(txt, "Kiểu dữ liệu " + tb + " không hợp lệ", "Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt.Focus();
                txt.SelectAll();
                return false;
            }
        }
        public static bool KtraRong(TextEdit txt, String tb)
        {
            if (txt.Text == "")
            {
                XtraMessageBox.Show(txt, "Bạn chưa nhập " + tb, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.Focus();
                txt.SelectAll();
                return false;
            }
            return true;
        }
    }
}
