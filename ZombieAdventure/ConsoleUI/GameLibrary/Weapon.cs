using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Weapon
    {
        //Fields
        private string _name;
        private string _description;
        private int _power;
        private int _damage;
        //Constructors
        public Weapon()
        {
            Name = "";
            Description = "";
            Power = 0;
            Damage = 0;
        }
        //Custom Constructor
        public Weapon(string name, string description, int power, int damage)
        {
            Name = name;
            Description = description;
            Power = power;
            Damage = damage;
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
        public int Power
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
            }
        }
        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }
    }
}
