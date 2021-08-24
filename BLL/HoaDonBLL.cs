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
    public class HoaDonBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public HOADON taoHoaDonMoi()
        {
            return new HOADON();
        }
        public HOADON layHoaDon(int mahd)
        {
            return db.HOADONs.Where(x => x.MAHD == mahd).FirstOrDefault();
        }
        public DataTable layDSHoaDon()
        {
            var query = from hd in db.HOADONs
                        join nv in db.NHANVIENs on hd.EMAIL equals nv.EMAIL
                        join kh in db.KHACHHANGs on hd.MAKH equals kh.MAKH
                        select new 
                        {
                            MAHD= hd.MAHD,
                            NGAYLAP=hd.NGAYLAP,
                            TONGTIEN=hd.TONGTIEN,
                            EMAIL=hd.EMAIL,
                            MAKH=hd.MAKH,
                            TENNV=nv.TENNV,
                            TENKH=kh.TENKH
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themHoaDon(HOADON hd)
        {
            try
            {
                db.HOADONs.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public DataTable DoanhThuSanPham(int thang, int nam)
        {
            DataTable dt = new DataTable();
            var query = from nv in db.NHANVIENs
                        join h in db.HOADONs on nv.EMAIL equals h.EMAIL into hds
                        from hd in hds.DefaultIfEmpty()
                        join ct in db.CTHOADONs on hd.MAHD equals ct.MAHD into cthds
                        from cthd in cthds.DefaultIfEmpty()
                        where (hd.NGAYLAP.Value.Year == nam && hd.NGAYLAP.Value.Month == thang)
                        group new { cthd.THANHTIEN, cthd.SOLUONG } by hd.NGAYLAP.Value.Day into g
                        select new
                        {
                            CHISO = g.Key,
                            SOSP = g.Sum(x => x.SOLUONG).GetValueOrDefault(),
                            THANHTIEN = g.Sum(x => x.THANHTIEN).GetValueOrDefault()
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable DoanhThuSanPham(int nam)
        {
            DataTable dt = new DataTable();
            var query = from nv in db.NHANVIENs
                        join h in db.HOADONs on nv.EMAIL equals h.EMAIL into hds
                        from hd in hds.DefaultIfEmpty()
                        join ct in db.CTHOADONs on hd.MAHD equals ct.MAHD into cthds
                        from cthd in cthds.DefaultIfEmpty()
                        where (hd.NGAYLAP.Value.Year == nam)
                        group new { cthd.THANHTIEN, cthd.SOLUONG } by hd.NGAYLAP.Value.Month into g
                        select new
                        {
                            CHISO = g.Key,
                            SOSP = g.Sum(x => x.SOLUONG).GetValueOrDefault(),
                            THANHTIEN = g.Sum(x => x.THANHTIEN).GetValueOrDefault()
                        };
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
