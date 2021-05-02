using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    class Urun_Takip_Data
    {
        public String Urun_Seri_No { get; set; }
        public String Proje_Adi { get; set; }
        public String Isim { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public String Aciklama { get; set; }
        public int Adet { get; set; }
        public int State { get; set; }
    }
}
