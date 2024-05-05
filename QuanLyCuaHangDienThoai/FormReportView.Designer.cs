namespace QuanLyCuaHangDienThoai
{
    partial class FormReportView
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ControlBoxMaximum = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBoxMinimum = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1099, 716);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1015, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✖️";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ControlBoxMaximum
            // 
            this.ControlBoxMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxMaximum.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ControlBoxMaximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ControlBoxMaximum.FillColor = System.Drawing.Color.LightSkyBlue;
            this.ControlBoxMaximum.IconColor = System.Drawing.Color.White;
            this.ControlBoxMaximum.Location = new System.Drawing.Point(936, 7);
            this.ControlBoxMaximum.Name = "ControlBoxMaximum";
            this.ControlBoxMaximum.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxMaximum.TabIndex = 4;
            // 
            // ControlBoxMinimum
            // 
            this.ControlBoxMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxMinimum.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlBoxMinimum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ControlBoxMinimum.FillColor = System.Drawing.Color.LightSkyBlue;
            this.ControlBoxMinimum.IconColor = System.Drawing.Color.White;
            this.ControlBoxMinimum.Location = new System.Drawing.Point(854, 7);
            this.ControlBoxMinimum.Name = "ControlBoxMinimum";
            this.ControlBoxMinimum.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxMinimum.TabIndex = 5;
            // 
            // FormReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 716);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ControlBoxMaximum);
            this.Controls.Add(this.ControlBoxMinimum);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportView";
            this.Load += new System.EventHandler(this.FormReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxMaximum;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxMinimum;
    }
}