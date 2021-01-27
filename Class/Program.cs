using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Talha Ereli";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursEgitmeni = "Talha Ereli";
            kurs2.IzlenmeOrani = 45;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Java";
            kurs4.KursEgitmeni = "Talha Ereli";
            kurs4.IzlenmeOrani = 66;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.KursEgitmeni = "Talha Ereli";
            kurs3.IzlenmeOrani = 96;

            //Console.WriteLine(kurs1.KursAdi + " " +kurs1.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };


            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursEgitmeni);
            }




            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
