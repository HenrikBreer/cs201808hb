using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i1 = 1; i1 < 11; i1++)
            {
                for (int i2 = 1; i2 < 11; i2++)
                {
                    if (i1*i2 >= 50) { Console.ForegroundColor = ConsoleColor.Yellow; } else { Console.ForegroundColor = ConsoleColor.White; }
                    if (i2 == 10) { Console.WriteLine(System.Convert.ToString(i1 * i2).PadLeft(5)); }
                    else
                    {
                        Console.Write(System.Convert.ToString(i1 * i2).PadLeft(5));
                    }
                }
                
            }

            Console.ReadKey();
        }
    }
}
