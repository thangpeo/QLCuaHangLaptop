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
    public class CTLuongBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public DataTable layDSCTLuong(string mabl)
        {
            var query = from ctl in db.CTLUONGs
                        join nv in db.NHANVIENs on ctl.EMAIL equals nv.EMAIL
                        where ctl.MABL == mabl
                        select new
                        {
                            MABL = ctl.MABL,
                            SONGAYLAM = ctl.SONGAYLAM,
                            LUONG = ctl.LUONG,
                            EMAIL = nv.EMAIL,
                            TENNV = nv.TENNV,
                            NGAYSINH = nv.NGAYSINH,
                            DIACHI = nv.DIACHI,
                            SDT = nv.SDT
                        };

            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public void themCTLChoBL(NHANVIEN nv,DiemDanhBLL diemdanh, string mabl)
        {
            CTLUONG ctl = new CTLUONG();
            ctl.EMAIL = nv.EMAIL;
            ctl.MABL = mabl;

            DateTime ngaythang = db.BANGLUONGs.Where(x => x.MABL == mabl).FirstOrDefault().THOIGIAN.Value;
            int ngaytrongthang = DateTime.DaysInMonth(ngaythang.Year,ngaythang.Month);
            int ngaycongchuan = ngaytrongthang;
            DateTime ngaybatdaucuathang = new DateTime(ngaythang.Year, ngaythang.Month, 1);

            for (int i = 0; i < ngaytrongthang; i++)
			{
                if (ngaybatdaucuathang.AddDays(i).DayOfWeek == DayOfWeek.Sunday)
                {
                    ngaycongchuan--;
                }
			}
            ctl.SONGAYLAM = diemdanh.soNgayDiLam(nv.EMAIL, ngaythang.Month, ngaythang.Year);
            ctl.LUONG = (nv.HESOLUONG.Value * nv.LUONGCOBAN.Value + nv.PHUCAP.Value) / ngaycongchuan * ctl.SONGAYLAM.Value;

            themCTLuong(ctl);
        }
        public bool themCTLuong(CTLUONG ctl)
        {
            try
            {
                db.CTLUONGs.InsertOnSubmit(ctl);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool xoaCTLuongTheoBangLuong(string mabl)
        {
            try
            {
                db.CTLUONGs.DeleteAllOnSubmit(db.CTLUONGs.Where(x=>x.MABL == mabl).ToList());
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;

            }
        }
    }
}
