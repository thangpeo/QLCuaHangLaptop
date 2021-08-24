namespace DoAn_QuanLyCuaHangLaptop
{
    partial class HoaDonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chiTietHDBtn = new FontAwesome.Sharp.IconButton();
            this.lamMoiLocBtn = new FontAwesome.Sharp.IconButton();
            this.InHDBtn = new FontAwesome.Sharp.IconButton();
            this.panelCTHoaDon = new System.Windows.Forms.Panel();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.MAHDCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timKiemBtn = new FontAwesome.Sharp.IconButton();
            this.refreshBtn = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dongCTHDBtn = new FontAwesome.Sharp.IconButton();
            this.baoHanhBtn = new FontAwesome.Sharp.IconButton();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelCTHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.dgvHoaDon);
            this.panelHoaDon.Controls.Add(this.tableLayoutPanel3);
            this.panelHoaDon.Controls.Add(this.tableLayoutPanel2);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHoaDon.Location = new System.Drawing.Point(0, 0);
            this.panelHoaDon.Margin = new System.Windows.Forms.Padding(11, 4, 3, 4);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(924, 830);
            this.panelHoaDon.TabIndex = 2;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENNV,
            this.TENKH,
            this.MAHD,
            this.NGAYLAP,
            this.TONGTIEN,
            this.EMAIL,
            this.MAKH});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(924, 525);
            this.dgvHoaDon.TabIndex = 10;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtKH, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtNV, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 525);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(924, 250);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 62);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 62);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khách hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKH
            // 
            this.txtKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKH.Location = new System.Drawing.Point(146, 139);
            this.txtKH.Margin = new System.Windows.Forms.Padding(11, 15, 22, 4);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(756, 35);
            this.txtKH.TabIndex = 5;
            this.txtKH.TextChanged += new System.EventHandler(this.txtNV_TextChanged);
            // 
            // txtNV
            // 
            this.txtNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNV.Location = new System.Drawing.Point(146, 77);
            this.txtNV.Margin = new System.Windows.Forms.Padding(11, 15, 22, 4);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(756, 35);
            this.txtNV.TabIndex = 4;
            this.txtNV.TextChanged += new System.EventHandler(this.txtNV_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.chiTietHDBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lamMoiLocBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.InHDBtn, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 775);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(924, 55);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // chiTietHDBtn
            // 
            this.chiTietHDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.chiTietHDBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chiTietHDBtn.Enabled = false;
            this.chiTietHDBtn.FlatAppearance.BorderSize = 0;
            this.chiTietHDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chiTietHDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiTietHDBtn.ForeColor = System.Drawing.Color.White;
            this.chiTietHDBtn.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.chiTietHDBtn.IconColor = System.Drawing.Color.White;
            this.chiTietHDBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chiTietHDBtn.IconSize = 32;
            this.chiTietHDBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chiTietHDBtn.Location = new System.Drawing.Point(352, 4);
            this.chiTietHDBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chiTietHDBtn.Name = "chiTietHDBtn";
            this.chiTietHDBtn.Size = new System.Drawing.Size(219, 47);
            this.chiTietHDBtn.TabIndex = 1;
            this.chiTietHDBtn.Text = "Chi tiết hóa đơn";
            this.chiTietHDBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chiTietHDBtn.UseVisualStyleBackColor = false;
            this.chiTietHDBtn.Click += new System.EventHandler(this.chiTietHDBtn_Click);
            // 
            // lamMoiLocBtn
            // 
            this.lamMoiLocBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.lamMoiLocBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lamMoiLocBtn.FlatAppearance.BorderSize = 0;
            this.lamMoiLocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lamMoiLocBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamMoiLocBtn.ForeColor = System.Drawing.Color.White;
            this.lamMoiLocBtn.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.lamMoiLocBtn.IconColor = System.Drawing.Color.White;
            this.lamMoiLocBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lamMoiLocBtn.IconSize = 32;
            this.lamMoiLocBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lamMoiLocBtn.Location = new System.Drawing.Point(105, 4);
            this.lamMoiLocBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lamMoiLocBtn.Name = "lamMoiLocBtn";
            this.lamMoiLocBtn.Size = new System.Drawing.Size(219, 47);
            this.lamMoiLocBtn.TabIndex = 2;
            this.lamMoiLocBtn.Text = "Làm mới";
            this.lamMoiLocBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lamMoiLocBtn.UseVisualStyleBackColor = false;
            this.lamMoiLocBtn.Click += new System.EventHandler(this.lamMoiLocBtn_Click);
            // 
            // InHDBtn
            // 
            this.InHDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.InHDBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InHDBtn.FlatAppearance.BorderSize = 0;
            this.InHDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InHDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHDBtn.ForeColor = System.Drawing.Color.White;
            this.InHDBtn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.InHDBtn.IconColor = System.Drawing.Color.White;
            this.InHDBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InHDBtn.IconSize = 32;
            this.InHDBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InHDBtn.Location = new System.Drawing.Point(599, 4);
            this.InHDBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InHDBtn.Name = "InHDBtn";
            this.InHDBtn.Size = new System.Drawing.Size(219, 47);
            this.InHDBtn.TabIndex = 1;
            this.InHDBtn.Text = "In hóa đơn";
            this.InHDBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InHDBtn.UseVisualStyleBackColor = false;
            this.InHDBtn.Click += new System.EventHandler(this.InHDBtn_Click);
            // 
            // panelCTHoaDon
            // 
            this.panelCTHoaDon.Controls.Add(this.dgvCTHD);
            this.panelCTHoaDon.Controls.Add(this.tableLayoutPanel1);
            this.panelCTHoaDon.Controls.Add(this.tableLayoutPanel4);
            this.panelCTHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCTHoaDon.Location = new System.Drawing.Point(959, 0);
            this.panelCTHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCTHoaDon.Name = "panelCTHoaDon";
            this.panelCTHoaDon.Size = new System.Drawing.Size(366, 830);
            this.panelCTHoaDon.TabIndex = 5;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToDeleteRows = false;
            this.dgvCTHD.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHDCT,
            this.MASP,
            this.TENSP,
            this.DONGIA,
            this.SOLUONG,
            this.THANHTIEN});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.Location = new System.Drawing.Point(0, 44);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCTHD.RowTemplate.Height = 28;
            this.dgvCTHD.Size = new System.Drawing.Size(366, 731);
            this.dgvCTHD.TabIndex = 9;
            // 
            // MAHDCT
            // 
            this.MAHDCT.DataPropertyName = "MAHD";
            this.MAHDCT.HeaderText = "MAHD";
            this.MAHDCT.Name = "MAHDCT";
            this.MAHDCT.ReadOnly = true;
            this.MAHDCT.Visible = false;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "MASP";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Visible = false;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Width = 200;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle5.Format = "N0";
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle5;
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Width = 200;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            dataGridViewCellStyle6.Format = "N0";
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle6;
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 200;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.timKiemBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.refreshBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 44);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // timKiemBtn
            // 
            this.timKiemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.timKiemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timKiemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.timKiemBtn.ForeColor = System.Drawing.Color.White;
            this.timKiemBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.timKiemBtn.IconColor = System.Drawing.Color.White;
            this.timKiemBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.timKiemBtn.IconSize = 32;
            this.timKiemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timKiemBtn.Location = new System.Drawing.Point(119, 3);
            this.timKiemBtn.Name = "timKiemBtn";
            this.timKiemBtn.Size = new System.Drawing.Size(194, 38);
            this.timKiemBtn.TabIndex = 8;
            this.timKiemBtn.Text = "Tìm kiếm";
            this.timKiemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timKiemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timKiemBtn.UseVisualStyleBackColor = false;
            this.timKiemBtn.Click += new System.EventHandler(this.timKiemBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.refreshBtn.IconColor = System.Drawing.Color.White;
            this.refreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refreshBtn.IconSize = 30;
            this.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshBtn.Location = new System.Drawing.Point(319, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(44, 38);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(3, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(110, 35);
            this.txtTimKiem.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dongCTHDBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.baoHanhBtn, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 775);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(366, 55);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // dongCTHDBtn
            // 
            this.dongCTHDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.dongCTHDBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dongCTHDBtn.FlatAppearance.BorderSize = 0;
            this.dongCTHDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dongCTHDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongCTHDBtn.ForeColor = System.Drawing.Color.White;
            this.dongCTHDBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.dongCTHDBtn.IconColor = System.Drawing.Color.Red;
            this.dongCTHDBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dongCTHDBtn.IconSize = 32;
            this.dongCTHDBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dongCTHDBtn.Location = new System.Drawing.Point(-49, 4);
            this.dongCTHDBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dongCTHDBtn.Name = "dongCTHDBtn";
            this.dongCTHDBtn.Size = new System.Drawing.Size(219, 47);
            this.dongCTHDBtn.TabIndex = 1;
            this.dongCTHDBtn.Text = "Đóng";
            this.dongCTHDBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dongCTHDBtn.UseVisualStyleBackColor = false;
            this.dongCTHDBtn.Click += new System.EventHandler(this.dongCTHDBtn_Click);
            // 
            // baoHanhBtn
            // 
            this.baoHanhBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.baoHanhBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baoHanhBtn.FlatAppearance.BorderSize = 0;
            this.baoHanhBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baoHanhBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baoHanhBtn.ForeColor = System.Drawing.Color.White;
            this.baoHanhBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.baoHanhBtn.IconColor = System.Drawing.Color.White;
            this.baoHanhBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.baoHanhBtn.IconSize = 32;
            this.baoHanhBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baoHanhBtn.Location = new System.Drawing.Point(196, 4);
            this.baoHanhBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baoHanhBtn.Name = "baoHanhBtn";
            this.baoHanhBtn.Size = new System.Drawing.Size(219, 47);
            this.baoHanhBtn.TabIndex = 1;
            this.baoHanhBtn.Text = "Bảo hành";
            this.baoHanhBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.baoHanhBtn.UseVisualStyleBackColor = false;
            this.baoHanhBtn.Click += new System.EventHandler(this.baoHanhBtn_Click);
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Nhân viên bán";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            this.TENNV.Width = 200;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 200;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Hóa đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Visible = false;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            this.NGAYLAP.Width = 200;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            dataGridViewCellStyle2.Format = "N0";
            this.TONGTIEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            this.TONGTIEN.Width = 200;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Mã nhân viên";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Visible = false;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Visible = false;
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 830);
            this.Controls.Add(this.panelCTHoaDon);
            this.Controls.Add(this.panelHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HoaDonForm";
            this.Text = "HoaDonForm";
            this.Load += new System.EventHandler(this.HoaDonForm_Load);
            this.panelHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelCTHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Panel panelCTHoaDon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconButton dongCTHDBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton chiTietHDBtn;
        private FontAwesome.Sharp.IconButton lamMoiLocBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private FontAwesome.Sharp.IconButton InHDBtn;
        private FontAwesome.Sharp.IconButton baoHanhBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton timKiemBtn;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
    }
}