using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG521
{
    public class Menu
    {
        // initialize variables
        public static decimal monthlyIncome;
        public static decimal monthlyTaxDeducted;
        public static int option;

        public Menu() // Menu method
        {
            new Greeting(); // call the Greeting method

            Console.WriteLine("\nIncome information:");

            // validation to check if user input is a negative number or not a number 
            while (monthlyIncome <= 0)
            {
                try
                {
                    if (monthlyIncome < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter your monthly income (before deductions): ");
                        monthlyIncome = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter your monthly income (before deductions): ");
                        monthlyIncome = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter your monthly income (before deductions): ");
                    monthlyIncome = decimal.Parse(Console.ReadLine());
                }
            }

            // validation to check if user input is a negative number or not a number 
            while (monthlyTaxDeducted <= 0)
            {
                try
                {
                    if (monthlyTaxDeducted < 0) {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the estimated monthly tax: ");
                        monthlyTaxDeducted = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the estimated monthly tax deducted: ");
                        monthlyTaxDeducted = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the estimated monthly tax: ");
                    monthlyTaxDeducted = decimal.Parse(Console.ReadLine());
                }
            }

            new Expenditures(); // call the Expenditures function

            Console.WriteLine("\nChoose between: \n(1) Renting an Accommodation \n(2) Buying a Property ");
            option = int.Parse(Console.ReadLine());

            // validation to check if input is either 1 or 2
            while (option != 1 || option != 2)
            {
                try
                {
                    if (option == 1)
                    {
                        new Rent(); // call the Rent method
                        break;
                    }
                    else if (option == 2)
                    {
                        new Buy(); // call the buy method
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please try again.");
                        Console.WriteLine("\nChoose between: \n(1) Renting an Accommodation " 
                            + "\n(2) Buying a Property ");
                        option = int.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nChoose between: \n(1) Renting an Accommodation " 
                        + "\n(2) Buying a Property ");
                    option = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
