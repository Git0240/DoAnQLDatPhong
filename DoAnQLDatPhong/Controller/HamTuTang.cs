﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnQLDatPhong.Controller
{
    class HamTuTang
    {
        ConnectionString connectDB = new ConnectionString();
        public string GetLastID(string nameTable, string nameSelectColumn)
        {
            SqlConnection con = connectDB.getConnection();
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT TOP 1 " + nameSelectColumn + " FROM " + nameTable + " ORDER BY " + nameSelectColumn + " DESC", con);
            return (string)sql.ExecuteScalar();

        }
        public string NextID(string lastID, string prefixID)
        {
            if (lastID == "")
            {
                return prefixID + "0001";  // fixwidth default
            }
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = lastID.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;

        }
    }
}
