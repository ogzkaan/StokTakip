using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using Dapper;
using NLog.Layouts;
using System.IO;

namespace Stok_Takip
{
    class ReadSerialPort
    {
        private bool exceptionFlag = false;

        //public String Barcode { get; set; }

        public static String brkd;
        public static  Thread thread;
        public ReadSerialPort()
        {
            thread = new Thread(new ThreadStart(readSerial));
            thread.Start();
        }
        public void readSerial()
        {
            while (true)
            {
                Thread.Sleep(100);
                using (SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One))
                {
                    try
                    {


                        if (!port.IsOpen)
                        {
                            port.Open();
                        }
                        if (port.IsOpen)
                        {
                            
                            MainProg.Barcode = port.ReadLine();
                        }
          
                    }
                    catch (Exception ex)
                    {
                        if (exceptionFlag == false)
                        {
                            //MessageBox.Show("Barkod Okuyucu Bağlı Değil "+ex);
                            exceptionFlag = true;
                        }
                    }

                }

            }
        }
    }
}
