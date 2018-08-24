using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
   
    class Program
    {
        static void Main(string[] args)
        {
            FilType ft = FilType.csv;
            Console.WriteLine(ft.ToString());

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            Person2 p2;
            p2.id = 1;
            p2.navn = "Mikkel";
            Console.WriteLine(p2.navn);

            Console.ReadKey();
        }

        

    }
    enum FilType
    {
        csv = 0,
        pdf = 1,
        txt = 2
    }

    struct Person
    { public int Id;
        public string Navn;      }

}
