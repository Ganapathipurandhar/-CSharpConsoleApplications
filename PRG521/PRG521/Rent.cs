using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRG521
{
    public class Rent
    {
        public static decimal monthlyRentalAmount; // initialize variables

        public Rent() // Rent method
        {
            Console.WriteLine("\nYou have chosen to Rent an Accommodation.");

            // validation to check if user input is a negative number or not a number 
            while (monthlyRentalAmount <= 0)
            {
                try
                {
                    if (monthlyRentalAmount < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the monthly rental amount: ");
                        monthlyRentalAmount = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the monthly rental amount: ");
                        monthlyRentalAmount = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the monthly rental amount: ");
                    monthlyRentalAmount = decimal.Parse(Console.ReadLine());
                }
            }

            // check if the balance - after paying all the expenditures - is less than a third of their income
            if (Expenditures.payment / 3 < monthlyRentalAmount)
            {
                Console.WriteLine("\nSorry " + char.ToUpper(Greeting.name[0]) + Greeting.name.Substring(1) 
                    + ". Your income does not cover your expenses, therefore \nyou are likely unable to " +
                    "afford the monthly rental amount.");

                // print new balance
                Console.WriteLine("\nYour available monthly funds after all your expenses including rent = R"
                    + Math.Round(Expenditures.payment - monthlyRentalAmount), 2);
                // Math.Round rounds off to two decimal places
            }
            else
            {
                Console.WriteLine("\nCongratulations " + char.ToUpper(Greeting.name[0]) 
                    + Greeting.name.Substring(1) + ". You qualify to rent the accommodation for R" 
                    + Math.Round(monthlyRentalAmount, 2) + " per month."); 
                    // Math.Round rounds off to two decimal places

                // print new balance
                Console.WriteLine("\nYour available monthly funds after all your expenses including rent = R" 
                    + Math.Round(Expenditures.payment - monthlyRentalAmount), 2);
                    // Math.Round rounds off to two decimal places
            }
        }
    }
}
