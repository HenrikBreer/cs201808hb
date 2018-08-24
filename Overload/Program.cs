using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregn(1, 2,3,4);
            Console.WriteLine(res);
           Console.ReadKey();
        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            return Beregn (a, b) + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            return Beregn (a , b) + Beregn (c , d);
        }




    }
}
