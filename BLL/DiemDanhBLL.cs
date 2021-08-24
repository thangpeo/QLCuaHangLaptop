using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DiemDanhBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public bool ktDiemDanh(string email)
        {
            return db.DIEMDANHs.Any(x => x.EMAIL == email && x.NGAYDIEMDANH == DateTime.Now);
        }
        public bool diemDanh(string email)
        {
            try
            {
                DIEMDANH dd = new DIEMDANH();
                dd.EMAIL = email;
                dd.NGAYDIEMDANH = DateTime.Now;
                db.DIEMDANHs.InsertOnSubmit(dd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int soNgayDiLam(string email, int thang, int nam)
        {
            return db.DIEMDANHs.Count(x => x.EMAIL == email && x.NGAYDIEMDANH.Month == thang && x.NGAYDIEMDANH.Year == nam);
        }
    }
}
