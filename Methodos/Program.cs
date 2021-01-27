using System;

namespace Methodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun(); //örnegi tanımlıyosun 
            urun1.Adi = "Iphone X";
            urun1.Fiyati = 5000;
            urun1.Aciklama = "64 GB Siyah ";

            Urun urun2 = new Urun();
            urun2.Adi = "Iphone 11";
            urun2.Fiyati = 6500;
            urun2.Aciklama = "128 GB Silver";

            Urun[] urunler = new Urun[] { urun1 , urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------Metotlar----------");
            //instance class örnegi oluşturma
            SepetManager sepetMeneger = new SepetManager();
            sepetMeneger.Ekle(urun1);
            sepetMeneger.Ekle(urun2);            //fonksiyon tarzı çalışıyor metotlar
            
            

            
        }
    }
}


//Dont rapeat yourself  - clean kod - best practice
