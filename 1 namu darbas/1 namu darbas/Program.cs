using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_namu_darbas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kokia yra darbuotojo darbo patirtis?");
         
            string input = Console.ReadLine();
            double d;
            Double.TryParse(input, out d);

            if (d == 0)
            {
                Console.WriteLine("Entry");
            }
            if (d > 0 && d < 2)
            {
                Console.WriteLine("Junior");
            }
            if (d >=2 && d < 4)
            {
                Console.WriteLine("Mid-Level");
            }
            if (d >=4 &&  d < 6.5)
            {
                Console.WriteLine("Professional");
            }
            if( d >=6.5)
            {
                Console.WriteLine("Senior");
            }
            Console.ReadLine();



        }

    }
}
