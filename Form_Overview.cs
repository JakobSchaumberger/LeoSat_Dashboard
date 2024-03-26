using LeoSat_Dashboard;
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
    public partial class Form_Overview : Form, IObserver<SerialData>
    {
        private Model model;
        private IDisposable unsubscriber;
        public Form_Overview()
        {
            InitializeComponent();
        }
        public Form_Overview(Model _model)
        {
            this.model = _model;
            model.Subscribe(this);

            InitializeComponent();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(SerialData value)
        {
            throw new NotImplementedException();
        }

        private void Form_Overview_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
