using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 01,
                Name = "Leyla",
                LastName = "Gülen",
                Email = "leylagülen@gmail.com",
                Password = 86495
            };


            Musteri musteri2 = new Musteri()
            {
                Id = 02,
                Name = "Ayşe",
                LastName = "Diken",
                Email = "aysediken@gmail.com",
                Password = 45764
            };


            Musteri musteri3 = new Musteri()
            {
                Id = 03,
                Name = "Ahmet",
                LastName = "Yıldız",
                Email = "ahmetyıldız@gmail.com",
                Password = 14548
            };
            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri Id : " + musteri.Id);
                Console.WriteLine("Musteri Adı : " + musteri.Name);
                Console.WriteLine("Musteri Soyadı : " + musteri.LastName);
                Console.WriteLine("Musteri Maili : " + musteri.Email);
                Console.WriteLine("Musteri Şifresi : " + musteri.Password);
            }

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("-----------------");
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("-----------------");
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("-----------------");
            musteriManager.MusteriEkle(musteri3);
          

        }
    }
}
