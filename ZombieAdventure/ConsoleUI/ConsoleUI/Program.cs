using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
/**
* 04.05.2020
* CSC 153
* Anthony Orengo
* Program description: This program uses a menu to direct the 
* user to start the game and view different settings and options.
* The program also allows the user to create a game character 
* for Zombie Adventure. Once the character is created a movement
* menu will display and consist of four different options. The
* options include an up, down, attack and exit option.
* If the user chooses the attack option, a random number will be 
* generated to represent points lost against the players health.

*/
namespace ConsoleUI
{
    
    class Program
    {
        public static GameRoom room = new GameRoom(" ", " ");
        public static Player player = new Player();
        

        public static List <Zombie> mobList = new List<Zombie>();
        public static Zombie H1N1 = new Zombie();
        static void Main(string[] args)
        {            
            SplashScreenMessages.Splash();            
            GameMenus.MainMenu();            
            StartGame(room);
        }

        public static void StartGame(GameRoom room)
        {
            SplashScreenMessages.GameInstructions();
            CreateCharacter.CreateZombieAdvCharacter(player, room);            
        }

        
        
       

      
    }
}
