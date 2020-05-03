using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PreferredCustomer : Customer
    {
        //Fields
        private bool _customerStatus;
        private decimal _purchaseAmount;
        private decimal _discountLevel;
        // Default Constructor
        public PreferredCustomer()
        {

            PurchaseAmount = 0.0m;
            DiscountLevel = 0.0m;
            CustomerStatus = true;
        }
        //Custom Constructor
        public PreferredCustomer(string name, string address, string phoneNumber, string customerNumber, bool mailingListOption, decimal purchaseAmount, decimal discountLevel, bool customerStatus) :
            base(name, address, phoneNumber, customerNumber, mailingListOption)
        {
            PurchaseAmount = purchaseAmount;
            DiscountLevel = discountLevel;
            CustomerStatus = customerStatus;
        }
        //Properties
        public decimal PurchaseAmount
        {
            get
            {
                return _purchaseAmount;
            }
            set
            {
                _purchaseAmount = value;
            }
        }
        public decimal DiscountLevel
        {
            get
            {
                return _discountLevel;
            }
            set
            {
                _discountLevel = value;
            }
        }
        public bool CustomerStatus
        {
            get
            {
                return _customerStatus;
            }
            set
            {
                _customerStatus = value;
            }
        }
    }
}
