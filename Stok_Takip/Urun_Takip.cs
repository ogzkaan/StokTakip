﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    class Urun_Takip
    {
        public int ID_Urun { get; set; }
        public int ID_Proje { get; set; }
        public int ID_Personel { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public String Aciklama { get; set; }
        public int Adet { get; set; }
        public int State { get; set; }


    }
}
