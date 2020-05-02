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
        private string _option;
        private bool _mailingListOption;    
        
        //Constructor
        public Customer()
        {
            CustomerNumber = "";
            Option = "";
            MailingListOption = true;          
        }
        // Custom Constructor
        public Customer(string customerName, string option, bool mailingListOption)
        {
            CustomerNumber = customerName;
            Option = option;
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
                _mailingListOption  = value;
            }
        }       
        public string Option
        {
            get
            {
                return _option;

            }

            set
            {
                _option = value;
            }
        }







    }
}
