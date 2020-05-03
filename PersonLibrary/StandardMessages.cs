using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class StandardMessages
    {
        //Display program instructions
        public static string DisplayProgramInstructions()
        {
            return " Preferred Customer Program\n" +
                "----------------------------------\n" +
                "This program allows the user to input customer data based on\n" +
                "customer preference. The user must input the customers choice\n" +
                "of preferred or non-preferred customer. If the customer chooses\n" +
                "preferred, the user must input the customer data and proceed to\n" +
                "complete the transaction. The program will display the customers\n" +
                "discounts based on price. The data will be saved in a list for future\n" +
                "reference. If the customer chooses non-preferred, the user will\n" +
                "complete the transaction and display the missed discounts to the\n" +
                "customer. The transaction data will be saved in a list for future\n" +
                "reference. The user will have the option to view both preferred and\n" +
                "non-preferred customer data.\n\n" +
                "Press enter to continue...";
        }
        //Display main menu
        public static string DisplayMainMenu()
        {
            return "      Main Menu\n" +
                "---------------------\n" +
                "1. Preferred customers\n" +
                "2. Non-preferred customers\n" +
                "3. Display preferred customers\n" +
                "4. Display non-preferred customers\n"+
                "5. Exit\n" +
                "=====================";
        }

        //Display Customer Creation menu
        public static string DisplayCreateCustomerMenu()
        {
            return "Customer Creation Menu\n" +
                "---------------------\n" +
                "1. Preferred customer\n" +
                "2. Display customers\n" +
                "3. Complete Transaction\n" +
                "4. Exit\n" +
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
        //Display preferred customer information title
        public static string PreferredCustomerInformationTitle()
        {
            return "Preferred Customer Information\n" +
                "---------------------------------";
        }
        //Display non=preferred customer information title
        public static string NonPreferredCustomerInformationTitle()
        {
            return "Non-Preferred Customer Information\n" +
                "---------------------------------";
        }
        //Display invalid selection
        public static string DisplayInvalidChoice()
        {
            return "Not a valid input! Press Enter to Continue. ";
        }
        
        public static string DisplayNotPreferredCustomerMessage()
        {
            return "You are not a preferred customer!\n" +
                "You will not recieve any discounts at this time.";
        }
        public static string DisplayEnterMessage()
        {
            return "Press Enter to Continue";
        }


    }
}
