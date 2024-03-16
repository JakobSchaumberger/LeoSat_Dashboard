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
using Anbindung_mit_Mikrocontroller;

namespace LeoSat_Dashboard
{
    public partial class LeoSat_Dashboard : Form, IObserver<Dashboard>
    {
        private Model model;
        private IDisposable unsubscriber;
        private Dashboard Data;

        static SerialPort _serialPort;

        private static Boolean _connected;
        private static string _receivedData = "";

        private readonly static Color[] _colors = {Color.FromArgb(255, 46, 51, 71), Color.FromArgb(255, 20, 30, 48) };


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

        public static double nLat;
        public static double nLong;

        Form_LiveData F_LiveData;
        Form_GPS F_GPS;
        Form_Statistics F_Statistics;


        public LeoSat_Dashboard()
        {
            model = new Model();
            model.Subscribe(this);
            InitializeComponent();       
            InitializeSerialPort();

            F_Statistics = new Form_Statistics(model);
            F_Statistics.FormClosed += FGPS_FormClosed;
            F_Statistics.MdiParent = this;
            F_Statistics.Dock = DockStyle.Fill;

            F_LiveData = new Form_LiveData(model);
            F_LiveData.FormClosed += Dashboard_FormClosed;
            F_LiveData.MdiParent = this;
            F_LiveData.Dock = DockStyle.Fill;
            F_LiveData.Show();
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
            int _screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int _screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

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

        // ----------------------------------------------------------------------------------------------------------
        // Event handling
        // ----------------------------------------------------------------------------------------------------------
        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Close();
                _connected = false;
                bt_Connect.Enabled = true;

                /*lb_Connected.Text = "Disconnected";
                pb_IconConnectionStatus.Image = Image.FromFile(@ImagePath + "Icon_disconnected" + ".png");

                lb_Temperature.Text = "-" + "°C";
                lb_Pressure.Text = "-" + "°C";
                lb_Humidity.Text = "-" + "°C";
                lb_time.Text = "-" + "°C";*/

                //chart_temperautre_statistik.Series[0].Points.Clear();
            }
            catch (System.InvalidOperationException)
            {

            }
            catch (System.NullReferenceException)
            {

            }
        }
        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           _receivedData = _serialPort.ReadLine();
            model.DataReceived(_receivedData);
        }

        public void OnNext(Dashboard data)
        {
            // 0
        }

        bool menuExpand = false;
        private void menuTransistion_Tick(object sender, EventArgs e)
        {
            if(menuExpand)
            {
                menuContainer.Width -= 10;
                if (menuContainer.Width <= 60)
                {
                    menuExpand = false;
                    menuTransistion.Stop();
                }
            }
            else
            {
                menuContainer.Width += 10;
                if (menuContainer.Width >= 250)
                {
                    menuExpand = true;
                    menuTransistion.Stop();
                }
            }
        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            menuTransistion.Start();
            Console.WriteLine("test");
        }

        private void bt_LiveData_Click(object sender, EventArgs e)
        {
            if (F_LiveData == null)
            {
                F_LiveData = new Form_LiveData(model);
                F_LiveData.FormClosed += Dashboard_FormClosed;
                F_LiveData.MdiParent = this;
                F_LiveData.Dock = DockStyle.Fill;
                F_LiveData.Show();
            }
            else
            {
                F_LiveData.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            F_LiveData = null;
        }

        private void bt_GPS_Click(object sender, EventArgs e)
        {
            if (F_GPS == null)
            {
                F_GPS = new Form_GPS(model);
                F_GPS.FormClosed += FGPS_FormClosed;
                F_GPS.MdiParent = this;
                F_GPS.Dock = DockStyle.Fill;
                F_GPS.Show();
            }
            else
            {
                F_GPS.Activate();
            }
        }
        private void FGPS_FormClosed(object sender, FormClosedEventArgs e)
        {
            F_GPS = null;
        }

        private void bt_Statistics_Click(object sender, EventArgs e)
        {
            if (F_Statistics == null)
            {
                F_Statistics = new Form_Statistics(model);
                F_Statistics.FormClosed += FStatistics_FormClosed;
                F_Statistics.MdiParent = this;
                F_Statistics.Dock = DockStyle.Fill;
                F_Statistics.Show();
            }
            else
            {
                F_Statistics.Activate();
                F_Statistics.Show();
            }
        }
        private void FStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            F_GPS = null;
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button connect");
            try
            {
                _serialPort.PortName = cb_PortSelect.Text;
                _serialPort.BaudRate = 115200;
                _serialPort.DtrEnable = true;

                _serialPort.Open();
                Console.WriteLine("Connected to Port {0}", _serialPort.PortName);

                //pb_IconConnectionStatus.Image = Image.FromFile(@ImagePath + "Icon_connected" + ".png");
                //lb_Connected.Text = "Connected";

                _connected = true;
                bt_Connect.Enabled = false;
            }
            catch
            {
                Console.WriteLine("Port not available");
            }
        }
    }
}
