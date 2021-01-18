using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //encapsulation
       public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string acıklama,double fiyat, int stokadedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
