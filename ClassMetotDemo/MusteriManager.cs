using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Sisteme Eklendi" + " " + musteri.Name + " " + musteri.LastName);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri Sistemden Silindi " + " " + musteri.Name);
        }
    }
}
