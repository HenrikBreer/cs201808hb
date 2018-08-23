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

            double Kommatal = 12.3;
            Console.WriteLine(Kommatal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            Console.ReadKey();
        }
    }
}
