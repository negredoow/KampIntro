using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {





        }

        private static void classss()
        {
            Kurs kr1 = new Kurs();
            kr1.KursAdı = "C#";
            kr1.Egitmen = "Engin Demirog";
            kr1.izlenmeOranı = 68;

            Kurs kr2 = new Kurs();
            kr2.KursAdı = "Python";
            kr2.Egitmen = "Engin Demirog";
            kr2.izlenmeOranı = 75;

            Kurs kr3 = new Kurs();
            kr3.KursAdı = "Java";
            kr3.Egitmen = "Engin Demirog";
            kr3.izlenmeOranı = 48;


            // Console.WriteLine("Kurs1 Ad : {0} " ,kr1.KursAdı);

            Kurs[] kurslar = new Kurs[]
            {
           kr1,kr2,kr3

            };

            foreach (var x in kurslar)
            {
                Console.WriteLine("Kurs Adı : {0}", x.KursAdı);
            }
        }
    }

}









public class Kurs
{
    public string KursAdı { get; set; }
    public string Egitmen { get; set; }
    public int izlenmeOranı { get; set; }



}

