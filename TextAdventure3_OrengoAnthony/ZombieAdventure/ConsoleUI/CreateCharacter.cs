using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class CreateCharacter
    {
        public static Player player = new Player();
        public static void CreateZombieAdvCharacter(Player player, GameRoom room)
        {
            //Sentinel to control loop
            bool characterLoop = false;
            string input;
            Console.WriteLine(StandardMessages.CreateCharacterDirections());
            Console.ReadLine();
            Console.Clear();
            do
            {
                //Character creation menu 
                
                Console.Write(StandardMessages.DisplayCreateCharacterMenu());
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //Creat name and password
                        CreateNameAndPassword(player, characterLoop);
                        break;
                    
                    case "2": 
                        //Select player class
                        SelectPlayerClass(player, input, characterLoop);
                        break;
                    case "3":    
                        //Select player race
                        SelectPlayerRace(player, input, characterLoop);
                        break;
                    case "4":
                        //Display created player information
                        DisplayPlayerInformation(player);

                        break;                   
                    case "5":
                        //Test to ensure player completes character creation 
                        if (player.Name == "" || player.Password == "" || player.ClassType == "" || player.Race == "") 
                        {
                            Console.WriteLine("You must complete all tasks to proceed!");
                            Console.ReadLine();
                        }
                        else
                        {                           
                            characterLoop = true;
                            Console.Clear();
                            PlayerMovement.CharacterMovement(player, room);
                        }
                        break;
                    default:
                        Console.WriteLine(StandardMessages.InvalidSelection());
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while (characterLoop == false);            
        }

        public static void CreateNameAndPassword(Player player, bool characterLoop)
        {
            Console.Clear();
            //Create user name 
            Console.Write("Enter your name ==> ");
            string playerName = Console.ReadLine();
            player.Name = playerName;

            do
            {
                //Create Password
                Console.WriteLine(StandardMessages.DisplayPasswordCreationInformation());
                Console.Write("Enter your Password ==> ");
                string passWord1 = Console.ReadLine();
                player.Password = passWord1;
                Console.Write("Reenter your Password ==> ");
                string passWord2 = Console.ReadLine();
                //Decision structure to confirm password guidelines
                if (passWord1 != passWord2)
                {
                    Console.WriteLine("Passwords do not match!");
                    player.Password = " ";
                }
                else if (passWord1.Length < 8)
                {
                    Console.WriteLine("Password is not long enough!");
                    player.Password = " ";
                }
                else if (passWord1.Length > 15)
                {
                    Console.WriteLine("Password is to long!");
                    player.Password = " ";
                }
                else
                {
                    Console.WriteLine("Great Job! Press enter to continue.");
                    characterLoop = true;
                }
                Console.ReadLine();
                Console.Clear();
            } while (characterLoop == false);
            
        }
        public static void SelectPlayerClass(Player player, string input, bool characterLoop)
        {   //Select player class                    
            do
            {
                Console.Clear();
                Console.WriteLine(StandardMessages.DisplaySelectPlayerClass());
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        player.ClassType = "Warrior";
                        characterLoop = true;
                        break;
                    case "2":
                        player.ClassType = "Mage";
                        characterLoop = true;
                        break;
                    case "3":
                        player.ClassType = "Thief";
                        characterLoop = true;
                        break;
                    case "4":
                        player.ClassType = "Cleric";
                        characterLoop = true;
                        break;
                    case "5":
                        characterLoop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.InvalidSelection());
                        break;
                }
                Console.Clear();
            } while (characterLoop == false);

        }
        public static void SelectPlayerRace(Player player,string input, bool characterLoop)
        {
            Console.Clear();
            //Select player race
            do
            {
                Console.WriteLine(StandardMessages.DisplaySelectPlayerRace());
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        player.Race = "Human";
                        characterLoop = true;
                        break;
                    case "2":
                        player.Race = "Elf";
                        characterLoop = true;
                        break;
                    case "3":
                        player.Race = "Dwarf";
                        characterLoop = true;
                        break;
                    case "4":
                        player.Race = "Wizard";
                        characterLoop = true;
                        break;
                    case "5":
                        characterLoop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.InvalidSelection());
                        break;
                }
                Console.Clear();
            } while (characterLoop == false);
        }
        public static void DisplayPlayerInformation(Player player)
        {
            //Display player information
            Console.Clear();
            Console.WriteLine($"Player Information\n----------------------\n" +
                $"Name: {player.Name}\nPassword: {player.Password}\nCLass: {player.ClassType}\nRace: {player.Race}");
            Console.ReadLine();
        }
    }
}
