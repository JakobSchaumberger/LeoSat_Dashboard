using GMap.NET;
using LeoSat_Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeoSat_Dashboard
{   
    public partial class Form_LiveData : Form, IObserver<SerialData>
    {
        private Model model;
        private IDisposable unsubscriber;

        string timeOfFLight, Temp, Hum, Press, xAcc, yAcc, zAcc, Altitude;
        public Form_LiveData()
        {
            InitializeComponent();
        }
        public Form_LiveData(Model _model)
        {
            this.model = _model;
            model.Subscribe(this);

            InitializeComponent();
        }

        private void Form_LiveData_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        public void OnNext(SerialData recaivedData)
        {
            try
            {
                string[] data = recaivedData.ToStringArray();

                timeOfFLight = data[0];
                Temp         = data[2];
                Hum          = data[3];
                Press        = data[4];
                xAcc         = data[9];             
                yAcc         = data[10];     
                zAcc         = data[11];
                Altitude     = data[12];

                this.Invoke((MethodInvoker)delegate
                {
                    lb_Time.Text = timeOfFLight;
                    lb_Temperature.Text = Temp;
                    lb_Pressure.Text = Press;
                    lb_Humidity.Text = Hum;
                    lb_Altitude.Text = Altitude;
                    lb_Acceleration.Text = yAcc;

                    lb_Time.Text = timeOfFLight;

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
