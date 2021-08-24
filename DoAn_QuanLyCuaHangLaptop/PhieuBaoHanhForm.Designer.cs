namespace DoAn_QuanLyCuaHangLaptop
{
    partial class PhieuBaoHanhForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTienBH = new System.Windows.Forms.TextBox();
            this.txtLYDO = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.suaPhieuBHBtn = new FontAwesome.Sharp.IconButton();
            this.xoaPhieuBHBtn = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.timKiemBtn = new FontAwesome.Sharp.IconButton();
            this.dgvPhieuBaoHanh = new System.Windows.Forms.DataGridView();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LANBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LYDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuBaoHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 436);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1041, 190);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtTienBH, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLYDO, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(615, 184);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtTienBH
            // 
            this.txtTienBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTienBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienBH.Location = new System.Drawing.Point(203, 3);
            this.txtTienBH.Name = "txtTienBH";
            this.txtTienBH.Size = new System.Drawing.Size(409, 30);
            this.txtTienBH.TabIndex = 0;
            this.txtTienBH.Text = "0";
            this.txtTienBH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienBH_KeyPress);
            this.txtTienBH.Leave += new System.EventHandler(this.txtTienBH_Leave);
            // 
            // txtLYDO
            // 
            this.txtLYDO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLYDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLYDO.Location = new System.Drawing.Point(203, 73);
            this.txtLYDO.Name = "txtLYDO";
            this.txtLYDO.Size = new System.Drawing.Size(409, 108);
            this.txtLYDO.TabIndex = 1;
            this.txtLYDO.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiền bảo hành";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 114);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lý do";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.suaPhieuBHBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.xoaPhieuBHBtn, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(624, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(414, 184);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // suaPhieuBHBtn
            // 
            this.suaPhieuBHBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.suaPhieuBHBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suaPhieuBHBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaPhieuBHBtn.ForeColor = System.Drawing.Color.White;
            this.suaPhieuBHBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.suaPhieuBHBtn.IconColor = System.Drawing.Color.Orange;
            this.suaPhieuBHBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.suaPhieuBHBtn.IconSize = 32;
            this.suaPhieuBHBtn.Location = new System.Drawing.Point(3, 137);
            this.suaPhieuBHBtn.Name = "suaPhieuBHBtn";
            this.suaPhieuBHBtn.Size = new System.Drawing.Size(201, 44);
            this.suaPhieuBHBtn.TabIndex = 0;
            this.suaPhieuBHBtn.Text = "Sửa";
            this.suaPhieuBHBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.suaPhieuBHBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.suaPhieuBHBtn.UseVisualStyleBackColor = false;
            this.suaPhieuBHBtn.Click += new System.EventHandler(this.suaPhieuBHBtn_Click);
            // 
            // xoaPhieuBHBtn
            // 
            this.xoaPhieuBHBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.xoaPhieuBHBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xoaPhieuBHBtn.ForeColor = System.Drawing.Color.White;
            this.xoaPhieuBHBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.xoaPhieuBHBtn.IconColor = System.Drawing.Color.Red;
            this.xoaPhieuBHBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xoaPhieuBHBtn.IconSize = 32;
            this.xoaPhieuBHBtn.Location = new System.Drawing.Point(210, 137);
            this.xoaPhieuBHBtn.Name = "xoaPhieuBHBtn";
            this.xoaPhieuBHBtn.Size = new System.Drawing.Size(201, 44);
            this.xoaPhieuBHBtn.TabIndex = 1;
            this.xoaPhieuBHBtn.Text = "Xóa";
            this.xoaPhieuBHBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xoaPhieuBHBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoaPhieuBHBtn.UseVisualStyleBackColor = false;
            this.xoaPhieuBHBtn.Click += new System.EventHandler(this.xoaPhieuBHBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel4.Controls.Add(this.txtTimKiem, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.timKiemBtn, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1041, 50);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(3, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(815, 39);
            this.txtTimKiem.TabIndex = 1;
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
            this.timKiemBtn.Location = new System.Drawing.Point(824, 3);
            this.timKiemBtn.Name = "timKiemBtn";
            this.timKiemBtn.Size = new System.Drawing.Size(214, 44);
            this.timKiemBtn.TabIndex = 2;
            this.timKiemBtn.Text = "Tìm kiếm";
            this.timKiemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timKiemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timKiemBtn.UseVisualStyleBackColor = false;
            this.timKiemBtn.Click += new System.EventHandler(this.timKiemBtn_Click);
            // 
            // dgvPhieuBaoHanh
            // 
            this.dgvPhieuBaoHanh.AllowDrop = true;
            this.dgvPhieuBaoHanh.AllowUserToAddRows = false;
            this.dgvPhieuBaoHanh.AllowUserToDeleteRows = false;
            this.dgvPhieuBaoHanh.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuBaoHanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhieuBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuBaoHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENKH,
            this.TENSP,
            this.LANBH,
            this.NGAYBH,
            this.TIENBH,
            this.LYDO,
            this.MAHD,
            this.MASP});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuBaoHanh.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPhieuBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuBaoHanh.Location = new System.Drawing.Point(0, 50);
            this.dgvPhieuBaoHanh.Name = "dgvPhieuBaoHanh";
            this.dgvPhieuBaoHanh.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuBaoHanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPhieuBaoHanh.RowTemplate.Height = 28;
            this.dgvPhieuBaoHanh.Size = new System.Drawing.Size(1041, 386);
            this.dgvPhieuBaoHanh.TabIndex = 22;
            this.dgvPhieuBaoHanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuBaoHanh_CellClick);
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 200;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            this.TENSP.Width = 200;
            // 
            // LANBH
            // 
            this.LANBH.DataPropertyName = "LANBH";
            this.LANBH.HeaderText = "Lần bảo hành";
            this.LANBH.Name = "LANBH";
            this.LANBH.ReadOnly = true;
            // 
            // NGAYBH
            // 
            this.NGAYBH.DataPropertyName = "NGAYBAOHANH";
            this.NGAYBH.HeaderText = "Ngày bảo hành";
            this.NGAYBH.Name = "NGAYBH";
            this.NGAYBH.ReadOnly = true;
            this.NGAYBH.Width = 200;
            // 
            // TIENBH
            // 
            this.TIENBH.DataPropertyName = "TIENBH";
            dataGridViewCellStyle6.Format = "N0";
            this.TIENBH.DefaultCellStyle = dataGridViewCellStyle6;
            this.TIENBH.HeaderText = "Tiền bảo hành";
            this.TIENBH.Name = "TIENBH";
            this.TIENBH.ReadOnly = true;
            this.TIENBH.Width = 200;
            // 
            // LYDO
            // 
            this.LYDO.DataPropertyName = "LYDO";
            this.LYDO.HeaderText = "Lý do";
            this.LYDO.Name = "LYDO";
            this.LYDO.ReadOnly = true;
            this.LYDO.Width = 200;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "MAHD";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Visible = false;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "MASP";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            this.MASP.Visible = false;
            // 
            // PhieuBaoHanhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 626);
            this.Controls.Add(this.dgvPhieuBaoHanh);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PhieuBaoHanhForm";
            this.Text = "PhieuBaoHanhForm";
            this.Load += new System.EventHandler(this.PhieuBaoHanhForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuBaoHanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtTienBH;
        private System.Windows.Forms.RichTextBox txtLYDO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton suaPhieuBHBtn;
        private FontAwesome.Sharp.IconButton xoaPhieuBHBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton timKiemBtn;
        private System.Windows.Forms.DataGridView dgvPhieuBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LYDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
    }
}