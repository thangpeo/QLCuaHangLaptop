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
using System.Threading;

namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class LuongForm : Form
    {
        BangLuongBLL blBUS = new BangLuongBLL();
        CTLuongBLL ctlBUS = new CTLuongBLL();
        NhanVienBLL nvBUS = new NhanVienBLL();
        DiemDanhBLL diemdanh = new DiemDanhBLL();

        DataTable dtBL, dtCTL, dtNV;
        public LuongForm()
        {
            InitializeComponent();
        }

        private void LuongForm_Load(object sender, EventArgs e)
        {

            dtBL = blBUS.layDSBangLuong();
            dtNV = nvBUS.layDSNhanVien();

            this.dgvBL.DataSource = dtBL;
            this.dgvCTL.DataSource = dtCTL;
            moChiTietLuong(false);
        }

        private void reloadBLBtn_Click(object sender, EventArgs e)
        {
            dtBL = blBUS.layDSBangLuong();
            this.dgvBL.DataSource = dtBL;
        }

        private void taoBLMoiBtn_Click(object sender, EventArgs e)
        {
            BANGLUONG bl = new BANGLUONG();
            DateTime date = dateTimePicker1.Value;
            bl.MABL = string.Format("BLTHANG{0}NAM{1}", date.Month, date.Year);
            bl.GHICHU = txtGhiChu.Text;
            bl.THOIGIAN = date;
            bl.TONGTIEN = 0;
            if (blBUS.themBangLuong(bl))
            {
                MessageBox.Show(string.Format("Tạo mới bảng lương tháng {0} năm {1} thành công", date.Month, date.Year));
                NHANVIEN nv;

                foreach (DataRow row in dtNV.Rows)
                {
                    nv = nvBUS.layNhanVien(row["EMAIL"].ToString());
                    ctlBUS.themCTLChoBL(nv, diemdanh, bl.MABL);
                }
                dtBL = blBUS.layDSBangLuong();
                this.dgvBL.DataSource = dtBL;
            }
            else
            {
                MessageBox.Show(string.Format("Đã tồn tại bảng lương tháng {0} năm {1}", date.Month, date.Year));
                
            }
            
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            string filter = "TENNV LIKE '%{0}%' OR " +
                            "DIACHI LIKE '%{0}%' OR " +
                            "SDT LIKE '%{0}%' OR " +
                            "EMAIL LIKE '%{0}%'";
            dtCTL.DefaultView.RowFilter = string.Format(filter, txtTimKiemNV.Text);
        }

        private void suaGhiChuBtn_Click(object sender, EventArgs e)
        {
            if (txtMaBL.Text != string.Empty)
            {
                BANGLUONG bl = new BANGLUONG() { MABL = txtMaBL.Text, GHICHU = txtGhiChu.Text };
                blBUS = new BangLuongBLL();
                if (blBUS.suaBangLuong(bl))
                {
                    MessageBox.Show("Thay đổi ghi chú thành công");
                    dtBL = blBUS.layDSBangLuong();
                    dgvBL.DataSource = dtBL;
                }
                else
                {
                    MessageBox.Show("Thay đổi ghi chú thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bảng lương");
            }
        }

        

        private void dgvBL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBL.CurrentRow;
            if (row!= null)
            {
                txtMaBL.Text = row.Cells["MABL"].Value.ToString();
                txtGhiChu.Text = row.Cells["GHICHU"].Value.ToString();
            }
        }

        private void xemChiTietLuongBTn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvBL.CurrentRow;
            if (row != null)
            {
                moChiTietLuong(true);
                dtCTL = ctlBUS.layDSCTLuong(row.Cells["MABL"].Value.ToString());
                this.dgvCTL.DataSource = dtCTL;
            }
        }
        private void moChiTietLuong(bool isOpen)
        {
            if (isOpen)
            {
                panelBL.Dock = DockStyle.None;
                panelCTL.Dock = DockStyle.Fill;
                panelBL.Visible = false;
                panelCTL.Visible = true;
            }
            else
            {
                panelBL.Dock = DockStyle.Fill;
                panelCTL.Dock = DockStyle.None;
                panelBL.Visible = true;
                panelCTL.Visible = false;
            }
            
            
        }

        private void locBLBtn_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year,dateTimePicker1.Value.Month,1);
            DateTime d2 = d1.AddMonths(1).AddDays(-1);
            dtBL.DefaultView.RowFilter = string.Format("THOIGIAN >= '{0}' AND THOIGIAN <= '{1}'", d1, d2);
        }

        private void dongChiTietLuong_Click(object sender, EventArgs e)
        {
            moChiTietLuong(false);
        }

        private void xoaBLBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvBL.CurrentRow;
            if (row != null)
            {
                string mabl = row.Cells["MABL"].Value.ToString();
                ctlBUS.xoaCTLuongTheoBangLuong(mabl);
                blBUS = new BangLuongBLL();
                if (blBUS.xoaBangLuong(mabl))
                {
                    MessageBox.Show("Xóa bảng lương thành công");
                    dtBL = blBUS.layDSBangLuong();
                    this.dgvBL.DataSource = dtBL;
                }
                else
                {
                    MessageBox.Show("Xóa bảng lương thất bại");
                }
                
            }
            else
            {
                MessageBox.Show("Chưa chọn bảng lương");
            }
        }
    }
}
