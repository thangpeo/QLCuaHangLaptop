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
    public class SanPhamBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public DataTable layDSSanPham()
        {
            DataTable dt = new DataTable();
            var query = from LT in db.SANPHAMs
                        join NSX in db.NHASANXUATs on LT.MANSX equals NSX.MANSX
                        join DM in db.DANHMUCs on LT.MADM equals DM.MADM
                        select new
                        {
                            MASP = LT.MASP,
                            TENSP= LT.TENSP,
                            MOTA= LT.MOTA,
                            XUATXU  = LT.XUATXU,
                            THOIDIEMRAMAT=LT.THOIDIEMRAMAT,
                            HINHANH=LT.HINHANH,
                            GIANHAP = LT.GIANHAP,
                            GIABAN=LT.GIABAN,
                            SLTON=LT.SLTON,
                            MANSX=LT.MANSX,
                            TENNSX=NSX.TENNSX,
                            MADM = DM.MADM,
                            TENDM = DM.TENDM
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable layDSSanPham(int MADM)
        {
            DataTable dt = new DataTable();
            var query = from LT in db.SANPHAMs
                        join NSX in db.NHASANXUATs on LT.MANSX equals NSX.MANSX
                        join DM in db.DANHMUCs on LT.MADM equals DM.MADM
                        where DM.MADM == MADM
                        select new
                        {
                            MASP = LT.MASP,
                            TENSP = LT.TENSP,
                            MOTA = LT.MOTA,
                            XUATXU = LT.XUATXU,
                            THOIDIEMRAMAT = LT.THOIDIEMRAMAT,
                            HINHANH = LT.HINHANH,
                            GIANHAP = LT.GIANHAP,
                            GIABAN = LT.GIABAN,
                            SLTON = LT.SLTON,
                            MANSX = LT.MANSX,
                            TENNSX = NSX.TENNSX,
                            MADM = DM.MADM,
                            TENDM = DM.TENDM
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themSanPham(SANPHAM l)
        {
            try
            {
                db.SANPHAMs.InsertOnSubmit(l);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool xoaSanPham(int id)
        {
            try
            {
                SANPHAM l = db.SANPHAMs.Where(x => x.MASP == id).FirstOrDefault();
                db.SANPHAMs.DeleteOnSubmit(l);
                db.SubmitChanges();
                db.ChangeConflicts.ResolveAll(System.Data.Linq.RefreshMode.KeepCurrentValues);
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;

            }
        }
        public bool suaSanPham(SANPHAM l)
        {
            try
            {
                SANPHAM sp = db.SANPHAMs.Where(x => x.MASP == l.MASP).FirstOrDefault();
                sp.TENSP = l.TENSP;
                sp.MOTA = l.MOTA;
                sp.XUATXU = l.XUATXU;
                sp.THOIDIEMRAMAT = l.THOIDIEMRAMAT;
                sp.MANSX = l.MANSX;
                sp.SLTON = l.SLTON;
                sp.MADM = l.MADM;
                sp.HINHANH = l.HINHANH;
                sp.GIABAN = l.GIABAN;
                sp.GIANHAP = l.GIANHAP;
                db.SubmitChanges();

                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public SANPHAM laySanPham(int id)
        {
            return db.SANPHAMs.Where(x => x.MASP == id).FirstOrDefault();
        }

        public DataTable TyLeBanSanPham(int ngay,int thang,int nam)
        {
            DataTable dt = new DataTable();
            var query = from dm in db.DANHMUCs

                        join s in db.SANPHAMs on dm.MADM equals s.MADM into sps
                        from sp in sps

                        join ct in db.CTHOADONs on sp.MASP equals ct.MASP into cts
                        from cthd in cts

                        join h in db.HOADONs on cthd.MAHD equals h.MAHD into hds
                        from hd in hds

                        where (hd.NGAYLAP.Value.Day == ngay && hd.NGAYLAP.Value.Month == thang && hd.NGAYLAP.Value.Year == nam) 
                        group new { cthd.SOLUONG, cthd.THANHTIEN } by dm.TENDM into g
                        select new
                        {
                            TENDM = g.Key,
                            SOSP = g.Sum(x=>x.SOLUONG.GetValueOrDefault())
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TyLeBanSanPham( int thang, int nam)
        {
            DataTable dt = new DataTable();
            var query = from dm in db.DANHMUCs

                        join s in db.SANPHAMs on dm.MADM equals s.MADM into sps
                        from sp in sps

                        join ct in db.CTHOADONs on sp.MASP equals ct.MASP into cts
                        from cthd in cts

                        join h in db.HOADONs on cthd.MAHD equals h.MAHD into hds
                        from hd in hds

                        where ( hd.NGAYLAP.Value.Month == thang && hd.NGAYLAP.Value.Year == nam) 
                        group new { cthd.SOLUONG, cthd.THANHTIEN } by dm.TENDM into g
                        select new
                        {
                            TENDM = g.Key,
                            SOSP = g.Sum(x => x.SOLUONG.GetValueOrDefault())
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TyLeBanSanPham(int nam)
        {
            DataTable dt = new DataTable();
            var query = from dm in db.DANHMUCs

                        join s in db.SANPHAMs on dm.MADM equals s.MADM into sps
                        from sp in sps

                        join ct in db.CTHOADONs on sp.MASP equals ct.MASP into cts
                        from cthd in cts

                        join h in db.HOADONs on cthd.MAHD equals h.MAHD into hds
                        from hd in hds

                        where (hd.NGAYLAP.Value.Year == nam) 
                        group new { cthd.SOLUONG, cthd.THANHTIEN } by dm.TENDM into g
                        select new
                        {
                            TENDM = g.Key,
                            SOSP = g.Sum(x => x.SOLUONG.GetValueOrDefault()),
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

      
    }
}
