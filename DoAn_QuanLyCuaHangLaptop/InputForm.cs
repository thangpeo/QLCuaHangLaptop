using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class InputForm : Form
    {
        string title = string.Empty;
        public string message;
        public InputForm()
        {
            InitializeComponent();
        }
        public InputForm(string title)
        {
            InitializeComponent();
            this.title = title;
        }
        public InputForm(string title,string max)
        {
            InitializeComponent();
            this.title = title;
            this.label2.Text = "Số nhập không vượt quá:" + max.ToString();
        }
        private void InputForm_Load(object sender, EventArgs e)
        {
            if (this.title == string.Empty)
            {
                lblTitle.Visible = false;
            }
            else
            {
                lblTitle.Text = this.title;
                lblTitle.Visible = true;
            }
        }
        private void chiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '0' && (sender as TextBox).SelectionStart == 0 )
            {
                e.Handled = true;
            }
        }

      

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập!");
            }
            else
            {
                this.message = txtNhap.Text;
            }
        }

        private void HuyBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNhap.Text))
            {
                txtNhap.Text = "1";
            }
        }
    }
}
