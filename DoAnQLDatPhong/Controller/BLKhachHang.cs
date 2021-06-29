using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQLDatPhong.Models;

namespace DoAnQLDatPhong.Controller
{
    class BLKhachHang
    {
        DALKhachHang dalKH;
        public BLKhachHang()
        {
            dalKH = new DALKhachHang();
        }
        public DataTable LayDuLieuKH()
        {
            return dalKH.LayDLKhachHang();
        }
        public bool ThemKh(KhachHang kh)
        {
            return dalKH.ThemKH(kh);
        }
        public bool XoaKH(KhachHang kh)
        {
            return dalKH.XoaKH(kh);
        }
        public bool SuaKH(KhachHang kh)
        {
            return dalKH.SuaKH(kh);
        }
        public DataTable TimLiemKH(string kh)
        {
            return dalKH.TimKiemKH(kh);
        }
    }
}
