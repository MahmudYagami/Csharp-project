
namespace Modern_Pharmacy_Managment_System
{
    partial class AdminMainDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainDashboard));
            this.RevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LastYearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TodayBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Last30Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Last7Btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalOrders = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalRevenue = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DateStartCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateEndCalender = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmployeeCnt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLeaveCnt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UnpaidEmpCnt = new System.Windows.Forms.Label();
            this.CustomerCountPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.CustomerCountPanel.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // RevenueChart
            // 
            this.RevenueChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.RevenueChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.IsMarginVisible = false;
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.BlueViolet;
            chartArea5.AxisX.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.LineWidth = 0;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisX.MajorGrid.LineWidth = 0;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.MediumPurple;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.BlueViolet;
            chartArea5.AxisY.LabelStyle.Format = "${0}";
            chartArea5.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.LineWidth = 0;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.MajorTickMark.LineWidth = 0;
            chartArea5.BackColor = System.Drawing.Color.LightCyan;
            chartArea5.BorderColor = System.Drawing.Color.Maroon;
            chartArea5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.Name = "ChartArea1";
            this.RevenueChart.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.White;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Font = new System.Drawing.Font("Verdana", 8F);
            legend5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            legend5.IsTextAutoFit = false;
            legend5.Name = "Revenue";
            this.RevenueChart.Legends.Add(legend5);
            this.RevenueChart.Location = new System.Drawing.Point(18, 145);
            this.RevenueChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RevenueChart.Name = "RevenueChart";
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series5.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series5.BackSecondaryColor = System.Drawing.Color.RoyalBlue;
            series5.BorderColor = System.Drawing.Color.DarkRed;
            series5.BorderWidth = 0;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.Color = System.Drawing.Color.Cyan;
            series5.Legend = "Revenue";
            series5.MarkerColor = System.Drawing.Color.Cyan;
            series5.MarkerSize = 2;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Revenue";
            series5.ShadowColor = System.Drawing.Color.LightGreen;
            series5.YValuesPerPoint = 2;
            this.RevenueChart.Series.Add(series5);
            this.RevenueChart.Size = new System.Drawing.Size(1229, 392);
            this.RevenueChart.TabIndex = 33;
            this.RevenueChart.Text = "chart1";
            title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title5.BackColor = System.Drawing.Color.White;
            title5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.ForeColor = System.Drawing.Color.SaddleBrown;
            title5.Name = "Title1";
            title5.ShadowColor = System.Drawing.Color.Red;
            title5.Text = "Gross Revenue";
            this.RevenueChart.Titles.Add(title5);
            // 
            // LastYearBtn
            // 
            this.LastYearBtn.Animated = true;
            this.LastYearBtn.BackColor = System.Drawing.Color.Transparent;
            this.LastYearBtn.BorderRadius = 10;
            this.LastYearBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LastYearBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.LastYearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LastYearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LastYearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LastYearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LastYearBtn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.LastYearBtn.FocusedColor = System.Drawing.Color.Red;
            this.LastYearBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastYearBtn.ForeColor = System.Drawing.Color.White;
            this.LastYearBtn.Location = new System.Drawing.Point(1032, 11);
            this.LastYearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastYearBtn.Name = "LastYearBtn";
            this.LastYearBtn.Size = new System.Drawing.Size(190, 34);
            this.LastYearBtn.TabIndex = 39;
            this.LastYearBtn.Text = "Last Year";
            // 
            // TodayBtn
            // 
            this.TodayBtn.Animated = true;
            this.TodayBtn.BorderRadius = 10;
            this.TodayBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TodayBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.TodayBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TodayBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TodayBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TodayBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TodayBtn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.TodayBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.TodayBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayBtn.ForeColor = System.Drawing.Color.White;
            this.TodayBtn.Location = new System.Drawing.Point(545, 11);
            this.TodayBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TodayBtn.Name = "TodayBtn";
            this.TodayBtn.Size = new System.Drawing.Size(122, 34);
            this.TodayBtn.TabIndex = 41;
            this.TodayBtn.Text = "Today";
            this.TodayBtn.Click += new System.EventHandler(this.TodayBtn_Click_1);
            // 
            // Last30Btn
            // 
            this.Last30Btn.Animated = true;
            this.Last30Btn.BorderRadius = 10;
            this.Last30Btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Last30Btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Last30Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Last30Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Last30Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Last30Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Last30Btn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Last30Btn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Last30Btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last30Btn.ForeColor = System.Drawing.Color.White;
            this.Last30Btn.Location = new System.Drawing.Point(841, 11);
            this.Last30Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Last30Btn.Name = "Last30Btn";
            this.Last30Btn.Size = new System.Drawing.Size(185, 34);
            this.Last30Btn.TabIndex = 40;
            this.Last30Btn.Text = "Last 30 days";
            // 
            // Last7Btn
            // 
            this.Last7Btn.Animated = true;
            this.Last7Btn.BorderRadius = 10;
            this.Last7Btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Last7Btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Last7Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Last7Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Last7Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Last7Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Last7Btn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Last7Btn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(66)))), ((int)(((byte)(252)))));
            this.Last7Btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last7Btn.ForeColor = System.Drawing.Color.White;
            this.Last7Btn.Location = new System.Drawing.Point(673, 11);
            this.Last7Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Last7Btn.Name = "Last7Btn";
            this.Last7Btn.Size = new System.Drawing.Size(162, 34);
            this.Last7Btn.TabIndex = 42;
            this.Last7Btn.Text = "Last 7 days";
            this.Last7Btn.Click += new System.EventHandler(this.Last7Btn_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(0, 7);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(57, 57);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 6;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 7);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(51, 50);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 5;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.TotalOrders);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Location = new System.Drawing.Point(36, 65);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(227, 70);
            this.guna2Panel1.TabIndex = 45;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 7);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(55, 53);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(48, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalOrders
            // 
            this.TotalOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrders.Location = new System.Drawing.Point(57, 32);
            this.TotalOrders.Name = "TotalOrders";
            this.TotalOrders.Size = new System.Drawing.Size(151, 25);
            this.TotalOrders.TabIndex = 2;
            this.TotalOrders.Text = "100000.76";
            this.TotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 5;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.TotalRevenue);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel2.Location = new System.Drawing.Point(353, 65);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(229, 70);
            this.guna2Panel2.TabIndex = 46;
            this.guna2Panel2.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(48, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Revenue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalRevenue
            // 
            this.TotalRevenue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRevenue.Location = new System.Drawing.Point(57, 32);
            this.TotalRevenue.Name = "TotalRevenue";
            this.TotalRevenue.Size = new System.Drawing.Size(151, 25);
            this.TotalRevenue.TabIndex = 2;
            this.TotalRevenue.Text = "100000.76";
            this.TotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 5;
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel3.Location = new System.Drawing.Point(673, 65);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(227, 70);
            this.guna2Panel3.TabIndex = 46;
            this.guna2Panel3.UseTransparentBackground = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(48, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Profit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "100000.76";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.BorderThickness = 5;
            this.guna2Panel4.Controls.Add(this.label6);
            this.guna2Panel4.Controls.Add(this.label7);
            this.guna2Panel4.Controls.Add(this.guna2PictureBox4);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel4.Location = new System.Drawing.Point(998, 65);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(236, 70);
            this.guna2Panel4.TabIndex = 47;
            this.guna2Panel4.UseTransparentBackground = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(48, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Expense";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "100000.76";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(0, 7);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(57, 57);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 6;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // DateStartCalender
            // 
            this.DateStartCalender.BorderRadius = 8;
            this.DateStartCalender.Checked = true;
            this.DateStartCalender.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.DateStartCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateStartCalender.ForeColor = System.Drawing.Color.White;
            this.DateStartCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateStartCalender.Location = new System.Drawing.Point(15, 9);
            this.DateStartCalender.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateStartCalender.MinDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.DateStartCalender.Name = "DateStartCalender";
            this.DateStartCalender.Size = new System.Drawing.Size(193, 36);
            this.DateStartCalender.TabIndex = 49;
            this.DateStartCalender.Value = new System.DateTime(2024, 4, 5, 17, 31, 20, 106);
            // 
            // DateEndCalender
            // 
            this.DateEndCalender.BorderRadius = 8;
            this.DateEndCalender.Checked = true;
            this.DateEndCalender.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.DateEndCalender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateEndCalender.ForeColor = System.Drawing.Color.White;
            this.DateEndCalender.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateEndCalender.Location = new System.Drawing.Point(275, 9);
            this.DateEndCalender.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEndCalender.MinDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.DateEndCalender.Name = "DateEndCalender";
            this.DateEndCalender.Size = new System.Drawing.Size(193, 36);
            this.DateEndCalender.TabIndex = 50;
            this.DateEndCalender.Value = new System.DateTime(2024, 4, 5, 17, 31, 20, 106);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.LightCyan;
            this.guna2Panel5.Controls.Add(this.UnpaidEmpCnt);
            this.guna2Panel5.Controls.Add(this.CustomerCountPanel);
            this.guna2Panel5.Controls.Add(this.label10);
            this.guna2Panel5.Controls.Add(this.lblLeaveCnt);
            this.guna2Panel5.Controls.Add(this.label8);
            this.guna2Panel5.Controls.Add(this.label3);
            this.guna2Panel5.Location = new System.Drawing.Point(12, 542);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(260, 232);
            this.guna2Panel5.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Management";
            // 
            // lblEmployeeCnt
            // 
            this.lblEmployeeCnt.AutoSize = true;
            this.lblEmployeeCnt.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCnt.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCnt.Location = new System.Drawing.Point(59, 8);
            this.lblEmployeeCnt.Name = "lblEmployeeCnt";
            this.lblEmployeeCnt.Size = new System.Drawing.Size(41, 29);
            this.lblEmployeeCnt.TabIndex = 3;
            this.lblEmployeeCnt.Text = "14";
            this.lblEmployeeCnt.Click += new System.EventHandler(this.lblEmployeeCnt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(0, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "        Employee On Leave";
            // 
            // lblLeaveCnt
            // 
            this.lblLeaveCnt.AutoSize = true;
            this.lblLeaveCnt.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveCnt.ForeColor = System.Drawing.Color.Black;
            this.lblLeaveCnt.Location = new System.Drawing.Point(88, 121);
            this.lblLeaveCnt.Name = "lblLeaveCnt";
            this.lblLeaveCnt.Size = new System.Drawing.Size(55, 40);
            this.lblLeaveCnt.TabIndex = 5;
            this.lblLeaveCnt.Text = "14";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(-3, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "         Unpaid Employee";
            // 
            // UnpaidEmpCnt
            // 
            this.UnpaidEmpCnt.AutoSize = true;
            this.UnpaidEmpCnt.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnpaidEmpCnt.ForeColor = System.Drawing.Color.Black;
            this.UnpaidEmpCnt.Location = new System.Drawing.Point(88, 180);
            this.UnpaidEmpCnt.Name = "UnpaidEmpCnt";
            this.UnpaidEmpCnt.Size = new System.Drawing.Size(55, 40);
            this.UnpaidEmpCnt.TabIndex = 7;
            this.UnpaidEmpCnt.Text = "14";
            // 
            // CustomerCountPanel
            // 
            this.CustomerCountPanel.AutoRoundedCorners = true;
            this.CustomerCountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(221)))), ((int)(((byte)(207)))));
            this.CustomerCountPanel.BorderRadius = 36;
            this.CustomerCountPanel.Controls.Add(this.guna2Panel6);
            this.CustomerCountPanel.Controls.Add(this.label9);
            this.CustomerCountPanel.Location = new System.Drawing.Point(35, 28);
            this.CustomerCountPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerCountPanel.Name = "CustomerCountPanel";
            this.CustomerCountPanel.Size = new System.Drawing.Size(197, 74);
            this.CustomerCountPanel.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Employee";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.White;
            this.guna2Panel6.Controls.Add(this.lblEmployeeCnt);
            this.guna2Panel6.Location = new System.Drawing.Point(21, 2);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(155, 47);
            this.guna2Panel6.TabIndex = 0;
            // 
            // AdminMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1280, 828);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.DateEndCalender);
            this.Controls.Add(this.DateStartCalender);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.RevenueChart);
            this.Controls.Add(this.LastYearBtn);
            this.Controls.Add(this.TodayBtn);
            this.Controls.Add(this.Last30Btn);
            this.Controls.Add(this.Last7Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.CustomerCountPanel.ResumeLayout(false);
            this.CustomerCountPanel.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart RevenueChart;
        private Guna.UI2.WinForms.Guna2Button LastYearBtn;
        private Guna.UI2.WinForms.Guna2Button TodayBtn;
        private Guna.UI2.WinForms.Guna2Button Last30Btn;
        private Guna.UI2.WinForms.Guna2Button Last7Btn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalOrders;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalRevenue;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStartCalender;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateEndCalender;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmployeeCnt;
        private System.Windows.Forms.Label lblLeaveCnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label UnpaidEmpCnt;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel CustomerCountPanel;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
    }
}