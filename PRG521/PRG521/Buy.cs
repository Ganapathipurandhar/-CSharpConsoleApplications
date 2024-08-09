using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRG521
{
    public class Buy
    {
        // initialize variables
        public static decimal purchasePrice;
        public static decimal deposit;
        public static decimal interestRate;
        public static decimal noOfMonths;
        public static decimal pricePerMonth;

        public Buy() // Buy method
        {
            Console.WriteLine("\nYou have chosen to Buy a Property.");

            // validation to check if user input is a negative number or not a number 
            while (purchasePrice <= 0)
            {
                try
                {
                    if (purchasePrice < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the purchase price of the property: ");
                        purchasePrice = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the purchase price of the property: ");
                        purchasePrice = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the purchase price of the property: ");
                    purchasePrice = decimal.Parse(Console.ReadLine());
                }
            }

            // validation to check if user input is a negative number or not a number 
            while (deposit <= 0)
            {
                try
                {
                    if (deposit < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the total deposit: ");
                        deposit = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the total deposit: ");
                        deposit = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the total deposit: ");
                    deposit = decimal.Parse(Console.ReadLine());
                }
                
            }

            // validation to check if user input is a negative number or not a number 
            while (interestRate <= 0)
            {
                try
                {
                    if (interestRate < 0)
                    {
                        Console.WriteLine("\nPlease try again and make sure to enter a positive number!");
                        Console.WriteLine("\nEnter the interest rate as a percentage: ");
                        interestRate = decimal.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the interest rate as a percentage: ");
                        interestRate = decimal.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInput is not a number. Please try again!");
                    Console.WriteLine("\nEnter the interest rate as a percentage: ");
                    interestRate = decimal.Parse(Console.ReadLine());
                }
                
            }

            Console.WriteLine("\nEnter the number of months to repay (between 240 and 360): ");
            noOfMonths = decimal.Parse(Console.ReadLine());

            // validation to check if number of months is between 240 and 360
            while ((noOfMonths < 240 || noOfMonths > 360))
            {
                Console.WriteLine("\nInput is invalid: The number of months to repay should be between " +
                    "240 and 360. \nPlease re-enter the number of months to repay: ");
                noOfMonths = decimal.Parse(Console.ReadLine());
            }

            // formula to calculate the price per month for the property
            pricePerMonth = (purchasePrice * (interestRate / 100) + purchasePrice) / noOfMonths + deposit;

            // check if the balance - after paying all the expenditures - is less than a third of their income
            if (Expenditures.payment / 3 < pricePerMonth)
            {
                Console.WriteLine("\nSorry " + char.ToUpper(Greeting.name[0]) + Greeting.name.Substring(1) 
                    + ". Your income does not cover your expenses, therefore \nthe approval of the home loan " +
                    "is unlikely.");

                Console.WriteLine("\nThe monthly home loan repayment amount = R" + Math.Round(pricePerMonth), 2);

                Console.WriteLine("\nYour available monthly funds after paying all your expenses including "
                    + "the \nmonthly payment of the property per month = R"
                    + Math.Round(Expenditures.payment - pricePerMonth), 2);
            }
            else
            {
                Console.WriteLine("\nCongratulations " + char.ToUpper(Greeting.name[0]) 
                    + Greeting.name.Substring(1) + ". The approval of the home loan is likely.");

                Console.WriteLine("\nThe monthly home loan repayment amount = R" + Math.Round(pricePerMonth), 2);

                Console.WriteLine("\nYour available monthly funds after paying all your expenses including " 
                    + "the \nmonthly payment of the property per month = R" 
                    + Math.Round(Expenditures.payment - pricePerMonth), 2);
            }
        }
    }
}
