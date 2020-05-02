using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class StandardMessages
    {
        //Display main menu
        public static string DisplayCreateCustomerMenu()
        {
            return "      Main Menu\n" +
                "---------------------\n" +
                "1. Create customer\n" +
                "2. Display customers\n" +
                "3. Exit\n" +
                "=====================";
        }
        //Display customer creation title
        public static string EnterCustomerInformationTitle()
        {
            return "Enter Customer Information\n" +
                "---------------------------------";
        }
        //Display enter customer name
        public static string EnterCustomerName()
        {
            return "Enter customer name ==> ";
        }
        //Display enter customer ID#
        public static string EnterCustomerIDNumber()
        {
            return "Enter customer ID number ==> ";
        }
        //Display enter customer address
        public static string EnterCustomerAddress()
        {
            return "Enter customer address ==> ";
        }
        //Display enter customer phone number
        public static string EnterCustomerPhoneNumber()
        {
            return "Enter customer phone number ==> ";
        }
        //Display customer information title
        public static string CustomerInformationTitle()
        {
            return "Customer Information\n" +
                "---------------------------------";
        }
        //Display invalid selection
        public static string DisplayInvalidChoice()
        {
            return "Not a valid selection! Press Enter to Continue. ";
        }
    }
}
