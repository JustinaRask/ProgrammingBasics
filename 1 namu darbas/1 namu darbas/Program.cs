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
            int number;
            Int32.TryParse(input, out number);
            //double d;
            //if (!double.TryParse(Console.ReadLine(), out d))

            if (number == 0)
            {
                Console.WriteLine("Entry");
            }
            if (number > 0 && number < 2)
            {
                Console.WriteLine("Junior");
            }
            if (number >=2 && number < 4)
            {
                Console.WriteLine("Mid-Level");
            }
            if (number >=4 &&  number <6.5)
            {
                Console.WriteLine("Professional");
            }
            if(number>6.5)
            {
                Console.WriteLine("Senior");
            }
            Console.ReadLine();



        }

    }
}
