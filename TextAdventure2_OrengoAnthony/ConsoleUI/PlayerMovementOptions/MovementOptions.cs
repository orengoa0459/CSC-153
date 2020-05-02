using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMovementOptions
{
    public class MovementOptions
    {
        public static string move()
        {
            //Allows unicode to display in console.
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //returns movement menu
            return  " \u2191 Move North \n \u2193 Move South \n A. Attack \n Esc. Exit ";

        }
    }
}
