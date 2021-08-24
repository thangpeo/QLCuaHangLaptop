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
    public class DanhMucBLL
    {
        LaptopDBDataContext db =new LaptopDBDataContext();
        public DataTable layDSDanhMuc()
        {
            SqlCommand cmd = db.GetCommand(db.DANHMUCs) as SqlCommand;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DANHMUC layDanhMuc(int madm)
        {
            return db.DANHMUCs.Where(x => x.MADM == madm).FirstOrDefault();
        }

        public bool themDanhMuc(DANHMUC dm)
        {
            try
            {
                db.DANHMUCs.InsertOnSubmit(dm);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;   
            }
        }
        public bool xoaDanhMuc(int madm)
        {
            try
            {
                db.DANHMUCs.DeleteOnSubmit(db.DANHMUCs.Where(x => x.MADM == madm).FirstOrDefault());
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;
            }
        }
        public bool suaDanhMuc(DANHMUC dm)
        {
            try
            {
                DANHMUC d = db.DANHMUCs.Where(x=>x.MADM == dm.MADM).FirstOrDefault();
                d.TENDM = dm.TENDM;
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
