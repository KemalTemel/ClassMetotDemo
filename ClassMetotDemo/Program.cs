using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Kemal";
            musteri1.MusteriSoyadi = "Temel";
            musteri1.MusteriAdres = "Hatay";
            musteri1.MusteriBakiye = 1550.5;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriSoyadi = "Kimyacı";
            musteri2.MusteriAdres = "Hatay";
            musteri2.MusteriBakiye = 5450;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Durmus";
            musteri3.MusteriSoyadi = "Yıkar";
            musteri3.MusteriAdres = "Hatay";
            musteri3.MusteriBakiye = 125456 ;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            

            Console.WriteLine("---------------------------------------------------------------");

            musteriManager.Listeler(musteriler);

            Console.WriteLine("---------------------------------------------------------------");

            
            musteriManager.MusteriGuncelle(musteri2);
            

            Console.WriteLine("---------------------------------------------------------------");

            
            musteriManager.MusteriSil(musteri3);

            Console.WriteLine("----------------------------------------------------------------");



        }
    }
}
