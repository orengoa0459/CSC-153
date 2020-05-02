using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailItemLibrary;

/**
* Date 03.28.2020
* CSC 153
* Anthony Orengo
* Program description: This program uses a menu to display the 
* retail items list of three items.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setinel to control loop
            bool menuLoop = false;
            //Get input from user
            string input;
            //Create objects
            RetailItemLibrary.Items jackets = new RetailItemLibrary.Items("Jackets", 12, 59.05m);
            RetailItemLibrary.Items jeans = new RetailItemLibrary.Items("Jeans", 40, 34.95m);
            RetailItemLibrary.Items shirts = new RetailItemLibrary.Items("Shirts", 20, 24.95m);
            do
            {
                //Displays main menu
                Console.Write(StandardMessages.DisplayMainMenu());                
                //Controls the process flow of the menu
                input = Console.ReadLine();
                switch (input)
                {                    
                    case "1":
                        //Display retail items list
                        Console.WriteLine("\n\n*Retail Item List*");
                        Console.WriteLine(StandardMessages.DisplayRetailItems(jackets.Description, jackets.UnitsOnHand, jackets.Price));
                        Console.WriteLine(StandardMessages.DisplayRetailItems(jeans.Description, jeans.UnitsOnHand, jeans.Price));
                        Console.WriteLine(StandardMessages.DisplayRetailItems(shirts.Description, shirts.UnitsOnHand, shirts.Price));
                        Console.WriteLine(StandardMessages.ReturnToMainMenu());
                        Console.ReadLine();                   
                        break;
                    
                    case "2":
                        //Exit main program
                        menuLoop = true;
                        break;
                    default:
                        //Displays invalid choice 
                        Console.WriteLine(StandardMessages.DisplayInvalidChoice());
                        Console.WriteLine(StandardMessages.ReturnToMainMenu());
                        Console.ReadLine();
                        break;
                }
                //Clears current screen
                Console.Clear();
            } while (menuLoop == false);
        }
    }
}
