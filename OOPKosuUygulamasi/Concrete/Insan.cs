using OOPKosuUygulamasi.Abstract;
using OOPKosuUygulamasi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKosuUygulamasi.Concrete
{
    internal class Insan : Kullanici,IMesafe
    {
        public Insan(double adımBoyu, int adımSayisi, int kosuSaati, int kosuDakikasi ,string adSoyad, Cinsiyet cinsiyet) : base(adımBoyu, adımSayisi, kosuSaati, kosuDakikasi)
        {
            this.Cinsiyet = cinsiyet;
            this.AdSoyad = adSoyad;
        }

        public Cinsiyet Cinsiyet { get; set; } // Burada cinsiyet alarak kadın mı erkek mi durumuna göre adım boyu vb sorgulamak için yaptım.
        public string AdSoyad { get; set; }

        public double TemposuzKosu(int dakika) // toplam girilen sürelere göre Temposuz kosu mesafemi hesapladım.
        {
            double toplamYol = ((this.AdımBoyu / 100) * this.AdımSayisi) * ((this.KosuSaati * 60) + (this.KosuDakikasi-dakika));
            return toplamYol;
        }

        public double ToplamAdım(int dakika, int adım) //
        {
            double toplamAdım = (((this.AdımBoyu / 100) * this.AdımSayisi) * ((this.KosuSaati * 60) + (this.KosuDakikasi-dakika)) / (this.AdımBoyu / 100)) + (((this.AdımBoyu / 100) * adım) * dakika) / (this.AdımBoyu / 100);
            return toplamAdım;
        }

        public double TempoluKosu(int dakika, int adım) // Girilen sürelere göre tempolu kosu mesafemi hesapladım.
        {
            double TempoluToplamYol = ((this.AdımBoyu / 100) * adım) * dakika;
            return TempoluToplamYol;
        }

        public double ToplamYol(double temposuzKosu, double tempoluKosu) // Toplam tempolu ve temposuz kosularıma göre katetdiğim mesafeyi hesapladım.
        {
            return tempoluKosu + temposuzKosu;
        }
    }
}
