using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun elma = new Urun();
            elma.UrunAd = "elma";
            elma.aciklama = "amasya elması";
            elma.fiyat = 15;

            Urun urun2 = new Urun();
            urun2.UrunAd = "karpuz";
            urun2.fiyat = 90;
            urun2.aciklama = "diyarbakır";

            Urun[] urunler = new Urun[] { elma, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAd);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine("------");
            }
            Console.WriteLine("--metotlar--");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(elma);
        }
    }
}
