using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailItemLibrary
{
    public class Items
    {
        //Set fields
        private string _description;
        private int _unitsOnHand;
        private decimal _price;

        //Create constructors
        public Items(string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;

        }
        //Set full properties for description, units, and price
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
               _description = value;
            }
        }

        public int UnitsOnHand
        {
            get
            {
                return _unitsOnHand;
            }

            set
            {
                _unitsOnHand = value; 
            }
        }
        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
               _price = value;
            }
        }
        public static void DisplayItemsList()
        {
            //List<Items> itemsList = new List<Items>();
            //itemsList.Add(new Items("Jackets", 12, 59.05m));
            //itemsList.Add(new Items("Jeans", 40, 34.95m));
            //itemsList.Add(new Items("Shirts", 20, 24.95m));

           
            //foreach (var item in itemsList)
            //{
            //    Console.WriteLine("Type, Quantity, Price");
            //    Console.WriteLine("{0} {1} {2}",item.Description, item.UnitsOnHand, item.Price);
            //}
           
        }
    }

}
