using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Lab._16
{
    class CountriesTextFile
    {
        public static string WelcomingText()
        {
            Console.WriteLine("Hi there! Please look over our menu.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("1. List all countries.");
            Console.WriteLine("2. Enter a new coutnry.");
            Console.WriteLine("3. Delete a country.");
            Console.WriteLine("4. Close program.");
            Console.WriteLine("**********************************************");
            Console.Write("Please enter the menu number you would like to access: ");
            var userEntry = Console.ReadLine();
            return userEntry;

        }

        public static void ReadFile()
        {
            var textFilePath = @"C:\Users\crazy\Desktop\Countries.txt";

            using (StreamReader textReader = new StreamReader(textFilePath))
            {
                while (!textReader.EndOfStream)
                {
                    Console.WriteLine(textReader.ReadLine());
                }
            }
        }

        public static void WriteFile(string newCountry)
        {
            var textFilePath = @"C:\Users\crazy\Desktop\Countries.txt";

            var doAgain = true;

            while (doAgain)
            {
                using (var textWriter = new StreamWriter(textFilePath, append: true))
                {
                    textWriter.WriteLine($"\r{newCountry}");
                }

                Console.Write("Would you like to add another country to the file? Y or N: ");
                var repeat = Console.ReadLine();

                if (repeat.StartsWith("Y", StringComparison.OrdinalIgnoreCase))
                {
                    doAgain = true;
                }

                else
                {
                    doAgain = false;
                }
            }
        }

        public static void DeleteCountry()
        {
            Console.WriteLine("Which country would you like to delete?");

            var textFilePath = @"C:\Users\crazy\Desktop\Countries.txt";
            string deletion = Console.ReadLine();
            TextInfo deletedCountry = new CultureInfo("en-US", false).TextInfo;
            deletion = deletedCountry.ToTitleCase(deletion);

            var countryText = File.ReadAllText(textFilePath);
            countryText = countryText.Replace(deletion, null);
            File.WriteAllText(textFilePath, countryText);
        }
    }
}
