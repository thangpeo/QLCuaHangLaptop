namespace DoAn_QuanLyCuaHangLaptop
{
    partial class NhaCungCapForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.themNCCBtn = new FontAwesome.Sharp.IconButton();
            this.suaNCCBtn = new FontAwesome.Sharp.IconButton();
            this.xoaNCCBtn = new FontAwesome.Sharp.IconButton();
            this.lamMoiBtn = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.timKiemBtn = new FontAwesome.Sharp.IconButton();
            this.refreshBtn = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 300);
            this.panel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaNCC, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTenNCC, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDiaChi, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtSDT, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1178, 250);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nhà cung cấp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 56);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên nhà cung cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(220, 14);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(20, 14, 30, 10);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(928, 39);
            this.txtMaNCC.TabIndex = 6;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(220, 76);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(20, 14, 30, 10);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(928, 39);
            this.txtTenNCC.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 56);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 58);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(220, 138);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(20, 14, 30, 10);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(928, 39);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(220, 200);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(20, 14, 30, 10);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(928, 39);
            this.txtSDT.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.themNCCBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.suaNCCBtn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.xoaNCCBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lamMoiBtn, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 250);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1178, 50);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // themNCCBtn
            // 
            this.themNCCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.themNCCBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themNCCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themNCCBtn.ForeColor = System.Drawing.Color.Transparent;
            this.themNCCBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.themNCCBtn.IconColor = System.Drawing.Color.Lime;
            this.themNCCBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.themNCCBtn.IconSize = 32;
            this.themNCCBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.themNCCBtn.Location = new System.Drawing.Point(107, 3);
            this.themNCCBtn.Name = "themNCCBtn";
            this.themNCCBtn.Size = new System.Drawing.Size(214, 44);
            this.themNCCBtn.TabIndex = 6;
            this.themNCCBtn.Text = "Thêm mới";
            this.themNCCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themNCCBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.themNCCBtn.UseVisualStyleBackColor = false;
            this.themNCCBtn.Click += new System.EventHandler(this.themNCCBtn_Click);
            // 
            // suaNCCBtn
            // 
            this.suaNCCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.suaNCCBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suaNCCBtn.Enabled = false;
            this.suaNCCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaNCCBtn.ForeColor = System.Drawing.Color.Transparent;
            this.suaNCCBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.suaNCCBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.suaNCCBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.suaNCCBtn.IconSize = 32;
            this.suaNCCBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.suaNCCBtn.Location = new System.Drawing.Point(607, 3);
            this.suaNCCBtn.Name = "suaNCCBtn";
            this.suaNCCBtn.Size = new System.Drawing.Size(214, 44);
            this.suaNCCBtn.TabIndex = 8;
            this.suaNCCBtn.Text = "Sửa thông tin";
            this.suaNCCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suaNCCBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.suaNCCBtn.UseVisualStyleBackColor = false;
            this.suaNCCBtn.Click += new System.EventHandler(this.suaNCCBtn_Click);
            // 
            // xoaNCCBtn
            // 
            this.xoaNCCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.xoaNCCBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xoaNCCBtn.Enabled = false;
            this.xoaNCCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaNCCBtn.ForeColor = System.Drawing.Color.Transparent;
            this.xoaNCCBtn.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.xoaNCCBtn.IconColor = System.Drawing.Color.Red;
            this.xoaNCCBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xoaNCCBtn.IconSize = 32;
            this.xoaNCCBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.xoaNCCBtn.Location = new System.Drawing.Point(357, 3);
            this.xoaNCCBtn.Name = "xoaNCCBtn";
            this.xoaNCCBtn.Size = new System.Drawing.Size(214, 44);
            this.xoaNCCBtn.TabIndex = 7;
            this.xoaNCCBtn.Text = "Xóa";
            this.xoaNCCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoaNCCBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoaNCCBtn.UseVisualStyleBackColor = false;
            this.xoaNCCBtn.Click += new System.EventHandler(this.xoaNCCBtn_Click);
            // 
            // lamMoiBtn
            // 
            this.lamMoiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.lamMoiBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lamMoiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamMoiBtn.ForeColor = System.Drawing.Color.Transparent;
            this.lamMoiBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.lamMoiBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lamMoiBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lamMoiBtn.IconSize = 32;
            this.lamMoiBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lamMoiBtn.Location = new System.Drawing.Point(857, 3);
            this.lamMoiBtn.Name = "lamMoiBtn";
            this.lamMoiBtn.Size = new System.Drawing.Size(214, 44);
            this.lamMoiBtn.TabIndex = 8;
            this.lamMoiBtn.Text = "Làm mới";
            this.lamMoiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lamMoiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lamMoiBtn.UseVisualStyleBackColor = false;
            this.lamMoiBtn.Click += new System.EventHandler(this.lamMoiBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Controls.Add(this.timKiemBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.refreshBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtTimKiem, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 300);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1178, 44);
            this.tableLayoutPanel4.TabIndex = 16;
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
            this.timKiemBtn.Location = new System.Drawing.Point(931, 3);
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
            this.refreshBtn.IconSize = 28;
            this.refreshBtn.Location = new System.Drawing.Point(1131, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(44, 38);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(3, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(922, 39);
            this.txtTimKiem.TabIndex = 6;
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANCC,
            this.TENNCC,
            this.DIACHI,
            this.SDT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCC.Location = new System.Drawing.Point(0, 344);
            this.dgvNCC.MultiSelect = false;
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNCC.RowTemplate.Height = 28;
            this.dgvNCC.Size = new System.Drawing.Size(1178, 320);
            this.dgvNCC.TabIndex = 17;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.Name = "MANCC";
            this.MANCC.ReadOnly = true;
            this.MANCC.Width = 122;
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên nhà cung cấp";
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.ReadOnly = true;
            this.TENNCC.Width = 300;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 200;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 200;
            // 
            // NhaCungCapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 664);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NhaCungCapForm";
            this.Text = "NhaCungCapForm";
            this.Load += new System.EventHandler(this.NhaCungCapForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton themNCCBtn;
        private FontAwesome.Sharp.IconButton suaNCCBtn;
        private FontAwesome.Sharp.IconButton xoaNCCBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private FontAwesome.Sharp.IconButton lamMoiBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconButton timKiemBtn;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}