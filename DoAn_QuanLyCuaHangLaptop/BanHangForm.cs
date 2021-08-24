using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class BanHangForm : Form
    {
        HoaDonBLL hoadonBUS = new HoaDonBLL();
        SanPhamBLL sanphamBUS = new SanPhamBLL();
        KhachHangBLL khachhangBUS = new KhachHangBLL();
        CTHoaDonBLL cthdBUS = new CTHoaDonBLL();
        DanhMucBLL loaispBUS = new DanhMucBLL();

        NHANVIEN nvHienTai;

        DataTable dtSP,dtKH, dtLoaiSP;

        public BanHangForm()
        {
            InitializeComponent();
            

            //ModelsDataContext db = new ModelsDataContext();
            //SqlCommand cmd = db.GetCommand(db.LAPTOPs) as SqlCommand;
            //DataTable dataTable = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(dataTable);

            //string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\QL_LAPTOP.mdf;Integrated Security=True;Connect Timeout=30";
            //SqlCommand cmd = new SqlCommand("select * from LAPTOP", new SqlConnection(con));
            //DataTable dataTable = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(dataTable);
            //dataGridView1.DataSource = dataTable;

            //<add name="DAL.Properties.Settings.QL_LAPTOPConnectionString"
            //connectionString="Data Source=.;Initial Catalog=QL_LAPTOP;User ID=sa;Password=sa2012"
            //providerName="System.Data.SqlClient" />

            //<add name="DAL.Properties.Settings.QL_LAPTOPConnectionString"
            //connectionString="Data Source=.;AttachDbFilename=|DataDirectory|\QL_LAPTOP.mdf;Integrated Security=True;Connect Timeout=30"
            //providerName="System.Data.SqlClient" />

        }
        public BanHangForm(NHANVIEN nv)
        {
            InitializeComponent();
            this.nvHienTai = nv;
        }
        
        private void timkiemSanPhamDGV(DataTable dt)
        {
            string filter = "TENSP LIKE '%{0}%'";
            dt.DefaultView.RowFilter = string.Format(filter, txtTimKiem.Text);
        }
        private double tinhThanhTien(double dongia, double soluong)
        {
            return dongia * soluong;
        }
        void tinhTongTien()
        {
            double tt = 0;
            foreach (ListViewItem item in lvDSSP.Items)
            {
                tt += double.Parse(item.SubItems[4].Text);
            }
            lbTongTien.Text = tt.ToString("N0");
        }
        
        private void themSPVaoHD()
        {
            foreach (DataGridViewRow row in dgvSanPham.SelectedRows)
            {
                int index= layViTriItemTrongListView(row.Cells["MASP"].Value.ToString());
                if (index>=0)
                {
                    ListViewItem item = lvDSSP.Items[index];
                    int slsp = int.Parse(item.SubItems[3].Text);
                    if (slsp + 1 > int.Parse(row.Cells["SLTON"].Value.ToString()))
                    {
                        MessageBox.Show("Không được vượt quá số lượng sản phẩm hiện có");
                    }
                    else
                        suaSLSPTrongHD(item, slsp + 1);
                    
                }
                else
                {
                    themSPMoiVaoHD(row);
                }
            }
            tinhTongTien();
        }
        private void themSPMoiVaoHD(DataGridViewRow row)
        {
            if (int.Parse(row.Cells["SLTON"].Value.ToString())>0)
            {
                InputForm f = new InputForm("Nhập số lượng sản phẩm " + row.Cells["TENSP"].Value.ToString(), row.Cells["SLTON"].Value.ToString());
                if (f.ShowDialog() == DialogResult.OK)
                {
                    int sl = int.Parse(f.message);
                    if (sl>int.Parse(row.Cells["SLTON"].Value.ToString()))
                    {
                        MessageBox.Show("Số lượng vượt quá số lượng sản phẩm hiện có");
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem();
                        item.Tag = row.Cells["MASP"].Value.ToString();
                        item.Text = (lvDSSP.Items.Count + 1).ToString();
                        item.SubItems.Add(row.Cells["TENSP"].Value.ToString());
                        double thanhtien = double.Parse(row.Cells["GIABAN"].Value.ToString()) * sl;
                        item.SubItems.Add(thanhtien.ToString("N0"));
                        item.SubItems.Add(sl.ToString());
                        item.SubItems.Add(thanhtien.ToString("N0"));
                        lvDSSP.Items.Add(item);
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show(string.Format("Sản phẩm {0} đã hết hàng",row.Cells["TENSP"].Value.ToString()));
            }
            
        }
        void resetHoaDon()
        {
            lvDSSP.Items.Clear();
            enableThayDoiBtn();
            tinhTongTien();
        }
        private void luuHoaDon()
        {

            HOADON hd = hoadonBUS.taoHoaDonMoi();
            hd.EMAIL = nvHienTai.EMAIL;
            if (chkbVangLai.Checked) 
            {
                hd.MAKH = khachhangBUS.khachVangLai().MAKH;
            }
            else
            {
                if (string.IsNullOrEmpty(cbbKH.SelectedValue.ToString()))
                {
                    MessageBox.Show("Hãy chọn khách hàng");
                    return;
                }
                hd.MAKH =int.Parse(cbbKH.SelectedValue.ToString());
            }
            hd.NGAYLAP = DateTime.Now;
            hd.TONGTIEN = 0;
            hoadonBUS.themHoaDon(hd);
            foreach (ListViewItem item in lvDSSP.Items)
            {
                CTHOADON ct = new CTHOADON();
                ct.MAHD = hd.MAHD;
                ct.MASP = int.Parse(item.Tag.ToString());
                ct.DONGIA = double.Parse(item.SubItems[2].Text);
                ct.SOLUONG = int.Parse(item.SubItems[3].Text);
                ct.THANHTIEN = double.Parse(item.SubItems[4].Text);
                cthdBUS.themCTHoaDon(ct);
            }
            dtSP = sanphamBUS.layDSSanPham();
            this.dgvSanPham.DataSource = dtSP;
            resetHoaDon();
            enableThayDoiBtn();

            rpHoaDon rp = new rpHoaDon();
            rp.SetDataSource(new RPHoaDonBLL().layrpHoaDon(hd.MAHD));

            ReportForm rpPN = new ReportForm();
            rpPN.crpView.ReportSource = rp;
            rpPN.ShowDialog();
        }

        
        private int layViTriItemTrongListView(string masp)
        {
            foreach (ListViewItem item in lvDSSP.Items)
            {
                if (item.Tag.ToString().Equals(masp))
                {
                    return item.Index;
                }
            }
            return -1;
        }
        private void suaSLSPTrongHD(ListViewItem item,int sl)
        {
            item.SubItems[3].Text = sl.ToString();
            item.SubItems[4].Text = tinhThanhTien(double.Parse(item.SubItems[2].Text), double.Parse(item.SubItems[3].Text)).ToString("N0");
            tinhTongTien();
        }

        private void enableThayDoiBtn()
        {
            if (lvDSSP.Items.Count >0)
            {
                
                luuHDBtn.Enabled = true;
                huyHDBtn.Enabled = true;
                thaydoiSLSPBtn.Enabled = true;
            }
            else
            {
                
                luuHDBtn.Enabled = false;
                huyHDBtn.Enabled = false;
                thaydoiSLSPBtn.Enabled = false;
            }
        }
        private void BanHangForm_Load(object sender, EventArgs e)
        {
            
            dtKH = khachhangBUS.layDSKhachHang();
            dtLoaiSP = loaispBUS.layDSDanhMuc();
            dtSP = sanphamBUS.layDSSanPham();
            DataColumn[] key = new DataColumn[1];
            dtSP.CaseSensitive = false;
            
            key[0] = dtSP.Columns["MASP"];
            dtSP.PrimaryKey = key;
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.DataSource = dtSP;

            
            this.cbbKH.DataSource = dtKH;
            this.cbbKH.DisplayMember = "TENKH";
            this.cbbKH.ValueMember = "MAKH";

            
            this.cbbLoaiSP.DataSource = dtLoaiSP;
            this.cbbLoaiSP.DisplayMember = "TENDM";
            this.cbbLoaiSP.ValueMember = "MADM";

            this.dtpickerNgaySinh.DataBindings.Clear();
            this.txtDiaChiKH.DataBindings.Clear();
            this.txtSDTKH.DataBindings.Clear();

            this.dtpickerNgaySinh.DataBindings.Add("Value", dtKH, "NGAYSINH");
            this.txtDiaChiKH.DataBindings.Add("Text", dtKH, "DIACHI");
            this.txtSDTKH.DataBindings.Add("Text", dtKH, "SDT");

            enableThayDoiBtn();
        }      
        private void btnThemVaoHD_Click(object sender, EventArgs e)
        {
            if (this.dgvSanPham.SelectedRows.Count > 0)
            {
                themSPVaoHD();
                enableThayDoiBtn();
            }
            
        }        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
            timkiemSanPhamDGV(dtSP);
        }
        private void lvDSSP_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lvDSSP.SelectedItems[0];
            if (item != null)
            {
                lvDSSP.Items.Remove(item);
            }
            enableThayDoiBtn();
            tinhTongTien();
        }

        private void dgvSanPham_DoubleClick(object sender, EventArgs e)
        {

        }

       
        private void chkbVangLai_CheckedChanged(object sender, EventArgs e)
        {
            cbbKH.Enabled = !chkbVangLai.Checked;
        }

        private void luuHDBtn_Click(object sender, EventArgs e)
        {
            luuHoaDon();
        }

        private void huyHDBtn_Click(object sender, EventArgs e)
        {
            resetHoaDon();
        }

        private void thaydoiSLSPBtn_Click(object sender, EventArgs e)
        {
            if (lvDSSP.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDSSP.SelectedItems[0];
                InputForm f = new InputForm("Nhập số lượng sản phẩm "+item.SubItems[1].Text , dtSP.Rows.Find(item.Tag.ToString())["SLTON"].ToString());

                if (f.ShowDialog() == DialogResult.OK)
                {
                    int slmoi = int.Parse(f.message);
                    DataRow row = dtSP.Rows.Find(item.Tag.ToString());

                    if (slmoi > int.Parse(row["SLTON"].ToString()))
                    {
                        MessageBox.Show("Không được vượt quá số lượng sản phẩm hiện có");
                    }
                    else
                        suaSLSPTrongHD(item, slmoi);

                }
            }
        }

        private void lvDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSSP.SelectedItems.Count > 0)
            {
                thaydoiSLSPBtn.Enabled = true;
            }
            else
            {
                thaydoiSLSPBtn.Enabled = false;
            }
        }

        private void ALLSPBtn_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            dtSP = sanphamBUS.layDSSanPham();
            dgvSanPham.DataSource = dtSP;
        }

        private void cbbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbbLoaiSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbLoaiSP.SelectedIndex > -1)
            {
                dtSP = sanphamBUS.layDSSanPham(int.Parse(cbbLoaiSP.SelectedValue.ToString()));
                dgvSanPham.DataSource = dtSP;
            }
            
        }

        private void themKHMoiBtn_Click(object sender, EventArgs e)
        {
            KhachHangForm f = new KhachHangForm(true);
            f.FormBorderStyle = FormBorderStyle.None;
            if (f.ShowDialog() != DialogResult.No)
            {
                dtKH = khachhangBUS.layDSKhachHang();
                this.cbbKH.DataSource = dtKH;
                this.cbbKH.DisplayMember = "TENKH";
                this.cbbKH.ValueMember = "MAKH";
            }
             
        }

        
    }
}
