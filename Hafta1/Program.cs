using System;

namespace Hafta1
{
    class Program
    {
        static void Main(string[] args)
        {

            // type safety - tip güvenliği
            string kategoriEtiketi = "Katagori";
            int OgrenciSayisi = 31000;
            double faizOranı = 1.69;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.63;
            double dolarBugun = 7.76;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("Degişdemi Butonu");
            }
            
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Kayıt Ol & Giriş Yap Butonu");
            }

            

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
