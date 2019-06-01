using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{
    public class Urun_Tanimi
    {
        public int UrunKodu { get; set; }
        public int Fiyat { get; set; }
        public string UrunAdi { get; set; }
        public SatisKalemi kalem { get; set; }
        public int MusteriKodu { get; set; }

        public Urun_Tanimi()
        {
            kalem = new SatisKalemi();
        }

      
    }
}
