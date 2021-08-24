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
    public class KhachHangBLL
    {
        LaptopDBDataContext db = new LaptopDBDataContext();
        public KHACHHANG khachVangLai()
        {
            return db.KHACHHANGs.Where(x=>x.MAKH==0).FirstOrDefault();
        }
        public KHACHHANG layKhachHang(int makh)
        {
            return db.KHACHHANGs.Where(x => x.MAKH == makh).FirstOrDefault();
        }
        public DataTable layDSKhachHang()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = db.GetCommand(db.KHACHHANGs) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dt.Rows.RemoveAt(0);
            return dt;
        }
        public bool themKhachHang(KHACHHANG kh)
        {
            try
            {
                db.KHACHHANGs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool xoaKhachHang(int makh)
        {
            try
            {
                db.KHACHHANGs.DeleteOnSubmit(db.KHACHHANGs.Where(x=>x.MAKH == makh).FirstOrDefault());
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db = new LaptopDBDataContext();
                return false;

            }
        }
        public bool suaKhachHang(KHACHHANG kh)
        {
            try
            {
                KHACHHANG k = db.KHACHHANGs.Where(x => x.MAKH == kh.MAKH).FirstOrDefault();
                k.TENKH = kh.TENKH;
                k.NGAYSINH = kh.NGAYSINH;
                k.DIACHI = kh.DIACHI;
                k.SDT = kh.SDT;
                k.CMND = kh.CMND;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                db.Connection.Close();
                return false;
            }
        }
    }
}
