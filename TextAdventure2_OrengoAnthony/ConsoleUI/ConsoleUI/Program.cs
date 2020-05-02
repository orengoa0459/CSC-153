using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 02.21.2020
* CSC 153
* Anthony Orengo
* Program description: This program uses a menu
* for character movement. The menu consist of four different
* options that include an up, down, attack and exit option.
* If the user chooses the attack option, a random number will be 
* generated to represent points lost against the players health.

*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SplashScreen.Splash();//Display splash image.
            StartGame();//Call method
        }

        public static void StartGame()
        {
            //Allows unicode to display in console.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            //Display message to user explaining how character movement works.            
            Console.WriteLine(" ");
            Console.WriteLine("This game uses basic movement by use of keyboard.");
            Console.WriteLine("\nBelow is the breakdown of character movement. ");
            Console.WriteLine("************************************************");
            Console.WriteLine("* Move North: Up Arrow Key \u2191 \n* Move South: Down Arrow Key \u2193 \n* Attack: A key \n* Exit: Esc key ");
            Console.WriteLine("************************************************");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();//Clears screen
            PlayerMovement.CharacterMovement(); //Starts character movement method (refer to player movemement class)
        }

        
    }
}
