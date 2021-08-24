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
    public partial class NhaCungCapForm : Form
    {
        NhaCungCapBLL nccBUS = new NhaCungCapBLL();

        DataTable dtNCC;
        public NhaCungCapForm()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            dtNCC = nccBUS.layDSNhaCungCap();
            dgvNCC.DataSource = dtNCC;
        }
        private void reset()
        {
            txtMaNCC.Text = "Hãy nhập thông tin bên dưới để thêm mới";
            txtTenNCC.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            xoaNCCBtn.Enabled = false;
            suaNCCBtn.Enabled = false;
            themNCCBtn.Enabled = true;
        }
        private void hienthithongtin(DataGridViewRow row)
        {

            txtMaNCC.Text = row.Cells[0].Value.ToString();
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            txtSDT.Text = row.Cells[3].Value.ToString();
        }
        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNCC.CurrentRow;
            if (row!=null)
            {
                hienthithongtin(row);
                xoaNCCBtn.Enabled = true;
                suaNCCBtn.Enabled = true;
                themNCCBtn.Enabled = false;
            }
            else
            {
                xoaNCCBtn.Enabled = false;
                suaNCCBtn.Enabled = false;
                themNCCBtn.Enabled = true;
            }
        }
        private void lamMoiBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void themNCCBtn_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == string.Empty||txtDiaChi.Text == string.Empty || txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            else
            {
                NHACUNGCAP ncc = nccBUS.taoNhaCungCapMoi();
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDT = txtSDT.Text;
                ncc.DIACHI = txtDiaChi.Text;
                if (nccBUS.themNhaCungCap(ncc))
                {
                    MessageBox.Show("Thêm thành công nhà cung cấp " + ncc.TENNCC);
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show(string.Format("Thêm {0} thất bại", ncc.TENNCC));
                }
            }
        }
        private void suaNCCBtn_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == string.Empty || txtDiaChi.Text == string.Empty || txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            else
            {
                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.MANCC = int.Parse(txtMaNCC.Text);
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDT = txtSDT.Text;
                ncc.DIACHI = txtDiaChi.Text;
                if (nccBUS.suaNhaCungCap(ncc))
                {
                    MessageBox.Show(string.Format("Thay đổi thông tin nhà cung cấp {0} thành công", ncc.TENNCC));
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show(string.Format("Thay đổi thông tin nhà cung cấp {0} thất bại", ncc.TENNCC));
                }
            }
        }

        private void xoaNCCBtn_Click(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = nccBUS.layNhaCungCap(int.Parse(txtMaNCC.Text));
            if (nccBUS.xoaNhaCungCap(ncc.MANCC))
            {
                MessageBox.Show("Xóa nhà cung cấp " + ncc.TENNCC + " thành công");
                loadData();
                reset();
            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp " + ncc.TENNCC + " thất bại");
            }
        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            dtNCC.DefaultView.RowFilter = "TENNCC LIKE '%"+txtTimKiem.Text+"%'";
            txtTimKiem.Text = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dtNCC.DefaultView.RowFilter = "";
        }
    }
}
