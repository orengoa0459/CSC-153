using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;

namespace ConsoleUI
{
    public class DisplayCustomerTransaction
    {
        //Displays preferred customer receipt data
        public static void DisplayPreferredTransaction(decimal purchase, decimal discountPercent, decimal discountPrice)
        {
            discountPercent = discountPercent * 100;
            Console.WriteLine($"\nOrengo's Discounts\n" +
                              $"--------------------------\n" +
                              $"Total Price: ${purchase}\n" +
                              $"Discount Percent: {discountPercent}%\n" +
                              $"Total Savings: ${discountPrice}\n" +
                              $"==========================");        
        }

        //Displays non-preferred customer receipt data
        public static void DisplayNonPreferredTransaction(decimal purchase)
        {
            decimal discount = 0.0m;
            decimal fivePer = .05m;
            decimal sixPer = .06m;
            decimal sevenPer = .07m;
            decimal tenPer = .10m;

            // 0% transaction
            if(purchase <= 499.99m && purchase >= 0)
            {
                discount = purchase * 0;
                fivePer = fivePer * 0;
                Console.WriteLine($"\nYou did not miss any discounts\n" +
                              $"--------------------------\n" +
                              $"Total Price: ${purchase}\n" +
                              $"Discount Percent: {fivePer}%\n" +
                              $"Possible Savings: ${discount}\n" +
                              $"==========================");
            }
            // 5% transaction            
            else if (purchase >= 500.00m && purchase <= 999.99m)
            {
                discount = purchase * fivePer;
                fivePer = fivePer * 100;
                Console.WriteLine($"\nDiscounts you missed\n" +
                              $"--------------------------\n" +
                              $"Total Price: ${purchase}\n" +
                              $"Discount Percent: {fivePer}%\n" +
                              $"Possible Savings: ${discount}\n" +
                              $"==========================");
            }
            // 6% transaction    
            else if (purchase >= 1000.00m && purchase <= 1499.99m)
            {
                discount = purchase * sixPer;
                sixPer = sixPer * 100;
                Console.WriteLine($"\nDiscounts you missed\n" +
                              $"--------------------------\n" +
                              $"Total Price: ${purchase}\n" +
                              $"Discount Percent: {sixPer}%\n" +
                              $"Possible Savings: ${discount}\n" +
                              $"==========================");
            }
            // 7% transaction    
            else if (purchase >= 1500.00m && purchase <= 1999.99m)
            {
                discount = purchase * sevenPer;
                sevenPer = sevenPer * 100;
                Console.WriteLine($"\nDiscounts you missed\n" +
                              $"--------------------------\n" +
                              $"Total Price: ${purchase}\n" +
                              $"Discount Percent: {sevenPer}%\n" +
                              $"Possible Savings: ${discount}\n" +
                              $"==========================");
            }
            // 10% transaction    
            else if (purchase >= 2000.00m)
            {
                discount = purchase * tenPer;
                tenPer = tenPer * 100;
                Console.WriteLine($"\nDiscounts you missed\n" +
                              $"--------------------------\n" +
                              $"Total Price: ${purchase}\n" +
                              $"Discount Percent: {tenPer}%\n" +
                              $"Possible Savings: ${discount}\n" +
                              $"==========================");
            }
        }
    }
}
