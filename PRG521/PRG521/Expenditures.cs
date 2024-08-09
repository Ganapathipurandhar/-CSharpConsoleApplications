using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG521
{
    public class Expenditures
    {
        // initialize variables
        public static decimal groceries;
        public static decimal lights;
        public static decimal water;
        public static decimal traveling;
        public static decimal other;
        public static decimal payment;

        public Expenditures() // Expenditures method
        {
            Console.WriteLine("\nExpenditures:");

            // validation to check if user input is a negative number or not a number 
            while (groceries <= 0)
            {
                try
                {
                    if (groceries < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the estimated monthly expenditures for groceries: ");
                        groceries = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the estimated monthly expenditures for groceries: ");
                        groceries = decimal.Parse(Console.ReadLine());
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the estimated monthly expenditures for groceries: ");
                    groceries = decimal.Parse(Console.ReadLine());
                }
            }

            // validation to check if user input is a negative number or not a number 
            while (water <= 0)
            {
                try
                {
                    if (water < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the estimated monthly expenditures for water: ");
                        water = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the estimated monthly expenditures for water: ");
                        water = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the estimated monthly expenditures for water: ");
                    water = decimal.Parse(Console.ReadLine());
                }
            }

            // validation to check if user input is a negative number or not a number 
            while (lights <= 0)
            {
                try
                {
                    if (lights < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the estimated monthly expenditures for lights: ");
                        lights = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the estimated monthly expenditures for lights: ");
                        lights = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the estimated monthly expenditures for lights: ");
                    lights = decimal.Parse(Console.ReadLine());
                }
            }

            // validation to check if user input is a negative number or not a number 
            while (traveling <= 0)
            {
                try
                {
                    if (traveling < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the estimated monthly expenditures for traveling: ");
                        traveling = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the estimated monthly expenditures for traveling: ");
                        traveling = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the estimated monthly expenditures for traveling: ");
                    traveling = decimal.Parse(Console.ReadLine());
                }
            }

            // validation to check if user input is a negative number or not a number 
            while (other <= 0)
            {
                try
                {
                    if (other < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the estimated monthly expenditures for other expenses: ");
                        other = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the estimated monthly expenditures for other expenses: ");
                        other = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the estimated monthly expenditures for other expenses: ");
                    other = decimal.Parse(Console.ReadLine());
                }
            }

            // formula for calculating the balance after paying expenditures
            payment = Menu.monthlyIncome - Menu.monthlyTaxDeducted - groceries - water - lights 
                - traveling - other;
        }
    }
}
