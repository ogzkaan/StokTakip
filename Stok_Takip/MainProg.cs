using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using NLog;

namespace Stok_Takip
{
    class MainProg
    {
        //NLog Logger
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static String Barcode;
        [STAThread]
        static void Main(string[] args) 
        {
            logger.Error("Program starting...");
            Application.EnableVisualStyles();
            logger.Error("EnableVisualStyles kodunu gecti.");
            Application.Run(new AnaSayfa());
            logger.Error("Program started.");
        }
        

        

    }
}
