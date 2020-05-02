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
        public static void DisplayCustomerInformation(List<Customer> inputList)
        {
            //Clear current screen
            Console.Clear();
            Console.WriteLine(StandardMessages.CustomerInformationTitle());
            //Loop to display customer information
            foreach (var Customer in inputList)
            {
                Console.WriteLine($"Name: {Customer.Name}\nCustomer# {Customer.CustomerNumber}\nAddress: {Customer.Address}\nPhone Number: {Customer.PhoneNumber}\n" +
                    $"Mail Preference: {(Customer.MailingListOption ? "Yes" : "No")}\n--------------------------------\nPress Enter for Main Menu");                    
            }
            Console.ReadLine();
        }
    }
}
