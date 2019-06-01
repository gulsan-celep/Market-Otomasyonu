using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{
   public class Hesap_Defteri :Satis
    {

        public List<Urun_Tanimi> SatilanUrunler = new List<Urun_Tanimi>();
        public Satis satisBilgileri { get; set; }
        public Hesap_Defteri()
        {
            this.SatilanUrunler = new List<Urun_Tanimi>();
            satisBilgileri = new Satis();
        }
        public void UrunEkle(Urun_Tanimi s)
        {
            SatilanUrunler.Add(s);
        }
        public void UrunCikar(int musteriKodu)
        {
            foreach (Urun_Tanimi item in SatilanUrunler)
            {
                if (item.MusteriKodu == musteriKodu)
                {
                    SatilanUrunler.Remove(item);
                }
            }
        }


        //public string SatislariListele()
        //{

        //}

        /*  public int ToplamTutarHesapla()

          {
              int Toplam = 0;

              foreach (Satis satis in Satislar)
              {
                  Toplam += satis.Tutar;
              }
              return Toplam;
          }

          public override int UrunMiktarHesapla()
          {
              base.UrunMiktarHesapla();
              foreach (Satis s in Satislar)
              {
                  Toplam -= s.Adet;
              }
              return Toplam;
          }
          */

    }
}
