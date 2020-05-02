using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Player
    {
        //Fields
        private string _name;
        private string _password;
        private string _classType;
        private string _race;
        private int _health;
        private int _armor;
        private int _potions;
        private int _coins;



        //Default Constructors
        public Player()
        {
            Name = "";
            Password = "";
            ClassType = "";
            Race = "";
            Health = 100;
            Armor = 100;
            Potions = 0;
            Coins = 0;
        }
        //Custom Constructors
        public Player(string name, string password, string classType, string race, int health,int armor, int potions, int coins)
        {
            Name = name;
            Password = password;
            ClassType = classType;
            Race = race;
            Health = health;
            Armor = armor;
            Potions = potions;
            Coins = coins;
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
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string ClassType
        {
            get
            {
                return _classType;
            }
            set
            {
                _classType = value;
            }
        }
        public string Race
        {
            get
            {
                return _race;
            }
            set
            {
                _race = value;
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
        public int Armor
        {
            get
            {
                return _armor;
            }
            set
            {
                _armor = value;
            }
        }
        public int Potions
        {
            get
            {
                return _potions;
            }
            set
            {
                _potions = value;
            }
        }
        public int Coins
        {
            get
            {
                return _coins;
            }
            set
            {
                _coins = value;
            }
        }

        //Methods
    }
}
