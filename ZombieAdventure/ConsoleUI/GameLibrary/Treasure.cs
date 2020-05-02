using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Treasure
    {
        private string _name;
        private string _description;        
        private int _points;
        //Constructor
        public Treasure()
        {
            Name = "";
            Description = "";            
            Points = 0;            
        }
        //Custom Constructor
        public Treasure(string name, string description, int points)
        {
            Name = name;
            Description = description;           
            Points = points;
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
        
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }
    }
}
