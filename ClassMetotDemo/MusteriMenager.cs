using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriMenager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Eklendi");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Silindi");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
        }
        public void musteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri Adı : "+musteri.MusteriAdi);
                Console.WriteLine("Musteri Soy Adı : "+musteri.MusteriSoyadi);
                Console.WriteLine("Musteri Yaşı : "+musteri.MusteriYasi);
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
