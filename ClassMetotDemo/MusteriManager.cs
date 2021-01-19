using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine($"Müşteri ekle : {musteri.MusteriId} {musteri.MusteriAdi} {musteri.MusteriSoyadi}"+ " ===="+ " Başarılı. Müşteri Eklendi");
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine($"Müşteri Güncelle : {musteri.MusteriId} {musteri.MusteriAdi} {musteri.MusteriSoyadi}" + "====" + " Başarılı. Müşteri Güncellendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine($"Müşteri Sil : {musteri.MusteriId} {musteri.MusteriAdi} {musteri.MusteriSoyadi}" + "====" + " Başarılı. Müşteri Silindi");
        }

        public void Listeler (Musteri[] musteriler)
        {
            foreach (var liste in musteriler)
            {
                Console.WriteLine("Müşteri İD : " + liste.MusteriId);
                Console.WriteLine(" ");
                Console.WriteLine("Müşteri Adı: "+ liste.MusteriAdi);
                Console.WriteLine(" ");
                Console.WriteLine("Müşteri Soyadı : " + liste.MusteriSoyadi);
                Console.WriteLine(" ");
                Console.WriteLine("Müşteri Adresi : " + liste.MusteriAdres);
                Console.WriteLine(" ");
                Console.WriteLine("Müşteri Bakiyesi : " + liste.MusteriBakiye);
                Console.WriteLine("**********************************************");
            }
        }
    }
}
