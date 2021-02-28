using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Osman";
            musteri1.Soyadi = "ECEOĞLU";
            musteri1.Yasi = 35;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Hakan";
            musteri2.Soyadi = "DEMİR";
            musteri2.Yasi = 40;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);

            Console.WriteLine("--------Müşteri silme işlemi------------");

            musteriManager.Sil(musteri2);


            Console.WriteLine("----------Müşteri Listesi----------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }



        }
    }
}
