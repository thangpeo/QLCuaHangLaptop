using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class TaoBaoHanhForm : Form
    {
        HoaDonBLL hdBUS = new HoaDonBLL();
        SanPhamBLL spBUS = new SanPhamBLL();
        KhachHangBLL khBUS = new KhachHangBLL();
        BaoHanhBLL baoHanhBUS = new BaoHanhBLL();
        int mahd, masp;
        public TaoBaoHanhForm()
        {
            InitializeComponent();
        }
        public TaoBaoHanhForm(int mahd, int masp)
        {
            this.mahd = mahd;
            this.masp = masp;
            InitializeComponent();
            
        }
       
        private void thoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaoBaoHanhForm_Load(object sender, EventArgs e)
        {
            HOADON hd = hdBUS.layHoaDon(mahd);
            SANPHAM sp = spBUS.laySanPham(masp);
            KHACHHANG kh = khBUS.layKhachHang(hd.MAKH.Value);

            txtTenKH.Text = kh.TENKH;
            txtTenSP.Text = sp.TENSP;
            DateTime ngayBaoHanh = hd.NGAYLAP.Value.AddMonths(sp.THOIGIANBAOHANH.Value);
            if (DateTime.Compare(DateTime.Now,ngayBaoHanh)<=0)
            {
                txtGia.Enabled = false;
            }
            txtGia.Text = "0";    
        }
        private void taoPhieuBaoHanh_Click(object sender, EventArgs e)
        {
            BAOHANH bh = new BAOHANH();
            bh.MAHD = this.mahd;
            bh.MASP = this.masp;
            bh.NGAYBH = DateTime.Now;
            bh.TIENBH =double.Parse(txtGia.Text);
            bh.LYDO = txtLydo.Text;
            if (baoHanhBUS.themPhieuBaoHanh(bh))
            {
                MessageBox.Show("Tạo phiếu bảo hành thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo phiếu bảo hành thất bại");
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
