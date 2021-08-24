using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public class CTHoaDonBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public DataTable layDSCTHoaDon(int MAHD)
        {
            var query = from cthd in db.CTHOADONs
                        join l in db.SANPHAMs on cthd.MASP equals l.MASP
                        where cthd.MAHD == MAHD
                        select new
                        {
                            MAHD = cthd.MAHD,
                            MASP = cthd.MASP,
                            DONGIA = cthd.DONGIA,
                            SOLUONG = cthd.SOLUONG,
                            THANHTIEN = cthd.THANHTIEN,
                            TENSP = l.TENSP
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themCTHoaDon(CTHOADON cthd)
        {
            try
            {
                db.CTHOADONs.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

    
    }
}
