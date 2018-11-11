using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._16
{
    class Validator
    {
        public static int Validate(string menuChoice)
        {
            var doAgain = true;
            var menuNumber = Int16.TryParse(menuChoice, out short newNumber);

            while (doAgain)
            {
                menuNumber = Int16.TryParse(menuChoice, out newNumber);

                if (newNumber >= 1 && newNumber <= 4)
                {
                    break;
                }

                else
                {
                    Console.Write("I'm sorry that entry is out of range. Please enter your menu number again: ");
                    menuChoice = Console.ReadLine();
                    doAgain = true;
                }
            }

            return newNumber;
        }
    }
}
