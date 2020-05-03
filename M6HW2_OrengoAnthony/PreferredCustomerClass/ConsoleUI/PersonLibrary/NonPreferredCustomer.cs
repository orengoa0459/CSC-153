using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class NonPreferredCustomer : PreferredCustomer
    {

        //Fields
        private int _transactionNumber;

        //Constructor
        public NonPreferredCustomer()
        {
            TransactionNumber = 0;
        }

        //Custom constructor
        public NonPreferredCustomer(string name, string address, string phoneNumber, string customerNumber, 
            bool mailingListOption, decimal purchaseAmount, decimal discountLevel, bool customerStatus, int transactionNumber) : 
            base(name, address, phoneNumber, customerNumber, mailingListOption, purchaseAmount, discountLevel, customerStatus)
        {
            TransactionNumber = transactionNumber;
        }

        //Properties
        public int TransactionNumber
        {
            get
            {
                return _transactionNumber;
            }

            set
            {
                _transactionNumber = value; 
            }           

        }





    }
}
