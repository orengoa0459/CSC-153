using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class Customer : Person
    {
        //Fields
        private string _customerNumber;

        private bool _mailingListOption;

        //Constructor
        public Customer()
        {
            CustomerNumber = "";
            MailingListOption = true;
        }
        // Custom Constructor
        public Customer(string name, string address, string phoneNumber, string customerName, bool mailingListOption) : base(name, address, phoneNumber)
        {
            CustomerNumber = customerName;
            MailingListOption = mailingListOption;
        }

        //Properties
        public string CustomerNumber
        {
            get
            {
                return _customerNumber;
            }
            set
            {
                _customerNumber = value;
            }
        }
        public bool MailingListOption
        {
            get
            {
                return _mailingListOption;

            }

            set
            {
                _mailingListOption = value;
            }
        }
    }
}
