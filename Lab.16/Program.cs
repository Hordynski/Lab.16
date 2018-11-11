using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._16
{
    class Program
    {
        static void Main(string[] args)
        {
            var doAgain = true;

            while (doAgain)
            {
                var userEntry = CountriesTextFile.WelcomingText();
                var menuEntry = Validator.Validate(userEntry);

                if (menuEntry == 1)
                {
                    CountriesTextFile.ReadFile();
                    Console.WriteLine(" ");
                }

                else if (menuEntry == 2)
                {
                    Console.Write("Please enter your new country: ");
                    CountriesTextFile.WriteFile(Console.ReadLine());
                    Console.WriteLine(" ");
                }

                else if (menuEntry == 3)
                {
                    CountriesTextFile.DeleteCountry();
                    Console.WriteLine(" ");
                }

                else
                {
                    doAgain = false;
                    Console.WriteLine("Goodbye!");
                    Console.ReadKey();
                }
            }
        }
    }
}
