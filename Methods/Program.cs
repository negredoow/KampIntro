using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya Elması";

            Urun urun2 = new Urun
            {
                Adi = "Karpuz",Fiyati = 80, Acıklama = "Diyarbakır Karpuzu"
            };

            Urun[] urunler = new Urun[]
            {
               urun1,urun2
            };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine(new string('*',50));
            }
            Console.WriteLine("Metotlar");
            Console.WriteLine(new string('-',50));

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yeşil Armut",12,500);



            Console.ReadLine();

            

            
        }
    }
}
