using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class NhaSanXuatForm : Form
    {
        NhaSanXuatBLL nsxBUS = new NhaSanXuatBLL();
        DataTable dtNSX;
        public NhaSanXuatForm()
        {
            InitializeComponent();
        }


        private void loadDGV()
        {
            this.dtNSX = nsxBUS.layDSNhaSanXuat();
            this.dgvNSX.DataSource = this.dtNSX;
        }
        private void NhaSanXuatForm_Load(object sender, EventArgs e)
        {
            loadDGV();
        }
        private void themNSXBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNSX.Text) || string.IsNullOrEmpty(txtTenNSX.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                NHASANXUAT nsx = new NHASANXUAT();
                nsx.MANSX = txtMaNSX.Text;
                nsx.TENNSX = txtTenNSX.Text;
                if (nsxBUS.themNhaSanXuat(nsx))
                {
                    MessageBox.Show("Thêm thành công nhà sản xuất " + nsx.TENNSX);
                    loadDGV();
                    reset();
                }
                else
                {
                    MessageBox.Show(string.Format("Thêm {0} thất bại \n-Trùng mã nhà sản xuất", nsx.TENNSX));
                }
            }
            
        }

        private void xoaNSXBtn_Click(object sender, EventArgs e)
        {
            NHASANXUAT nsx = nsxBUS.layNhaSanXuat(txtMaNSX.Text);
            if (nsxBUS.xoaNhaSanXuat(nsx.MANSX))
            {
                MessageBox.Show("Xóa nhà sản xuất" + nsx.TENNSX + " thành công ");
                loadDGV();
                reset();
            }
            else
            {
                MessageBox.Show(string.Format("Xóa nhà sản xuất" + nsx.TENNSX + " thất bại\n- Có sản phẩm có nhà sản xuất này"));
            }
        }

        private void suaNSXBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNSX.Text) || string.IsNullOrEmpty(txtTenNSX.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                NHASANXUAT nsx = new NHASANXUAT() { MANSX = txtMaNSX.Text, TENNSX = txtTenNSX.Text };
                if (nsxBUS.suaNhaSanXuat(nsx))
                {
                    MessageBox.Show(string.Format("Sửa thông tin {0} thành công",nsx.TENNSX));
                    loadDGV();
                    reset();
                }
                else
                {
                    MessageBox.Show(string.Format("Sửa thông tin {0} thất bại", nsx.TENNSX));
                }
            }
        }

        private void dgvNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNSX.CurrentRow;
            if (row != null)
            {
                txtMaNSX.Text = row.Cells[0].Value.ToString();
                txtTenNSX.Text = row.Cells[1].Value.ToString();
                xoaNSXBtn.Enabled = true;
                suaNSXBtn.Enabled = true;
                txtMaNSX.Enabled = false;
                themNSXBtn.Enabled = false;
            }
            else
            {
                txtMaNSX.Text = string.Empty;
                txtTenNSX.Text = string.Empty;
                xoaNSXBtn.Enabled = false;
                suaNSXBtn.Enabled = false;
                txtMaNSX.Enabled = true;
                themNSXBtn.Enabled = true;
            }
        }

        private void lamMoiBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            txtMaNSX.Text = string.Empty;
            txtTenNSX.Text = string.Empty;
            xoaNSXBtn.Enabled = false;
            suaNSXBtn.Enabled = false;
            txtMaNSX.Enabled = true;
            themNSXBtn.Enabled = true;
        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            dtNSX.DefaultView.RowFilter = "TENNSX LIKE '%"+txtTimKiem.Text+"%'";
            txtTimKiem.Text = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dtNSX.DefaultView.RowFilter = "";
        }
       
    }
}
