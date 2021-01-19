using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public string MusteriEkleme(Musteri musteri)
        {
            string musteriId = musteri.Id.ToString();
            string musteriAdi = musteri.Adi;
            string musteriSoyadi = musteri.Soyadi;
            string musteriTcNo = musteri.TcNo;
            string musteriUrun = musteri.SatinAlinanUrun;
            String[] eklenenMusteriler = new String[] { musteriId, musteriAdi, musteriSoyadi, musteriTcNo, musteriUrun };
            return("Musteri kayıdınız tamamlanmıştır! \n"+eklenenMusteriler);
        }

        public string MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+musteri.Soyadi+musteri.SatinAlinanUrun);
            return musteri.Id.ToString() + "Listelendi!";
        }
        public string MusteriSilme(Musteri musteri)
        {

            return musteri.Id.ToString() + "Silindi";
        }

    }
}
