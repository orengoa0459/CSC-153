using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
namespace ConsoleUI
{
    public class DisplayCustomerInfo
    {
        //Displays preferred customer data(note: Option is located in main program menu)
        public static void DisplayPreferredCustomerInformation(List<PreferredCustomer> inputList)
        {
            //Clear current screen
            Console.Clear();
            Console.WriteLine(StandardMessages.PreferredCustomerInformationTitle());
            //Loop to display customer information
            foreach (var PreferredCustomer in inputList)
            {
                Console.WriteLine($"Preferred Status: {(PreferredCustomer.CustomerStatus ? "Yes" : "No")}\nName: {PreferredCustomer.Name}\nCustomer# {PreferredCustomer.CustomerNumber}\nAddress: {PreferredCustomer.Address}\nPhone Number: {PreferredCustomer.PhoneNumber}\n" +
                    $"Mail Preference: {(PreferredCustomer.MailingListOption ? "Yes" : "No")}\n--------------------------------\n");
            }
            Console.WriteLine(StandardMessages.DisplayEnterMessage());
            Console.ReadLine();
        }
        //Displays non-preferred customer data(note: Option is located in main program menu)
        public static void DisplayNotPreferredCustomerInformation(List<NonPreferredCustomer> inputList)
        {
            //Clear current screen
            Console.Clear();
            Console.WriteLine(StandardMessages.NonPreferredCustomerInformationTitle());
            //Loop to display customer information
            foreach (var nonPreferredCustomer in inputList)
            {
                Console.WriteLine($"Preferred Status: {(nonPreferredCustomer.CustomerStatus ? "Yes" : "No")}\nTransaction#: {nonPreferredCustomer.TransactionNumber}" +
                    $"\n--------------------------------\n");
            }
            Console.WriteLine(StandardMessages.DisplayEnterMessage());
            Console.ReadLine();
        }
    }
}
