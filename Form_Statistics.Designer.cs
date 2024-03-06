namespace LeoSat_Dashboard
{
    partial class Form_Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Temperature = new System.Windows.Forms.TableLayoutPanel();
            this.Chart_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_Temperature_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Chart_Altitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_Altitude_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Chart_Pressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_Pressure_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Chart_Acceleration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_Acceleration_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Chart_Humidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_Humidity_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbl_Temperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Temperature)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Altitude)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Pressure)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Acceleration)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Humidity)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbl_Temperature, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 652);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbl_Temperature
            // 
            this.tbl_Temperature.ColumnCount = 1;
            this.tbl_Temperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Temperature.Controls.Add(this.Chart_Temperature, 0, 1);
            this.tbl_Temperature.Controls.Add(this.lb_Temperature_Text, 0, 0);
            this.tbl_Temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Temperature.Location = new System.Drawing.Point(3, 3);
            this.tbl_Temperature.Name = "tbl_Temperature";
            this.tbl_Temperature.RowCount = 2;
            this.tbl_Temperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Temperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tbl_Temperature.Size = new System.Drawing.Size(358, 320);
            this.tbl_Temperature.TabIndex = 0;
            // 
            // Chart_Temperature
            // 
            this.Chart_Temperature.BackColor = System.Drawing.Color.Transparent;
            this.Chart_Temperature.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Chart_Temperature.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Chart_Temperature.BorderlineColor = System.Drawing.Color.Transparent;
            this.Chart_Temperature.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.Chart_Temperature.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea6.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX2.MinorGrid.Enabled = true;
            chartArea6.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BorderColor = System.Drawing.Color.White;
            chartArea6.Name = "ChartArea1";
            this.Chart_Temperature.ChartAreas.Add(chartArea6);
            this.Chart_Temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_Temperature.Location = new System.Drawing.Point(3, 56);
            this.Chart_Temperature.Name = "Chart_Temperature";
            this.Chart_Temperature.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.Chart_Temperature.Series.Add(series6);
            this.Chart_Temperature.Size = new System.Drawing.Size(352, 261);
            this.Chart_Temperature.TabIndex = 0;
            this.Chart_Temperature.Text = "chart1";
            // 
            // lb_Temperature_Text
            // 
            this.lb_Temperature_Text.AutoSize = true;
            this.lb_Temperature_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Temperature_Text.ForeColor = System.Drawing.Color.White;
            this.lb_Temperature_Text.Location = new System.Drawing.Point(3, 0);
            this.lb_Temperature_Text.Name = "lb_Temperature_Text";
            this.lb_Temperature_Text.Size = new System.Drawing.Size(352, 53);
            this.lb_Temperature_Text.TabIndex = 1;
            this.lb_Temperature_Text.Text = "Temperature in °C";
            this.lb_Temperature_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Chart_Altitude, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_Altitude_Text, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(367, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 320);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Chart_Altitude
            // 
            this.Chart_Altitude.BackColor = System.Drawing.Color.Transparent;
            this.Chart_Altitude.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Chart_Altitude.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Chart_Altitude.BorderlineColor = System.Drawing.Color.Transparent;
            this.Chart_Altitude.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.Chart_Altitude.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.MinorGrid.Enabled = true;
            chartArea7.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.BorderColor = System.Drawing.Color.White;
            chartArea7.Name = "ChartArea1";
            this.Chart_Altitude.ChartAreas.Add(chartArea7);
            this.Chart_Altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_Altitude.Location = new System.Drawing.Point(3, 56);
            this.Chart_Altitude.Name = "Chart_Altitude";
            this.Chart_Altitude.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "Series1";
            this.Chart_Altitude.Series.Add(series7);
            this.Chart_Altitude.Size = new System.Drawing.Size(352, 261);
            this.Chart_Altitude.TabIndex = 0;
            this.Chart_Altitude.Text = "chart1";
            // 
            // lb_Altitude_Text
            // 
            this.lb_Altitude_Text.AutoSize = true;
            this.lb_Altitude_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Altitude_Text.ForeColor = System.Drawing.Color.White;
            this.lb_Altitude_Text.Location = new System.Drawing.Point(3, 0);
            this.lb_Altitude_Text.Name = "lb_Altitude_Text";
            this.lb_Altitude_Text.Size = new System.Drawing.Size(352, 53);
            this.lb_Altitude_Text.TabIndex = 1;
            this.lb_Altitude_Text.Text = "Altitude in m";
            this.lb_Altitude_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Chart_Pressure, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lb_Pressure_Text, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(731, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(426, 320);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // Chart_Pressure
            // 
            this.Chart_Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Chart_Pressure.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Chart_Pressure.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Chart_Pressure.BorderlineColor = System.Drawing.Color.Transparent;
            this.Chart_Pressure.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.Chart_Pressure.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MinorGrid.Enabled = true;
            chartArea8.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.BorderColor = System.Drawing.Color.White;
            chartArea8.Name = "ChartArea1";
            this.Chart_Pressure.ChartAreas.Add(chartArea8);
            this.Chart_Pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_Pressure.Location = new System.Drawing.Point(3, 56);
            this.Chart_Pressure.Name = "Chart_Pressure";
            this.Chart_Pressure.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Series1";
            this.Chart_Pressure.Series.Add(series8);
            this.Chart_Pressure.Size = new System.Drawing.Size(420, 261);
            this.Chart_Pressure.TabIndex = 0;
            this.Chart_Pressure.Text = "chart1";
            // 
            // lb_Pressure_Text
            // 
            this.lb_Pressure_Text.AutoSize = true;
            this.lb_Pressure_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Pressure_Text.ForeColor = System.Drawing.Color.White;
            this.lb_Pressure_Text.Location = new System.Drawing.Point(3, 0);
            this.lb_Pressure_Text.Name = "lb_Pressure_Text";
            this.lb_Pressure_Text.Size = new System.Drawing.Size(420, 53);
            this.lb_Pressure_Text.TabIndex = 1;
            this.lb_Pressure_Text.Text = "Pressure in mbar";
            this.lb_Pressure_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Chart_Acceleration, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lb_Acceleration_Text, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 329);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(358, 320);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // Chart_Acceleration
            // 
            this.Chart_Acceleration.BackColor = System.Drawing.Color.Transparent;
            this.Chart_Acceleration.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Chart_Acceleration.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Chart_Acceleration.BorderlineColor = System.Drawing.Color.Transparent;
            this.Chart_Acceleration.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.Chart_Acceleration.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisX.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea9.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.MinorGrid.Enabled = true;
            chartArea9.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.BorderColor = System.Drawing.Color.White;
            chartArea9.Name = "ChartArea1";
            this.Chart_Acceleration.ChartAreas.Add(chartArea9);
            this.Chart_Acceleration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_Acceleration.Location = new System.Drawing.Point(3, 56);
            this.Chart_Acceleration.Name = "Chart_Acceleration";
            this.Chart_Acceleration.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Name = "Series1";
            this.Chart_Acceleration.Series.Add(series9);
            this.Chart_Acceleration.Size = new System.Drawing.Size(352, 261);
            this.Chart_Acceleration.TabIndex = 0;
            this.Chart_Acceleration.Text = "chart1";
            // 
            // lb_Acceleration_Text
            // 
            this.lb_Acceleration_Text.AutoSize = true;
            this.lb_Acceleration_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Acceleration_Text.ForeColor = System.Drawing.Color.White;
            this.lb_Acceleration_Text.Location = new System.Drawing.Point(3, 0);
            this.lb_Acceleration_Text.Name = "lb_Acceleration_Text";
            this.lb_Acceleration_Text.Size = new System.Drawing.Size(352, 53);
            this.lb_Acceleration_Text.TabIndex = 1;
            this.lb_Acceleration_Text.Text = "Acceleration in m/s^2";
            this.lb_Acceleration_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Chart_Humidity, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lb_Humidity_Text, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(367, 329);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(358, 320);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // Chart_Humidity
            // 
            this.Chart_Humidity.BackColor = System.Drawing.Color.Transparent;
            this.Chart_Humidity.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.Chart_Humidity.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Chart_Humidity.BorderlineColor = System.Drawing.Color.Transparent;
            this.Chart_Humidity.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.Chart_Humidity.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea10.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisX.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea10.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX2.MinorGrid.Enabled = true;
            chartArea10.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea10.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisY.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.BorderColor = System.Drawing.Color.White;
            chartArea10.Name = "ChartArea1";
            this.Chart_Humidity.ChartAreas.Add(chartArea10);
            this.Chart_Humidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_Humidity.Location = new System.Drawing.Point(3, 56);
            this.Chart_Humidity.Name = "Chart_Humidity";
            this.Chart_Humidity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Name = "Series1";
            this.Chart_Humidity.Series.Add(series10);
            this.Chart_Humidity.Size = new System.Drawing.Size(352, 261);
            this.Chart_Humidity.TabIndex = 0;
            this.Chart_Humidity.Text = "chart1";
            // 
            // lb_Humidity_Text
            // 
            this.lb_Humidity_Text.AutoSize = true;
            this.lb_Humidity_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Humidity_Text.ForeColor = System.Drawing.Color.White;
            this.lb_Humidity_Text.Location = new System.Drawing.Point(3, 0);
            this.lb_Humidity_Text.Name = "lb_Humidity_Text";
            this.lb_Humidity_Text.Size = new System.Drawing.Size(352, 53);
            this.lb_Humidity_Text.TabIndex = 1;
            this.lb_Humidity_Text.Text = "Humidity in %";
            this.lb_Humidity_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Statistics";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Form_Statistics";
            this.Load += new System.EventHandler(this.Form_Statistics_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbl_Temperature.ResumeLayout(false);
            this.tbl_Temperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Temperature)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Altitude)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Pressure)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Acceleration)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Humidity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbl_Temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Temperature;
        private System.Windows.Forms.Label lb_Temperature_Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Humidity;
        private System.Windows.Forms.Label lb_Humidity_Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Acceleration;
        private System.Windows.Forms.Label lb_Acceleration_Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Pressure;
        private System.Windows.Forms.Label lb_Pressure_Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Altitude;
        private System.Windows.Forms.Label lb_Altitude_Text;
    }
}