namespace DoAn_QuanLyCuaHangLaptop
{
    partial class ReportForm
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
            this.crpView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpView
            // 
            this.crpView.ActiveViewIndex = -1;
            this.crpView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpView.Location = new System.Drawing.Point(0, 0);
            this.crpView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crpView.Name = "crpView";
            this.crpView.Size = new System.Drawing.Size(1108, 626);
            this.crpView.TabIndex = 0;
            this.crpView.ToolPanelWidth = 225;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 626);
            this.Controls.Add(this.crpView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportForm";
            this.Text = "rpPhieuNhapForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crpView;
    }
}