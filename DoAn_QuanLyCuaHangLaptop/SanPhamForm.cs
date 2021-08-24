using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class SanPhamForm : Form
    {
        SanPhamBLL sanphamBUS = new SanPhamBLL();
        NhaSanXuatBLL nsxBUS = new NhaSanXuatBLL();
        DanhMucBLL loaispBUS = new DanhMucBLL();
        

        DataTable dtNSX, dtSP, dtloaiSP;
        public SanPhamForm()
        {
            InitializeComponent();
        }
        private void reset()
        {
            panelNhapThongTin.VerticalScroll.Value = 0;
            txtTenSanPham.Text = string.Empty;
            dtpThoiDiemRaMat.Value = DateTime.Now;
           
            txtMoTa.Text= string.Empty;
            txtXuatXu.Text = string.Empty;
            dtpThoiDiemRaMat.Value = DateTime.Now;
            txtSLTON.Text = "0";
            txtGiaBan.Text = "0";
            txtGiaNhap.Text = "0";  
            txtHinhAnh.Text = string.Empty;

        }
        private void hienthiThongTin(DataGridViewRow row)
        {
            txtTenSanPham.Tag = row.Cells["MASP"].Value.ToString();
            txtTenSanPham.Text = row.Cells["TENSP"].Value.ToString();
            dtpThoiDiemRaMat.Value =(DateTime) row.Cells["THOIDIEMRAMAT"].Value;
            cbbNSX.SelectedValue = row.Cells["MANSX"].Value;
            cbbLoaiSP.SelectedValue = row.Cells["MADM"].Value;
            txtGiaBan.Text = row.Cells["GIABAN"].Value.ToString();
            txtGiaNhap.Text = row.Cells["GIANHAP"].Value.ToString();
            txtMoTa.Text = row.Cells["MOTA"].Value.ToString();
            txtXuatXu.Text = row.Cells["XUATXU"].Value.ToString();
            txtSLTON.Text = row.Cells["SLTON"].Value.ToString();
            txtHinhAnh.Text = row.Cells["HINHANH"].Value.ToString();
        }
        private void moPanelNhap()
        {
            this.panelDSSP.Dock = DockStyle.Right;
            this.panelDSSP.Size = new Size(0, this.panelDSSP.Height);

            this.panelNhapThongTin.Dock = DockStyle.Fill;
            this.tblLayoutCRUD.Visible = false;
            this.tblLayoutLuu.Visible = true;

            txtTenSanPham.Focus();
            
        }
        private void dongPanelNhap()
        {
            reset();
            this.panelDSSP.Dock = DockStyle.Fill;

            this.panelNhapThongTin.Dock = DockStyle.Left;
            this.panelNhapThongTin.Size = new Size(0, this.panelNhapThongTin.Height);
            
            this.tblLayoutCRUD.Visible = true;
            this.tblLayoutLuu.Visible = false;

            txtTenSanPham.Tag = null;
        }
        private void editDataRowLaptop(DataRow row, SANPHAM l, bool isEdit)
        {
            row["MASP"] = l.MASP;
            row["TENSP"] = l.TENSP;
            row["MOTA"] = l.MOTA;
            row["XUATXU"] = l.XUATXU;
            row["THOIDIEMRAMAT"] = l.THOIDIEMRAMAT;
            row["HINHANH"] = l.HINHANH;
            row["MANSX"] = l.MANSX;
            row["TENNSX"] = nsxBUS.layNhaSanXuat(l.MANSX).TENNSX;
            row["MADM"] = l.MADM;
            row["TENDM"] = loaispBUS.layDanhMuc(l.MADM.Value).TENDM;
            row["GIABAN"] = l.GIABAN;
            row["GIANHAP"] = l.GIANHAP;
            row["SLTON"] = l.SLTON;
            if (!isEdit)
            {
                this.dtSP.Rows.Add(row);
            }
        }
        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            dongPanelNhap();
            dtSP = sanphamBUS.layDSSanPham();
            dtNSX = nsxBUS.layDSNhaSanXuat();
            dtloaiSP = loaispBUS.layDSDanhMuc();

            dtloaiSP.CaseSensitive = false; 

            DataColumn[] key = new DataColumn[1];
            key[0] = dtSP.Columns["MASP"];
            dtSP.PrimaryKey = key;

            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.DataSource = dtSP;

            cbbNSX.DataSource = dtNSX;
            cbbNSX.DisplayMember = "TENNSX";
            cbbNSX.ValueMember = "MANSX";

            cbbLoaiSP.DataSource = dtloaiSP;
            cbbLoaiSP.DisplayMember = "TENDM";
            cbbLoaiSP.ValueMember = "MADM";
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            moPanelNhap();
            label1.Text = "Thêm sản phẩm mới";
        }
        private void suaBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSanPham.CurrentRow;
            if (row != null)
            {
                moPanelNhap();
                label1.Text = "Sửa thông tin sản phẩm";
                hienthiThongTin(row);
            }
        }
        private void xoaSPBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSanPham.CurrentRow;
            if (row != null)
            {
                if (sanphamBUS.xoaSanPham(int.Parse(row.Cells["MASP"].Value.ToString())))
                {
                    MessageBox.Show("Xóa thành công");
                    dtSP.Rows.Remove(dtSP.Rows.Find(row.Cells["MASP"].Value.ToString()));
                }
                else
                {
                    MessageBox.Show("Không được xóa sản phẩm này");
                }
            }
        }
      
        private void luuSPBtn_Click(object sender, EventArgs e)
        {
            if (cbbNSX.Items.Count == 0)
            {
                MessageBox.Show("Chưa có nhà sản xuất");
                return;
            }
            if (cbbLoaiSP.Items.Count == 0)
            {
                MessageBox.Show("Chưa có loại sản phẩm");
                return;
            }
            if (txtTenSanPham.Text == "")
            {
                MessageBox.Show("Chưa có tên cho sản phẩm");
                return;
            }
            bool isEdit = true;
            SANPHAM l = new SANPHAM();
            if (txtTenSanPham.Tag == null)
            {
                isEdit = false;
            }
            else
            {
                l.MASP = int.Parse(txtTenSanPham.Tag.ToString());
            }
            l.TENSP = txtTenSanPham.Text;
            l.THOIDIEMRAMAT = dtpThoiDiemRaMat.Value;
            l.MANSX = cbbNSX.SelectedValue.ToString();
            l.MADM =int.Parse(cbbLoaiSP.SelectedValue.ToString());
            double giaban = double.Parse(txtGiaBan.Text);
            double gianhap = double.Parse(txtGiaNhap.Text);
            if (giaban <= gianhap*(1 + 0.2))
            {
                MessageBox.Show("Giá bán phải cao hơn giá nhập 20%");
                return;
            }
            l.GIABAN = double.Parse(txtGiaBan.Text);
            l.GIANHAP = double.Parse(txtGiaNhap.Text);
            l.MOTA = txtMoTa.Text;
            l.XUATXU = txtXuatXu.Text;
            l.SLTON = int.Parse(txtSLTON.Text);
            l.HINHANH = txtHinhAnh.Text;
            if (cbbLoaiSP.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại sản phẩm");
            }
            else if (cbbNSX.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn nhà sản xuất");
            }
            else if (isEdit)
            {
                if (sanphamBUS.suaSanPham(l))
                {
                    MessageBox.Show("Sửa thông tin sản phẩm thành công", "Thông báo");
                    DataRow row = dtSP.Rows.Find(txtTenSanPham.Tag.ToString());
                    editDataRowLaptop(row, l, isEdit);
                    dongPanelNhap();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin sản phẩm thất bại", "Thông báo");
                }
            }
            else
            {
                if (sanphamBUS.themSanPham(l))
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                    DataRow row = dtSP.NewRow();
                    editDataRowLaptop(row, l, isEdit);
                    dongPanelNhap();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo");
                }
            }
        }     
        private void xemAnhSPBtn_Click(object sender, EventArgs e)
        {
             DataGridViewRow row = dgvSanPham.CurrentRow;
             if (row != null)
             {
                 new XemAnhSPForm(row.Cells["HINHANH"].Value.ToString()).ShowDialog();
             }
        }

        private void lammoiBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dongNhapBtn_Click(object sender, EventArgs e)
        {
            dongPanelNhap();
        }

        private void keyPress_ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == string.Empty)
            {
                tb.Text = "0";
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtHinhAnh.Text = openFileDialog.SafeFileName;
            }
        }
        private void timkiemSanPhamDGV(DataTable dt)
        {
            string filter = "TENSP LIKE '%{0}%'";
            dt.DefaultView.RowFilter = string.Format(filter, txtTimKiemSP.Text);
            txtTimKiemSP.Text = "";
        }
        private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            timkiemSanPhamDGV(dtSP);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dtSP.DefaultView.RowFilter = "";
        }

       
    }
}
