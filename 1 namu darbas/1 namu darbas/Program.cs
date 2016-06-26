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
            string[] competenceLevelArray = new string[] { "Entry", "Junior", "Mid-Level", "Professional", "Senior" };
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Employee experience in years?");
                string input = Console.ReadLine();
                double workExperienceInYears;

                if (!double.TryParse(input, out workExperienceInYears))
                {
                    if (input == "q")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Klaida: Ivestas blogas argumentas. Ivesti galima tik skaiciu");
                        continue;
                    }
                }
                else
                {
                    if (workExperienceInYears < 0 || workExperienceInYears > 100)
                    {
                        Console.WriteLine("Klaida: Darbo patirtis metais negali buti mazesne nei 0 arba didesne nei 100");
                        continue;
                    }
                }

                if (workExperienceInYears == 0)
                {
                    Console.WriteLine(competenceLevelArray[0]);
                }
                else if (workExperienceInYears > 0 && workExperienceInYears < 2)
                {
                    Console.WriteLine(competenceLevelArray[1]);
                }
                else if (workExperienceInYears >= 2 && workExperienceInYears < 4)
                {
                    Console.WriteLine(competenceLevelArray[2]);
                }
                else if (workExperienceInYears >= 4 && workExperienceInYears < 6.5)
                {
                    Console.WriteLine(competenceLevelArray[3]);
                }
                else if (workExperienceInYears >= 6.5 && workExperienceInYears < 100)
                {
                    Console.WriteLine(competenceLevelArray[4]);
                }

            }
            Console.ReadLine();
        }
    }
}
