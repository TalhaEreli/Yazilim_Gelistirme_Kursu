using System;

namespace Hafta1_Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "DizÜstü Bilgisayar";
            urun1.urunFiyati = 7500;
            urun1.urunKodu = 00011;

            Product urun2 = new Product();
            urun2.urunAdi = "Çamaşır Makinesi";
            urun2.urunFiyati = 1500;
            urun2.urunKodu = 00022;

            Product urun3 = new Product();
            urun3.urunAdi = "Telefon";
            urun3.urunFiyati = 3000;
            urun3.urunKodu = 00033;



            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " " + urun.urunFiyati + " " + urun.urunKodu);
            }










        }
    }
    class Product
    {
        public string urunAdi { get; set; }
        public int urunKodu { get; set; }
        public int urunFiyati { get; set; }
    }       
}
