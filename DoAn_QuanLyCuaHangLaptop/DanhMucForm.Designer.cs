namespace DoAn_QuanLyCuaHangLaptop
{
    partial class DanhMucForm
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
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.MADM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.themDMBtn = new FontAwesome.Sharp.IconButton();
            this.xoaDMBtn = new FontAwesome.Sharp.IconButton();
            this.lamMoiBtn = new FontAwesome.Sharp.IconButton();
            this.suaDMBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADM,
            this.TENDM});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMuc.Location = new System.Drawing.Point(0, 170);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowTemplate.Height = 28;
            this.dgvDanhMuc.Size = new System.Drawing.Size(1135, 445);
            this.dgvDanhMuc.TabIndex = 15;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // MADM
            // 
            this.MADM.DataPropertyName = "MADM";
            this.MADM.HeaderText = "Mã danh mục";
            this.MADM.Name = "MADM";
            this.MADM.ReadOnly = true;
            this.MADM.Width = 200;
            // 
            // TENDM
            // 
            this.TENDM.DataPropertyName = "TENDM";
            this.TENDM.HeaderText = "Tên danh mục";
            this.TENDM.Name = "TENDM";
            this.TENDM.ReadOnly = true;
            this.TENDM.Width = 400;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 170);
            this.panel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaDM, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTenDM, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1135, 120);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã danh mục";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên danh mục";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaDM.Enabled = false;
            this.txtMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDM.Location = new System.Drawing.Point(220, 10);
            this.txtMaDM.Margin = new System.Windows.Forms.Padding(20, 10, 30, 10);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(885, 39);
            this.txtMaDM.TabIndex = 0;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDM.Location = new System.Drawing.Point(220, 70);
            this.txtTenDM.Margin = new System.Windows.Forms.Padding(20, 10, 30, 10);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(885, 39);
            this.txtTenDM.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.themDMBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.xoaDMBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lamMoiBtn, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.suaDMBtn, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 50);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // themDMBtn
            // 
            this.themDMBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.themDMBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themDMBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themDMBtn.ForeColor = System.Drawing.Color.Transparent;
            this.themDMBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.themDMBtn.IconColor = System.Drawing.Color.Lime;
            this.themDMBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.themDMBtn.IconSize = 32;
            this.themDMBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.themDMBtn.Location = new System.Drawing.Point(85, 3);
            this.themDMBtn.Name = "themDMBtn";
            this.themDMBtn.Size = new System.Drawing.Size(214, 44);
            this.themDMBtn.TabIndex = 6;
            this.themDMBtn.Text = "Thêm mới";
            this.themDMBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themDMBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.themDMBtn.UseVisualStyleBackColor = false;
            this.themDMBtn.Click += new System.EventHandler(this.themDMBtn_Click);
            // 
            // xoaDMBtn
            // 
            this.xoaDMBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.xoaDMBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xoaDMBtn.Enabled = false;
            this.xoaDMBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaDMBtn.ForeColor = System.Drawing.Color.Transparent;
            this.xoaDMBtn.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.xoaDMBtn.IconColor = System.Drawing.Color.Red;
            this.xoaDMBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xoaDMBtn.IconSize = 32;
            this.xoaDMBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.xoaDMBtn.Location = new System.Drawing.Point(335, 3);
            this.xoaDMBtn.Name = "xoaDMBtn";
            this.xoaDMBtn.Size = new System.Drawing.Size(214, 44);
            this.xoaDMBtn.TabIndex = 7;
            this.xoaDMBtn.Text = "Xóa";
            this.xoaDMBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoaDMBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoaDMBtn.UseVisualStyleBackColor = false;
            this.xoaDMBtn.Click += new System.EventHandler(this.xoaDMBtn_Click);
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
            this.lamMoiBtn.Location = new System.Drawing.Point(835, 3);
            this.lamMoiBtn.Name = "lamMoiBtn";
            this.lamMoiBtn.Size = new System.Drawing.Size(214, 44);
            this.lamMoiBtn.TabIndex = 8;
            this.lamMoiBtn.Text = "Làm mới";
            this.lamMoiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lamMoiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lamMoiBtn.UseVisualStyleBackColor = false;
            this.lamMoiBtn.Click += new System.EventHandler(this.lamMoiBtn_Click);
            // 
            // suaDMBtn
            // 
            this.suaDMBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.suaDMBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suaDMBtn.Enabled = false;
            this.suaDMBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaDMBtn.ForeColor = System.Drawing.Color.Transparent;
            this.suaDMBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.suaDMBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.suaDMBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.suaDMBtn.IconSize = 32;
            this.suaDMBtn.Location = new System.Drawing.Point(585, 3);
            this.suaDMBtn.Name = "suaDMBtn";
            this.suaDMBtn.Size = new System.Drawing.Size(214, 44);
            this.suaDMBtn.TabIndex = 8;
            this.suaDMBtn.Text = "Sửa thông tin";
            this.suaDMBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.suaDMBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.suaDMBtn.UseVisualStyleBackColor = false;
            this.suaDMBtn.Click += new System.EventHandler(this.suaDMBtn_Click);
            // 
            // DanhMucForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 615);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DanhMucForm";
            this.Text = "DanhMucForm";
            this.Load += new System.EventHandler(this.DanhMucForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton themDMBtn;
        private FontAwesome.Sharp.IconButton xoaDMBtn;
        private FontAwesome.Sharp.IconButton lamMoiBtn;
        private FontAwesome.Sharp.IconButton suaDMBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDM;
    }
}