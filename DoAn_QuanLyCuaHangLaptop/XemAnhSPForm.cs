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
    public partial class XemAnhSPForm : Form
    {
        string url = "";
        public XemAnhSPForm(string url )
        {
            InitializeComponent();
            this.url = url;
        }

        private void XemAnhSP_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile("../../Images/" + url);
            }
            catch (Exception)
            {
                
            }
            
        }
    }
}
