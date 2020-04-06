using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* Date: 02.15.2020
* CSC 153
* Anthony Orengo
* Program description: This program determines the retail price
* of an item by calculating the the whole sale cost by the markup percent. 
* The results are then displayed to the user.This program is also menu operated 
* by use of a loop, to be more user friendly.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculateRetailPrice();
        }
        static void CalculateRetailPrice()

        {
            //Declare variables-------------------              
            string input;  
            decimal wholeSale; 
            decimal markUpPercent;
            decimal percent;
            decimal wholeSalePercent;
            decimal total;

            //Declare and initialize sentinel 
            bool keep_going = false;

            do
            {
                //Display main menu
                Console.WriteLine("***************************************");
                Console.WriteLine("*             Main Menu               *");
                Console.WriteLine("***************************************");
                Console.WriteLine("* 1. Whole Sale Calculator            *");
                Console.WriteLine("* 2. Exit                             *");
                Console.WriteLine("*                                     *");
                Console.WriteLine("***************************************");

                Console.Write("Make a selection --> ");
                input =Console.ReadLine();
                switch (input)
                {

                    case "1":
                    {
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("***************************************");
                            Console.WriteLine("* Welcome to the wholesale calculator *");
                            Console.WriteLine("***************************************");
                            Console.WriteLine(" ");

                            //Get wholesale price from user
                            Console.Write("Enter wholesale price --> ");
                            wholeSale = decimal.Parse(Console.ReadLine());

                            //Get markup percent from user
                            Console.Write("Enter markup percent --> ");
                            markUpPercent = decimal.Parse(Console.ReadLine());

                            //Converts markUpPercent input to percentage format
                            percent = markUpPercent / 100m;
                            //Determines the markup price by multiplying wholeSale by percent
                            wholeSalePercent = wholeSale * percent;
                            //Calculates the total by adding wholeSale and wholeSalePercent
                            total = wholeSale + wholeSalePercent;
                            Console.WriteLine(" ");
                            //Display the retail price of the item
                            Console.WriteLine("**************************************** ");
                            Console.WriteLine("Summary: ");
                            Console.WriteLine(" ");
                            //Display wholesSale price using currency format
                            Console.WriteLine("Wholesale Price: "+ wholeSale.ToString("C", CultureInfo.CurrentCulture));
                            Console.WriteLine("Markup Percent:  "+"%"+markUpPercent);
                            Console.WriteLine(" ");
                            //Display total using currency format
                            Console.WriteLine("Retail price of the item: " + total.ToString("C", CultureInfo.CurrentCulture));
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine(" ");
                            Console.WriteLine("* Press enter to return to main menu");
                            Console.ReadLine();                            

                            break;
                    }

                    case "2":
                        {      
                            //Set sentinel to true to end loop
                            keep_going = true;                            

                            break;
                        }

                    default:
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Invalid selection!");
                            Console.WriteLine(" ");
                            break;
                        }   

                }

            } while (keep_going == false);
        }

    }
}
