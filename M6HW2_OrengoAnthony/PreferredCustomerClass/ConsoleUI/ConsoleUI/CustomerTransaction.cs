using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
namespace ConsoleUI
{
    public class CustomerTransaction
    {
        //Non-Preferred customer transaction method
        public static void CustomerItemPurchaseNotPreferred(List<NonPreferredCustomer> inputList, int index, string input)
        {
            bool loop = false;
            decimal purchasePrice;
            NonPreferredCustomer notPreferredTransaction = new NonPreferredCustomer();
            Console.WriteLine(StandardMessages.DisplayNotPreferredCustomerMessage());
            notPreferredTransaction.CustomerStatus = false;
            
            do
            {
                //Get users purchase price
                Console.Write("Enter purchase price ==> ");
                input = Console.ReadLine();
                //Determine if user inputs a number or character
                if (decimal.TryParse(input, out purchasePrice))
                {
                    notPreferredTransaction.PurchaseAmount = purchasePrice;
                    notPreferredTransaction.TransactionNumber = notPreferredTransaction.TransactionNumber + index;
                    inputList.Add(notPreferredTransaction);
                    DisplayCustomerTransaction.DisplayNonPreferredTransaction(purchasePrice);
                    Console.WriteLine(StandardMessages.DisplayEnterMessage());
                    Console.ReadLine();
                    loop = true;
                }
                else
                {
                    //If user enters anything other than a number display invalid input.
                    Console.WriteLine(StandardMessages.DisplayInvalidChoice());
                    Console.ReadLine();                    
                }

            } while (loop == false);
            
            
        }
        //Preferred customer transaction method
        public static void CustomerItemPurchasePreferred(List<PreferredCustomer> inputList, string input, bool loop)
        {
            decimal purchasePrice;
            decimal discountPrice;
            PreferredCustomer transaction = new PreferredCustomer();
            transaction.PurchaseAmount = 0.0m;
            do
            {
                //Get input from user and validate if user inputs a number or character
                Console.Write("Enter total purchase ==> ");
                input = Console.ReadLine();
                decimal.TryParse(input, out purchasePrice);
                if (decimal.TryParse(input, out purchasePrice) && purchasePrice <= 499.99m && purchasePrice >= 0)
                {
                    transaction.DiscountLevel = 0m;
                    discountPrice = purchasePrice * transaction.DiscountLevel;
                    purchasePrice = purchasePrice - discountPrice;
                    transaction.PurchaseAmount = purchasePrice;
                    Console.WriteLine("\n**Sorry! No discount for this transaction.**"); 
                    //Display reciept
                    DisplayCustomerTransaction.DisplayPreferredTransaction(transaction.PurchaseAmount, transaction.DiscountLevel, discountPrice);                                     
                    loop = true;
                }
                else if (decimal.TryParse(input, out purchasePrice) && purchasePrice >= 500.00m && purchasePrice <= 999.99m)
                {
                    transaction.DiscountLevel = .05m;
                    discountPrice = purchasePrice * transaction.DiscountLevel;
                    purchasePrice = purchasePrice - discountPrice;
                    transaction.PurchaseAmount = purchasePrice;                    
                    DisplayCustomerTransaction.DisplayPreferredTransaction(transaction.PurchaseAmount, transaction.DiscountLevel, discountPrice);
                    loop = true;
                }
                else if (decimal.TryParse(input, out purchasePrice) && purchasePrice >= 1000.00m && purchasePrice <= 1499.99m)
                {
                    transaction.DiscountLevel = .06m;
                    discountPrice = purchasePrice * transaction.DiscountLevel;
                    purchasePrice = purchasePrice - discountPrice;
                    transaction.PurchaseAmount = purchasePrice;
                    DisplayCustomerTransaction.DisplayPreferredTransaction(transaction.PurchaseAmount, transaction.DiscountLevel, discountPrice);
                    loop = true;
                }
                else if (decimal.TryParse(input, out purchasePrice) && purchasePrice >= 1500.00m && purchasePrice <= 1999.99m)
                {
                    transaction.DiscountLevel = .07m;
                    discountPrice = purchasePrice * transaction.DiscountLevel;
                    purchasePrice = purchasePrice - discountPrice;
                    transaction.PurchaseAmount = purchasePrice;
                    DisplayCustomerTransaction.DisplayPreferredTransaction(transaction.PurchaseAmount, transaction.DiscountLevel, discountPrice); ;                    
                    loop = true;
                }
                else if (decimal.TryParse(input, out purchasePrice) && purchasePrice >= 2000.00m)
                {
                    transaction.DiscountLevel = .10m;
                    discountPrice = purchasePrice * transaction.DiscountLevel;
                    purchasePrice = purchasePrice - discountPrice;
                    transaction.PurchaseAmount = purchasePrice;
                    DisplayCustomerTransaction.DisplayPreferredTransaction(transaction.PurchaseAmount, transaction.DiscountLevel, discountPrice);
                    loop = true;
                }
                
                else
                {
                    //If user enters anything other than a number display invalid input.
                    Console.WriteLine(StandardMessages.DisplayInvalidChoice());
                    Console.ReadLine();
                }

            } while (loop == false);
            Console.WriteLine(StandardMessages.DisplayEnterMessage());
            Console.ReadLine();
        }
    }
}
