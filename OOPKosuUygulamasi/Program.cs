// Kosu Uygulamasi

using OOPKosuUygulamasi.Concrete;
using OOPKosuUygulamasi.Enum;

double adımBoyu = 0;
int adımSayisi = 0;
int kosuSaat = 0;
int kosuDakika = 0;
int tempoluKosuDakika = 0;
int tempoluAdimSayisi = 0;
string adSoyad = "";

try
{
    Console.WriteLine("Adınızı ve Soyadınızı Giriniz");
    adSoyad=Console.ReadLine();

    Console.WriteLine("Ortalama bir adımınız kaç cm? (ör: 60 - 70)");
    while (!double.TryParse(Console.ReadLine(), out adımBoyu) || adımBoyu < 1 || adımBoyu > 200)
    {
        Console.WriteLine("Lütfen geçerli bir sayı girin (60 - 70 arası):");
    }

    Console.WriteLine("1 dakikada ortalama kaç adım atıyorsunuz? (ör: 100)");
    while (!int.TryParse(Console.ReadLine(), out adımSayisi) || adımSayisi <= 0 || adımSayisi >= 500)
    {
        Console.WriteLine("Lütfen geçerli bir pozitif tam sayı girin:");
    }

    Console.WriteLine("Kaç saat koşu yapacaksınız?");
    while (!int.TryParse(Console.ReadLine(), out kosuSaat) || kosuSaat < 0)
    {
        Console.WriteLine("Lütfen geçerli bir pozitif tam sayı girin:");
    }

    Console.WriteLine("Kaç dakika koşu yapacaksınız?");
    while (!int.TryParse(Console.ReadLine(), out kosuDakika) || kosuDakika < 0 || kosuDakika >= 60)
    {
        Console.WriteLine("Lütfen geçerli bir pozitif sayı (0 - 59 arası) girin:");
    }

    Console.WriteLine("Kaç dakika Tempolu koşu yapacaksınız?");
    while (!int.TryParse(Console.ReadLine(), out tempoluKosuDakika) || tempoluKosuDakika < 0 || tempoluKosuDakika >= (kosuSaat * 60) + kosuDakika)
    {
        Console.WriteLine($"Lütfen geçerli bir pozitif tam sayı (0 - {(kosuSaat * 60) + kosuDakika - 1} arası) girin:");
    }

    Console.WriteLine("1 dakikada ortalama kaç tempolu adım atıyorsunuz?");
    while (!int.TryParse(Console.ReadLine(), out tempoluAdimSayisi) || tempoluAdimSayisi <= 0)
    {
        Console.WriteLine("Lütfen geçerli bir pozitif tam sayı girin:");
    }

Insan insan1 = new Insan(adımBoyu, adımSayisi, kosuSaat, kosuDakika, adSoyad, Cinsiyet.Erkek);

double temposuzKosu= insan1.TemposuzKosu(tempoluKosuDakika);

double tempoluKosu = insan1.TempoluKosu(tempoluKosuDakika, tempoluAdimSayisi);

Console.WriteLine($"Merhaba {adSoyad}\n Toplam Yol: " + insan1.ToplamYol(tempoluKosu, temposuzKosu)+" metre\n" + "Atılan Toplam Adım: "+insan1.ToplamAdım(tempoluKosuDakika, tempoluAdimSayisi));

}
catch (Exception e)
{
    throw e;
}

