using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{
   public class Urun_Katalogu 
    {
        public List<Urun_Tanimi> UrunDosyalari;
        public Urun_Katalogu()
        {
            UrunDosyalari = new List<Urun_Tanimi>();
        }
        public void UrunEkle(Urun_Tanimi u)
        {
            UrunDosyalari.Add(u);
        }
        public void UrunCikar(string silinenurunkodu)
        {
            foreach (Urun_Tanimi item in UrunDosyalari)
            {
                if (item.UrunKodu == Convert.ToInt32(silinenurunkodu))
                    UrunDosyalari.Remove(item);
                break;
            }
          
        }

        public string UrunleriListele()
        {
            string temp = "";
           /*  for (int i = a; i <a+1; i++)
              {
                  temp += "Ürün Adı:" + UrunDosyalari[i].UrunAdi + Environment.NewLine + "Ürün Kodu:" + UrunDosyalari[i].UrunKodu + Environment.NewLine + "Fiyat:" + UrunDosyalari[i].Fiyat + "TL" ;

              }
              return temp;*/

           foreach (Urun_Tanimi dosya in UrunDosyalari)
            {

                    temp += "Ürün Adı:" + dosya.UrunAdi + Environment.NewLine + "Ürün Kodu:" + dosya.UrunKodu + Environment.NewLine + "Fiyat:" + dosya.Fiyat+Environment.NewLine + "TL"+"Ürün Miktar:"+dosya.kalem.Miktar+Environment.NewLine+Environment.NewLine;
      
            }
            return temp;
        }

    }
}
