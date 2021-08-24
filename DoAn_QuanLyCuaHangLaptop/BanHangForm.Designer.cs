namespace DoAn_QuanLyCuaHangLaptop
{
    partial class BanHangForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XUATXU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIDIEMRAMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemVaoHD = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.ALLSPBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.themKHMoiBtn = new FontAwesome.Sharp.IconButton();
            this.chkbVangLai = new System.Windows.Forms.CheckBox();
            this.dtpickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.cbbKH = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.luuHDBtn = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.huyHDBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.thaydoiSLSPBtn = new System.Windows.Forms.Button();
            this.lvDSSP = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TENSPLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DONGIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOLUONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.THANHTIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSanPham);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 400);
            this.panel1.TabIndex = 0;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.GIABAN,
            this.SLTON,
            this.XUATXU,
            this.THOIDIEMRAMAT,
            this.MOTA,
            this.MANSX,
            this.TENNSX,
            this.MADM,
            this.TENDM});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 92);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(679, 263);
            this.dgvSanPham.TabIndex = 14;
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
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            dataGridViewCellStyle1.Format = "N0";
            this.GIABAN.DefaultCellStyle = dataGridViewCellStyle1;
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            this.GIABAN.Width = 200;
            // 
            // SLTON
            // 
            this.SLTON.DataPropertyName = "SLTON";
            this.SLTON.HeaderText = "Số lượng tồn";
            this.SLTON.Name = "SLTON";
            this.SLTON.ReadOnly = true;
            // 
            // XUATXU
            // 
            this.XUATXU.DataPropertyName = "XUATXU";
            this.XUATXU.HeaderText = "Xuất xứ";
            this.XUATXU.Name = "XUATXU";
            this.XUATXU.ReadOnly = true;
            this.XUATXU.Width = 200;
            // 
            // THOIDIEMRAMAT
            // 
            this.THOIDIEMRAMAT.DataPropertyName = "THOIDIEMRAMAT";
            this.THOIDIEMRAMAT.HeaderText = "Thời điểm ra mắt";
            this.THOIDIEMRAMAT.Name = "THOIDIEMRAMAT";
            this.THOIDIEMRAMAT.ReadOnly = true;
            this.THOIDIEMRAMAT.Width = 200;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            this.MOTA.Width = 300;
            // 
            // MANSX
            // 
            this.MANSX.DataPropertyName = "MANSX";
            this.MANSX.HeaderText = "MANSX";
            this.MANSX.Name = "MANSX";
            this.MANSX.ReadOnly = true;
            this.MANSX.Visible = false;
            // 
            // TENNSX
            // 
            this.TENNSX.DataPropertyName = "TENNSX";
            this.TENNSX.HeaderText = "Nhà sản xuất";
            this.TENNSX.Name = "TENNSX";
            this.TENNSX.ReadOnly = true;
            this.TENNSX.Width = 200;
            // 
            // MADM
            // 
            this.MADM.DataPropertyName = "MADM";
            this.MADM.HeaderText = "Mã danh mục";
            this.MADM.Name = "MADM";
            this.MADM.ReadOnly = true;
            this.MADM.Visible = false;
            // 
            // TENDM
            // 
            this.TENDM.DataPropertyName = "TENDM";
            this.TENDM.HeaderText = "Danh Mục";
            this.TENDM.Name = "TENDM";
            this.TENDM.ReadOnly = true;
            this.TENDM.Width = 200;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnThemVaoHD, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 355);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 45);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnThemVaoHD
            // 
            this.btnThemVaoHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemVaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoHD.IconChar = FontAwesome.Sharp.IconChar.LevelDownAlt;
            this.btnThemVaoHD.IconColor = System.Drawing.Color.Lime;
            this.btnThemVaoHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemVaoHD.IconSize = 36;
            this.btnThemVaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoHD.Location = new System.Drawing.Point(412, 3);
            this.btnThemVaoHD.Name = "btnThemVaoHD";
            this.btnThemVaoHD.Size = new System.Drawing.Size(244, 39);
            this.btnThemVaoHD.TabIndex = 0;
            this.btnThemVaoHD.Text = "Thêm vào hóa đơn";
            this.btnThemVaoHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThemVaoHD.UseVisualStyleBackColor = true;
            this.btnThemVaoHD.Click += new System.EventHandler(this.btnThemVaoHD_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(679, 40);
            this.panel5.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel3.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbbLoaiSP, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ALLSPBtn, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(679, 40);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(243, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(263, 35);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLoaiSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Location = new System.Drawing.Point(3, 3);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(234, 37);
            this.cbbLoaiSP.TabIndex = 2;
            this.cbbLoaiSP.SelectionChangeCommitted += new System.EventHandler(this.cbbLoaiSP_SelectionChangeCommitted);
            // 
            // ALLSPBtn
            // 
            this.ALLSPBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ALLSPBtn.Location = new System.Drawing.Point(512, 3);
            this.ALLSPBtn.Name = "ALLSPBtn";
            this.ALLSPBtn.Size = new System.Drawing.Size(164, 34);
            this.ALLSPBtn.TabIndex = 3;
            this.ALLSPBtn.Text = "Tất cả sản phẩm";
            this.ALLSPBtn.UseVisualStyleBackColor = true;
            this.ALLSPBtn.Click += new System.EventHandler(this.ALLSPBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.themKHMoiBtn);
            this.panel2.Controls.Add(this.chkbVangLai);
            this.panel2.Controls.Add(this.dtpickerNgaySinh);
            this.panel2.Controls.Add(this.txtSDTKH);
            this.panel2.Controls.Add(this.txtDiaChiKH);
            this.panel2.Controls.Add(this.cbbKH);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(679, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 348);
            this.panel2.TabIndex = 9;
            // 
            // themKHMoiBtn
            // 
            this.themKHMoiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.themKHMoiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themKHMoiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themKHMoiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themKHMoiBtn.ForeColor = System.Drawing.Color.White;
            this.themKHMoiBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.themKHMoiBtn.IconColor = System.Drawing.Color.White;
            this.themKHMoiBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.themKHMoiBtn.IconSize = 32;
            this.themKHMoiBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.themKHMoiBtn.Location = new System.Drawing.Point(16, 302);
            this.themKHMoiBtn.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.themKHMoiBtn.Name = "themKHMoiBtn";
            this.themKHMoiBtn.Size = new System.Drawing.Size(257, 38);
            this.themKHMoiBtn.TabIndex = 13;
            this.themKHMoiBtn.Text = "Thêm khách hàng mới";
            this.themKHMoiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.themKHMoiBtn.UseVisualStyleBackColor = false;
            this.themKHMoiBtn.Click += new System.EventHandler(this.themKHMoiBtn_Click);
            // 
            // chkbVangLai
            // 
            this.chkbVangLai.AutoSize = true;
            this.chkbVangLai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbVangLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbVangLai.Location = new System.Drawing.Point(323, 306);
            this.chkbVangLai.Name = "chkbVangLai";
            this.chkbVangLai.Size = new System.Drawing.Size(186, 26);
            this.chkbVangLai.TabIndex = 12;
            this.chkbVangLai.Text = "Là khách vãng lai?";
            this.chkbVangLai.UseVisualStyleBackColor = true;
            this.chkbVangLai.CheckedChanged += new System.EventHandler(this.chkbVangLai_CheckedChanged);
            // 
            // dtpickerNgaySinh
            // 
            this.dtpickerNgaySinh.Enabled = false;
            this.dtpickerNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerNgaySinh.Location = new System.Drawing.Point(193, 111);
            this.dtpickerNgaySinh.Name = "dtpickerNgaySinh";
            this.dtpickerNgaySinh.Size = new System.Drawing.Size(316, 35);
            this.dtpickerNgaySinh.TabIndex = 11;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(193, 217);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.ReadOnly = true;
            this.txtSDTKH.Size = new System.Drawing.Size(316, 39);
            this.txtSDTKH.TabIndex = 9;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(193, 159);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.ReadOnly = true;
            this.txtDiaChiKH.Size = new System.Drawing.Size(316, 39);
            this.txtDiaChiKH.TabIndex = 8;
            // 
            // cbbKH
            // 
            this.cbbKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKH.FormattingEnabled = true;
            this.cbbKH.Location = new System.Drawing.Point(193, 58);
            this.cbbKH.Name = "cbbKH";
            this.cbbKH.Size = new System.Drawing.Size(316, 40);
            this.cbbKH.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(16)))), ((int)(((byte)(100)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1200, 52);
            this.label5.TabIndex = 8;
            this.label5.Text = "HÓA ĐƠN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 670);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 50);
            this.panel3.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.luuHDBtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbTongTien, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.huyHDBtn, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 50);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // luuHDBtn
            // 
            this.luuHDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.luuHDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luuHDBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luuHDBtn.Enabled = false;
            this.luuHDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luuHDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuHDBtn.ForeColor = System.Drawing.Color.White;
            this.luuHDBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.luuHDBtn.IconColor = System.Drawing.Color.RoyalBlue;
            this.luuHDBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.luuHDBtn.IconSize = 32;
            this.luuHDBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.luuHDBtn.Location = new System.Drawing.Point(534, 8);
            this.luuHDBtn.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.luuHDBtn.Name = "luuHDBtn";
            this.luuHDBtn.Size = new System.Drawing.Size(202, 38);
            this.luuHDBtn.TabIndex = 1;
            this.luuHDBtn.Text = "Lưu hóa đơn";
            this.luuHDBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.luuHDBtn.UseVisualStyleBackColor = false;
            this.luuHDBtn.Click += new System.EventHandler(this.luuHDBtn_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 50);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tổng tiền";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.Location = new System.Drawing.Point(113, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(144, 50);
            this.lbTongTien.TabIndex = 5;
            this.lbTongTien.Text = "0";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(263, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 50);
            this.label13.TabIndex = 6;
            this.label13.Text = "VNĐ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // huyHDBtn
            // 
            this.huyHDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.huyHDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.huyHDBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.huyHDBtn.Enabled = false;
            this.huyHDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.huyHDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huyHDBtn.ForeColor = System.Drawing.Color.White;
            this.huyHDBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.huyHDBtn.IconColor = System.Drawing.Color.Red;
            this.huyHDBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.huyHDBtn.IconSize = 32;
            this.huyHDBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.huyHDBtn.Location = new System.Drawing.Point(794, 8);
            this.huyHDBtn.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.huyHDBtn.Name = "huyHDBtn";
            this.huyHDBtn.Size = new System.Drawing.Size(202, 38);
            this.huyHDBtn.TabIndex = 1;
            this.huyHDBtn.Text = "Hủy hóa đơn";
            this.huyHDBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.huyHDBtn.UseVisualStyleBackColor = false;
            this.huyHDBtn.Click += new System.EventHandler(this.huyHDBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(967, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "( Click đúp để xóa )";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 628);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 42);
            this.panel4.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.thaydoiSLSPBtn, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(967, 42);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // thaydoiSLSPBtn
            // 
            this.thaydoiSLSPBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thaydoiSLSPBtn.Enabled = false;
            this.thaydoiSLSPBtn.Location = new System.Drawing.Point(23, 3);
            this.thaydoiSLSPBtn.Name = "thaydoiSLSPBtn";
            this.thaydoiSLSPBtn.Size = new System.Drawing.Size(941, 36);
            this.thaydoiSLSPBtn.TabIndex = 0;
            this.thaydoiSLSPBtn.Text = "Thay đổi số lượng";
            this.thaydoiSLSPBtn.UseVisualStyleBackColor = true;
            this.thaydoiSLSPBtn.Click += new System.EventHandler(this.thaydoiSLSPBtn_Click);
            // 
            // lvDSSP
            // 
            this.lvDSSP.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvDSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TENSPLV,
            this.DONGIA,
            this.SOLUONG,
            this.THANHTIEN});
            this.lvDSSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDSSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDSSP.FullRowSelect = true;
            this.lvDSSP.GridLines = true;
            this.lvDSSP.Location = new System.Drawing.Point(0, 400);
            this.lvDSSP.MultiSelect = false;
            this.lvDSSP.Name = "lvDSSP";
            this.lvDSSP.Size = new System.Drawing.Size(1200, 228);
            this.lvDSSP.TabIndex = 12;
            this.lvDSSP.UseCompatibleStateImageBehavior = false;
            this.lvDSSP.View = System.Windows.Forms.View.Details;
            this.lvDSSP.SelectedIndexChanged += new System.EventHandler(this.lvDSSP_SelectedIndexChanged);
            this.lvDSSP.DoubleClick += new System.EventHandler(this.lvDSSP_DoubleClick);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 90;
            // 
            // TENSPLV
            // 
            this.TENSPLV.Text = "Tên sản phẩm";
            this.TENSPLV.Width = 670;
            // 
            // DONGIA
            // 
            this.DONGIA.Text = "Đơn giá";
            this.DONGIA.Width = 200;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Text = "Số lượng";
            this.SOLUONG.Width = 101;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.Text = "Thành tiền";
            this.THANHTIEN.Width = 250;
            // 
            // BanHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.lvDSSP);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanHangForm";
            this.Text = "HoaDonForm";
            this.Load += new System.EventHandler(this.BanHangForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnThemVaoHD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton luuHDBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.ComboBox cbbKH;
        private System.Windows.Forms.DateTimePicker dtpickerNgaySinh;
        private System.Windows.Forms.CheckBox chkbVangLai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button thaydoiSLSPBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvDSSP;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TENSPLV;
        private System.Windows.Forms.ColumnHeader DONGIA;
        private System.Windows.Forms.ColumnHeader SOLUONG;
        private System.Windows.Forms.ColumnHeader THANHTIEN;
        private FontAwesome.Sharp.IconButton huyHDBtn;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button ALLSPBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTON;
        private System.Windows.Forms.DataGridViewTextBoxColumn XUATXU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIDIEMRAMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDM;
        private FontAwesome.Sharp.IconButton themKHMoiBtn;
    }
}