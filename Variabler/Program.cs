using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            //tre forskellige variable
            int _nummer;
            int Nummer;
            int nummer;
            //standard: Start med småt og lave store bogstaver undervejs:
            int antalMaanederPrAar;  //pascalCasing
            antalMaanederPrAar = 0;
            int a, b, c;
            int d = 0, e = 0, f = 0;

            System.Int32  i = 1; // svarer til int
            System.Int64 ii = 1; // svarer til long
            long g = 3000000000;
            int h = 2000000000;

            Console.WriteLine(g);
            Console.WriteLine("g = "+ g);
            Console.WriteLine($"g = {g}"); // template streng

            int y = 10;
            Console.WriteLine(y.ToString()); // instans medlem
            Console.WriteLine(int.MaxValue); // statisk medlem


            //float q = 0.01; Fejl da xxx.yyyy opfattes som double
            float q = 0.01F;
            double w = 0.01;  //standard for xxx.yyyy
            decimal ww = 0.01M;


            double tal = 013130.1231414125;
            Console.WriteLine(tal.ToString());
            Console.WriteLine(tal.ToString("N2"));
            Console.WriteLine(tal.ToString("N3"));
            Console.WriteLine(tal.ToString("F2"));
            Console.WriteLine(tal.ToString("C2"));
            Console.WriteLine(tal.ToString("P2"));
            










            Console.ReadKey();












        }
    }
}
