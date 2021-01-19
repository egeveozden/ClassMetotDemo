using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.AdSoyad = "Ege Özden";
            musteri1.DogumYili = 1998;
            musteri1.KartNo = "11111";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.AdSoyad = "Hüsnü Özden";
            musteri2.DogumYili = 1973;
            musteri2.KartNo = "22222";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("İşlem Seçiniz" + "\n1 - Müşterileri Listele \n2 - Müşteri Ekle \n3 - Müşteri Sil\n4 - Çıkış");
            int secim = Convert.ToInt16(Console.ReadLine());

            if (secim == 1)
            {
                foreach (var musteri in musteriler)
                {
                    musteriManager.MusteriListele(musteri);
                }
            }
            
            else if (secim == 2)
            {
                musteriManager.MusteriEkle();
            }
            else if (secim == 3)
            {
                musteriManager.MusteriSil();
            }
            else
            {
                if (secim == 4)
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                }
            }
        }
    }
}
