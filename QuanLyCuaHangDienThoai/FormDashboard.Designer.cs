namespace QuanLyCuaHangDienThoai
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_startedDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endedDate = new System.Windows.Forms.DateTimePicker();
            this.btnCustomDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast30Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast7Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_orders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_grossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_bestSellingProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_products = new System.Windows.Forms.Label();
            this.label_customers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_underStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_totalRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_totalProfit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_startedDate = new System.Windows.Forms.Label();
            this.label_endedDate = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bestSellingProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_underStock)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_startedDate
            // 
            this.dateTimePicker_startedDate.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker_startedDate.Name = "dateTimePicker_startedDate";
            this.dateTimePicker_startedDate.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_startedDate.TabIndex = 0;
            this.dateTimePicker_startedDate.ValueChanged += new System.EventHandler(this.DateTimePicker_startedDate_ValueChanged_1);
            // 
            // dateTimePicker_endedDate
            // 
            this.dateTimePicker_endedDate.Location = new System.Drawing.Point(218, 12);
            this.dateTimePicker_endedDate.Name = "dateTimePicker_endedDate";
            this.dateTimePicker_endedDate.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_endedDate.TabIndex = 0;
            this.dateTimePicker_endedDate.ValueChanged += new System.EventHandler(this.DateTimePicker_endedDate_ValueChanged_1);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.AutoRoundedCorners = true;
            this.btnCustomDate.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomDate.BorderRadius = 21;
            this.btnCustomDate.BorderThickness = 1;
            this.btnCustomDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomDate.FillColor = System.Drawing.Color.White;
            this.btnCustomDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCustomDate.ForeColor = System.Drawing.Color.Black;
            this.btnCustomDate.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomDate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCustomDate.Location = new System.Drawing.Point(441, 12);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(112, 45);
            this.btnCustomDate.TabIndex = 6;
            this.btnCustomDate.Text = "Custom";
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
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
            this.btnLast30Days.Location = new System.Drawing.Point(672, 63);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(147, 45);
            this.btnLast30Days.TabIndex = 6;
            this.btnLast30Days.Text = "Last 30 Days";
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
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
            this.btnLast7Days.Location = new System.Drawing.Point(677, 12);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(142, 45);
            this.btnLast7Days.TabIndex = 6;
            this.btnLast7Days.Text = "Last 7 Days";
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
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
            this.btnToday.Location = new System.Drawing.Point(559, 12);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(112, 45);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Today";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2PictureBox3);
            this.panel1.Controls.Add(this.label_orders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 69);
            this.panel1.TabIndex = 7;
            // 
            // label_orders
            // 
            this.label_orders.AutoSize = true;
            this.label_orders.Location = new System.Drawing.Point(58, 34);
            this.label_orders.Name = "label_orders";
            this.label_orders.Size = new System.Drawing.Size(76, 24);
            this.label_orders.TabIndex = 0;
            this.label_orders.Text = "100000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Orders";
            // 
            // chart_grossRevenue
            // 
            chartArea1.Name = "Gross Revenue";
            this.chart_grossRevenue.ChartAreas.Add(chartArea1);
            this.chart_grossRevenue.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart_grossRevenue.Legends.Add(legend1);
            this.chart_grossRevenue.Location = new System.Drawing.Point(12, 194);
            this.chart_grossRevenue.Name = "chart_grossRevenue";
            series1.ChartArea = "Gross Revenue";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_grossRevenue.Series.Add(series1);
            this.chart_grossRevenue.Size = new System.Drawing.Size(544, 300);
            this.chart_grossRevenue.TabIndex = 8;
            this.chart_grossRevenue.Text = "Gross Revenue";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            this.chart_grossRevenue.Titles.Add(title1);
            // 
            // chart_bestSellingProduct
            // 
            chartArea2.Name = "Gross Revenue";
            this.chart_bestSellingProduct.ChartAreas.Add(chartArea2);
            this.chart_bestSellingProduct.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart_bestSellingProduct.Legends.Add(legend2);
            this.chart_bestSellingProduct.Location = new System.Drawing.Point(573, 194);
            this.chart_bestSellingProduct.Name = "chart_bestSellingProduct";
            series2.ChartArea = "Gross Revenue";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_bestSellingProduct.Series.Add(series2);
            this.chart_bestSellingProduct.Size = new System.Drawing.Size(298, 460);
            this.chart_bestSellingProduct.TabIndex = 8;
            this.chart_bestSellingProduct.Text = "Gross Revenue";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            this.chart_bestSellingProduct.Titles.Add(title2);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2PictureBox2);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.label_products);
            this.panel2.Controls.Add(this.label_customers);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 143);
            this.panel2.TabIndex = 7;
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.Location = new System.Drawing.Point(58, 99);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(76, 24);
            this.label_products.TabIndex = 0;
            this.label_products.Text = "100000";
            // 
            // label_customers
            // 
            this.label_customers.AutoSize = true;
            this.label_customers.Location = new System.Drawing.Point(58, 38);
            this.label_customers.Name = "label_customers";
            this.label_customers.Size = new System.Drawing.Size(76, 24);
            this.label_customers.TabIndex = 0;
            this.label_customers.Text = "100000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Number of product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Number of Customer";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_underStock);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(232, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 142);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView_underStock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_underStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_underStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_underStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_underStock.ColumnHeadersHeight = 20;
            this.dataGridView_underStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_underStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_underStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_underStock.Location = new System.Drawing.Point(3, 28);
            this.dataGridView_underStock.Name = "dataGridView_underStock";
            this.dataGridView_underStock.RowHeadersVisible = false;
            this.dataGridView_underStock.RowHeadersWidth = 51;
            this.dataGridView_underStock.RowTemplate.Height = 24;
            this.dataGridView_underStock.Size = new System.Drawing.Size(318, 111);
            this.dataGridView_underStock.TabIndex = 1;
            this.dataGridView_underStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_underStock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_underStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_underStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_underStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_underStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_underStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_underStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_underStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_underStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridView_underStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_underStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_underStock.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridView_underStock.ThemeStyle.ReadOnly = false;
            this.dataGridView_underStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_underStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_underStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridView_underStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_underStock.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_underStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_underStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Products Understock";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_totalRevenue);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(232, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 69);
            this.panel4.TabIndex = 7;
            // 
            // label_totalRevenue
            // 
            this.label_totalRevenue.AutoSize = true;
            this.label_totalRevenue.Location = new System.Drawing.Point(28, 34);
            this.label_totalRevenue.Name = "label_totalRevenue";
            this.label_totalRevenue.Size = new System.Drawing.Size(76, 24);
            this.label_totalRevenue.TabIndex = 0;
            this.label_totalRevenue.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Revenue";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_totalProfit);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(515, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(356, 69);
            this.panel5.TabIndex = 7;
            // 
            // label_totalProfit
            // 
            this.label_totalProfit.AutoSize = true;
            this.label_totalProfit.Location = new System.Drawing.Point(23, 33);
            this.label_totalProfit.Name = "label_totalProfit";
            this.label_totalProfit.Size = new System.Drawing.Size(76, 24);
            this.label_totalProfit.TabIndex = 0;
            this.label_totalProfit.Text = "100000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Profit";
            // 
            // label_startedDate
            // 
            this.label_startedDate.AutoSize = true;
            this.label_startedDate.Location = new System.Drawing.Point(28, 47);
            this.label_startedDate.Name = "label_startedDate";
            this.label_startedDate.Size = new System.Drawing.Size(64, 24);
            this.label_startedDate.TabIndex = 9;
            this.label_startedDate.Text = "label6";
            // 
            // label_endedDate
            // 
            this.label_endedDate.AutoSize = true;
            this.label_endedDate.Location = new System.Drawing.Point(231, 47);
            this.label_endedDate.Name = "label_endedDate";
            this.label_endedDate.Size = new System.Drawing.Size(75, 24);
            this.label_endedDate.TabIndex = 10;
            this.label_endedDate.Text = "label10";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.User;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(20, 30);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_mobile_phone_blue;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(20, 91);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::QuanLyCuaHangDienThoai.Properties.Resources.icon_order_blue;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(20, 26);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 2;
            this.guna2PictureBox3.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 666);
            this.Controls.Add(this.label_endedDate);
            this.Controls.Add(this.label_startedDate);
            this.Controls.Add(this.chart_bestSellingProduct);
            this.Controls.Add(this.chart_grossRevenue);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.dateTimePicker_endedDate);
            this.Controls.Add(this.dateTimePicker_startedDate);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bestSellingProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_underStock)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_startedDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endedDate;
        private Guna.UI2.WinForms.Guna2Button btnCustomDate;
        private Guna.UI2.WinForms.Guna2Button btnLast30Days;
        private Guna.UI2.WinForms.Guna2Button btnLast7Days;
        private Guna.UI2.WinForms.Guna2Button btnToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bestSellingProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_underStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_customers;
        private System.Windows.Forms.Label label_totalProfit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.Label label_totalRevenue;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_startedDate;
        private System.Windows.Forms.Label label_endedDate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}