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
                        
                        OptionMenu();
                        break;
                    case "4":
                    case "Exit":
                    case "exit":
                    case "E":
                    case "e":
                        mainMenuLoop = true;
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(StandardMessages.InvalidSelection());
                        Console.ReadLine();
                        break;

                }
            } while (mainMenuLoop == false);

            
        }    

        public static void OptionMenu()
        {
            //Declare and initilize loop variable
            bool menuOptionsLoop = false;
            //Declare and initialize Arrays
            GameRoom[] roomArray = new GameRoom[7];
            Weapon[] weaponArray = new Weapon[4];
            Potion[] potionArray = new Potion[2];
            Treasure[] treasureArray = new Treasure[3];

            //Declare and initialize List
            List<Item> itemList = new List<Item>();
            List<Zombie> mobList = new List<Zombie>();
           
            //object[GameRoom] roomArray = new object[7];
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
                        Console.Clear();                        
                        Console.WriteLine(StandardMessages.OptionsMenuRoomTitle());                       
                         //String array to list rooms
                        roomArray[0] = new GameRoom("Entrance", StandardMessages.HallDescription());
                        roomArray[1] = new GameRoom("Hall", StandardMessages.HallDescription());
                        roomArray[2] = new GameRoom("Kitchen", StandardMessages.KitchenDescription());
                        roomArray[3] = new GameRoom("Living Room", StandardMessages.LivingRoomDescription());
                        roomArray[4] = new GameRoom("Bathroom", StandardMessages.BathroomDescription());
                        roomArray[5] = new GameRoom("Bedroom", StandardMessages.BedRoomDescription());
                        roomArray[6] = new GameRoom("Master Bedroom", StandardMessages.MasterBedroomDescription());

                        foreach (GameRoom element in roomArray) //Displays all the elements in the array
                        {
                            Console.WriteLine($"Room Name: {element.RoomName}\nRoom Description: {element.RoomDescription}\n" +
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
                        Console.Clear();
                        Console.WriteLine(StandardMessages.OptionsMenuWeaponsTitle());
                        weaponArray[0] = new Weapon("Knife", StandardMessages.KnifeDescription(), 10, 15);
                        weaponArray[1] = new Weapon("Pistol",StandardMessages.PistolDescription() , 20, 25);
                        weaponArray[2] = new Weapon("Shotgun",StandardMessages.ShotgunmDescription() , 45, 40);
                        weaponArray[3] = new Weapon("Automatic Rifle",StandardMessages.AutomaticRifleDescription() ,50,50);                    
                        //Array.Sort(weaponArray[Weapon]);
                        foreach (var element in weaponArray)//Displays all the elements in the array
                        {
                            Console.WriteLine($"Name: {element.Name}\nDescription: {element.Description}\nPower: {element.Power}\nDamage: {element.Damage}\n" +
                                $"_______________________________");
                            
                        }
                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();
                        break;
                    case "3":
                    case "Potion":
                    case "Potions":
                    case "potion":
                    case "potions":
                        Console.Clear();
                        Console.WriteLine(StandardMessages.OptionsMenuPotionsTitle());
                        potionArray[0] = new Potion("100% Health Potion", StandardMessages.HundredPercentHealthDescription(), 100);
                        potionArray[1] = new Potion("50% Health Potion", StandardMessages.FiftyPercentHealthDescription(), 50);
                       
                        foreach (var element in potionArray)//Displays all the elements in the array
                        {
                            Console.WriteLine($"Name: {element.Name}\nDescription: {element.Description}\nHealth Points: {element.HealthPoints}\n" +
                                $"_______________________________");
                            
                        }
                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();
                        break;
                    case "4":
                    case "Treasure":
                    case "treasure":
                    case "Treasures":
                    case "treasures":
                        Console.Clear();
                        Console.WriteLine(StandardMessages.OptionsMenuTreasureTitle());
                        treasureArray[0] = new Treasure("Ammo Crate", StandardMessages.AmmoCrateDescription(),  50);
                        treasureArray[1] = new Treasure("Body Armor", StandardMessages.BodyArmorDescription(), 50);
                        treasureArray[2] = new Treasure("First Aid Kit",StandardMessages.FirstAidKitDescription(), 25);
                        
                        foreach (var element in treasureArray)//Displays all the elements in the array
                        {
                            Console.WriteLine($"Name: {element.Name}\nDescription: {element.Description}\nPoints: {element.Points}\n" +
                                $"_______________________________");
                           
                        }
                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();

                        break;
                    case "5":
                    case "Item":
                    case "Items":
                    case "item":
                    case "items":
                        Console.Clear();
                        Console.WriteLine(StandardMessages.OptionsMenuItemTitle());

                        itemList.Add(new Item("Map", StandardMessages.MapDescription()));
                        itemList.Add(new Item("Compass", StandardMessages.CompassDescription()));
                        itemList.Add(new Item("Flashlight", StandardMessages.FlashLightDescription()));
                        itemList.Add(new Item("First Aid Kits", StandardMessages.FirstAidKitsDescription()));                        

                        foreach (var element in itemList)//Displays all the elements in the list
                        {
                            Console.WriteLine($"Name: {element.Name}\nDescription: {element.Description}\n" +
                                $"_______________________________");
                            
                        }

                        Console.WriteLine(StandardMessages.OptionsMenuReturn());
                        Console.ReadLine();
                        break;
                    case "6":
                    case "Mob":
                    case "Mobs":
                    case "mobs":
                    case "mob":
                        Console.Clear();
                        Console.WriteLine(StandardMessages.OptionsMenuMonsterTitle());

                        mobList.Add(new Zombie("H1n1-Z", StandardMessages.H1N1ZombieDescription(), 5, 100));                        
                        mobList.Add(new Zombie("Corona-Z", StandardMessages.CoronaZombieDescription(),7, 100));                        
                        mobList.Add(new Zombie("Rota-Z", StandardMessages.RotaZombieDescription(), 15, 100));                        
                        mobList.Add(new Zombie("Ebola-Z", StandardMessages.EbolaZombieDescription(), 20, 100));                        
                        mobList.Add(new Zombie("Marburg-Z", StandardMessages.MarburgZombieDescription(), 50, 100));                
                        
                        foreach (Zombie zomb in mobList)//Displays all the elements in the list
                        {
                            Console.WriteLine($"Name: {zomb.Name}\nDescription: {zomb.Description}\nAttack Points: {zomb.AttackPoints}\nHealth: { zomb.Health}\n" +
                                $"_______________________________");
                            
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
                        Console.ReadLine();
                        break;
                }

            } while (menuOptionsLoop == false);
            
        }
        
    }
}
