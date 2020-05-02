using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class ZombieAttack
    {
        public static int GenerateRandomAttackNumber(ref int zombieAttack)
        {
            //Declares and initializes random number.
            Random randint = new Random();
            
            //Returms random number between 1 and 20.
            return zombieAttack = randint.Next(1, 20);
            
        }
    }
}
