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
    public partial class HoaDonForm : Form
    {
        HoaDonBLL hoadonBUS = new HoaDonBLL();
        CTHoaDonBLL cthdBUS = new CTHoaDonBLL();
        RPHoaDonBLL rpHoaDonbll = new RPHoaDonBLL();

        DataTable dtHD, dtCTHD, dtHoaDon;
        public HoaDonForm()
        {
            InitializeComponent();
        }
        private void dongCTHD()
        {
            this.panelCTHoaDon.Dock = DockStyle.Right;
            this.panelCTHoaDon.Size = new Size(0, this.panelCTHoaDon.Size.Height);

            this.panelHoaDon.Dock = DockStyle.Fill;
        }
        private void moCTHoaDon()
        {
            this.panelHoaDon.Dock = DockStyle.Left;
            this.panelHoaDon.Size = new Size(0, this.panelHoaDon.Size.Height);

            this.panelCTHoaDon.Dock = DockStyle.Fill;
        }
        private void reset()
        {
            txtKH.Text = string.Empty;
            txtNV.Text = string.Empty;
        }
        private void locHD(string nv, string kh)
        {
            string loc = "TENNV LIKE '%{0}%' AND TENKH LIKE '%{1}%'";
            (this.dgvHoaDon.DataSource as DataTable).DefaultView.RowFilter = string.Format(loc, nv, kh);
        }
        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            dongCTHD();
            dtHD = hoadonBUS.layDSHoaDon();
            this.dgvHoaDon.DataSource = dtHD;
        }

        private void chiTietHDBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row =dgvHoaDon.CurrentRow;
            if (row!=null)
	        {
                moCTHoaDon();   
                dtCTHD = cthdBUS.layDSCTHoaDon(int.Parse(row.Cells["MAHD"].Value.ToString()));
                this.dgvCTHD.DataSource = dtCTHD;   
            }
            
        }

        private void dongCTHDBtn_Click(object sender, EventArgs e)
        {
            dongCTHD();
        }


        private void lamMoiLocBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void locHDBtn_Click(object sender, EventArgs e)
        {
            
        }


        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.CurrentRow!=null)
            {
                chiTietHDBtn.Enabled = true;
                InHDBtn.Enabled = true;
            }
            else
            {
                chiTietHDBtn.Enabled = false;
                InHDBtn.Enabled = false;
            }
        }

        private void InHDBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHoaDon.CurrentRow;
            if (row != null)
            {                
                dtHoaDon = rpHoaDonbll.layrpHoaDon(int.Parse(row.Cells["MAHD"].Value.ToString()));
                //đổ dữ liệu vào report
                rpHoaDon baocaoHoaDon = new rpHoaDon();
                baocaoHoaDon.SetDataSource(dtHoaDon);

                //load report
                ReportForm rpHD = new ReportForm();
                rpHD.crpView.ReportSource = baocaoHoaDon;
                rpHD.ShowDialog();
            }
                        
        }

        private void baoHanhBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCTHD.CurrentRow;
            if (row != null)
            {
                TaoBaoHanhForm f = new TaoBaoHanhForm(int.Parse(row.Cells["MAHDCT"].Value.ToString()), int.Parse(row.Cells["MASP"].Value.ToString()));
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần bảo hành");
            }
        }

        private void txtNV_TextChanged(object sender, EventArgs e)
        {
            locHD(txtNV.Text, txtKH.Text);
        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            dtCTHD.DefaultView.RowFilter = "TENSP LIKE '%" + txtTimKiem.Text + "%'";
            txtTimKiem.Text = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dtCTHD.DefaultView.RowFilter = "";
        }


    }
}
