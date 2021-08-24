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
    public partial class DanhMucForm : Form
    {
        DanhMucBLL danhmucBUS = new DanhMucBLL();
        DataTable dtDM;

        public DanhMucForm()
        {
            InitializeComponent();
        }
        private void loadDGV()
        {
            dtDM = danhmucBUS.layDSDanhMuc();
            dgvDanhMuc.DataSource = dtDM;
        }
        private void reset()
        {
            txtMaDM.Text = string.Empty;
            txtTenDM.Text = string.Empty;
            xoaDMBtn.Enabled = false;
            suaDMBtn.Enabled = false;
            themDMBtn.Enabled = true;
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhMuc.CurrentRow;
            if (row != null)
            {
                txtMaDM.Text = row.Cells[0].Value.ToString();
                txtTenDM.Text = row.Cells[1].Value.ToString();
                xoaDMBtn.Enabled = true;
                suaDMBtn.Enabled = true;
                themDMBtn.Enabled = false;
            }
            else
            {
                txtMaDM.Text = string.Empty;
                txtTenDM.Text = string.Empty;
                xoaDMBtn.Enabled = false;
                suaDMBtn.Enabled = false;
                themDMBtn.Enabled = true;
            }
        }
        
        private void DanhMucForm_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void themDMBtn_Click(object sender, EventArgs e)
        {
            DANHMUC dm = new DANHMUC() { TENDM = txtTenDM.Text};
            if (danhmucBUS.themDanhMuc(dm))
            {
                MessageBox.Show("Thêm " + dm.TENDM + " thành công");
                loadDGV();
                reset();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void suaDMBtn_Click(object sender, EventArgs e)
        {
            DANHMUC dm = new DANHMUC() {MADM = int.Parse(txtMaDM.Text), TENDM = txtTenDM.Text };
            if (danhmucBUS.suaDanhMuc(dm))
            {
                MessageBox.Show("Sửa " + dm.TENDM + " thành công");
                loadDGV();
                reset();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void xoaDMBtn_Click(object sender, EventArgs e)
        {
            DANHMUC dm = danhmucBUS.layDanhMuc(int.Parse(txtMaDM.Text));
            if (danhmucBUS.xoaDanhMuc(dm.MADM))
            {
                MessageBox.Show("Xóa" + dm.TENDM + " thành công");
                loadDGV();
                reset();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void lamMoiBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
