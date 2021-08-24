namespace DoAn_QuanLyCuaHangLaptop
{
    partial class DangNhapForm
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
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbNhoTK = new System.Windows.Forms.CheckBox();
            this.thoatBtn = new System.Windows.Forms.Button();
            this.dangnhapBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(92, 287);
            this.txtTaiKhoan.MaxLength = 50;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(377, 39);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(92, 380);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(377, 39);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // chkbNhoTK
            // 
            this.chkbNhoTK.AutoSize = true;
            this.chkbNhoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbNhoTK.ForeColor = System.Drawing.Color.White;
            this.chkbNhoTK.Location = new System.Drawing.Point(312, 435);
            this.chkbNhoTK.Name = "chkbNhoTK";
            this.chkbNhoTK.Size = new System.Drawing.Size(157, 26);
            this.chkbNhoTK.TabIndex = 3;
            this.chkbNhoTK.Text = "Nhớ tài khoản?";
            this.chkbNhoTK.UseVisualStyleBackColor = true;
            // 
            // thoatBtn
            // 
            this.thoatBtn.BackColor = System.Drawing.Color.White;
            this.thoatBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.thoatBtn.FlatAppearance.BorderSize = 0;
            this.thoatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatBtn.ForeColor = System.Drawing.Color.Black;
            this.thoatBtn.Location = new System.Drawing.Point(324, 497);
            this.thoatBtn.Name = "thoatBtn";
            this.thoatBtn.Size = new System.Drawing.Size(145, 44);
            this.thoatBtn.TabIndex = 4;
            this.thoatBtn.Text = "Thoát";
            this.thoatBtn.UseVisualStyleBackColor = false;
            // 
            // dangnhapBtn
            // 
            this.dangnhapBtn.BackColor = System.Drawing.Color.White;
            this.dangnhapBtn.FlatAppearance.BorderSize = 0;
            this.dangnhapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhapBtn.ForeColor = System.Drawing.Color.Black;
            this.dangnhapBtn.Location = new System.Drawing.Point(92, 497);
            this.dangnhapBtn.Name = "dangnhapBtn";
            this.dangnhapBtn.Size = new System.Drawing.Size(145, 44);
            this.dangnhapBtn.TabIndex = 4;
            this.dangnhapBtn.Text = "Đăng nhập";
            this.dangnhapBtn.UseVisualStyleBackColor = false;
            this.dangnhapBtn.Click += new System.EventHandler(this.dangnhapBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 119);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đăng nhập";
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(578, 664);
            this.Controls.Add(this.dangnhapBtn);
            this.Controls.Add(this.thoatBtn);
            this.Controls.Add(this.chkbNhoTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhapForm";
            this.Load += new System.EventHandler(this.DangNhapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbNhoTK;
        private System.Windows.Forms.Button thoatBtn;
        private System.Windows.Forms.Button dangnhapBtn;
        private System.Windows.Forms.Label label3;
    }
}