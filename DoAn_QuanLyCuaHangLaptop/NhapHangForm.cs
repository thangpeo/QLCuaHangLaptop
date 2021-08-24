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
    public partial class NhapHangForm : Form
    {
        NhaCungCapBLL nccBUS = new NhaCungCapBLL();
        SanPhamBLL laptopBUS = new SanPhamBLL();
        PhieuNhapBLL phieunhapBUS = new PhieuNhapBLL();
        CTPhieuNhapBLL ctpnBUS = new CTPhieuNhapBLL();

        DataTable dtSP, dtNCC;

        NHANVIEN nv;
        public NhapHangForm()
        {
            InitializeComponent();
        }
        public NhapHangForm(NHANVIEN nv)
        {
            InitializeComponent();
            this.nv = nv;
        }
        private void dataBinding()
        {
            txtDiaChi.DataBindings.Clear();
            txtSDT.DataBindings.Clear();

            txtDiaChi.DataBindings.Add("Text", dtNCC, "DIACHI");
            txtSDT.DataBindings.Add("Text", dtNCC, "SDT");
        }
        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            dtNCC = nccBUS.layDSNhaCungCap();
            dtSP = laptopBUS.layDSSanPham();

            dtSP.CaseSensitive = false; 
            DataColumn[] key = new DataColumn[1];
            key[0] = dtSP.Columns["MASP"];
            dtSP.PrimaryKey = key;

            cbbNCC.DataSource = dtNCC;
            cbbNCC.DisplayMember = "TENNCC";
            cbbNCC.ValueMember = "MANCC";

            dgvSanPham.DataSource = dtSP;
        }
        private void enableButton()
        {

            if (dgvSPTrongPhieuNhap.Rows.Count > 0)
            {
                luuPhieuNhapBtn.Enabled = true;
                huyPhieuNhapBtn.Enabled = true;
            }
            else
            {
                luuPhieuNhapBtn.Enabled = false;
                huyPhieuNhapBtn.Enabled = false;

                xoaSPBtn.Enabled = false;
                suaSLSPBtn.Enabled = false;
            }
            
        }
        private int timDGVSPTrongPhieuNhap(int key)
        {
            if (dgvSPTrongPhieuNhap.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSPTrongPhieuNhap.Rows)
                {
                    if ((int)row.Cells["MASPCT"].Value == key)
                    {
                        return row.Index;
                    }
                }   
            }
            return -1;
            
        }

        private void timkiemSanPhamDGV(DataTable dt)
        {
            string filter = "TENSP LIKE '%{0}%'";
            dt.DefaultView.RowFilter = string.Format(filter, txtTimKiemSP.Text);
        }
        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBinding();
        }

        private void themSPBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSanPham.SelectedRows)
            {
                int index = timDGVSPTrongPhieuNhap((int)row.Cells["MASP"].Value);
                if (index > -1)
                {
                    MessageBox.Show("Đã có sản phẩm trong danh sách hàng nhập");
                    //dgvSPTrongPhieuNhap.Rows[index].Cells["SOLUONG"].Value = int.Parse(dgvSPTrongPhieuNhap.Rows[index].Cells["SOLUONG"].Value.ToString()) + 1;
                    //dgvSPTrongPhieuNhap.Rows[index].Cells["THANHTIEN"].Value = double.Parse(dgvSPTrongPhieuNhap.Rows[index].Cells["DONGIA"].Value.ToString()) * int.Parse(dgvSPTrongPhieuNhap.Rows[index].Cells["SOLUONG"].Value.ToString());
                }
                else
                {
                    InputForm f = new InputForm("Nhập số lượng sản phẩm "+row.Cells["TENSP"].Value.ToString()+":");
                    string sl = string.Empty;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        sl = f.message;
                        dgvSPTrongPhieuNhap.Rows.Add(row.Cells["MASP"].Value, row.Cells["TENSP"].Value, row.Cells["GIANHAP"].Value, int.Parse(sl), double.Parse(row.Cells["GIANHAP"].Value.ToString()) * int.Parse(sl));
                    }
                }
                
            }
            enableButton();
        }

        private void xoaSPBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSPTrongPhieuNhap.SelectedRows)
            {
                dgvSPTrongPhieuNhap.Rows.Remove(row);
            }
            enableButton();
        }

        private void suaSLSPBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSPTrongPhieuNhap.SelectedRows)
            {
                InputForm f = new InputForm("Nhập số lượng sản phẩm "+row.Cells["TENSPCT"].Value.ToString()+":");
                string sl = string.Empty;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    sl = f.message;
                    if (sl != string.Empty)
                    {
                        if (int.Parse(sl) == 0)
                        {
                            MessageBox.Show("Bạn nên nhập số lượng sản phẩm lớn hơn 0");
                        }
                        else
                        {
                            row.Cells["SOLUONG"].Value = int.Parse(sl);
                            row.Cells["THANHTIEN"].Value = double.Parse(row.Cells["DONGIA"].Value.ToString()) * int.Parse(row.Cells["SOLUONG"].Value.ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("Số lượng nhập trống");
                    }
                }
                
                
                
            }
        }

        private void dgvSPTrongPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSPTrongPhieuNhap.CurrentRow != null)
            {
                xoaSPBtn.Enabled = true;
                suaSLSPBtn.Enabled = true;
            }
            else
            {
                xoaSPBtn.Enabled = false;
                suaSLSPBtn.Enabled = false;
            }
        }

        private void huyPhieuNhapBtn_Click(object sender, EventArgs e)
        {
            dgvSPTrongPhieuNhap.Rows.Clear();
            enableButton();
        }

        private void luuPhieuNhapBtn_Click(object sender, EventArgs e)
        {
            PHIEUNHAP pn = phieunhapBUS.taoPhieuNhapMoi();
            pn.EMAIL = nv.EMAIL;
            if (cbbNCC.Items.Count > 0)
            {
                pn.MANCC =int.Parse(cbbNCC.SelectedValue.ToString());
                pn.NGAYLAP = DateTime.Now;
                pn.TONGTIEN = 0;
                if (phieunhapBUS.themPhieuNhap(pn))
                {
                    CTPHIEUNHAP ct;
                    foreach (DataGridViewRow row in dgvSPTrongPhieuNhap.Rows)
                    {
                        ct = new CTPHIEUNHAP();
                        ct.MAPN = pn.MAPN;
                        ct.MASP = int.Parse(row.Cells["MASPCT"].Value.ToString());
                        ct.DONGIA = double.Parse(row.Cells["DONGIA"].Value.ToString());
                        ct.SOLUONG = int.Parse(row.Cells["SOLUONG"].Value.ToString());
                        ct.THANHTIEN = double.Parse(row.Cells["THANHTIEN"].Value.ToString());
                        ctpnBUS.themCTPhieuNhap(ct);
                    }
                    MessageBox.Show("Thêm phiếu nhập thành công");
                    dgvSPTrongPhieuNhap.Rows.Clear();
                    dtSP = laptopBUS.layDSSanPham();
                    dgvSanPham.DataSource = dtSP;

                    
                    //đổ dữ liệu
                    rpPhieuNhap baocao = new rpPhieuNhap();
                    baocao.SetDataSource(new RPPhieuNhapBLL().layrpPhieuNhap(pn.MAPN));

                    //load report
                    ReportForm rpPN = new ReportForm();
                    rpPN.crpView.ReportSource = baocao;
                    rpPN.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu nhập thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa có nhà cung cấp");
            }
            
            
        }

        private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            timkiemSanPhamDGV(dtSP);
        }
    }
}
