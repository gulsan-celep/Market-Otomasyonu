using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{
   public class Satis
    {
      
        public DateTime Tarih { get; set; }
        public int Tutar { get; set; }
        public int Adet { get; set; }
        public Terminal terminal { get; set; }
        public Odeme odeme { get; set; }
        public Musteri musteri { get; set; }
        public SatisKalemi kalem { get; set; }
        public Kasa_Gorevlisi gorevli { get; set; }

        public Satis()
        {
            musteri = new Musteri();
            kalem = new SatisKalemi();
            gorevli = new Kasa_Gorevlisi();
            terminal = new Terminal();
        }


    }
}
