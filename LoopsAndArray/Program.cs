using System;

namespace LoopsAndArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım Geliştirme Kursu", "Programlamanın Temelleri", "Java","Python" }; //array - dizi

            
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)  //Dizilerde her bir elemana verilen takma isim
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
