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
    public partial class NhanVienForm : Form
    {

        NhanVienBLL nhanvienBUS = new NhanVienBLL();
        ChucVuBLL chucvuBUS = new ChucVuBLL();


        DataTable dtNV,dtCV;

        NHANVIEN nhanvien;

        bool isEdit = false;
        public NhanVienForm()
        {
            InitializeComponent();
        }
        public NhanVienForm(NHANVIEN nhanvien)
        {
            this.nhanvien = nhanvien;
            InitializeComponent();
        }
        private void reset()
        {
            txtEmail.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            cbbChucVu.SelectedIndex = 1;
            txtHeSoLuong.Text = "3.5";
            txtLuongCoBan.Text = "1350000";
            dtpNgayVaoLam.Value = DateTime.Now;
            txtPhuCap.Text = "0";
            chkbHoatDong.Checked = true;

            txtEmail.Enabled = true;
        }
        private void moPanelThongTinNV()
        {
            reset();
            this.pnThongTin.Visible = true;
            this.panelNV.Visible = false;
            if (isEdit)
            {
                labelNV.Text = "Sửa thông tin nhân viên";
            }
            else
            {
                labelNV.Text = "Thêm nhân viên";
            }

        }
        private void dongPanelThongTinNV()
        {
            reset();
            this.pnThongTin.Visible = false;
            this.panelNV.Visible = true;
        }
        private void thayDoiKichHoatBtn(bool a)
        {
            if (a)
            {
                huyHoatDongBtn.IconChar = FontAwesome.Sharp.IconChar.Frown;
                huyHoatDongBtn.Text = "Hủy hoạt động";
            }
            else
            {
                huyHoatDongBtn.IconChar = FontAwesome.Sharp.IconChar.SmileBeam;
                huyHoatDongBtn.Text = "Kích hoạt";
            }
        } 
        private void timkiemNVDGV(DataTable dtNV)
        {
            string filter = "TENNV LIKE '%{0}%'";
            dtNV.DefaultView.RowFilter = string.Format(filter, txtTimKiem.Text);
            txtTimKiem.Text = "";
        }
        private void hienthiThongTinNhanVien(DataGridViewRow row)
        {
            txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
            txtTenNV.Text = row.Cells["TENNV"].Value.ToString();
            dtpNgaySinh.Value = (DateTime)row.Cells["NGAYSINH"].Value;
            txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            txtSDT.Text = row.Cells["SDT"].Value.ToString();
            txtMatKhau.Text = row.Cells["MATKHAU"].Value.ToString();
            cbbChucVu.SelectedValue = row.Cells["MACV"].Value.ToString();
            txtHeSoLuong.Text = row.Cells["HESOLUONG"].Value.ToString();
            txtLuongCoBan.Text = row.Cells["LUONGCOBAN"].Value.ToString();
            dtpNgayVaoLam.Value = (DateTime)row.Cells["NGAYVAOLAM"].Value;
            txtPhuCap.Text = row.Cells["PHUCAP"].Value.ToString();
            chkbHoatDong.Checked = (bool)row.Cells["HOATDONG"].Value;
        }
        private void editDataRow(DataRow row, NHANVIEN nv, bool isEdit)
        {
            row["EMAIL"] = nv.EMAIL;
            row["TENNV"] = nv.TENNV;
            row["NGAYSINH"] = nv.NGAYSINH;
            row["DIACHI"] = nv.DIACHI;
            row["SDT"] = nv.SDT;
            row["EMAIL"] = nv.EMAIL;
            row["MATKHAU"] = nv.MATKHAU;
            row["MACV"] = nv.MACV;
            row["TENCV"] = dtCV.Rows.Find(nv.MACV)["TENCV"];
            row["HESOLUONG"] = nv.HESOLUONG;
            row["LUONGCOBAN"] = nv.LUONGCOBAN;
            row["NGAYVAOLAM"] = nv.NGAYVAOLAM;
            row["PHUCAP"] = nv.PHUCAP;
            row["HOATDONG"] = nv.HOATDONG;
            if (!isEdit)
            {
                this.dtNV.Rows.Add(row);
            }
        }
        private bool ktEmail(string email)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private bool ktNhap()
        {
            foreach (Control ctrl in tblLayoutNhap.Controls)
            {
                if (ctrl is TextBox && ctrl.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return false;
                }
            }
            if (txtMatKhau.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự");
                return false;
            }
            else if (!ktEmail(txtEmail.Text))
            {
                MessageBox.Show("Email nhập k phù hợp");
                return false;
            }
            else if(cbbChucVu.SelectedIndex < 0){
                MessageBox.Show("Chưa chọn chức vụ");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            
            dtNV = nhanvienBUS.layDSNhanVien();
            dtNV.CaseSensitive = false;
            this.dgvNhanVien.DataSource = dtNV;


            dtCV = chucvuBUS.layDSChucVu();


            DataColumn[] key = new DataColumn[1];
            key[0] = dtNV.Columns["EMAIL"];
            dtNV.PrimaryKey = key;

            DataColumn[] keyCV = new DataColumn[1];
            keyCV[0] = dtCV.Columns["MACV"];
            dtCV.PrimaryKey = keyCV;

            

            cbbChucVu.DataSource = dtCV;
            cbbChucVu.DisplayMember = "TENCV";
            cbbChucVu.ValueMember = "MACV";

            this.pnThongTin.Size = new Size(this.pnThongTin.Size.Width, this.Height);

            dongPanelThongTinNV();


        }
        private void themNVBtn_Click(object sender, EventArgs e)
        {
            isEdit = false;
            moPanelThongTinNV();
        }

        private void suaNVBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.CurrentRow;
            if (row != null)
            {
                isEdit = true;
                moPanelThongTinNV();
                hienthiThongTinNhanVien(row);
                txtEmail.Enabled = false;   
            }
        }

        private void huyChinhSuaNVBtn_Click(object sender, EventArgs e)
        {
            dongPanelThongTinNV();
        }

        private void lammoiThongTinNVBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void luuThongTinNVBtn_Click(object sender, EventArgs e)
        {
            if (ktNhap())
            {
                NHANVIEN nv = new NHANVIEN();
                nv.EMAIL = txtEmail.Text;
                nv.TENNV = txtTenNV.Text;
                nv.NGAYSINH = dtpNgaySinh.Value;
                nv.DIACHI = txtDiaChi.Text;
                nv.SDT = txtSDT.Text;
                nv.MATKHAU = txtMatKhau.Text;
                nv.MACV = cbbChucVu.SelectedValue.ToString();
                nv.HESOLUONG = double.Parse(txtHeSoLuong.Text);
                nv.LUONGCOBAN = double.Parse(txtLuongCoBan.Text);
                nv.NGAYVAOLAM = dtpNgayVaoLam.Value;
                nv.PHUCAP = double.Parse(txtPhuCap.Text);
                nv.HOATDONG = chkbHoatDong.Checked;
                if (isEdit)
                {
                    if (nhanvienBUS.suaNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thông tin nhân viên " + nv.TENNV + " thành công");
                        DataRow row = dtNV.Rows.Find(txtEmail.Text);
                        editDataRow(row, nv, isEdit);
                        dongPanelThongTinNV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin nhân viên " + nv.TENNV + " thất bại");
                    }
                }
                else
                {
                    if (nhanvienBUS.themNhanVien(nv))
                    {
                        MessageBox.Show("Thêm nhân viên " + nv.TENNV + " thành công");
                        DataRow row = dtNV.NewRow();
                        editDataRow(row, nv, isEdit);
                        dongPanelThongTinNV();
                    }
                    else
                    {
                        MessageBox.Show("Trùng Email với nhân viên khác");
                    }
                }
            }
            
        }

        private void xoaNVBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.CurrentRow;
            if (row != null)
            {
                if (row.Cells["EMAIL"].Value.ToString() == this.nhanvien.EMAIL)
                {
                    MessageBox.Show("Không thể xóa chính mình");
                }
                else
                {
                    if (nhanvienBUS.xoaNhanVien(row.Cells["EMAIL"].Value.ToString()))
                    {
                        MessageBox.Show("Xóa nhân viên " + row.Cells["TENNV"].Value.ToString() + " thành công");
                        dtNV.Rows.Remove(dtNV.Rows.Find(row.Cells["EMAIL"].Value.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên " + row.Cells["TENNV"].Value.ToString() + " thất bại");
                    }
                }
                
            }
            

        }

        private void chiPhimSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void soThapPhan(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).SelectionStart < 1))
            {
                e.Handled = true;
            }
        }

        private void txtHeSoLuong_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeSoLuong.Text))
            {
                txtHeSoLuong.Text = "3.5";
            }
            if (string.IsNullOrEmpty(txtLuongCoBan.Text))
            {
                txtLuongCoBan.Text = "1350000";
            }
            if (string.IsNullOrEmpty(txtPhuCap.Text))
            {
                txtPhuCap.Text = "0";
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.CurrentRow;
            if (row != null)
            {
                thayDoiKichHoatBtn((bool)row.Cells["HOATDONG"].Value);
            }
        }

        private void huyHoatDongBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.CurrentRow;
            if (row != null)
            {
                NHANVIEN nv = nhanvienBUS.layNhanVien(row.Cells["EMAIL"].Value.ToString());
                if (nhanvienBUS.thaydoiHoatDongNhanVien(nv))
                {
                    MessageBox.Show("Thay đổi trạng thái hoạt động nhân viên " + row.Cells["TENNV"].Value.ToString() + " thành công");
                    row.Cells["HOATDONG"].Value = nv.HOATDONG.Value;
                    thayDoiKichHoatBtn(nv.HOATDONG.Value);
                }
                else
                {
                    MessageBox.Show("Thay đổi trạng thái hoạt động nhân viên " + row.Cells["TENNV"].Value.ToString() + " thất bại");
                }

            }
        }

        private void timKiemBtn_Click(object sender, EventArgs e)
        {
            timkiemNVDGV(dtNV);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
