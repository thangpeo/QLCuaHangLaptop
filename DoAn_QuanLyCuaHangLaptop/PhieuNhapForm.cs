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
    public partial class PhieuNhapForm : Form
    {
        CTPhieuNhapBLL ctphieunhapnBUS = new CTPhieuNhapBLL();
        PhieuNhapBLL phieunhapBUS = new PhieuNhapBLL();
        RPPhieuNhapBLL rpPhieuNhapBUS = new RPPhieuNhapBLL();
        NhaCungCapBLL nccBus = new NhaCungCapBLL();
        NhanVienBLL nvBus = new NhanVienBLL();

        DataTable dtPN, dtCTPN, dtPhieuNhap;

        public PhieuNhapForm()
        {
            InitializeComponent();
        }
        private void dongCTPN()
        {
            this.panelCTPhieuNhap.Dock = DockStyle.Right;
            this.panelCTPhieuNhap.Size = new Size(0, this.panelCTPhieuNhap.Size.Height);

            this.panelPhieuNhap.Dock = DockStyle.Fill;
        }
        private void moCTPhieuNhap()
        {
            this.panelPhieuNhap.Dock = DockStyle.Left;
            this.panelPhieuNhap.Size = new Size(0, this.panelPhieuNhap.Size.Height);

            this.panelCTPhieuNhap.Dock = DockStyle.Fill;
        }
        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            dongCTPN();

            dtPN = phieunhapBUS.layDSPhieuNhap();
            dgvPhieuNhap.DataSource = dtPN;

            cbbNhanVien.DataSource = nvBus.layDSNhanVien();
            cbbNhanVien.DisplayMember = "TENNV";
            cbbNhanVien.ValueMember = "EMAIL";

            cbbNCC.DataSource = nccBus.layDSNhaCungCap();
            cbbNCC.DisplayMember = "TENNCC";
            cbbNCC.ValueMember = "MANCC";
            
            
        }

        private void chiTietPNBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPhieuNhap.CurrentRow;
            if (row != null)
            {
                dtCTPN = ctphieunhapnBUS.layDSCTPhieuNhap(int.Parse(row.Cells["MAPN"].Value.ToString()));
                dgvCTPhieuNhap.DataSource = dtCTPN;
                moCTPhieuNhap();
            }
        }

        private void dongCTPNBtn_Click(object sender, EventArgs e)
        {
            dongCTPN();
        }

        private void lamMoiLocBtn_Click(object sender, EventArgs e)
        {
            dtPN.DefaultView.RowFilter = "";
        }

        private void InPNBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPhieuNhap.CurrentRow;
            if (row != null)
            {
                dtPhieuNhap = rpPhieuNhapBUS.layrpPhieuNhap(int.Parse(row.Cells["MAPN"].Value.ToString()));
                //đổ dữ liệu
                rpPhieuNhap baocao = new rpPhieuNhap();
                baocao.SetDataSource(dtPhieuNhap);

                //load report
                ReportForm rpPN = new ReportForm();
                rpPN.crpView.ReportSource = baocao;
                rpPN.ShowDialog();
            }
        }

        private void locTheoNVBtn_Click(object sender, EventArgs e)
        {
            dtPN.DefaultView.RowFilter = string.Format("EMAIL = '{0}'",cbbNhanVien.SelectedValue.ToString());
        }

        private void locTheoNCCBtn_Click(object sender, EventArgs e)
        {
            dtPN.DefaultView.RowFilter = string.Format("MANCC = '{0}'", cbbNCC.SelectedValue.ToString());
        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            dtCTPN.DefaultView.RowFilter = "TENSP LIKE '%" + txtTimKiem.Text + "%'";
            txtTimKiem.Text = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dtCTPN.DefaultView.RowFilter = "";
        }
    }
}
