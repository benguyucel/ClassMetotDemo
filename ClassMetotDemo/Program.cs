using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { MusteriAdi = "Yücel",MusteriSoyadi="Bengü",MusteriYasi=29 };
            Musteri musteri2 = new Musteri() { MusteriAdi = "Ali",MusteriSoyadi="Kahraman",MusteriYasi= 22 };

            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Add(musteri2);
            musteriMenager.Add(musteri1);
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriMenager.musteriListele(musteriler);

        }
    }
}
