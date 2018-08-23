using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveVariabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 10;
            tal++;
            tal--;
            tal+= 20;
            Console.WriteLine(tal);

            double kommatal1 = 12.3;
            Console.WriteLine(kommatal1);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);
            int uU = 2;
            Console.ReadKey();

            bool b1 = false;
            bool b2 = false;

            if (b1 && b2) { Console.WriteLine("true"); }




        }
    }
}
