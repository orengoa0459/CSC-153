using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        //Create private fields
        private int _year;
        private string _make;
        private int _speed;

        //Constructor
        public Car(int year, string make, int speed)
        {
            Year = year;
            Make = make;
            Speed = speed;
        }

        //Set full properties for year, make, and speed
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
               _year = value;
            }

        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }

    }
}
      

