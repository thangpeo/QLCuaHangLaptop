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
    public class BaoHanhBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();

        public DataTable layDSPhieuBaoHanh(){
            DataTable dt = new DataTable();
            var query = from bh in db.BAOHANHs
                        join hd in db.HOADONs on bh.MAHD equals hd.MAHD
                        join kh in db.KHACHHANGs on hd.MAKH equals kh.MAKH
                        join sp in db.SANPHAMs on bh.MASP equals sp.MASP
                        select new
                        {
                            TENSP = sp.TENSP,
                            TENKH = kh.TENKH,
                            LANBH = bh.LANBH,
                            NGAYBAOHANH = bh.NGAYBH,
                            LYDO = bh.LYDO,
                            TIENBH = bh.TIENBH,
                            MAHD = bh.MAHD,
                            MASP = bh.MASP
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themPhieuBaoHanh(BAOHANH bh)
        {
            try
            {
                BAOHANH b= db.BAOHANHs.Where(x=>x.MAHD==bh.MAHD && x.MASP == bh.MASP).FirstOrDefault();
                if (b!=null)
                {
                    bh.LANBH = b.LANBH + 1;
                }
                else
                {
                    bh.LANBH = 1;
                }
                db.BAOHANHs.InsertOnSubmit(bh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaPhieuBaoHanh(BAOHANH bh)
        {
            try
            {
                db.BAOHANHs.DeleteOnSubmit(db.BAOHANHs.Where(x => x.MAHD == bh.MAHD && x.MASP == bh.MASP && x.LANBH == bh.LANBH).FirstOrDefault());
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;
            }
        }
        public bool suaPhieuBaoHanh(BAOHANH bh)
        {
            try
            {
                BAOHANH b = db.BAOHANHs.Where(x => x.MAHD == bh.MAHD && x.MASP == bh.MASP && x.LANBH == bh.LANBH).FirstOrDefault();
                b.LYDO = bh.LYDO;
                b.TIENBH = bh.TIENBH;
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
