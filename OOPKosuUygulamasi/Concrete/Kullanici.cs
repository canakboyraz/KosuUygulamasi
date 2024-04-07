using OOPKosuUygulamasi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKosuUygulamasi.Concrete
{
    internal class Kullanici // base class
    {
        public double AdımBoyu { get; set; }
        /* public double AdımBoyu
         {
             get => AdımBoyu;
             set
             {
                 if (value <= 0)
                 {
                     throw new Exception("Adım Boyunu doğru girmediniz!");
                 }
                 else
                 {
                     AdımBoyu = value;
                 }
             }
         }
        */
        public int AdımSayisi { get; set; }
        /*
        public int AdımSayisi
        {
            get => AdımSayisi;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Adım Sayısını doğru girmediniz!");
                }
                else
                {
                    AdımSayisi = value;
                }
            }
        }
        */
        public int KosuSaati { get; set; }

        public int KosuDakikasi { get; set; }
        /*
        public int KosuDakikasi
        {
            get => KosuDakikasi; set
            {
                if (value >= 60)
                {
                    throw new Exception("Dakikayı 60 dan daha az bir değer giriniz.");
                }
                else
                {
                    KosuDakikasi = value;

                }
            }
        }
        */


        // Bunu yazarak default constructor ezmiş oluyoruz.
        public Kullanici(double adımBoyu, int adımSayisi, int kosuSaati, int kosuDakikasi)
        {
            this.AdımBoyu = adımBoyu;
            this.AdımSayisi = adımSayisi;
            this.KosuSaati = kosuSaati;
            this.KosuDakikasi = kosuDakikasi;
        }
    }
}
