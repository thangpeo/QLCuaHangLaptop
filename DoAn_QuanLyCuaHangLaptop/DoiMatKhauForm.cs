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
    public partial class DoiMatKhauForm : Form
    {
        NHANVIEN nv;
        NhanVienBLL nvBUS = new NhanVienBLL();
        public DoiMatKhauForm(NHANVIEN nv)
        {
            InitializeComponent();
            this.nv = nv;
        }
        private void thoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doimatkhauBtn_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu cũ không được để trống");
            }
            else if (txtMatKhauMoi.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu mới không được để trống");
            }
            else if (txtMatKhauMoi.Text.Length < 8 )
            {
                MessageBox.Show("Mật khẩu tối thiểu 8 ký tự");
            }
            else if (txtXacNhanMatKhau.Text != txtMatKhauMoi.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu sai");
            }
            else
            {
                if (nvBUS.doiMatKhau(nv.EMAIL,txtMatKhauCu.Text,txtXacNhanMatKhau.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                }
            }
        }
    }
}
