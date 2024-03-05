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

namespace LeoSat_Dashboard
{
    public partial class Form_GPS : Form
    {
        public Form_GPS()
        {
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

        private void timer_RefreshDisplay_Tick(object sender, EventArgs e)
        {

        }
        public void OnNext(Dashboard data)
        {
            string Latitude = data[13];
            string Longitude = data[14]; ;

            Refresh();
        }
    }
}
