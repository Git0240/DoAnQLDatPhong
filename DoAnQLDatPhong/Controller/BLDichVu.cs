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
    class BLDichVu
    {
        DALDichVu dalDV;
        public BLDichVu()
        {
            dalDV = new DALDichVu();
        }
        public DataTable LayDLDichVu()
        {
            return dalDV.LayDLDichVu();
        }
        public bool ThemDV(DichVu dv)
        {
            return dalDV.ThemDV(dv);
        }
        public bool SuaDV(DichVu dv)
        {
            return dalDV.SuaDV(dv);
        }
        public bool XoaDV(DichVu dv)
        {
            return dalDV.XoaDV(dv);
        }
        public DataTable TimKiemDV(string dv)
        {
            return dalDV.TimKiemDV(dv);
        }
    }
}
