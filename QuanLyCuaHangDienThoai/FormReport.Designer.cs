namespace QuanLyCuaHangDienThoai
{
    partial class FormReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast7Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast30Days = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Based on statistics";
            // 
            // btnToday
            // 
            this.btnToday.AutoRoundedCorners = true;
            this.btnToday.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnToday.BorderRadius = 21;
            this.btnToday.BorderThickness = 1;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToday.FillColor = System.Drawing.Color.White;
            this.btnToday.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnToday.ForeColor = System.Drawing.Color.Black;
            this.btnToday.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnToday.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(53, 76);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(385, 45);
            this.btnToday.TabIndex = 7;
            this.btnToday.Text = "Export report according to today\'s date";
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.AutoRoundedCorners = true;
            this.btnLast7Days.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLast7Days.BorderRadius = 21;
            this.btnLast7Days.BorderThickness = 1;
            this.btnLast7Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast7Days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLast7Days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLast7Days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLast7Days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLast7Days.FillColor = System.Drawing.Color.White;
            this.btnLast7Days.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLast7Days.ForeColor = System.Drawing.Color.Black;
            this.btnLast7Days.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLast7Days.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLast7Days.Location = new System.Drawing.Point(53, 145);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(457, 45);
            this.btnLast7Days.TabIndex = 8;
            this.btnLast7Days.Text = "Export reports according to the previous 7 days";
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.AutoRoundedCorners = true;
            this.btnLast30Days.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLast30Days.BorderRadius = 21;
            this.btnLast30Days.BorderThickness = 1;
            this.btnLast30Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast30Days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLast30Days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLast30Days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLast30Days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLast30Days.FillColor = System.Drawing.Color.White;
            this.btnLast30Days.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLast30Days.ForeColor = System.Drawing.Color.Black;
            this.btnLast30Days.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLast30Days.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLast30Days.Location = new System.Drawing.Point(53, 210);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(468, 45);
            this.btnLast30Days.TabIndex = 9;
            this.btnLast30Days.Text = "Export reports according to the previous 30 days";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnToday;
        private Guna.UI2.WinForms.Guna2Button btnLast7Days;
        private Guna.UI2.WinForms.Guna2Button btnLast30Days;
    }
}