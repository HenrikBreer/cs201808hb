using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmåMetoder
{
    class Program 
    {
        static void Main(string[] args)
        {
            int res = LægSammen(1, 2);
            Console.WriteLine(res);

            double areal = BeregnAreal(1);
            Console.WriteLine(areal);

            Udskriv("Udskrivning af tekst.....");


        }

        static int LægSammen(int a, int b)
        { return a + b; }

        static double BeregnAreal(int radius)
        { return System.Math.PI * radius * radius; }

        static void Udskriv(string tekst)
        { Console.WriteLine(tekst);
            Console.ReadKey();
        }

    }
}
