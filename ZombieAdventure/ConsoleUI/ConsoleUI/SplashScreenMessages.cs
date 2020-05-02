using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class SplashScreenMessages
    {
        public static void Splash()
        {

            //Displays Main menu welcome screen for Zombie Adventure
            Console.WriteLine("********************************************");
            Console.WriteLine("*****                                  *****");
            Console.WriteLine("*****            Welcome To            *****");
            Console.WriteLine("*****         Zombie Adventure         *****");
            Console.WriteLine("*****                                  *****");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("*                                          *");
            Console.WriteLine("*                                          *");
            Console.WriteLine("*            ***************               *");
            Console.WriteLine("*        *                     *           *");
            Console.WriteLine("*      *  ______        ______   *         *");
            Console.WriteLine("*    *   / *****      / *****     *        *");
            Console.WriteLine("*    *   *  (o) *     * (o)  *    *        *");
            Console.WriteLine("*    *   *      *     *      *    *        *");
            Console.WriteLine("*    *     ****         ****      *        *");
            Console.WriteLine("*    *              *             *        *");
            Console.WriteLine("*      *          *___*          *         *");
            Console.WriteLine("*        *        *****        *           *");
            Console.WriteLine("*        *     ***********     *           *");
            Console.WriteLine("*        *   * [][][][][] *    *           *");
            Console.WriteLine("*        *   * [][][][][] *    *           *");
            Console.WriteLine("*          *   ********** *   *            *");
            Console.WriteLine("*            *             *               *");
            Console.WriteLine("*              * * * * * *                 *");
            Console.WriteLine("*                                          *");
            Console.WriteLine("********************************************");
            Console.WriteLine("Press Enter to Begin!");
            Console.ReadLine();
        }

        public static void GameInstructions()
        {
            //Allows unicode to display in console.
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Display message to user explaining how character movement works.            
            Console.WriteLine(" ");
            Console.WriteLine("          Welcome to Zombie Adventure ");
            Console.WriteLine("------------------------------------------------ ");
            Console.WriteLine("This game uses basic movement by use of keyboard.");
            Console.WriteLine("\nBelow is the breakdown of character movement. ");
            Console.WriteLine("************************************************");
            Console.WriteLine("* Move North: Up Arrow Key \u2191 \n* Move South: Down Arrow Key \u2193 \n* Attack: A key \n* Exit: Esc key ");
            Console.WriteLine("************************************************");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static void EndMessage()
        {
            Console.WriteLine("Not Everyone is meant to win Zombie Adventure.");
            Console.WriteLine("You have proven to be a failure because you lack");
            Console.WriteLine("the neccessary skills of surviving. Better luck");
            Console.WriteLine("next time loser.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Developer Credits");
            Console.WriteLine("***********************************************.");
           
            
        }
    }
}
