using System;

namespace ClassMetotDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            // bir banka müşteri takip programı
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            Console.WriteLine("Müsterinin adını girin: ");
            musteri1.Adi = Console.ReadLine();
            Console.WriteLine("Müşterinin soyadını girin: ");
            musteri1.Soyadi = Console.ReadLine();
            Console.WriteLine("Müsterinin TcNo'sunu girin: ");
            musteri1.TcNo = Console.ReadLine();
            Console.WriteLine("Müsterinin satin aldığı ürünün adını girin: ");
            musteri1.SatinAlinanUrun = Console.ReadLine();

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            Console.WriteLine("Müsterinin adını girin: ");
            musteri2.Adi = Console.ReadLine();
            Console.WriteLine("Müşterinin soyadını girin: ");
            musteri2.Soyadi = Console.ReadLine();
            Console.WriteLine("Müsterinin TcNo'sunu girin: ");
            musteri2.TcNo = Console.ReadLine();
            Console.WriteLine("Müsterinin satin aldığı ürünün adını girin: ");
            musteri2.SatinAlinanUrun = Console.ReadLine();

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            Console.WriteLine("Müsterinin adını girin: ");
            musteri3.Adi = Console.ReadLine();
            Console.WriteLine("Müşterinin soyadını girin: ");
            musteri3.Soyadi = Console.ReadLine();
            Console.WriteLine("Müsterinin TcNo'sunu girin: ");
            musteri3.TcNo = Console.ReadLine();
            Console.WriteLine("Müsterinin satin aldığı ürünün adını girin: ");
            musteri3.SatinAlinanUrun = Console.ReadLine();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };



            while (true)
            {
                Console.WriteLine("Musteri kayıtları ile ilgili yapılmasını istediğiniz işlemi seçin (Ekle / Sil / Listele): (Çıkış için q/Q)");
                string deger = Console.ReadLine();
                if (deger == "ekle" || deger == "Ekle" || deger == "EKLE")
                {
                    Console.WriteLine("Eklemek istediğiniz müsteriyi seçin (musteri1 / musteri2 / musteri3): ");
                    string deger2 = Console.ReadLine();
                    if (deger2 == "musteri1")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriEkleme(musteri1);
                    }
                    else if (deger2 == "musteri2")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriEkleme(musteri2);
                    }
                    else if (deger2 == "musteri3")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriEkleme(musteri3);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış giriş yaptınız.");
                        continue;
                    }
                }
                else if (deger == "Sil" || deger == "SİL" || deger == "sil")
                {
                    Console.WriteLine("Silmek istediğiniz müsteriyi seçin (musteri1 / musteri2 / musteri3): ");
                    string deger2 = Console.ReadLine();
                    if (deger2 == "musteri1")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriSilme(musteri1);
                    }
                    else if (deger2 == "musteri2")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriSilme(musteri2);
                    }
                    else if (deger2 == "musteri3")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriSilme(musteri3);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış giriş yaptınız.");
                        continue;
                    }
                }
                else if (deger == "Listele" || deger == "listele" || deger == "LİSTELE")
                {
                    Console.WriteLine("Listelemek istediğiniz müsteriyi seçin (musteri1 / musteri2 / musteri3): ");
                    string deger2 = Console.ReadLine();
                    if (deger2 == "musteri1")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriListele(musteri1);
                    }
                    else if (deger2 == "musteri2")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriListele(musteri2);
                    }
                    else if (deger2 == "musteri3")
                    {
                        MusteriManager musteriManager = new MusteriManager();
                        musteriManager.MusteriListele(musteri3);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış giriş yaptınız.");
                        continue;
                    }
                }
                else if (deger == "q" || deger == "Q") { break; }
                else { break; }
            }
            

        }
    }
}
