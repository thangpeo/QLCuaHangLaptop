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
    public partial class PhieuBaoHanhForm : Form
    {
        BaoHanhBLL baohanhBUS = new BaoHanhBLL();
        DataTable dtBH;
        public PhieuBaoHanhForm()
        {
            InitializeComponent();
        }
        private void PhieuBaoHanhForm_Load(object sender, EventArgs e)
        {
            dtBH = baohanhBUS.layDSPhieuBaoHanh();
            dgvPhieuBaoHanh.DataSource = dtBH;
        }
        private void xoaPhieuBHBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPhieuBaoHanh.CurrentRow;
            if (row!= null)
            {
                BAOHANH bh = new BAOHANH();
                bh.MAHD = int.Parse(row.Cells["MAHD"].Value.ToString());
                bh.MASP = int.Parse(row.Cells["MASP"].Value.ToString());
                bh.LANBH = int.Parse(row.Cells["LANBH"].Value.ToString());
                if (baohanhBUS.xoaPhieuBaoHanh(bh))
                {
                    MessageBox.Show("Xoá thành công");
                    dtBH = baohanhBUS.layDSPhieuBaoHanh();
                    dgvPhieuBaoHanh.DataSource = dtBH;
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu bảo hành");
            }
        }

        private void suaPhieuBHBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPhieuBaoHanh.CurrentRow;
            if (row != null)
            {
                BAOHANH bh = new BAOHANH();
                bh.MAHD = int.Parse(row.Cells["MAHD"].Value.ToString());
                bh.MASP = int.Parse(row.Cells["MASP"].Value.ToString());
                bh.LANBH = int.Parse(row.Cells["LANBH"].Value.ToString());
                bh.LYDO = txtLYDO.Text;
                bh.TIENBH = double.Parse(txtTienBH.Text);
                if (baohanhBUS.suaPhieuBaoHanh(bh))
                {
                    MessageBox.Show("Sửa thông tin thành công");
                    dtBH = baohanhBUS.layDSPhieuBaoHanh();
                    dgvPhieuBaoHanh.DataSource = dtBH;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn phiếu bảo hành");
            }
        }

        private void txtTienBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvPhieuBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPhieuBaoHanh.CurrentRow;
            if (row != null)
            {
                txtLYDO.Text = row.Cells["LYDO"].Value.ToString();
                txtTienBH.Text = row.Cells["TIENBH"].Value.ToString();
            }
        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            dtBH.DefaultView.RowFilter = "TENKH LIKE '%" + txtTimKiem.Text + "%'";
            txtTimKiem.Text = "";
        }

        private void txtTienBH_Leave(object sender, EventArgs e)
        {
            if (txtTienBH.Text == "")
            {
                txtTienBH.Text = "0";
            }

        }

       
    }
}
