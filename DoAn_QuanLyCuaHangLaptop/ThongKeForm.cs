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
    public partial class ThongKeForm : Form
    {

        NhanVienBLL nvBUS = new NhanVienBLL();
        HoaDonBLL hdBUS = new HoaDonBLL();
        SanPhamBLL spBUS = new SanPhamBLL();


        DataTable dtNV,dtHD,dtSP;
        public ThongKeForm()
        {
            InitializeComponent();
        }
        private void ThongKeForm_Load(object sender, EventArgs e)
        {
          
        }
        private void xemBDBtn_Click(object sender, EventArgs e)
        {
            string title = "Biểu đồ ";
            if (rdNgay.Checked)
            {
                dtNV = nvBUS.DoanhThuNhanVien(dtpDoanhThuNV.Value.Day, dtpDoanhThuNV.Value.Month, dtpDoanhThuNV.Value.Year);
                title += rdNgay.Text + " " + dtpDoanhThuNV.Value.Date.ToString("dd/MM/yyyy");
            }
            else if(rdThang.Checked)
            {
                dtNV = nvBUS.DoanhThuNhanVien(dtpDoanhThuNV.Value.Month, dtpDoanhThuNV.Value.Year);
                title += rdThang.Text + " " + dtpDoanhThuNV.Value.Date.ToString("MM/yyyy");
            }
            else
            {
                dtNV = nvBUS.DoanhThuNhanVien(dtpDoanhThuNV.Value.Year);
                title += rdNam.Text + " " + dtpDoanhThuNV.Value.Date.ToString("yyyy");
            }
            if (rdSoSP.Checked)
            {
                chartDoanhThuNV.Series[0].LegendText = rdSoSP.Text;
                chartDoanhThuNV.Series[0].Points.DataBind(dtNV.AsEnumerable(), "TENNV", "SOSP", "Label=SOSP");
            }
            else
            {
                chartDoanhThuNV.Series[0].LegendText = rdTongTien.Text;
                chartDoanhThuNV.Series[0].Points.DataBind(dtNV.AsEnumerable(), "TENNV", "THANHTIEN", "Label=THANHTIEN");
            }
            chartDoanhThuNV.Titles[0].Text = title;
        }

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Name == rdNgay.Name)
            {
                dtpDoanhThuNV.CustomFormat = "dd/MM/yyyy";
            }
            else if (r.Name == rdThang.Name)
            {
                dtpDoanhThuNV.CustomFormat = "MM/yyyy";
            }
            else
            {
                dtpDoanhThuNV.CustomFormat = "yyyy";
            }
        }

        private void rdTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Name == rdTheoNgay.Name)
            {
                dateTimePickerTab2.CustomFormat = "dd/MM/yyyy";
            }
            else if (r.Name == rdTheoThang.Name)
            {
                dateTimePickerTab2.CustomFormat = "MM/yyyy";
            }
            else
            {
                dateTimePickerTab2.CustomFormat = "yyyy";
            }
        }

        private void tylebanSPBtn_Click(object sender, EventArgs e)
        {
            string title = "Biểu đồ tỷ lệ bán sản phẩm";
            if (rdTheoNgay.Checked)
            {
                dtSP = spBUS.TyLeBanSanPham(dateTimePickerTab2.Value.Day, dateTimePickerTab2.Value.Month, dateTimePickerTab2.Value.Year);
                title += rdTheoNgay.Text + " " + dateTimePickerTab2.Value.Date.ToString("dd/MM/yyyy");
            }
            else if (rdTheoThang.Checked)
            {
                dtSP = spBUS.TyLeBanSanPham(dateTimePickerTab2.Value.Month, dateTimePickerTab2.Value.Year);
                title += rdTheoThang.Text + " " + dateTimePickerTab2.Value.Date.ToString("MM/yyyy");
            }
            else
            {
                dtSP = spBUS.TyLeBanSanPham(dateTimePickerTab2.Value.Year);
                title += rdTheoNam.Text + " " + dateTimePickerTab2.Value.Date.ToString("yyyy");
            }
            chartTyLeBanSP.Series[0].Points.DataBind(dtSP.AsEnumerable(), "", "SOSP", "Label=SOSP,LegendText=TENDM");
            chartTyLeBanSP.Titles[0].Text = title;
        }

        private void rdDTNam_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Name == rdDTThang.Name)
            {
                dateTimePickerTab3.CustomFormat = "MM/yyyy";
            }
            else
            {
                dateTimePickerTab3.CustomFormat = "yyyy";
            }
        }

        private void xemDoanhThu_Click(object sender, EventArgs e)
        {
            string title = "Doanh thu ";
            if (rdDTThang.Checked)
            {
                dtHD = hdBUS.DoanhThuSanPham(dateTimePickerTab3.Value.Month, dateTimePickerTab3.Value.Year);
                title += "Tháng " + dateTimePickerTab3.Value.Date.ToString("MM/yyyy");
            }
            else
            {
                dtHD = hdBUS.DoanhThuSanPham(dateTimePickerTab3.Value.Year);
                title += "Năm " + dateTimePickerTab3.Value.Date.ToString("yyyy");
            }
            if (rdDTSOSP.Checked)
            {
                chartDoanhThuNV.Series[0].LegendText = rdDTSOSP.Text;
                chartDoanhThuBanHang.Series[0].Points.DataBind(dtHD.AsEnumerable(), "CHISO", "SOSP", "Label=SOSP,LegendText=CHISO"); 
            }
            else
            {
                chartDoanhThuNV.Series[0].LegendText = rdDTTT.Text;
                chartDoanhThuBanHang.Series[0].Points.DataBind(dtHD.AsEnumerable(), "CHISO", "THANHTIEN", "Label=THANHTIEN,LegendText=CHISO"); 
            }
            chartDoanhThuBanHang.Titles[0].Text = title;
        }
    }
}
