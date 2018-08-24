using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekursion(1);
            Console.ReadKey();
        }


        static void Rekursion(int i)
        {
            
            Console.WriteLine(i);
            i = i + 1;
            if (i < 11) { Rekursion(i); }

        }

    }
}
