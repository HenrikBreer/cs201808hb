using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hukommelse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack:
            int i = 1;
            int y = 2;
            i = y; //kopiering af værdier
            y = 3;

            //
            Person p; //Pegepind på stack (peger ikke på noget endnu
            p = new Person(); //peger nu på object på heap hvor alder er 10
            //Alternativt
            Person q = new Person() { alder = 12 };

            p = null; //pegepind til object forsvinder. objectet kan herefter slettes, hvis der ikke er andre variable der peger på det

            p = q; //nu peger både p og q på samme object;

            q = null; //nu er det kun p der peger på object;

            // p og q er referencebaserede variable.

            //Struct er værdibaserede, class er referencebaseret








        }
    }
    class Person
    {
        public int alder = 10;

    }


}
