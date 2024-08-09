using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author Banoo Aboobaker - 20230228
// PRG521 FA2 - Question1
// Program in LINQ and C# Sharp to find the string which starts and ends with a specific character

namespace PRG521_FA2_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an array of cities
            string[] cities;

            // Declare variables
            char startChar;
            char endChar;
            string startString;
            string endString;
            

            // 1D array storing the 10 cities
            cities = new string[] { "Butterworth", "Mthatha", "Jagersfontein", "Kroonstad", "Boksburg", 
                "Soweto", "Empangeni", "Polokwane", "Secunda", "Kuruman" };


            // Welcome message
            Console.WriteLine("Welcome to City Finder!");
            Console.WriteLine("\nThis is a list of cities:");


            // Display the stored cities
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();


            // Prompt user for the starting character
            // Additional error handling has been implemented
            do
            {
                Console.Write("Enter a starting character for a city: ");
            }
            while (!char.TryParse(Console.ReadLine(), out startChar));
            Console.WriteLine();


            // Prompt user for the ending character
            // Additional error handling has been implemented
            do
            {
                Console.Write("Enter an ending character for a city: ");
            }
            while (!char.TryParse(Console.ReadLine(), out endChar));


            // Convert characters to String
            startString = startChar.ToString();
            endString = endChar.ToString();


            // Find the city that starts and ends with the specified characters using LINQ queries
            var matchingCities = cities.Where(city => city.StartsWith(startString) && city.EndsWith(endString));


            // Display the matching cities (also using LINQ query) or error message
            if (matchingCities.Any())
            {
                Console.WriteLine("\nMatching cities: ");
                foreach (string city in matchingCities)
                {
                    Console.WriteLine(city);
                }
            }
            else
            {
                Console.WriteLine("\nNo cities found that match the specified starting and ending characters.");
            }


            // Wait for the user to enter a key before closing the application
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
