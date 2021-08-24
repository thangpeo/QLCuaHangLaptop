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
    public partial class KhachHangForm : Form
    {
        KhachHangBLL khBUS = new KhachHangBLL();

        DataTable dtKH;

        bool isEdit = false;
        bool isAddNew = false;
        public KhachHangForm()
        {
            InitializeComponent();
        }
        public KhachHangForm(bool isAddNew)
        {
            this.isAddNew = isAddNew;
            InitializeComponent();
            this.panelNhap.BackColor = Color.LightBlue;
            this.dongBtn.DialogResult = DialogResult.No;
            this.panelKH.Visible = false;
            this.panelNhap.Visible = true;
            this.Height = panelNhap.Height + tableLayoutPanel2.Height;
        }
        private void loadData()
        {
            dtKH = khBUS.layDSKhachHang();
            dtKH.CaseSensitive = false;
            this.dgvKH.DataSource = dtKH;
        }
        private void reset()
        {
            //txtMaKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            dpNgaySinh.Value = DateTime.Now;
            txtSDT.Text = string.Empty;
            txtCMND.Text = string.Empty;
        }
        private void moOrDongPanelNhap()
        {
            this.panelKH.Visible = !this.panelKH.Visible;
            this.panelNhap.Visible = !this.panelKH.Visible;
        }
        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            
            loadData();
            DataColumn[] key = new DataColumn[1];
            key[0] = dtKH.Columns["MAKH"];
            dtKH.PrimaryKey = key;
            
        }
        private void themKHBtn_Click(object sender, EventArgs e)
        {
            isEdit = false;
            moOrDongPanelNhap();
            reset();
            txtMaKH.Text = "";
        }

        private void xoaKHBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKH.CurrentRow;
            if (row != null)
            {
                if (khBUS.xoaKhachHang(int.Parse(row.Cells["MAKH"].Value.ToString())))
                {
                    MessageBox.Show(string.Format("Xóa khách hàng {0} thành công",row.Cells["TENKH"].Value.ToString()));
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show(string.Format("Không thể xóa khách hàng {0} ", row.Cells["TENKH"].Value.ToString()));
                }
            }
        }

        private void suaKHBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKH.CurrentRow;
            if (row != null) 
            {
                isEdit = true;
                moOrDongPanelNhap();
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                dpNgaySinh.Value = (DateTime) row.Cells[2].Value;
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                txtCMND.Text = row.Cells[5].Value.ToString();
            }
        }

        private void luuKHBtn_Click(object sender, EventArgs e)
        {
            if (dpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
            }
            else if (string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                KHACHHANG kh = new KHACHHANG();
                kh.TENKH = txtTenKH.Text;
                kh.NGAYSINH = dpNgaySinh.Value;
                kh.DIACHI = txtDiaChi.Text;
                kh.SDT = txtSDT.Text;
                kh.CMND = txtCMND.Text;
                if (isEdit)
                {
                    kh.MAKH = int.Parse(txtMaKH.Text);
                    if (khBUS.suaKhachHang(kh))
                    {
                        MessageBox.Show(string.Format("Sửa thông tin khách hàng {0} thành công", kh.TENKH));
                        loadData();
                        reset();
                        moOrDongPanelNhap();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Sửa thông tin khách hàng {0} thất bại", kh.TENKH));
                    }
                }
                else
                {
                    if (khBUS.themKhachHang(kh))
                    {
                        MessageBox.Show(string.Format("Thêm khách hàng {0} thành công", kh.TENKH));
                        if (isAddNew)
                        {
                            this.Close();
                        }
                        else
                        {
                            loadData();
                            reset();
                            moOrDongPanelNhap();
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Thêm khách hàng {0} thất bại", kh.TENKH));
                    }
                }
            }
            
        }

        private void lamMoiBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dongBtn_Click(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                this.Close();
            }
            else
            {
                moOrDongPanelNhap();
                reset();
            }
            

        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            dtKH.DefaultView.RowFilter = "TENKH LIKE '%" + txtTimKiem.Text + "%'";
            txtTimKiem.Text = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dtKH.DefaultView.RowFilter = "";
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
