using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
/**
* Date 05/03/2020
* CSC 153
* Anthony Orengo
* Program description: This program allows the user to add a preferred or non-preferred
* customer to a list (**Preferred customer will require additional infgormation). The 
* program will ask the user to input the total purchase amount, and determine the customers 
* savings by computing the purchase amount by discount percentage. The program will display 
* the customers savings regardless of customer status. Each transaction will be saved in 
* either a preferred or non-preferred list which can be viewed for later reference.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set loop sentinels
            bool mainProgramLoop = false;
            bool preferredMenuLoop = false;            
            string input;
            //Set index to track number of  non-preferred customer transactions.
            int index = 1;

            //Store preferred and non-preferred customer information in lists
            List<PreferredCustomer> customer = new List<PreferredCustomer>();
            List<NonPreferredCustomer> nonPreferredCustomer = new List<NonPreferredCustomer>();
            Console.WriteLine(StandardMessages.DisplayProgramInstructions());
            Console.ReadLine();
            Console.Clear();
            do
            {   
                //Display main program menu
                Console.WriteLine(StandardMessages.DisplayMainMenu());
                //get input from user
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //Build preferred customer and complete customer transaction
                        BuildCustomer.BuildACustomer(customer, preferredMenuLoop, input);
                        CustomerTransaction.CustomerItemPurchasePreferred(customer, input, preferredMenuLoop);
                        break;
                    case "2":
                        //Complete non-preferred customer transaction
                        CustomerTransaction.CustomerItemPurchaseNotPreferred(nonPreferredCustomer,index, input);
                        index++;
                        break;
                    case "3":
                        //Display all preferred customers for the day                       
                        DisplayCustomerInfo.DisplayPreferredCustomerInformation(customer);
                        
                        break;
                    case "4":
                        //Display all non-preferred customer **Transactions** for the day
                        DisplayCustomerInfo.DisplayNotPreferredCustomerInformation(nonPreferredCustomer);
                        
                        break;
                    case "5":
                        //Exits program
                        mainProgramLoop = true;

                        break;
                    default:
                        //Display for invalid selection
                        Console.WriteLine(StandardMessages.DisplayInvalidChoice());
                        break;
                }
                Console.Clear();
            } while (mainProgramLoop == false);    
            
        }
    }
}
