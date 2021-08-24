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
    public class CTPhieuNhapBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();

        public DataTable layDSCTPhieuNhap(int mapn)
        {
            var query = from ctpn in db.CTPHIEUNHAPs
                        join l in db.SANPHAMs on ctpn.MASP equals l.MASP
                        where ctpn.MAPN == mapn
                        select new
                        {
                            MAPN = ctpn.MAPN,
                            MASP = ctpn.MASP,
                            DONGIA = ctpn.DONGIA,
                            SOLUONG = ctpn.SOLUONG,
                            THANHTIEN = ctpn.THANHTIEN,
                            TENSP = l.TENSP
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool themCTPhieuNhap(CTPHIEUNHAP ctpn){
            try
            {
                db.CTPHIEUNHAPs.InsertOnSubmit(ctpn);
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
