using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
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
            SaveData(receivedData);

            Console.WriteLine(receivedData);
        }
        private void ProcessData(string receivedData)
        {

            receivedData = receivedData.Replace("'", "");
            receivedData = receivedData.Replace("[", "");
            receivedData = receivedData.Replace("NaN", "0");

            data = receivedData.Split(',');
        }
        private void SaveData(string receivedData)
        {
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter writer = new StreamWriter(@FilePath + "\\SensorData.txt", append:true))
            {
                writer.WriteLine(receivedData);
            }
        }

        public string[] ToStringArray()
        {
            try
            {
                string[] str = new string[20];

                for (int i = 0; i < data.Length; i++)
                {
                    str[i] = data[i];
                }
                return str;
            }
            catch(Exception e)
            {
                string[] str = new string[20];

                for (int i = 0; i < data.Length; i++)
                {
                    str[i] = "0";
                }
                Console.WriteLine(e.Message.ToString());
                return str;
            }
        }
    }
}
