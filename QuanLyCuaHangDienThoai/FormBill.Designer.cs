namespace QuanLyCuaHangDienThoai
{
    partial class FormBill
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
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.picImageCustomer = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flpContainer.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // flpContainer
            // 
            this.flpContainer.AutoScroll = true;
            this.flpContainer.Controls.Add(this.pnlCustomer);
            this.flpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContainer.Location = new System.Drawing.Point(0, 0);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(893, 654);
            this.flpContainer.TabIndex = 16;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCustomer.Controls.Add(this.lblCustomerName);
            this.pnlCustomer.Controls.Add(this.btnChoose);
            this.pnlCustomer.Controls.Add(this.picImageCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(3, 3);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(883, 103);
            this.pnlCustomer.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(150, 32);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(153, 24);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnChoose
            // 
            this.btnChoose.AutoRoundedCorners = true;
            this.btnChoose.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnChoose.BorderRadius = 21;
            this.btnChoose.BorderThickness = 1;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoose.FillColor = System.Drawing.Color.White;
            this.btnChoose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChoose.ForeColor = System.Drawing.Color.Black;
            this.btnChoose.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnChoose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Location = new System.Drawing.Point(649, 32);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(180, 45);
            this.btnChoose.TabIndex = 8;
            this.btnChoose.Text = "Choose";
            // 
            // picImageCustomer
            // 
            this.picImageCustomer.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_order_blue;
            this.picImageCustomer.ImageRotate = 0F;
            this.picImageCustomer.Location = new System.Drawing.Point(69, 12);
            this.picImageCustomer.Name = "picImageCustomer";
            this.picImageCustomer.Size = new System.Drawing.Size(75, 75);
            this.picImageCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageCustomer.TabIndex = 0;
            this.picImageCustomer.TabStop = false;
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 654);
            this.Controls.Add(this.flpContainer);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.flpContainer.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private Guna.UI2.WinForms.Guna2Button btnChoose;
        private Guna.UI2.WinForms.Guna2PictureBox picImageCustomer;
    }
}