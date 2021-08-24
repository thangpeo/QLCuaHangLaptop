using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using DAL;
using BLL;

namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class MainForm : Form
    {

        NHANVIEN nvHienTai;
        DiemDanhBLL diemdanhBUS = new DiemDanhBLL();
        ChucVuBLL chucvuBUS = new ChucVuBLL();
        

        IconButton currentButton = null;
        Panel leftBorder = null;
        Form currentForm = null;

        public MainForm()
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorder);
            reset();
            
        }
        
        public void getData(NHANVIEN nv)
        {
            this.nvHienTai = nv;
        }

        struct myColors
        {
            public static Color color1 = Color.FromArgb(24, 161, 251);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        void activeButton(object sender, Color color)
        {
            if (sender != null)
            {
               
                DisableButton();

                currentButton = sender as IconButton;
                currentButton.BackColor = panelMenu.BackColor;
                currentButton.ForeColor = color;
                currentButton.IconColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;


                leftBorder.Height = currentButton.Height;
                leftBorder.BackColor = color;
                leftBorder.Location = new Point(0, currentButton.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
            }
        }
        
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = panelMenu.BackColor;
                currentButton.IconColor = Color.White;
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                leftBorder.Visible = false;
                
            }
        }
        void reset()
        {
            panelMenu.VerticalScroll.Value = 0;
            DisableButton();
            if (currentForm != null)
                currentForm.Close();

        }
        private void openForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = form;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }
        private void dangNhap()
        {
            
            DangNhapForm f = new DangNhapForm();
            f.send = getData;
            this.Hide();
            if (f.ShowDialog() == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                this.Show();
                labelNav.Text = nvHienTai.TENNV;
                diemDanhBtn.Visible = !diemdanhBUS.ktDiemDanh(nvHienTai.EMAIL);

                CHUCVU cv = chucvuBUS.layChucVuNhanVien(nvHienTai.MACV);
                if (cv.MACV != "ADMIN")
                {
                    foreach (Control ctrl in panelMenu.Controls)
                    {
                        if (ctrl.Tag != null)
                        {
                            if (ctrl.Tag.ToString().Contains(cv.MACV.ToString()))
                            {
                                ctrl.Visible = true;
                            }
                            else
                            {
                                ctrl.Visible = false;
                            }
                        }

                    }
                }
                else
                {
                    foreach (Control ctrl in panelMenu.Controls)
                    {
                        ctrl.Visible = true;
                    }
                }
                leftBorder.Visible = false;
            }
        }
        private void sanPhamBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color1);
            openForm(new SanPhamForm());
        }
        private void banHangBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color4);
            openForm(new BanHangForm(nvHienTai));
        }

        private void nhaSanXuatBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new NhaSanXuatForm());
        }
        
        private void nhanVienBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color4);
            openForm(new NhanVienForm(this.nvHienTai));
            
        }
        
        private void luongBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color5);
            openForm(new LuongForm());
        }

        private void hoaDonBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new HoaDonForm());
        }
        private void khachhangBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color2);
            openForm(new KhachHangForm());
        }
        private void nhapHangBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new NhapHangForm(this.nvHienTai));
        }
        private void nhaCungCapBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color4);
            openForm(new NhaCungCapForm());
        }

        private void danhMucBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color5);
            openForm(new DanhMucForm());
        }
        private void thongKeBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color1);
            openForm(new ThongKeForm());
        }
        private void phieuNhapBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color2);
            openForm(new PhieuNhapForm());
        }
        private void baoHanhBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new PhieuBaoHanhForm());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dangNhap();
            
        }

        private void diemDanhBtn_Click(object sender, EventArgs e)
        {
            if (diemdanhBUS.diemDanh(nvHienTai.EMAIL))
            {
                MessageBox.Show("Điểm danh thành công");
                diemDanhBtn.Visible = !diemdanhBUS.ktDiemDanh(nvHienTai.EMAIL);
            }
            else
            {
                MessageBox.Show("Điểm danh thất bại");
            }

        }

        private void dangXuatBtn_Click(object sender, EventArgs e)
        {
            reset();
            dangNhap();
        }

        private void doiMatKhauBtn_Click(object sender, EventArgs e)
        {
            DoiMatKhauForm f = new DoiMatKhauForm(this.nvHienTai);
            f.ShowDialog();
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            reset();
            
        }

     
    }
}
