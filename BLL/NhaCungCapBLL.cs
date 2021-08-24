using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        
        public NHACUNGCAP layNhaCungCap(int mancc)
        {
            return db.NHACUNGCAPs.Where(x => x.MANCC == mancc).FirstOrDefault();
        }
        public DataTable layDSNhaCungCap()
        {
            SqlCommand cmd = db.GetCommand(db.NHACUNGCAPs) as SqlCommand;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public NHACUNGCAP taoNhaCungCapMoi()
        {
            return new NHACUNGCAP();
        }
        public bool themNhaCungCap(NHACUNGCAP ncc)
        {
            try
            {
                db.NHACUNGCAPs.InsertOnSubmit(ncc);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaNhaCungCap(int mancc)
        {
            try
            {
                NHACUNGCAP ncc = db.NHACUNGCAPs.Where(x => x.MANCC == mancc).FirstOrDefault();
                db.NHACUNGCAPs.DeleteOnSubmit(ncc);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;
            }
        }
        public bool suaNhaCungCap(NHACUNGCAP ncc)
        {
            try
            {
                NHACUNGCAP n = db.NHACUNGCAPs.Where(x=>x.MANCC == ncc.MANCC).FirstOrDefault();
                n.TENNCC = ncc.TENNCC;
                n.DIACHI = ncc.DIACHI;
                n.SDT = ncc.SDT;
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
