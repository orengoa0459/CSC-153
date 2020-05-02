using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailItem
{
    public class StandardMessages
    {

        public static string DisplayMainMenu()
        {
            //Displays main menu
            return " Main Menu \n-----------------------\n" +
               " 1. Retail Items List\n 2. Exit\n" +
               "-----------------------\n" +
               "Select from the menu --> ";
        }
        public static string DisplayRetailItems(string description, int unitsOnHand, decimal price)
        {
            //Displays retail items
            return $"----------------------\n " +
                $"Item type: {description} \n " +
                $"Units on Hand: {unitsOnHand} \n " +
                $"Price: ${price}\n" +
                $"======================";
        }

        public static string DisplayInvalidChoice()
        {
            return "Invalid selection!";
        }

        public static string ReturnToMainMenu()
        {
            return "Press Enter";
        }

        



    }
}
