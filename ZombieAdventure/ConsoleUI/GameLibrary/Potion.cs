using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Potion
    {
        //Fields
        private string _name;
        private string _description;
        private int _healthPoints;
        //Constructors
        public Potion()
        {
            Name = "";
            Description = "";
            HealthPoints = 0;            
        }
        //Custom Constructors
        public Potion(string name, string description, int healthPoints)
        {
            Name = name;
            Description = description;
            HealthPoints = healthPoints;
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
        public int HealthPoints
        {
            get
            {
                return _healthPoints;
            }
            set
            {
                _healthPoints = value;
            }
        }


        
    }
}
