using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
namespace ConsoleUI
{
    public class BuildCustomer
    {
        public static void BuildACustomer(List<PreferredCustomer> inputList, bool loop, string input)
        {
            //Clear current screen
            Console.Clear();
            //Create customer object
            PreferredCustomer output = new PreferredCustomer();
            output.CustomerStatus = true;
            Console.WriteLine(StandardMessages.EnterCustomerInformationTitle());
            //Get customer name
            Console.Write(StandardMessages.EnterCustomerName());
            output.Name = Console.ReadLine();
            //Get customer ID#
            Console.Write(StandardMessages.EnterCustomerIDNumber());
            output.CustomerNumber = Console.ReadLine();
            //Get customer address
            Console.Write(StandardMessages.EnterCustomerAddress());
            output.Address = Console.ReadLine();
            //Get customer phone number
            Console.Write(StandardMessages.EnterCustomerPhoneNumber());
            output.PhoneNumber = Console.ReadLine();

            do
            {
                //Get customers mailing preference
                Console.Write("Do you wish to be on the mailing list yes/no? ==> ");
                input = Console.ReadLine().ToLower();
                //Decision structure for mailing preference
                if (input == "yes" || input == "y")
                {
                    output.MailingListOption = true;
                    loop = true;
                }
                else if (input == "no" || input == "n")
                {
                    output.MailingListOption = false;
                    loop = true;
                }
                else
                {
                    Console.WriteLine(StandardMessages.DisplayInvalidChoice());
                    Console.ReadLine();
                }

            } while (loop == false);
            inputList.Add(output);
        }
    }
}
