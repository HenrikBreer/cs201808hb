using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddHours(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2018, 09, 14);
            Console.WriteLine(d1);

            TimeSpan ts1 = d1.Subtract(d2);
            Console.WriteLine(ts1.Days);

            TimeSpan ts2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(ts2);

            TimeSpan ts3 = new TimeSpan(0, 30, 0);
            Console.WriteLine(ts3);

            TimeSpan ts4 = ts2.Subtract(ts3);
            Console.WriteLine(ts4);

            TimeSpan ts5 = ts2.Add(ts3);
            Console.WriteLine(ts5);







            Console.ReadKey();
        }
    }
}
