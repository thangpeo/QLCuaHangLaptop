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
    public class BangLuongBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public DataTable layDSBangLuong()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(db.BANGLUONGs) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public BANGLUONG layBangLuong(string mabl)
        {
            return db.BANGLUONGs.Where(x => x.MABL == mabl).FirstOrDefault();
        }
        public bool themBangLuong(BANGLUONG bl)
        {
            try
            {
                db.BANGLUONGs.InsertOnSubmit(bl);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool xoaBangLuong(string mabl)
        {
            try
            {
                db.BANGLUONGs.DeleteOnSubmit(db.BANGLUONGs.Where(x=>x.MABL==mabl).FirstOrDefault());
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;

            }
        }
        public bool suaBangLuong(BANGLUONG bl)
        {
            try
            {
                BANGLUONG n = db.BANGLUONGs.Where(x => x.MABL == bl.MABL).FirstOrDefault();
                n.GHICHU = bl.GHICHU;
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
