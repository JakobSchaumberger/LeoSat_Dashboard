using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using GMap.NET.MapProviders;
using GMap.NET;

namespace LeoSat_Dashboard
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        private static System.Timers.Timer timer;

        private static string ImagePath = "..\\..\\Images\\";

        private static int _screenHeight;
        private static int _screenWidth;

        private static Boolean _connected;
        private static string _receivedData = "";

        private readonly static Color[] _colors = {Color.FromArgb(255, 46, 51, 71), Color.FromArgb(255, 20, 30, 48) };

        private Button bt_Connect;
        private Button bt_Disconnect;
        private Button bt_LiveData;
        private Button bt_Statistik;
        private Button bt_liveView;
        private Button bt_GPS;

        static ComboBox cb_PortSelect;

        private PictureBox pb_IconMicrocontroller;
        private PictureBox pb_IconConnectionStatus;

        private Panel pn_Menue;

        static private Label lb_Connected;
        static private Label lb_Copyright;

        static private Label lb_Temperature;
        static private Label lb_Humidity;
        static private Label lb_Pressure;
        static private Label lb_time;
        static private Label lb_Altitude;
        static private Label lb_Acceleration;

        private String[] data;
        private String timeOfFLight = "0";
        private String Temp = "0";
        private String Press = "0";
        private String Latitude = "0";
        private String Longitude = "0";
        private String xAcc = "0";
        private String yAcc = "0";
        private String zAcc = "0";
        private String Hum = "0";
        private String Altitude = "0";
        private String totalAcc = "0";
        double nLat;
        double nLong;


        //static private System.Windows.Forms.DataVisualization.Charting.Chart chart_temperautre_statistik;

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            InitializeButton();        
            InitializeCombobox();            
            InitializePictureBox();           
            InitializeLabel();
            InitializePanel();
            InitializeSerialPort();
            InitializeChart();
            InitializeMap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                cb_PortSelect.Items.Add(s);
            }
        }

        // -----------------------------------------------------------------------------------------------------------
        // Initialize Form-Elements
        // -----------------------------------------------------------------------------------------------------------
        private void InitializeForm()
        {
            _screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            _screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            Size = new Size(_screenWidth, _screenHeight);
            Paint += new PaintEventHandler(PaintForm);       
        }
        private void PaintForm(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush linGrBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
            new Point(0, 0),
            new Point(1920, 1080),
            _colors[0],        // (0,  4,  40)
            _colors[1]);       // (0, 78, 146)

            Pen pen = new Pen(linGrBrush, 50000);

            e.Graphics.DrawLine(pen, 0, 0, 1920, 1080);
        }
        private void InitializeSerialPort()
        {
            _serialPort = new SerialPort();
            _serialPort.DataReceived += SerialPort_DataReceived;

            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("{0}", s);
            }
        }
        private void InitializeMap()
        {
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            //get tiles from server only
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            //not use proxy
            GMapProvider.WebProxy = null;
            //center map on moscow
            gMapControl1.Position = new PointLatLng(48.2793, 14.2528);

            //zoom min/max; default both = 2
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            //set zoom
            gMapControl1.Zoom = 10;

            gMapControl1.Visible = false;
        }
        private void InitializeButton()
        {
            bt_Connect = new Button();
            bt_Connect.Location = new Point(
                 (int)(_screenWidth * 0.14),
                 (int)(_screenHeight * 0.07));
            bt_Connect.Click += new EventHandler(this.bt_Connect_Click);
            bt_Connect.BackgroundImage = Image.FromFile(@ImagePath + "Icon_bt_connect" + ".png");
            bt_Connect.Size = new Size(
                (int)(_screenWidth * 0.02), 
                (int)(_screenWidth * 0.02));
            bt_Connect.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Connect.BackColor = Color.Transparent;            

            bt_Disconnect = new Button();            
            bt_Disconnect.Location = new Point(
                (int)(_screenWidth * 0.17),
                (int)(_screenHeight * 0.07));                     
            bt_Disconnect.Click += new EventHandler(this.bt_Disconnect_Click);

            bt_Disconnect.Size = new Size(
                (int)(_screenWidth * 0.02),
                (int)(_screenWidth * 0.02));
            bt_Disconnect.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Disconnect.BackColor = Color.Transparent;

            bt_LiveData = new Button();
            bt_LiveData.Location = new Point(
                0,
                (int)(_screenHeight * 0.2));
            bt_LiveData.Click += new EventHandler(this.bt_LiveData_Click);
            bt_LiveData.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.1));
            bt_LiveData.FlatStyle = FlatStyle.Flat;
            bt_LiveData.FlatAppearance.BorderSize = 0;
            bt_LiveData.BackColor = Color.FromArgb(255, 20, 30, 48);
            bt_LiveData.Text = "Live Data";
            bt_LiveData.ForeColor = Color.White;
            bt_LiveData.Font = new Font("Agency", 18);

            bt_Statistik = new Button();
            bt_Statistik.Location = new Point(
                0,
                (int)(_screenHeight * 0.3));
            bt_Statistik.Click += new EventHandler(this.bt_Statistik_Click);
            bt_Statistik.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.1));
            bt_Statistik.FlatStyle = FlatStyle.Flat;
            bt_Statistik.FlatAppearance.BorderSize = 0;
            bt_Statistik.BackColor = Color.FromArgb(255, 20, 30, 48);
            bt_Statistik.Text = "Statistik";
            bt_Statistik.ForeColor = Color.White;
            bt_Statistik.Font = new Font("Abadi", 18);

            bt_GPS = new Button();
            bt_GPS.Location = new Point(
                0,
                (int)(_screenHeight * 0.4));
            bt_GPS.Click += new EventHandler(this.bt_GPS_Click);
            bt_GPS.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.1));
            bt_GPS.FlatStyle = FlatStyle.Flat;
            bt_GPS.FlatAppearance.BorderSize = 0;
            bt_GPS.BackColor = Color.FromArgb(255, 20, 30, 48);
            bt_GPS.Text = "GPS";
            bt_GPS.ForeColor = Color.White;
            bt_GPS.Font = new Font("Abadi", 18);

            bt_liveView = new Button();
            bt_liveView.Location = new Point(
                0,
                (int)(_screenHeight * 0.5));
            bt_liveView.Click += new EventHandler(this.bt_liveView_Click);
            bt_liveView.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.1));
            bt_liveView.FlatStyle = FlatStyle.Flat;
            bt_liveView.FlatAppearance.BorderSize = 0;
            bt_liveView.BackColor = Color.FromArgb(255, 20, 30, 48);
            bt_liveView.Text = "Live View";
            bt_liveView.ForeColor = Color.White;
            bt_liveView.Font = new Font("Abadi", 18);

            Controls.Add(bt_Connect);
            Controls.Add(bt_Disconnect);
            Controls.Add(bt_LiveData);
            Controls.Add(bt_Statistik);
            Controls.Add(bt_liveView);
            Controls.Add(bt_GPS);
        }
        private void InitializeCombobox()
        {
            cb_PortSelect = new ComboBox();

            cb_PortSelect.Location = new Point(
                (int)(_screenWidth * 0.05),
                (int)(_screenHeight * 0.07));
            cb_PortSelect.Size = new Size(
                (int)(_screenWidth * 0.08),
                0);
            cb_PortSelect.ForeColor = Color.White;
            cb_PortSelect.BackColor = Color.FromArgb(255, 20, 30, 48);
            cb_PortSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;

            Controls.Add(cb_PortSelect);
        }
        private void InitializeLabel()
        {
            lb_Connected = new Label();
            lb_Connected.TextAlign = ContentAlignment.MiddleRight;
            lb_Connected.Location = new Point(
                (int)(_screenWidth * 0.892),
                (int)(_screenHeight * 0.015));
            lb_Connected.Size = new Size(
                (int)(_screenWidth * 0.06),
                (int)(_screenHeight * 0.02));
            lb_Connected.Text = "Disconnected";
            lb_Connected.BackColor = Color.Transparent;
            lb_Connected.ForeColor = Color.White;

            lb_Copyright = new Label();
            lb_Copyright.Location = new Point(
                0,
                (int)(_screenHeight * 0.94));
            lb_Copyright.Size = new Size(
                (int)(_screenWidth * 0.1),
                (int)(_screenHeight * 0.035));
            lb_Copyright.BackColor = _colors[1];
            lb_Copyright.Text = " " + (char)169 + " LeoSat, 2024";
            lb_Copyright.ForeColor = Color.White;
            lb_Copyright.Font = new Font("Abadi", 10);

            lb_time = new Label();
            lb_time.Location = new Point(
                (int)(_screenWidth * 0.25),
                (int)(_screenHeight * 0.05));
            lb_time.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.41));
            lb_time.Text = "-";
            lb_time.TextAlign = ContentAlignment.MiddleCenter;
            lb_time.Font = new Font("Abadi", 40);
            lb_time.BackColor = _colors[1];
            lb_time.ForeColor = Color.White;

            lb_Humidity = new Label();
            lb_Humidity.Location = new Point(
                (int)(_screenWidth * 0.5),
                (int)(_screenHeight * 0.05));
            lb_Humidity.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.41));
            lb_Humidity.Text = "-";
            lb_Humidity.TextAlign = ContentAlignment.MiddleCenter;
            lb_Humidity.Font = new Font("Abadi", 40);
            lb_Humidity.BackColor = _colors[1];
            lb_Humidity.ForeColor = Color.White;

            lb_Pressure = new Label();
            lb_Pressure.Location = new Point(
                (int)(_screenWidth * 0.75),
                (int)(_screenHeight * 0.05));
            lb_Pressure.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.41));
            lb_Pressure.Text = "-";
            lb_Pressure.TextAlign = ContentAlignment.MiddleCenter;
            lb_Pressure.Font = new Font("Abadi", 40);
            lb_Pressure.BackColor = _colors[1];
            lb_Pressure.ForeColor = Color.White;

            lb_Temperature = new Label();
            lb_Temperature.Location = new Point(
                (int)(_screenWidth * 0.25),
                (int)(_screenHeight * 0.51));
            lb_Temperature.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.41));
            lb_Temperature.Text = "-";
            lb_Temperature.TextAlign = ContentAlignment.MiddleCenter;
            lb_Temperature.Font = new Font("Abadi", 40);
            lb_Temperature.BackColor = _colors[1];
            lb_Temperature.ForeColor = Color.White;


            lb_Altitude = new Label();
            lb_Altitude.Location = new Point(
                (int)(_screenWidth * 0.5),
                (int)(_screenHeight * 0.51));
            lb_Altitude.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.41));
            lb_Altitude.Text = "-";
            lb_Altitude.TextAlign = ContentAlignment.MiddleCenter;
            lb_Altitude.Font = new Font("Abadi", 40);
            lb_Altitude.BackColor = _colors[1];
            lb_Altitude.ForeColor = Color.White;


            lb_Acceleration = new Label();
            lb_Acceleration.Location = new Point(
                (int)(_screenWidth * 0.75),
                (int)(_screenHeight * 0.51));
            lb_Acceleration.Size = new Size(
                (int)(_screenWidth * 0.2),
                (int)(_screenHeight * 0.41));
            lb_Acceleration.Text = "-";
            lb_Acceleration.TextAlign = ContentAlignment.MiddleCenter;
            lb_Acceleration.Font = new Font("Abadi", 40);
            lb_Acceleration.BackColor = _colors[1];
            lb_Acceleration.ForeColor = Color.White;

            Controls.Add(lb_Connected);
            Controls.Add(lb_Copyright);
            Controls.Add(lb_Temperature);
            Controls.Add(lb_Humidity);
            Controls.Add(lb_Pressure);
            Controls.Add(lb_time);
            Controls.Add(lb_Altitude);
            Controls.Add(lb_Acceleration);
        }
        private void InitializePictureBox()
        {
            pb_IconMicrocontroller = new PictureBox();
            pb_IconMicrocontroller.Image = Image.FromFile(@ImagePath + "Microcontroller" + ".png");
            pb_IconMicrocontroller.Location = new Point(
                (int)(_screenWidth * 0.0125),
                (int)(_screenHeight * 0.058));
            pb_IconMicrocontroller.Size = new Size(
                (int)(_screenWidth * 0.03),
                (int)(_screenWidth * 0.03));
            pb_IconMicrocontroller.SizeMode = PictureBoxSizeMode.Zoom;
            pb_IconMicrocontroller.BackColor = _colors[1];

            pb_IconConnectionStatus = new PictureBox();
            pb_IconConnectionStatus.Image = Image.FromFile(@ImagePath + "Icon_disconnected" + ".png");
            pb_IconConnectionStatus.Location = new Point(
                (int)(_screenWidth * 0.88),
                (int)(_screenHeight * 0.015));
            pb_IconConnectionStatus.Size = new Size(15, 15);
            pb_IconConnectionStatus.SizeMode = PictureBoxSizeMode.Zoom;
            pb_IconConnectionStatus.BackColor = Color.Transparent;

            Controls.Add(pb_IconMicrocontroller);
            Controls.Add(pb_IconConnectionStatus);
        }
        private void InitializePanel()
        {
            pn_Menue = new Panel();
            pn_Menue.BackColor = Color.FromArgb(255, 20, 30, 48);
            pn_Menue.Location = new Point(0, 0);
            pn_Menue.Size = new Size(
                (int)(_screenWidth * 0.2),
                _screenHeight);

            Controls.Add(pn_Menue);
        }
        private void InitializeChart()
        {
            chart_temperautre_statistik.Location = new Point(
                (int)(_screenWidth * 0.3),
                (int)(_screenHeight * 0.1));
            chart_temperautre_statistik.Size = new Size(
                (int)(_screenWidth * 0.6),
                (int)(_screenHeight * 0.75));

            chart_temperautre_statistik.Visible = false;

            chart_temperautre_statistik.Series.Clear();
            chart_temperautre_statistik.Titles.Add("Temperature statistik");

            chart_temperautre_statistik.Series.Add("Temperature");
            chart_temperautre_statistik.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
        // ----------------------------------------------------------------------------------------------------------
        // Event handling
        // ----------------------------------------------------------------------------------------------------------
        private void bt_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.PortName = cb_PortSelect.Text;
                _serialPort.BaudRate = 9600;
                _serialPort.DtrEnable = true;

                _serialPort.Open();               
                Console.WriteLine("Connected to Port {0}", _serialPort.PortName);

                pb_IconConnectionStatus.Image = Image.FromFile(@ImagePath + "Icon_connected" + ".png");
                lb_Connected.Text = "Connected";

                System.Threading.Thread.Sleep(1000);
                _serialPort.Write(new byte[] { 7, (byte)0x01 }, 0, 2);

                _connected = true;
                bt_Connect.Enabled = false;
                
            }
            catch
            {
                Console.WriteLine("Port not available");
            }
        }
        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Write(new byte[] { 7, (byte)0x00 }, 0, 2);
                _serialPort.Write(new byte[] { 6, (byte)0x00 }, 0, 2);

                _serialPort.Close();
                _connected = false;
                bt_Connect.Enabled = true;

                lb_Connected.Text = "Disconnected";
                pb_IconConnectionStatus.Image = Image.FromFile(@ImagePath + "Icon_disconnected" + ".png");

                lb_Temperature.Text = "-" + "°C";
                lb_Pressure.Text = "-" + "°C";
                lb_Humidity.Text = "-" + "°C";
                lb_time.Text = "-" + "°C";

                chart_temperautre_statistik.Series[0].Points.Clear();
            }
            catch (System.InvalidOperationException)
            {

            }
            catch (System.NullReferenceException)
            {

            }
        }
        private void bt_LiveData_Click(object sender, EventArgs e)
        {
            lb_Temperature.Visible = true;
            lb_Pressure.Visible = true;
            lb_Humidity.Visible = true;
            lb_time.Visible = true;
            lb_Acceleration.Visible = true;
            lb_Altitude.Visible = true;
            gMapControl1.Visible = false;

            chart_temperautre_statistik.Visible = false;
        }
        private void bt_Statistik_Click(object sender, EventArgs e)
        {
            lb_Temperature.Visible = false;
            lb_Pressure.Visible = false;
            lb_Humidity.Visible = false;
            lb_time.Visible = false;
            lb_Altitude.Visible = false;
            lb_Acceleration.Visible = false;
            gMapControl1.Visible = false;

            chart_temperautre_statistik.Visible = true;
        }
        private void bt_liveView_Click(object sender, EventArgs e)
        {
            lb_Temperature.Visible = false;
            lb_Pressure.Visible = false;
            lb_Humidity.Visible = false;
            lb_time.Visible = false;
            lb_Altitude.Visible = false;
            lb_Acceleration.Visible = false;
            gMapControl1.Visible = false;

            chart_temperautre_statistik.Visible = false;
        }
        private void bt_GPS_Click(object sender, EventArgs e)
        {
            lb_Temperature.Visible = false;
            lb_Pressure.Visible = false;
            lb_Humidity.Visible = false;
            lb_time.Visible = false;
            lb_Altitude.Visible = false;
            lb_Acceleration.Visible = false;
            gMapControl1.Visible = true;

            chart_temperautre_statistik.Visible = false;
        }
        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           _receivedData = _serialPort.ReadLine();
        }

        private void DisplayData()
        {
            float nxAcc;
            float nyAcc;
            float nzAcc;

            data = _receivedData.Split(',');
            try
            {
                timeOfFLight = data[0];
                Temp = data[2];
                Hum = data[3];
                Press = data[4];
                xAcc = data[9];
                //nxAcc = float.Parse(xAcc);
                yAcc = data[10];
                //nyAcc = float.Parse(yAcc);
                zAcc = data[11];
                //nzAcc = float.Parse(zAcc);

                //double sqrtTotalAcc = Math.Sqrt(nxAcc * nyAcc * nzAcc);
                //totalAcc = sqrtTotalAcc.ToString();

                Altitude = data[12];
                Latitude = data[13];
                Longitude = data[14];

                lb_Temperature.Text = Temp + "°C";
                lb_Pressure.Text = Press + "mbar";
                lb_Humidity.Text = Hum;
                lb_Altitude.Text = Altitude + "m";
                lb_Acceleration.Text = 0 + "m/s^2";
                lb_time.Text = timeOfFLight;

                chart_temperautre_statistik.Series[0].Points.AddXY(DateTime.Now.ToString("h:mm:ss tt"), Temp);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                nLat = Convert.ToDouble(Latitude, new System.Globalization.CultureInfo("en-US"));
                nLong = Convert.ToDouble(Longitude, new System.Globalization.CultureInfo("en-US"));

                gMapControl1.Position = new PointLatLng(nLat, nLong);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_connected && _receivedData != "") DisplayData();
          
        }

        private void chart_temperautre_statistik_Click(object sender, EventArgs e)
        {

        }
    }
}
