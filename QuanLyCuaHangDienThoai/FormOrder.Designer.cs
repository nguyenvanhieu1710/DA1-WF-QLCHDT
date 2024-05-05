namespace QuanLyCuaHangDienThoai
{
    partial class FormOrder
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
            this.flpContainerProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnStatus = new Guna.UI2.WinForms.Guna2Button();
            this.picImageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelivered = new Guna.UI2.WinForms.Guna2Button();
            this.btnWaitingForDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.btnWaitForConfirmation = new Guna.UI2.WinForms.Guna2Button();
            this.flpContainerProduct.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpContainerProduct
            // 
            this.flpContainerProduct.Controls.Add(this.pnlProduct);
            this.flpContainerProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpContainerProduct.Location = new System.Drawing.Point(0, 59);
            this.flpContainerProduct.Name = "flpContainerProduct";
            this.flpContainerProduct.Size = new System.Drawing.Size(893, 607);
            this.flpContainerProduct.TabIndex = 0;
            // 
            // pnlProduct
            // 
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProduct.Controls.Add(this.lblTotalPrice);
            this.pnlProduct.Controls.Add(this.btnStatus);
            this.pnlProduct.Controls.Add(this.picImageProduct);
            this.pnlProduct.Location = new System.Drawing.Point(3, 3);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(883, 103);
            this.pnlProduct.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(150, 32);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(105, 24);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // btnStatus
            // 
            this.btnStatus.AutoRoundedCorners = true;
            this.btnStatus.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStatus.BorderRadius = 21;
            this.btnStatus.BorderThickness = 1;
            this.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatus.FillColor = System.Drawing.Color.White;
            this.btnStatus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnStatus.ForeColor = System.Drawing.Color.Black;
            this.btnStatus.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnStatus.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(649, 32);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(180, 45);
            this.btnStatus.TabIndex = 8;
            this.btnStatus.Text = "Wait for pay";
            // 
            // picImageProduct
            // 
            this.picImageProduct.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_order_blue;
            this.picImageProduct.ImageRotate = 0F;
            this.picImageProduct.Location = new System.Drawing.Point(69, 12);
            this.picImageProduct.Name = "picImageProduct";
            this.picImageProduct.Size = new System.Drawing.Size(75, 75);
            this.picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageProduct.TabIndex = 0;
            this.picImageProduct.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelivered);
            this.panel1.Controls.Add(this.btnWaitingForDelivery);
            this.panel1.Controls.Add(this.btnWaitForConfirmation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnDelivered
            // 
            this.btnDelivered.AutoRoundedCorners = true;
            this.btnDelivered.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelivered.BorderRadius = 21;
            this.btnDelivered.BorderThickness = 1;
            this.btnDelivered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelivered.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivered.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivered.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivered.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivered.FillColor = System.Drawing.Color.White;
            this.btnDelivered.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDelivered.ForeColor = System.Drawing.Color.Black;
            this.btnDelivered.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDelivered.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelivered.Location = new System.Drawing.Point(680, 8);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(180, 45);
            this.btnDelivered.TabIndex = 10;
            this.btnDelivered.Text = "delivered";
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnWaitingForDelivery
            // 
            this.btnWaitingForDelivery.AutoRoundedCorners = true;
            this.btnWaitingForDelivery.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnWaitingForDelivery.BorderRadius = 21;
            this.btnWaitingForDelivery.BorderThickness = 1;
            this.btnWaitingForDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaitingForDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWaitingForDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWaitingForDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWaitingForDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWaitingForDelivery.FillColor = System.Drawing.Color.White;
            this.btnWaitingForDelivery.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnWaitingForDelivery.ForeColor = System.Drawing.Color.Black;
            this.btnWaitingForDelivery.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnWaitingForDelivery.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnWaitingForDelivery.Location = new System.Drawing.Point(350, 8);
            this.btnWaitingForDelivery.Name = "btnWaitingForDelivery";
            this.btnWaitingForDelivery.Size = new System.Drawing.Size(207, 45);
            this.btnWaitingForDelivery.TabIndex = 9;
            this.btnWaitingForDelivery.Text = "Waiting for delivery";
            this.btnWaitingForDelivery.Click += new System.EventHandler(this.btnWaitingForDelivery_Click);
            // 
            // btnWaitForConfirmation
            // 
            this.btnWaitForConfirmation.AutoRoundedCorners = true;
            this.btnWaitForConfirmation.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnWaitForConfirmation.BorderRadius = 21;
            this.btnWaitForConfirmation.BorderThickness = 1;
            this.btnWaitForConfirmation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaitForConfirmation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWaitForConfirmation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWaitForConfirmation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWaitForConfirmation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWaitForConfirmation.FillColor = System.Drawing.Color.White;
            this.btnWaitForConfirmation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnWaitForConfirmation.ForeColor = System.Drawing.Color.Black;
            this.btnWaitForConfirmation.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnWaitForConfirmation.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnWaitForConfirmation.Location = new System.Drawing.Point(23, 8);
            this.btnWaitForConfirmation.Name = "btnWaitForConfirmation";
            this.btnWaitForConfirmation.Size = new System.Drawing.Size(237, 45);
            this.btnWaitForConfirmation.TabIndex = 8;
            this.btnWaitForConfirmation.Text = "Wait for confirmation";
            this.btnWaitForConfirmation.Click += new System.EventHandler(this.btnWaitForConfirmation_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpContainerProduct);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.flpContainerProduct.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainerProduct;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDelivered;
        private Guna.UI2.WinForms.Guna2Button btnWaitingForDelivery;
        private Guna.UI2.WinForms.Guna2Button btnWaitForConfirmation;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Label lblTotalPrice;
        private Guna.UI2.WinForms.Guna2PictureBox picImageProduct;
        private Guna.UI2.WinForms.Guna2Button btnStatus;
    }
}