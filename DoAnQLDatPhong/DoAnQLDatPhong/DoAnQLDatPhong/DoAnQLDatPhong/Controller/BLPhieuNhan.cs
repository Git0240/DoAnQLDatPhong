using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQLDatPhong.Controller
{
    class BLPhieuNhan
    {
        DALPhieuNhan dalpn;
        public BLPhieuNhan()
        {
            dalpn = new DALPhieuNhan();
        }
        public DataTable LayDLPNP()
        {
            return dalpn.LayDLPhieuNhanPhong();
        }
        public DataSet LoadKH()
        {
            return dalpn.LoadKH();
        }
        public DataTable LoadPhong()
        {
            return dalpn.LoadPhong();
        }
        public DataTable LoadPT()
        {
            return dalpn.LoadPT();
        }
    }
}
