using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
            Urun_Katalogu katalog = new Urun_Katalogu();
        Hesap_Defteri defter = new Hesap_Defteri();
            Musteri m = new Musteri();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun_Tanimi u1 = new Urun_Tanimi();
            u1.UrunAdi = txtAd.Text;
            u1.UrunKodu=Convert.ToInt32(txtKod.Text);
            u1.Fiyat = Convert.ToInt32(txtFiyat.Text);
            u1.kalem.Miktar =Convert.ToInt32(txtMiktar.Text);
            katalog.UrunEkle(u1);
            txtAd.Text = txtFiyat.Text = txtKod.Text=txtMiktar.Text = "";
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            Urun_Tanimi u1 = new Urun_Tanimi();
            katalog.UrunCikar(txtUruncikar.Text);
            txtListele.Text = katalog.UrunleriListele();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
           txtListele.Text=katalog.UrunleriListele();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(lst_Urunler.Items.Count==0)
            {
                MessageBox.Show("Sepetiniz boş...");
            }
            else
            {
                defter.satisBilgileri.musteri.Adi = txtadi.Text;
                defter.satisBilgileri.musteri.Soyadi = txtsoyad.Text;
                defter.satisBilgileri.musteri.Adres = txtadres.Text;
                defter.satisBilgileri.musteri.Telefon = Convert.ToDecimal(txttelefon.Text);
                defter.satisBilgileri.musteri.Email = txtmail.Text;
                defter.satisBilgileri.musteri.MusteriKodu = Convert.ToInt32(lblMusteriKodu.Text);
                DateTime bugün = new DateTime();
                bugün = DateTime.Now;
                defter.Tarih = bugün;
                ListViewItem SatisMusteriListele = new ListViewItem();
                SatisMusteriListele.Text = defter.satisBilgileri.musteri.Adi.ToString();
                SatisMusteriListele.SubItems.Add(defter.satisBilgileri.musteri.Soyadi.ToString());
                SatisMusteriListele.SubItems.Add(defter.satisBilgileri.musteri.Adres.ToString());
                SatisMusteriListele.SubItems.Add(defter.satisBilgileri.musteri.Telefon.ToString());
                SatisMusteriListele.SubItems.Add(defter.satisBilgileri.musteri.Email.ToString());
                SatisMusteriListele.SubItems.Add(defter.Tarih.ToString());
                SatisMusteriListele.SubItems.Add(defter.terminal.SeriNo.ToString());
                SatisMusteriListele.SubItems.Add(defter.gorevli.KimlikNo.ToString());
                SatisMusteriListele.SubItems.Add(defter.satisBilgileri.musteri.MusteriKodu.ToString());
                MusterliListe.Items.Add(SatisMusteriListele);

                MessageBox.Show("Müşteri bilgileri Eklenmiştir..");

                btnUrnGoster.Enabled = true;
            }
          




        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

     
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa_Gorevlisi kasa = new Kasa_Gorevlisi();
          
        }

        private void lst_Urunler_DoubleClick(object sender, EventArgs e)
        {
            txturunadiii.Text = lst_Urunler.SelectedItems[0].SubItems[1].Text.ToString();
        }

        private void btn_SepeteEkle_Click(object sender, EventArgs e)
        {
            Urun_Tanimi SatilanUrun = new Urun_Tanimi();
            SatilanUrun.UrunKodu =Convert.ToInt32(lst_Urunler.SelectedItems[0].SubItems[0].Text.ToString());
            SatilanUrun.UrunAdi = lst_Urunler.SelectedItems[0].SubItems[1].Text.ToString();
            SatilanUrun.kalem.Miktar = Convert.ToInt32(txtSatisMiktari.Text);
            SatilanUrun.Fiyat = Convert.ToInt32(lst_Urunler.SelectedItems[0].SubItems[3].Text.ToString());
            SatilanUrun.MusteriKodu = Convert.ToInt32(lblMusteriKodu.Text);
            defter.UrunEkle(SatilanUrun);
            MessageBox.Show("Ürün sepete eklendi.");
            txtSatisMiktari.Clear();
            txturunadiii.Text = "";


        }

        private void btnUrnGoster_Click(object sender, EventArgs e)
        {
                   
                ListViewItem goruntule;
                foreach (Urun_Tanimi item in katalog.UrunDosyalari)
                {
                    goruntule = new ListViewItem();
                    goruntule.Text = item.UrunKodu.ToString();
                    goruntule.SubItems.Add(item.UrunAdi.ToString());
                    goruntule.SubItems.Add(item.kalem.Miktar.ToString());
                    goruntule.SubItems.Add(item.Fiyat.ToString());
                    lst_Urunler.Items.Add(goruntule);
                }
                if (lst_Urunler.Items.Count == 0)
                {
                    MessageBox.Show("Şuan ürün bulunmamaktadır.");
                }
                else
                {
                Random r = new Random();
                lblMusteriKodu.Text = r.Next(1000, 9999).ToString();
                btnUrnGoster.Enabled = false;
                }
                
            
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void MusterliListe_DoubleClick(object sender, EventArgs e)
        {
            int toplamTutar = 0;
            ListViewItem goruntule;
            int musteriKodu =Convert.ToInt32(MusterliListe.SelectedItems[0].SubItems[8].Text.ToString());
            foreach (Urun_Tanimi item in defter.SatilanUrunler)
            {
                goruntule = new ListViewItem();
                goruntule.Text = item.UrunKodu.ToString();
                    goruntule.SubItems.Add(item.UrunAdi.ToString());
                    goruntule.SubItems.Add(item.kalem.Miktar.ToString());
                    goruntule.SubItems.Add(item.Fiyat.ToString());
                    int tutar = Convert.ToInt32(item.kalem.Miktar.ToString()) * Convert.ToInt32(item.Fiyat.ToString());
                toplamTutar += tutar;
                    goruntule.SubItems.Add(tutar.ToString()+" TL");
                lstSepet.Items.Add(goruntule);
               
            }
            lbl_toplamTutar.Text = toplamTutar.ToString() + " TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem rapor;
            int musteriKodu = Convert.ToInt32(MusterliListe.SelectedItems[0].SubItems[8].Text.ToString());

            foreach (Urun_Tanimi item in defter.SatilanUrunler)
            {

                if (item.MusteriKodu == musteriKodu)
                {
                    rapor = new ListViewItem();
                    rapor.Text = item.UrunKodu.ToString();
                    rapor.SubItems.Add(item.UrunAdi.ToString());
                    rapor.SubItems.Add(item.kalem.Miktar.ToString());
                    int tutar = Convert.ToInt32(item.kalem.Miktar.ToString()) * Convert.ToInt32(item.Fiyat.ToString());
                    rapor.SubItems.Add(tutar.ToString());
                    rapor.SubItems.Add(MusterliListe.SelectedItems[0].SubItems[0].Text.ToString());
                    rapor.SubItems.Add(MusterliListe.SelectedItems[0].SubItems[1].Text.ToString());
                    rapor.SubItems.Add(MusterliListe.SelectedItems[0].SubItems[6].Text.ToString());
                    rapor.SubItems.Add(MusterliListe.SelectedItems[0].SubItems[7].Text.ToString());
                    lstRapor.Items.Add(rapor);//satış listesini silmiyor hesap defterindeki
                }
            }
            MusterliListe.Items.RemoveAt(MusterliListe.SelectedIndices[0]);
            lstSepet.Items.Clear();
            MessageBox.Show("Satışınız başarıyla gerçekleşti.");
        }

        private void btnKasa_Click_1(object sender, EventArgs e)
        {
            
            if(rbKasa.Checked==true)
            {
                Random r = new Random();
                defter.gorevli.KimlikNo = r.Next(1000000, 9999999);
                defter.terminal.SeriNo = 1;
                grpKasa.Visible = false;
                grpMusteri.Visible = true;
                grpUrun.Visible = true;
            }
           else if (rbKasa2.Checked == true)
            {
                Random r = new Random();
                defter.gorevli.KimlikNo = r.Next(1000000, 9999999);
                defter.terminal.SeriNo = 2;
                grpKasa.Visible = false;
                grpMusteri.Visible = true;
                grpUrun.Visible = true;
            }
           else if (rbKasa3.Checked == true)
            {
                Random r = new Random();
                defter.gorevli.KimlikNo = r.Next(1000000, 9999999);
                defter.terminal.SeriNo = 3;
                grpKasa.Visible = false;
                grpMusteri.Visible = true;
                grpUrun.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen kasayı seçiniz..(!)");
            }






        }
    }
}
