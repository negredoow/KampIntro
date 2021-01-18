using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            Console.WriteLine("Kurs 1 : {0}  \nKurs 2 : {1} \nKurs 3 : {2}",kurs1,kurs2,kurs3);

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç için Temel Kurs",
                "Java" 

            };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine(new string('-', 25));

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
