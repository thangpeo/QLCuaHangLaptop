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
    public class NhanVienBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public DataTable layDSNhanVien()
        {
            var query = from nv in db.NHANVIENs
                        join cv in db.CHUCVUs on nv.MACV equals cv.MACV
                        where nv.EMAIL != "ADMIN"
                        select new
                        {
                            EMAIL = nv.EMAIL,
                            TENNV = nv.TENNV,
                            NGAYSINH = nv.NGAYSINH,
                            DIACHI = nv.DIACHI,
                            SDT = nv.SDT,
                            MATKHAU = nv.MATKHAU,
                            HESOLUONG = nv.HESOLUONG,
                            LUONGCOBAN = nv.LUONGCOBAN,
                            NGAYVAOLAM = nv.NGAYVAOLAM,
                            PHUCAP = nv.PHUCAP,
                            HOATDONG = nv.HOATDONG,
                            MACV = nv.MACV,
                            TENCV = cv.TENCV                            
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable layDSNhanVienHoatDong()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(db.NHANVIENs.Where(x=>x.HOATDONG == true)) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool themNhanVien(NHANVIEN nv)
        {
            try
            {
                if (db.NHANVIENs.Any(x=>x.EMAIL==nv.EMAIL))
                {
                    return false;
                }
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool xoaNhanVien(string EMAIL)
        {
            try
            {
                NHANVIEN nv = db.NHANVIENs.Where(x => x.EMAIL == EMAIL).FirstOrDefault();
                db.NHANVIENs.DeleteOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;

            }
        }
        
        public bool suaNhanVien(NHANVIEN nv)
        {
            try
            {
                NHANVIEN n = db.NHANVIENs.Where(x => x.EMAIL == nv.EMAIL).FirstOrDefault();
                n.TENNV = nv.TENNV;
                n.NGAYSINH = nv.NGAYSINH;
                n.DIACHI = nv.DIACHI;
                n.SDT = nv.SDT;
                n.MATKHAU = nv.MATKHAU;
                n.MACV = nv.MACV;
                n.HESOLUONG = nv.HESOLUONG;
                n.LUONGCOBAN = nv.LUONGCOBAN;
                n.NGAYVAOLAM = nv.NGAYVAOLAM;
                n.PHUCAP = nv.PHUCAP;
                n.HOATDONG = nv.HOATDONG;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ktDangNhap(string taikhoan, string matkhau)
        {
            if (db.NHANVIENs.Any(x=>x.EMAIL == taikhoan && x.MATKHAU == matkhau))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ktHoatDong(string taikhoan, string matkhau)
        {
            return db.NHANVIENs.Where(x => x.EMAIL == taikhoan && x.MATKHAU == matkhau).FirstOrDefault().HOATDONG.Value;
        }

        public NHANVIEN layNhanVien(string email)
        {
            return db.NHANVIENs.Where(x => x.EMAIL == email).FirstOrDefault();
        }

        public bool thaydoiHoatDongNhanVien(NHANVIEN nv)
        {
            try
            {
                NHANVIEN n = db.NHANVIENs.Where(x => x.EMAIL == nv.EMAIL).FirstOrDefault();
                n.HOATDONG = !nv.HOATDONG;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable DoanhThuNhanVien(int ngay,int thang,int nam)
        {
            var query = from nv in db.NHANVIENs
                        join h in db.HOADONs on nv.EMAIL equals h.EMAIL into hds
                        from hd in hds.DefaultIfEmpty()
                        join ct in db.CTHOADONs on hd.MAHD equals ct.MAHD into cthds
                        from cthd in cthds.DefaultIfEmpty()
                        where (hd.NGAYLAP.Value.Day == ngay && hd.NGAYLAP.Value.Month == thang && hd.NGAYLAP.Value.Year == nam) 
                        group new { cthd.THANHTIEN, cthd.SOLUONG} by nv.TENNV into g
                        select new
                        {
                            TENNV = g.Key,
                            SOSP = g.Sum(x=>x.SOLUONG),
                            THANHTIEN = g.Sum(x=>x.THANHTIEN).GetValueOrDefault()
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable DoanhThuNhanVien(int thang, int nam)
        {
            var query = from nv in db.NHANVIENs
                        join h in db.HOADONs on nv.EMAIL equals h.EMAIL into hds
                        from hd in hds.DefaultIfEmpty()
                        join ct in db.CTHOADONs on hd.MAHD equals ct.MAHD into cthds
                        from cthd in cthds.DefaultIfEmpty()
                        where (hd.NGAYLAP.Value.Month == thang && hd.NGAYLAP.Value.Year == nam) 
                        group new { cthd.THANHTIEN, cthd.SOLUONG } by nv.TENNV into g
                        select new
                        {
                            TENNV = g.Key,
                            SOSP = g.Sum(x => x.SOLUONG),
                            THANHTIEN = g.Sum(x => x.THANHTIEN).GetValueOrDefault()
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable DoanhThuNhanVien(int nam)
        {
            var query = from nv in db.NHANVIENs
                        join h in db.HOADONs on nv.EMAIL equals h.EMAIL into hds
                        from hd in hds.DefaultIfEmpty()
                        join ct in db.CTHOADONs on hd.MAHD equals ct.MAHD into cthds
                        from cthd in cthds.DefaultIfEmpty()
                        where (hd.NGAYLAP.Value.Year == nam) 
                        group new { cthd.THANHTIEN, cthd.SOLUONG } by nv.TENNV into g
                        select new
                        {
                            TENNV = g.Key,
                            SOSP = g.Sum(x => x.SOLUONG),
                            THANHTIEN = g.Sum(x => x.THANHTIEN).GetValueOrDefault()
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }


        public bool doiMatKhau(string email,string matkhaucu, string matkhaumoi)
        {
            try
            {
                NHANVIEN n = db.NHANVIENs.Where(x => x.EMAIL == email && x.MATKHAU == matkhaucu).FirstOrDefault();
                n.MATKHAU = matkhaumoi;
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
