using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG521
{
    public class Greeting
    {
        public static string name; // initialize variable 
        public Greeting() // Greeting method
        {
            Console.WriteLine("Hello there!"); 
            Console.Write("Please enter your name: ");
            name = Console.ReadLine(); // get user input (name)

            while (string.IsNullOrEmpty(name)) // validation to check if the user input is valid
            {
                Console.Write("\nPlease try again and make sure to enter your name: ");
                name = Console.ReadLine();
            }

            // char.ToUpper(name[0]) capitalizes the first letter of the name
            // name.Substring(1) prints the rest of the name from index 1
            Console.WriteLine("\nWelcome " + char.ToUpper(name[0]) + name.Substring(1) + "!! " 
                + "\nThis is Rent an Accomodation or Buy a Property application. " 
                + "\n\nEnter all the required information below: ");
        }
    }
}
