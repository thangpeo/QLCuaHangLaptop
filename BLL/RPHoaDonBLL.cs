using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class RPHoaDonBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public DataTable layrpHoaDon(int MAHD)
        {
            var query = from rphd in db.HOADONs
                        join cthd in db.CTHOADONs on rphd.MAHD equals cthd.MAHD
                        join kh in db.KHACHHANGs on rphd.MAKH equals kh.MAKH
                        join nv in db.NHANVIENs on rphd.EMAIL equals nv.EMAIL
                        join sp in db.SANPHAMs on cthd.MASP equals sp.MASP
                        where rphd.MAHD == MAHD
                        select new
                        {
                            MAHD = rphd.MAHD,
                            TENSP = sp.TENSP,
                            TENKH = kh.TENKH,
                            DIACHI = kh.DIACHI,
                            SDT = kh.SDT,
                            DONGIA = cthd.DONGIA,
                            SOLUONG = cthd.SOLUONG,
                            THANHTIEN = cthd.THANHTIEN,
                            TENNV = nv.TENNV,
                            TONGTIEN = rphd.TONGTIEN,
                            NGAYLAP = rphd.NGAYLAP,
                            DIACHINV = nv.DIACHI,
                            SDTNV = nv.SDT,
                            THOIGIANBAOHANH = sp.THOIGIANBAOHANH
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
