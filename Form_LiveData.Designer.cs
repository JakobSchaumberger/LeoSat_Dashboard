namespace LeoSat_Dashboard
{
    partial class Form_LiveData
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Temperature = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Temperature_Text = new System.Windows.Forms.Label();
            this.lb_Temperature = new System.Windows.Forms.Label();
            this.tlp_Altitude = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Altitude = new System.Windows.Forms.Label();
            this.lb_Altitude_Text = new System.Windows.Forms.Label();
            this.tlp_Humidity = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Humidity = new System.Windows.Forms.Label();
            this.lb_Humidity_Text = new System.Windows.Forms.Label();
            this.tbl_Acceleration = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Acceleration = new System.Windows.Forms.Label();
            this.lb_Acceleration_Text = new System.Windows.Forms.Label();
            this.tlp_Pressure = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Pressure = new System.Windows.Forms.Label();
            this.lb_Pressure_Text = new System.Windows.Forms.Label();
            this.tlp_Time = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_Time_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_Temperature.SuspendLayout();
            this.tlp_Altitude.SuspendLayout();
            this.tlp_Humidity.SuspendLayout();
            this.tbl_Acceleration.SuspendLayout();
            this.tlp_Pressure.SuspendLayout();
            this.tlp_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.tlp_Time, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlp_Pressure, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbl_Acceleration, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlp_Humidity, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlp_Altitude, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlp_Temperature, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 692);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tlp_Temperature
            // 
            this.tlp_Temperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.tlp_Temperature.ColumnCount = 1;
            this.tlp_Temperature.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Temperature.Controls.Add(this.lb_Temperature, 0, 1);
            this.tlp_Temperature.Controls.Add(this.lb_Temperature_Text, 0, 0);
            this.tlp_Temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Temperature.Location = new System.Drawing.Point(426, 40);
            this.tlp_Temperature.Margin = new System.Windows.Forms.Padding(20);
            this.tlp_Temperature.Name = "tlp_Temperature";
            this.tlp_Temperature.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tlp_Temperature.RowCount = 2;
            this.tlp_Temperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34752F));
            this.tlp_Temperature.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.65248F));
            this.tlp_Temperature.Size = new System.Drawing.Size(346, 286);
            this.tlp_Temperature.TabIndex = 6;
            // 
            // lb_Temperature_Text
            // 
            this.lb_Temperature_Text.AutoSize = true;
            this.lb_Temperature_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Temperature_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Temperature_Text.Location = new System.Drawing.Point(3, 10);
            this.lb_Temperature_Text.Name = "lb_Temperature_Text";
            this.lb_Temperature_Text.Size = new System.Drawing.Size(340, 31);
            this.lb_Temperature_Text.TabIndex = 0;
            this.lb_Temperature_Text.Text = "Temperature in °C";
            this.lb_Temperature_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Temperature
            // 
            this.lb_Temperature.AutoSize = true;
            this.lb_Temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Temperature.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lb_Temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Temperature.Location = new System.Drawing.Point(3, 41);
            this.lb_Temperature.Name = "lb_Temperature";
            this.lb_Temperature.Size = new System.Drawing.Size(340, 245);
            this.lb_Temperature.TabIndex = 1;
            this.lb_Temperature.Text = "-";
            this.lb_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Altitude
            // 
            this.tlp_Altitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.tlp_Altitude.ColumnCount = 1;
            this.tlp_Altitude.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Altitude.Controls.Add(this.lb_Altitude, 0, 1);
            this.tlp_Altitude.Controls.Add(this.lb_Altitude_Text, 0, 0);
            this.tlp_Altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Altitude.Location = new System.Drawing.Point(812, 40);
            this.tlp_Altitude.Margin = new System.Windows.Forms.Padding(20);
            this.tlp_Altitude.Name = "tlp_Altitude";
            this.tlp_Altitude.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tlp_Altitude.RowCount = 2;
            this.tlp_Altitude.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34752F));
            this.tlp_Altitude.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.65248F));
            this.tlp_Altitude.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Altitude.Size = new System.Drawing.Size(348, 286);
            this.tlp_Altitude.TabIndex = 7;
            // 
            // lb_Altitude
            // 
            this.lb_Altitude.AutoSize = true;
            this.lb_Altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Altitude.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lb_Altitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Altitude.Location = new System.Drawing.Point(3, 41);
            this.lb_Altitude.Name = "lb_Altitude";
            this.lb_Altitude.Size = new System.Drawing.Size(342, 245);
            this.lb_Altitude.TabIndex = 1;
            this.lb_Altitude.Text = "-";
            this.lb_Altitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Altitude_Text
            // 
            this.lb_Altitude_Text.AutoSize = true;
            this.lb_Altitude_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Altitude_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Altitude_Text.Location = new System.Drawing.Point(3, 10);
            this.lb_Altitude_Text.Name = "lb_Altitude_Text";
            this.lb_Altitude_Text.Size = new System.Drawing.Size(342, 31);
            this.lb_Altitude_Text.TabIndex = 0;
            this.lb_Altitude_Text.Text = "Altitude in m";
            this.lb_Altitude_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Humidity
            // 
            this.tlp_Humidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.tlp_Humidity.ColumnCount = 1;
            this.tlp_Humidity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Humidity.Controls.Add(this.lb_Humidity, 0, 1);
            this.tlp_Humidity.Controls.Add(this.lb_Humidity_Text, 0, 0);
            this.tlp_Humidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Humidity.Location = new System.Drawing.Point(812, 366);
            this.tlp_Humidity.Margin = new System.Windows.Forms.Padding(20);
            this.tlp_Humidity.Name = "tlp_Humidity";
            this.tlp_Humidity.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tlp_Humidity.RowCount = 2;
            this.tlp_Humidity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34752F));
            this.tlp_Humidity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.65248F));
            this.tlp_Humidity.Size = new System.Drawing.Size(348, 286);
            this.tlp_Humidity.TabIndex = 8;
            // 
            // lb_Humidity
            // 
            this.lb_Humidity.AutoSize = true;
            this.lb_Humidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Humidity.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lb_Humidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Humidity.Location = new System.Drawing.Point(3, 41);
            this.lb_Humidity.Name = "lb_Humidity";
            this.lb_Humidity.Size = new System.Drawing.Size(342, 245);
            this.lb_Humidity.TabIndex = 1;
            this.lb_Humidity.Text = "-";
            this.lb_Humidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Humidity_Text
            // 
            this.lb_Humidity_Text.AutoSize = true;
            this.lb_Humidity_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Humidity_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Humidity_Text.Location = new System.Drawing.Point(3, 10);
            this.lb_Humidity_Text.Name = "lb_Humidity_Text";
            this.lb_Humidity_Text.Size = new System.Drawing.Size(342, 31);
            this.lb_Humidity_Text.TabIndex = 0;
            this.lb_Humidity_Text.Text = "Humdidity in %";
            this.lb_Humidity_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_Acceleration
            // 
            this.tbl_Acceleration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.tbl_Acceleration.ColumnCount = 1;
            this.tbl_Acceleration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Acceleration.Controls.Add(this.lb_Acceleration, 0, 1);
            this.tbl_Acceleration.Controls.Add(this.lb_Acceleration_Text, 0, 0);
            this.tbl_Acceleration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Acceleration.Location = new System.Drawing.Point(426, 366);
            this.tbl_Acceleration.Margin = new System.Windows.Forms.Padding(20);
            this.tbl_Acceleration.Name = "tbl_Acceleration";
            this.tbl_Acceleration.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tbl_Acceleration.RowCount = 2;
            this.tbl_Acceleration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34752F));
            this.tbl_Acceleration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.65248F));
            this.tbl_Acceleration.Size = new System.Drawing.Size(346, 286);
            this.tbl_Acceleration.TabIndex = 9;
            // 
            // lb_Acceleration
            // 
            this.lb_Acceleration.AutoSize = true;
            this.lb_Acceleration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Acceleration.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lb_Acceleration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Acceleration.Location = new System.Drawing.Point(3, 41);
            this.lb_Acceleration.Name = "lb_Acceleration";
            this.lb_Acceleration.Size = new System.Drawing.Size(340, 245);
            this.lb_Acceleration.TabIndex = 1;
            this.lb_Acceleration.Text = "-";
            this.lb_Acceleration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Acceleration_Text
            // 
            this.lb_Acceleration_Text.AutoSize = true;
            this.lb_Acceleration_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Acceleration_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Acceleration_Text.Location = new System.Drawing.Point(3, 10);
            this.lb_Acceleration_Text.Name = "lb_Acceleration_Text";
            this.lb_Acceleration_Text.Size = new System.Drawing.Size(340, 31);
            this.lb_Acceleration_Text.TabIndex = 0;
            this.lb_Acceleration_Text.Text = "Acceleration in m/s^2";
            this.lb_Acceleration_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Pressure
            // 
            this.tlp_Pressure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.tlp_Pressure.ColumnCount = 1;
            this.tlp_Pressure.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Pressure.Controls.Add(this.lb_Pressure, 0, 1);
            this.tlp_Pressure.Controls.Add(this.lb_Pressure_Text, 0, 0);
            this.tlp_Pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Pressure.Location = new System.Drawing.Point(40, 366);
            this.tlp_Pressure.Margin = new System.Windows.Forms.Padding(20);
            this.tlp_Pressure.Name = "tlp_Pressure";
            this.tlp_Pressure.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tlp_Pressure.RowCount = 2;
            this.tlp_Pressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34752F));
            this.tlp_Pressure.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.65248F));
            this.tlp_Pressure.Size = new System.Drawing.Size(346, 286);
            this.tlp_Pressure.TabIndex = 10;
            // 
            // lb_Pressure
            // 
            this.lb_Pressure.AutoSize = true;
            this.lb_Pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Pressure.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lb_Pressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Pressure.Location = new System.Drawing.Point(3, 41);
            this.lb_Pressure.Name = "lb_Pressure";
            this.lb_Pressure.Size = new System.Drawing.Size(340, 245);
            this.lb_Pressure.TabIndex = 1;
            this.lb_Pressure.Text = "-";
            this.lb_Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Pressure_Text
            // 
            this.lb_Pressure_Text.AutoSize = true;
            this.lb_Pressure_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Pressure_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Pressure_Text.Location = new System.Drawing.Point(3, 10);
            this.lb_Pressure_Text.Name = "lb_Pressure_Text";
            this.lb_Pressure_Text.Size = new System.Drawing.Size(340, 31);
            this.lb_Pressure_Text.TabIndex = 0;
            this.lb_Pressure_Text.Text = "Pressure in mbar";
            this.lb_Pressure_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Time
            // 
            this.tlp_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.tlp_Time.ColumnCount = 1;
            this.tlp_Time.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Time.Controls.Add(this.lb_Time, 0, 1);
            this.tlp_Time.Controls.Add(this.lb_Time_Text, 0, 0);
            this.tlp_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Time.Location = new System.Drawing.Point(40, 40);
            this.tlp_Time.Margin = new System.Windows.Forms.Padding(20);
            this.tlp_Time.Name = "tlp_Time";
            this.tlp_Time.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tlp_Time.RowCount = 2;
            this.tlp_Time.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34752F));
            this.tlp_Time.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.65248F));
            this.tlp_Time.Size = new System.Drawing.Size(346, 286);
            this.tlp_Time.TabIndex = 11;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Time.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lb_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Time.Location = new System.Drawing.Point(3, 41);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(340, 245);
            this.lb_Time.TabIndex = 1;
            this.lb_Time.Text = "-";
            this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Time_Text
            // 
            this.lb_Time_Text.AutoSize = true;
            this.lb_Time_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Time_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.lb_Time_Text.Location = new System.Drawing.Point(3, 10);
            this.lb_Time_Text.Name = "lb_Time_Text";
            this.lb_Time_Text.Size = new System.Drawing.Size(340, 31);
            this.lb_Time_Text.TabIndex = 0;
            this.lb_Time_Text.Text = "Time since start";
            this.lb_Time_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_LiveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_LiveData";
            this.Text = "LiveData";
            this.Load += new System.EventHandler(this.Form_LiveData_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_Temperature.ResumeLayout(false);
            this.tlp_Temperature.PerformLayout();
            this.tlp_Altitude.ResumeLayout(false);
            this.tlp_Altitude.PerformLayout();
            this.tlp_Humidity.ResumeLayout(false);
            this.tlp_Humidity.PerformLayout();
            this.tbl_Acceleration.ResumeLayout(false);
            this.tbl_Acceleration.PerformLayout();
            this.tlp_Pressure.ResumeLayout(false);
            this.tlp_Pressure.PerformLayout();
            this.tlp_Time.ResumeLayout(false);
            this.tlp_Time.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlp_Time;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_Time_Text;
        private System.Windows.Forms.TableLayoutPanel tlp_Pressure;
        private System.Windows.Forms.Label lb_Pressure;
        private System.Windows.Forms.Label lb_Pressure_Text;
        private System.Windows.Forms.TableLayoutPanel tbl_Acceleration;
        private System.Windows.Forms.Label lb_Acceleration;
        private System.Windows.Forms.Label lb_Acceleration_Text;
        private System.Windows.Forms.TableLayoutPanel tlp_Humidity;
        private System.Windows.Forms.Label lb_Humidity;
        private System.Windows.Forms.Label lb_Humidity_Text;
        private System.Windows.Forms.TableLayoutPanel tlp_Altitude;
        private System.Windows.Forms.Label lb_Altitude;
        private System.Windows.Forms.Label lb_Altitude_Text;
        private System.Windows.Forms.TableLayoutPanel tlp_Temperature;
        private System.Windows.Forms.Label lb_Temperature;
        private System.Windows.Forms.Label lb_Temperature_Text;
    }
}