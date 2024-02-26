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

namespace LeoSat_Dashboard
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        private static System.Timers.Timer timer;

        private static int _screenHeight;
        private static int _screenWidth;
        private static int _toggleReceiveLED;

        private static Boolean _connected;
        private static string _receivedData = "";

        private readonly static Color[] _colors = {Color.FromArgb(255, 46, 51, 71), Color.FromArgb(255, 20, 30, 48) };

        private Button bt_Connect;
        private Button bt_Disconnect;
        private Button bt_LiveData;
        private Button bt_Statistik;

        static ComboBox cb_PortSelect;

        private PictureBox pb_IconMicrocontroller;
        private PictureBox pb_IconConnectionStatus;

        private Panel pn_Menue;

        static private Label lb_Connected;
        static private Label lb_Copyright;
        static private Label lb_Temperature;
        static private Label lb_Humidity;
        static private Label lb_Temperature2;
        static private Label lb_Humidity2;

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
        private void InitializeButton()
        {
            bt_Connect = new Button();
            bt_Connect.Location = new Point(
                 (int)(_screenWidth * 0.14),
                 (int)(_screenHeight * 0.07));
            bt_Connect.Click += new EventHandler(this.bt_Connect_Click);
            bt_Connect.BackgroundImage = Image.FromFile(@"C:\Users\Jakob\OneDrive\4AHEL\Fst\Anbindung_mit_Mikrocontroller\Images\" + "Icon_bt_connect" + ".png"); ;
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
            bt_Disconnect.BackgroundImage = Image.FromFile(@"C:\Users\Jakob\OneDrive\4AHEL\Fst\Anbindung_mit_Mikrocontroller\Images\" + "Icon_bt_disconnect" + ".png"); ;
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

            Controls.Add(bt_Connect);
            Controls.Add(bt_Disconnect);
            Controls.Add(bt_LiveData);
            Controls.Add(bt_Statistik);
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
                (int)(_screenWidth * 0.078),
                (int)(_screenHeight * 0.035));
            lb_Copyright.BackColor = _colors[1];
            lb_Copyright.Text = " " + (char)169 + " 2023";
            lb_Copyright.ForeColor = Color.White;
            lb_Copyright.Font = new Font("Abadi", 10);

            lb_Temperature = new Label();
            lb_Temperature.Location = new Point(
                (int)(_screenWidth * 0.25),
                (int)(_screenHeight * 0.05));
            lb_Temperature.Size = new Size(
                (int)(_screenWidth * 0.325),
                (int)(_screenHeight * 0.41));
            lb_Temperature.Text = "-";
            lb_Temperature.TextAlign = ContentAlignment.MiddleCenter;
            lb_Temperature.Font = new Font("Abadi", 70);
            lb_Temperature.BackColor = _colors[1];
            lb_Temperature.ForeColor = Color.White;

            lb_Humidity = new Label();
            lb_Humidity.Location = new Point(
                (int)(_screenWidth * 0.625),
                (int)(_screenHeight * 0.05));
            lb_Humidity.Size = new Size(
                (int)(_screenWidth * 0.325),
                (int)(_screenHeight * 0.41));
            lb_Humidity.Text = "-";
            lb_Humidity.TextAlign = ContentAlignment.MiddleCenter;
            lb_Humidity.Font = new Font("Abadi", 70);
            lb_Humidity.BackColor = _colors[1];
            lb_Humidity.ForeColor = Color.White;

            lb_Temperature2 = new Label();
            lb_Temperature2.Location = new Point(
                (int)(_screenWidth * 0.25),
                (int)(_screenHeight * 0.51));
            lb_Temperature2.Size = new Size(
                (int)(_screenWidth * 0.325),
                (int)(_screenHeight * 0.41));
            lb_Temperature2.Text = "-";
            lb_Temperature2.TextAlign = ContentAlignment.MiddleCenter;
            lb_Temperature2.Font = new Font("Abadi", 70);
            lb_Temperature2.BackColor = _colors[1];
            lb_Temperature2.ForeColor = Color.White;

            lb_Humidity2 = new Label();
            lb_Humidity2.Location = new Point(
                (int)(_screenWidth * 0.625),
                (int)(_screenHeight * 0.51));
            lb_Humidity2.Size = new Size(
                (int)(_screenWidth * 0.325),
                (int)(_screenHeight * 0.41));
            lb_Humidity2.Text = "-";
            lb_Humidity2.TextAlign = ContentAlignment.MiddleCenter;
            lb_Humidity2.Font = new Font("Abadi", 70);
            lb_Humidity2.BackColor = _colors[1];
            lb_Humidity2.ForeColor = Color.White;

            Controls.Add(lb_Connected);
            Controls.Add(lb_Copyright);
            Controls.Add(lb_Temperature);
            Controls.Add(lb_Humidity);
            Controls.Add(lb_Temperature2);
            Controls.Add(lb_Humidity2);
        }
        private void InitializePictureBox()
        {
            pb_IconMicrocontroller = new PictureBox();
            pb_IconMicrocontroller.Image = Image.FromFile(@"C:\Users\Jakob\OneDrive\4AHEL\Fst\Anbindung_mit_Mikrocontroller\Images\" + "Microcontroller" + ".png");
            pb_IconMicrocontroller.Location = new Point(
                (int)(_screenWidth * 0.0125),
                (int)(_screenHeight * 0.058));
            pb_IconMicrocontroller.Size = new Size(
                (int)(_screenWidth * 0.03),
                (int)(_screenWidth * 0.03));
            pb_IconMicrocontroller.SizeMode = PictureBoxSizeMode.Zoom;
            pb_IconMicrocontroller.BackColor = _colors[1];

            pb_IconConnectionStatus = new PictureBox();
            pb_IconConnectionStatus.Image = Image.FromFile(@"C:\Users\Jakob\OneDrive\4AHEL\Fst\Anbindung_mit_Mikrocontroller\Images\" + "Icon_disconnected" + ".png");
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

                pb_IconConnectionStatus.Image = Image.FromFile(@"C:\Users\Jakob\OneDrive\4AHEL\Fst\Anbindung_mit_Mikrocontroller\Images\" + "Icon_connected" + ".png");
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
                pb_IconConnectionStatus.Image = Image.FromFile(@"C:\Users\Jakob\OneDrive\4AHEL\Fst\Anbindung_mit_Mikrocontroller\Images\" + "Icon_disconnected" + ".png");

                lb_Temperature.Text = "-" + "°C";
                lb_Temperature2.Text = "-" + "°C";
                lb_Humidity.Text = "-" + "°C";
                lb_Humidity2.Text = "-" + "°C";

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
            lb_Temperature2.Visible = true;
            lb_Humidity.Visible = true;
            lb_Humidity2.Visible = true;

            chart_temperautre_statistik.Visible = false;
        }
        private void bt_Statistik_Click(object sender, EventArgs e)
        {
            lb_Temperature.Visible = false;
            lb_Temperature2.Visible = false;
            lb_Humidity.Visible = false;
            lb_Humidity2.Visible = false;

            chart_temperautre_statistik.Visible = true;
        }
        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                _receivedData = _serialPort.ReadLine();
                //System.Threading.Thread.Sleep(500);

                _toggleReceiveLED = _toggleReceiveLED ^ 0x01;

                _serialPort.Write(new byte[] { 6, (byte)_toggleReceiveLED }, 0, 2);
            }          
            catch(System.IO.IOException)
            {

            }
            catch (System.InvalidOperationException)
            {

            }
        }

        private void DisplayData()
        {
            _receivedData = _receivedData.Replace(" ", "");
            _receivedData = _receivedData.Replace("\n", "");
            _receivedData = _receivedData.Replace("\r", "");
            _receivedData = _receivedData.Replace("@", "");
            _receivedData = _receivedData.Replace("#", "");

            lb_Temperature.Text = _receivedData + "°C";
            lb_Temperature2.Text = _receivedData + "°C";
            lb_Humidity.Text = _receivedData + "°C";
            lb_Humidity2.Text = _receivedData + "°C";

            chart_temperautre_statistik.Series[0].Points.AddXY(DateTime.Now.ToString("h:mm:ss tt"), _receivedData);

            Console.WriteLine(_receivedData);            
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
