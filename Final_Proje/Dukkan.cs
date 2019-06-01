using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{
    public abstract class Dukkan
    {
        public Urun urun { get; set; }

        public Dukkan()
        {
            urun = new Urun();
        }

     /*   public virtual string Urunler()
        {
            string temp = "";
            temp = urun.tanim.UrunleriListele();
           

            return temp;
        }*/

    }

}
