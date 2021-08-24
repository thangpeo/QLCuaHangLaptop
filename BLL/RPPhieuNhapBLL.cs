using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace DoAn_QuanLyCuaHangLaptop
{
    public class RPPhieuNhapBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public DataTable layrpPhieuNhap(int MAPN)
        {
            var query = from rppn in db.PHIEUNHAPs
                        join ctpn in db.CTPHIEUNHAPs on rppn.MAPN equals ctpn.MAPN
                        join nv in db.NHANVIENs on rppn.EMAIL equals nv.EMAIL
                        join ncc in db.NHACUNGCAPs on rppn.MANCC equals ncc.MANCC
                        join sp in db.SANPHAMs on ctpn.MASP equals sp.MASP
                        join nsx in db.NHASANXUATs on sp.MANSX equals nsx.MANSX
                        join dm in db.DANHMUCs on sp.MADM equals dm.MADM
                        where rppn.MAPN == MAPN
                        select new
                        {
                            MAPN = rppn.MAPN,
                            TENSP = sp.TENSP,
                            TENNV = nv.TENNV,
                            TONGTIEN = rppn.TONGTIEN,
                            DONGIA = ctpn.DONGIA,
                            SOLUONG = ctpn.SOLUONG,
                            THANHTIEN = ctpn.THANHTIEN,
                            TENNCC = ncc.TENNCC,
                            TENNSX = nsx.TENNSX,
                            TENDM = dm.TENDM,
                            DIACHI = ncc.DIACHI,
                            SDT = ncc.SDT,
                            NGAYLAP = rppn.NGAYLAP,
                            DIACHINV = nv.DIACHI,
                            SDTNV = nv.SDT
                        };
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(query) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
