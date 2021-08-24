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
    public class PhieuNhapBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();

        public DataTable layDSPhieuNhap(){
            var query = from pn in db.PHIEUNHAPs
                        join nv in db.NHANVIENs on pn.EMAIL equals nv.EMAIL
                        join ncc in db.NHACUNGCAPs on pn.MANCC equals ncc.MANCC
                        select new
                        {
                            MAPN = pn.MAPN,
                            NGAYLAP = pn.NGAYLAP,
                            TONGTIEN = pn.TONGTIEN,
                            EMAIL = pn.EMAIL,
                            MANCC = pn.MANCC,
                            TENNV = nv.TENNV,
                            TENNCC = ncc.TENNCC
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public PHIEUNHAP taoPhieuNhapMoi()
        {

            return new PHIEUNHAP();
        }
        public bool themPhieuNhap(PHIEUNHAP pn)
        {
            try
            {
                db.PHIEUNHAPs.InsertOnSubmit(pn);
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
