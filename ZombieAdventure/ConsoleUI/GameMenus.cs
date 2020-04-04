using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    
    public class GameMenus
    {
        public static GameRoom room = new GameRoom(" ", " ");
        public static object[] roomArray = new object[7];
        public static void MainMenu()
        {
            //Declare and initilize loop variable
            bool mainMenuLoop = false;
            
            //Loop to control main menu options
            do
            {
                Console.Clear();
                Console.WriteLine(StandardMessages.DisplayMainMenu());

                //Get menu choice from user
                string menuChoice = (Console.ReadLine());

                //Use to control the selction of the main menu   
                switch (menuChoice)               
                {

                    case "1":
                    case "Start":
                        Console.Clear();
                        mainMenuLoop = true;
                        break;
                    case "2":
                    case "Settings":
                    case "settings":
                    case "S":
                    case "s":
                        Console.WriteLine(StandardMessages.DisplaySettingsMenu());
                        Console.ReadLine();
                        break;
                    case "3":
                    case "Options":
                    case "options":
                    case "O":
                    case "o":
                        
                        OptionMenu(room, roomArray);
                        break;
                    case "4":
                    case "Exit":
                    case "exit":
                    case "E":
                    case "e":
                        mainMenuLoop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.InvalidSelection());
                        break;

                }
            } while (mainMenuLoop == false);

            
        }    

        public static void OptionMenu(GameRoom room, object[] roomArray)
        {
            //Declare and initilize loop variable
            bool menuOptionsLoop = false;
            List<Zombie> mobList = new List<Zombie>();
            
            //Loop to control main menu options
            do
            {
                //Clears screen
                Console.Clear();
                Console.WriteLine(StandardMessages.DisplayOptionsMenu());
                //Get menu choice from user
                string menuChoice = (Console.ReadLine());

                //Use to control the selction of the main menu   
                switch (menuChoice)
                {
                    case "1":
                    case "Room":
                    case "Rooms":
                    case "room":
                    case "rooms":
                                                
                        Console.WriteLine(StandardMessages.OptionsMenuRoomTitle());
                       
                         //String array to list rooms
                        roomArray[0] = new GameRoom("Entrance", StandardMessages.KitchenDescription());
                        roomArray[1] = new GameRoom("Hall", "");
                        roomArray[2] = new GameRoom("Kitchen", "");
                        roomArray[3] = new GameRoom("Living Room", "");
                        roomArray[4] = new GameRoom("Bathroom", "");
                        roomArray[5] = new GameRoom("Bedroom", "");
                        roomArray[6] = new GameRoom("Master Bedroom", "");

                        foreach (GameRoom element in roomArray) //Displays all the elements in the array
                        {
                            Console.WriteLine($"Room Name {element.RoomName}\nRoom Desc: {element.RoomDescription}\n" +
                                $"_______________________________");
                        }
                        Console.WriteLine(StandardMessages.OptionsMenuReturn());                        
                        Console.ReadLine();

                        break;
                    case "2":
                    case "Weapon":
                    case "Weapons":
                    case "weapon":
                    case "weapons":

                        Console.WriteLine(StandardMessages.OptionsMenuWeaponsTitle());

                        string[] weapons = new string[] //String array to list weapons
                            {
                         "Knife",
                         "Pistol",
                         "Shotgun",
                         "Automatic Rifle"
                            };
                        Array.Sort(weapons);
                        foreach (var element in weapons)//Displays all the elements in the array
                        {
                            Console.WriteLine(element);

                        }
                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();
                        break;
                    case "3":
                    case "Potion":
                    case "Potions":
                    case "potion":
                    case "potions":


                        Console.WriteLine(StandardMessages.OptionsMenuPotionsTitle());

                        string[] potions = new string[] //String array to list all potions
                            {
                         "1. 100% Health",
                         "2. 50% Health"
                            };
                        foreach (var element in potions)//Displays all the elements in the array
                        {
                            Console.WriteLine(element);
                        }
                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();
                        break;
                    case "4":
                    case "Treasure":
                    case "treasure":
                    case "Treasures":
                    case "treasures":

                        Console.WriteLine(StandardMessages.OptionsMenuTreasureTitle());

                        string[] treasures = new string[] //String array to list all treasures
                            {
                        "1. Ammo Crate",
                        "2. Body Armor",
                        "3. First Aid Kit"
                            };
                        foreach (var element in treasures)//Displays all the elements in the array
                        {
                            Console.WriteLine(element);
                        }
                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();

                        break;
                    case "5":
                    case "Item":
                    case "Items":
                    case "item":
                    case "items":

                        Console.WriteLine(StandardMessages.OptionsMenuItemTitle());

                        List<string> items = new List<string>();//String List to list all items

                        items.Add("1. Map");
                        items.Add("2. Compass");
                        items.Add("3. Flashlight");
                        items.Add("4. First Aid Kit");

                        foreach (var element in items)//Displays all the elements in the list
                        {
                            Console.WriteLine(element);
                        }

                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();
                        break;
                    case "6":
                    case "Mob":
                    case "Mobs":
                    case "mobs":
                    case "mob":

                        Console.WriteLine(StandardMessages.OptionsMenuMonsterTitle());

                        mobList.Add(new Zombie("H1n1-Z", "", 5, 100));                        
                        mobList.Add(new Zombie("Corona-Z", "",7, 100));                        
                        mobList.Add(new Zombie("Rota-Z", "", 15, 100));                        
                        mobList.Add(new Zombie("Ebola-Z", "", 20, 100));                        
                        mobList.Add(new Zombie("Marburg-Z", "", 50, 100));                
                        
                        foreach (Zombie zomb in mobList)//Displays all the elements in the list
                        {
                            Console.WriteLine($"Name: {zomb.Name}\nDesc: {zomb.Description}\nAP: {zomb.AttackPoints}\nHealth: { zomb.Health}");
                        }
                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();
                        break;
                    case "7":
                    case "R":
                    case "r":
                    case "Return":
                    case "return":
                        menuOptionsLoop = true;//Exits loop and program
                        break;

                    //Default option to return to main menu after incorrect slection
                    default:
                        Console.WriteLine(StandardMessages.InvalidSelection());
                        break;
                }

            } while (menuOptionsLoop == false);
            
        }
        
    }
}
