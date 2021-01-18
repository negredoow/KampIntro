using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(99, 101);
            dortIslem.Topla(9, 3);
            dortIslem.Topla(23);
            Console.ReadLine();
        }
    }
}
