using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
/**
* Date 04.19.2020
* CSC 153
* Anthony Orengo
* Program description: This program allows the user to input multiple
* customers information and display it. Information includes name, 
* customer#, address, phone number, and mailing preference. 
*/
namespace ConsoleUI
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Set loop sentinel
            bool menuLoop = false;
            string input;
            //Store customer information in list
            List<Customer> customer = new List<Customer>();
            do
            {
             //Main menu
                Console.WriteLine(StandardMessages.DisplayCreateCustomerMenu());
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //Build customer by entering information
                        BuildCustomer.BuildACustomer(customer, menuLoop, input);
                       
                        break;
                    case "2":
                        //Displays customer information
                        DisplayCustomerInfo.DisplayCustomerInformation(customer);
                        break;
                    case "3":
                        menuLoop = true; ;
                        break;                   
                    default:
                        //Displays invalid selection
                        Console.WriteLine(StandardMessages.DisplayInvalidChoice());
                        Console.ReadLine();
                            break;
                }
                //Clears screen
                Console.Clear();
            } while (menuLoop == false);
        }        
    }
}
