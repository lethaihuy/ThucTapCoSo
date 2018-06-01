using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhaDat_version2
{
    public class KetNoi
    {
        public SqlConnection con = new SqlConnection();

        public void Connect()
        {
            string chuoiCon = @"Data Source=HUY\SQLEXPRESS;Initial Catalog=QuanLyNhaDat;Integrated Security=True";

            con.ConnectionString = chuoiCon;
            con.Open();
        }
    }
}
