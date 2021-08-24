using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class ChucVuBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public DataTable layDSChucVu()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(db.CHUCVUs.Where(x=>x.MACV != "ADMIN")) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public CHUCVU layChucVuNhanVien(string macv)
        {
            return db.CHUCVUs.Where(x => x.MACV == macv).FirstOrDefault();
        }
    }
}
