/**
* Date 01.28.2020
* CSC 153
* Anthony Orengo
* This program uses an array to display a set of decimal
* values.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {   //----------------Beginning of main method---------------------------//
        static void Main(string[] args)
        {
            //Calls totalSales method//  
            totalSales();         

        }
        //================End of main method================================//

        //----------------Beginning of totalSales method------------------------//
        static void totalSales()
        {
            //Declares and initializes decimal array with a set size of 7//
            decimal[] sales = new decimal[7]

            
            {
                1245.67m, 
                1189.55m, 
                1098.72m, 
                1456.88m, 
                2109.34m, 
                1987.55m, 
                1872.36m
            };

            Console.WriteLine("Total Sales");
            Console.WriteLine("---------------------------------");

            //Iterates through each decimal value in the array//
            foreach (var element in sales)
            {
                //Writes the decimal value within the array for each iteration of the loop//
                Console.WriteLine($"*  {element}");

            }
            //Displays the decimal values within the array//
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Press enter to close the program.");
            Console.ReadLine();
            
        }
        //================End of totalSales method================================//
    }
}
