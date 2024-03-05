using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoSat_Dashboard
{
    public class Dashboard
    {
        private string[] data = null;            //Verweis auf zukünftiges Feld
        static SerialPort serialPort;

        Random r = new Random();

        public string[] Data
        {
            get { return data; }              //getter zum Auslesen der Zahlen

        }

        public Dashboard(string receivedData)                   //Konstruktor
        {
            ProcessData(receivedData);
        }
        private void ProcessData(string receivedData)
        {

            receivedData = receivedData.Replace("'", "");
            receivedData = receivedData.Replace("[", "");
            receivedData = receivedData.Replace("NaN", "0");

            data = receivedData.Split(',');
        }

        public string[] ToStringArray()
        {
            string[] str = new string[15];

            for(int i = 0; i < str.Length; i++)
            {
                str[i] = data[i];
            }

            return str;
        }
    }
}
