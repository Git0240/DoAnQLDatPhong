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
    class BLThietBi
    {
        DALThietBi dalTB;
        public BLThietBi()
        {
            dalTB = new DALThietBi();
        }
        public DataTable LayDLThietBi()
        {
            return dalTB.LayDLThietBi();
        }
        public bool ThemTB(ThietBi tb)
        {
            return dalTB.ThemTB(tb);
        }
    }
}
