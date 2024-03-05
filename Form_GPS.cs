using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LeoSat_Dashboard
{
    public partial class Form_GPS : Form, IObserver<Dashboard>
    {
        private Model model;
        private IDisposable unsubscriber;

        public Form_GPS()
        {
            InitializeComponent();
            //InitializeMap();
        }
        public Form_GPS(Model _model)
        {
            this.model = _model;
            model.Subscribe(this);

            InitializeComponent();
            InitializeMap();
        }

        private void Form_GPS_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
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
        }
        public void OnNext(Dashboard recaivedData)
        {
            try
            {
                string[] data = recaivedData.ToStringArray();

                string Latitude = data[13];
                string Longitude = data[14];

                double nLat = Convert.ToDouble(Latitude, new System.Globalization.CultureInfo("en-US"));
                double nLong = Convert.ToDouble(Longitude, new System.Globalization.CultureInfo("en-US"));

                this.Invoke((MethodInvoker)delegate
                {
                    label1.Text = "" + nLat + nLong;
                    gMapControl1.Position = new PointLatLng(nLat, nLong);
                    Refresh();
                });
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Wrong Format of GPS Coordinates");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}