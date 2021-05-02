using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    class Projeler
    {
        public int ID_Proje { get; set; }
        public String Proje_Adi { get; set; }
        public String Detay { get; set; }
        public DateTime Ekleme_Tarihi { get; set; }
        public Nullable<System.DateTime> Bitis_Tarihi { get; set; }
    }
}
