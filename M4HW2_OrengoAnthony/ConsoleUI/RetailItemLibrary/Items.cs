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
        
    }

}
