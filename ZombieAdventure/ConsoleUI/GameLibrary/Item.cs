using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Item
    {
        //Fields
        private string _name;
        private string _description;        

        //Constructors
        public Item()
        {
            Name = "";
            Description = "";            
        }
        //Custom Constructors
        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
        //Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
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
    }
}
