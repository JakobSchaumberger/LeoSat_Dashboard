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
    public class SerialData
    {
        private string[] data = null;            //Verweis auf zukünftiges Feld
        static SerialPort serialPort;

        Random r = new Random();

        public string[] Data
        {
            get { return data; }              //getter zum Auslesen der Zahlen

        }

        public SerialData(string receivedData)                   //Konstruktor
        {
            ProcessData(receivedData);
            SaveData(receivedData);

            Console.WriteLine(receivedData);
        }
        private void ProcessData(string receivedData)
        {
            try
            {
                receivedData = receivedData.Replace("'", "");
                receivedData = receivedData.Replace("[", "");
                receivedData = receivedData.Replace("NaN", "0");

                data = receivedData.Split(',');
            }
            catch(Exception ex)
            {
                Console.WriteLine("Data did not the specification" + ex.Message.ToString());
            }     
        }
        private void SaveData(string receivedData)
        {
            try
            {
                string FilePath = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop);
                using (StreamWriter writer = new StreamWriter
                    (@FilePath + "\\SensorData.txt", append: true))
                {
                    writer.WriteLine(receivedData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not save Data." + ex.Message.ToString());
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
            catch(Exception ex)
            {
                string[] str = new string[20];

                for (int i = 0; i < data.Length; i++)
                {
                    str[i] = "0";
                }
                Console.WriteLine(ex.Message.ToString());
                return str;
            }
        }
    }
}
