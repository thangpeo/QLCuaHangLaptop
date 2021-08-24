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
    public partial class DangNhapForm : Form
    {
        NhanVienBLL nhanVienBUS = new NhanVienBLL();

        public delegate void sendData(NHANVIEN nv);
        public sendData send;
        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.taikhoan != string.Empty)
            {
                txtTaiKhoan.Text = Properties.Settings.Default.taikhoan;
                txtMatKhau.Text = Properties.Settings.Default.matkhau;
                chkbNhoTK.Checked = true;
            }
        }

        private void dangnhapBtn_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else if (nhanVienBUS.ktDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                if (!nhanVienBUS.ktHoatDong(txtTaiKhoan.Text, txtMatKhau.Text))
                {
                    MessageBox.Show("Tài khoản đã bị khóa");
                    txtTaiKhoan.Focus();
                }
                else
                {
                    if (chkbNhoTK.Checked)
                    {
                        Properties.Settings.Default.taikhoan = txtTaiKhoan.Text;
                        Properties.Settings.Default.matkhau = txtMatKhau.Text;
                    }
                    else
                    {
                        Properties.Settings.Default.taikhoan = string.Empty;
                        Properties.Settings.Default.matkhau = string.Empty;
                    }
                    send(nhanVienBUS.layNhanVien(txtTaiKhoan.Text));
                    Properties.Settings.Default.Save();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                txtTaiKhoan.Focus();
            }
        }
    }
}
