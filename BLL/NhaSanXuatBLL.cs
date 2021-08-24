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
    public class NhaSanXuatBLL
    {
        
        LaptopDBDataContext db = new LaptopDBDataContext();
        public NHASANXUAT layNhaSanXuat(string id)
        {
            return db.NHASANXUATs.Where(x => x.MANSX == id).FirstOrDefault();
        }
        public DataTable layDSNhaSanXuat()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(db.NHASANXUATs) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themNhaSanXuat(NHASANXUAT nsx)
        {
            try
            {
                db.NHASANXUATs.InsertOnSubmit(nsx);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }
        public bool xoaNhaSanXuat(string MANSX)
        {
            try
            {
                NHASANXUAT n = db.NHASANXUATs.Where(x => x.MANSX == MANSX).FirstOrDefault();
                db.NHASANXUATs.DeleteOnSubmit(n);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;
             
            }
        }
        public bool suaNhaSanXuat(NHASANXUAT nsx)
        {
            try
            {
                NHASANXUAT n = db.NHASANXUATs.Where(x => x.MANSX == nsx.MANSX).FirstOrDefault();
                n.TENNSX = nsx.TENNSX;
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
