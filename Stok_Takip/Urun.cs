using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    public class Urun
    {
        public int ID_Urun { get; set; }
        public DateTime Ekleme_Tarihi { get; set; }
        public String Urun_Seri_No { get; set; }
        public int Urun_Adet { get; set; }

       /*public string FullInfo 
        { 
            get 
            {
                string str = "Urun Adi: " + Urun_Adi+ ", Ekleme Tarihi: " + Ekleme_Tarihi +", Urun Seri No: " + Urun_Seri_No;
                return str;
            } 
        }*/
       
    }
}
