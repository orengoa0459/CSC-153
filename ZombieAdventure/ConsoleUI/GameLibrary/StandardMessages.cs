using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class StandardMessages
    {
        //*****************Game Menus*******************************//
        public static string DisplayMainMenu()
        {
            return "********************************************\n"+
            "*                Main Menu                 *\n"+
            "********************************************\n"+
            "*                                          *\n"+
            "*  1. Start Zombie Adventure               *\n"+
            "*  2. Settings                             *\n"+
            "*  3. Options                              *\n"+
            "*  4. Exit                                 *\n"+
            "*                                          *\n"+
            "********************************************\n"+
            "Select from the Menu -->";
        }

        public static string DisplayOptionsMenu()
        {
            return " *******************************************\n"+
            "*                Options Menu              *\n" +
            "********************************************\n" +
            "*                                          *\n" +
            "*  1. Display Rooms                        *\n" +
            "*  2. Display Weapons                      *\n" +
            "*  3. Display Potions                      *\n" +
            "*  4. Display Treasure                     *\n" +
            "*  5. Display Items                        *\n" +
            "*  6. Display Mobs                         *\n" +
            "*  7. Return to Main Menu                  *\n" +
            "*                                          *\n" +
            "********************************************\n" +
            "Select from the Menu --> ";
        }
        public static string DisplaySettingsMenu()
        {
            return " ********************************************\n" +
            "*            Settings Menu           *\n" +
            "**************************************\n" +
            "*                                    *\n" +
            "*  1. General                        *\n" +
            "*  2. Video                          *\n" +
            "*  3. Graphics                       *\n" +
            "*  4. Sound                          *\n" +
            "*  5. Controls                       *\n" +           
            "*                                    *\n" +
            "**************************************\n" +
            "Press enter to return to main menu:";
        }
        public static string CreateCharacterDirections()
        {
            return "****Instructions****\n" +
                "To create a character for Zombie Adventure you must ensure\n" +
                "you complete all tasks***. The list below explains the tasks.\n" +
                "\n" +
                "1. Create user name\n" +
                "2. Create password**\n" +
                "3. Select player Class\n" +
                "4. Select player race\n" +
                "\n" +
                "Note:\n" +
                "*** In order to proceed to the game, you must complete ALL TASKS.\n" +
                "**  Ensure you read the password instructions. Your password must fit\n" +
                "the criteria in order to proceed to the next task.\n" +
                "\n" +
                "Press enter to continue....";
        }

        public static string DisplayCreateCharacterMenu()
        {
            return
            "***************************************\n" +
            "*           Create Character          *\n" +
            "***************************************\n" +
            "*                                     *\n" +
            "*  1. Enter Name/Password             *\n" +
            "*  2. Choose Class                    *\n" +
            "*  3. Choose Race                     *\n" +
            "*  4. Display Player                  *\n" +
            "*  5. Finish                          *\n" +
            "*                                     *\n" +
            "***************************************\n" +
            "Select from the menu ==> ";           
        }
        public static string DisplaySelectPlayerClass()
        {
            return
            "***************************************\n" +
            "*             Character Class         *\n" +
            "***************************************\n" +
            "*                                     *\n" +
            "*  1. Warrior                         *\n" +
            "*  2. Mage                            *\n" +
            "*  3. Thief                           *\n" +
            "*  4. Cleric                          *\n" +
            "*  5. Exit                            *\n" +
            "***************************************\n" +
            "Select your class ==> \n" +
            "Press enter to return to main menu:";
        }
        public static string DisplaySelectPlayerRace()
        {
            return
           "***************************************\n" +
           "*             Character Race          *\n" +
           "***************************************\n" +
           "*                                     *\n" +
           "*  1. Human                           *\n" +
           "*  2. Elf                             *\n" +
           "*  3. Dwarf                           *\n" +
           "*  4. Wizard                          *\n" +
           "*  5. Exit                            *\n" +
           "***************************************\n" +
           "Select your race ==> \n" +
           "Press enter to return to main menu:";
        }
        //**************End of Game Menus*************// 
        //***************Game Titles******************//

        public static string OptionsMenuRoomTitle()
        {
            return
            "**********************************\n"+
            "*  Rooms Menu                  ***\n"+
            "**********************************\n";
        }
        public static string OptionsMenuWeaponsTitle()
        {
            return            
            "**********************************\n" +
            "*  Weapons Menu                ***\n" +
            "**********************************\n";
        }
        public static string OptionsMenuPotionsTitle()
        {
            return 
            "**********************************\n" +
            "*  Potions Menu                ***\n" +
            "**********************************\n";
        }
        public static string OptionsMenuTreasureTitle()
        {
            return 
            "**********************************\n" +
            "*  Treasure Menu               ***\n" +
            "**********************************\n"; 
        }
        public static string OptionsMenuItemTitle()
        {
            return 
            "**********************************\n" +
            "*  Item Menu                   ***\n" +
            "**********************************\n";
        }
        public static string OptionsMenuMonsterTitle()
        {
            return 
            "**********************************\n" +
            "*  Mob Menu                    ***\n" +
            "**********************************\n";
        }
        public static string OptionsMenuReturn()
        {
            return 
            "-----------------------------------\n" +
            "Press enter to return to options menu:";        
        }
        //***************End of Game Titles******************//

        //Display Password creation instructions
        public static string DisplayPasswordCreationInformation()
        {
            return "Password Creation Guidelines:\n" +
                " \n"+
                "* Your password can contain upper case, lower case, and special characters.\n"+
                "* Ensure both passwords match.\n" +
                "* Ensure your password is greater than 8 characters.\n" +
                "* Ensure password length does not exceed 15 characters.";
        }
        //Display Character movement options
        public static string CharacterMovementOptions()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //returns movement menu
            return " \u2191 Move North \n \u2193 Move South \n A. Attack \n Esc. Exit ";
        }
        public static string InvalidSelection()
        {
            return "Invalid selection!\n" +
                "Press enter to continue.";
        }
        //********Options menu object room descriptions********
        public static string EntranceDescription()
        {
            return "";
        }
        public static string HallDescription()
        {
            return "The hallway is 4ft W x 37ft L, there are five doors\n" +
                "that branch off from the hallway. The doors lead to \n " +
                "the other rooms in the house.";

        }
        public static string KitchenDescription()
        {
            return
                "The Kitchen is a 12ft W x 14ft L size area; consisting of \n" +
                "a dining table, refridgerator, oven, and a chandelier\n" +
                "that hangs above the table. It also consist of many cabinets\n " +
                "and drawers that may contain useful tools.";
        }
        public static string LivingRoomDescription()
        {
            return
                "The livingroom is a 12ft W x 15ft L, consisting of a large couch\n" +
                "recliner chair, coffe table, 2 end tables with lamps, and an\n" +
                "entertainment center with a 55inch tv.";
        }
        public static string BathroomDescription()
        {
            return "The bathroom is 12ft W x 8ft L, consist of a toilet, bathtub,\n" +
                "walkin shower, and sink. There is also a medicine cabinet, and\n " +
                "a cabinet below the sink that may contain various items.";
        }
        public static string BedRoomDescription()
        {
            return "The bedroom is 12ft W x 17ft L, consisting of a queen sized bed,\n" +
                "6 drawer dresser, nightstand with one drawer and lamp on top, and a closet\n" +
                "with various items.";
        }
        public static string MasterBedroomDescription()
        {
            return "The master bedroom is 12ft W x 20ft L, consist of a king sized bed,\n" +
                "large 9 drawer dresser, tall 8 drawer dresser, two nightstands with one\n" +
                " drawer and lamp on top, a tv mounted to the wall, and a large walkin closet."; 
        }
        //**End of Options menu object room descriptions**

        //**Options menu object Weapons descriptions**
        public static string KnifeDescription()
        {
            return "KA-BAR Combat knife, 9 inch stainless steel blade,\n" +
                "with nylon grip handle. Overall length 14.5 inches long.";
        }
        public static string PistolDescription()
        {
            return "M9 Beretta Pistol, short recoil semi-automatic,\n" +
                "single/double action pistol, uses a 15 round magazine\n" +
                "that fires 9mm rounds. Overall weight is 34.2oz, and\n" +
                "overall length is 8.5 inches. Has a mass effective range\n" +
                "of 50 meters and maximum range of 1800 meters.";
        }
        public static string ShotgunmDescription()
        {
            return "M500 Mossberg 12 gauge shotgun, 30 inch barrel,\n" +
                "with an 8 shell capacity. Overall weight is 7.2lbs and\n" +
                "overall length is 35 inches. Max effective range is\n" +
                "40 meters.";
        }
        public static string AutomaticRifleDescription()
        {
            return "M4 Carbine, gas operated, air cooled, magazine fed\n" +
                "weapon, that fires a 5.56mm round. Overall barrel length\n" +
                "14.5 inches, overall length is 33 inches with stock\n" +
                "extended(29.75 inches retracted). Overall weight is \n" +
                "6.63lbs. Max effective range is 500 meters and max range\n" +
                "is 3600 meters.";
        }
        //**End of Options menu object Weapons descriptions**

        //**Options menu object Potions descriptions**
        public static string HundredPercentHealthDescription()
        {
            return "Potion pack that replenishes 100% health.";
        }
        public static string FiftyPercentHealthDescription()
        {
            return "Potion pack that replenishes 50% health.";
        }
        //**End of Options menu object Potions descriptions**

        //**Options menu object Treasures descriptions**
        public static string AmmoCrateDescription()
        {
            return "Ammo crate that replenishes 50 rounds of \n" +
                "various ammunition.";
        }
        public static string BodyArmorDescription()
        {
            return "Body armor pack that replenishes 50% armor.";
        }
        public static string FirstAidKitDescription()
        {
            return "First aid kit that replenishes 50% health.";
        }
        //**End of Options menu object Treasures descriptions**

        //**Options menu object Items descriptions**
        public static string MapDescription()
        {
            return "Map used to guide player through the level.\n" +
                "Shows minimal detail of the area and does not \n" +
                "include potential hints or locations of zombies,\n" +
                "potions, and crates.";
        }
        public static string CompassDescription()
        {
            return "Used to guide the player through the level by\n" +
                "providing the current direction of travel.";
        }
        public static string FlashLightDescription()
        {
            return "Used to help the player find things in the dark.";
        }
        public static string FirstAidKitsDescription()
        {
            return "First aid kit that replenishes 50% health.";
        }
        //**End of Options menu object Items descriptions**

        //**Options menu object Zombie descriptions**
        public static string H1N1ZombieDescription()
        {
            return "The H1N1 Zombie is a zombie infected with\n" +
                "the H1N1 flu strain. The H1N1 strain dates back\n" +
                "to the 1918 and infected 500 million and killed\n" +
                "50 million worldwide. The current strain is a\n" +
                "mutated version that is causing people to awake\n" +
                "from the dead and attack people who are not\n" +
                "infected. The disease is transmitted by scratching\n" +
                "biting, blood and saliva contact. Once the virus is \n" +
                "contracted, it takes 10-12hrs to turn into a zombie. ";
        }
        public static string CoronaZombieDescription()
        {
            return "The Corona Zombie is a zombie infected with the\n" +
                "COVID-20 strane. The strain before it caused mass\n" +
                "devistation and hysteria accross the world. Infecting\n" +
                "and killing millions of people worldwide. COVID-20 is \n " +
                "the mutated strain of COVID-19 and causes people to awake\n" +
                "from the dead and infect others by attacking them.The\n" +
                "disease is transmitted by scratching biting, blood and\n" +
                "saliva contact. Once the virus is contracted, it takes\n" +
                "8-10hrs to turn into a zombie. "; 
        }
        public static string RotaZombieDescription()
        {
            return "The Rota Zombie is a zombie infected with the\n" +
                "Rota virus strain Z. There are many species of the\n"+
                "Rota virus, however this strain is causing people to\n"+
                "die and come back to life. They attack others who are\n" +
                "not infected.The virus is transmitted by scratching\n" +
                "biting, blood and saliva contact. Once the virus is\n" +
                "contracted, it takes 6-8hrs to turn into a zombie. ";  

        }
        public static string EbolaZombieDescription()
        { 
            return "The Ebola Zombie is a zombie infected with the Ebola \n"+
                "virus. Normally the ebola virus causes death, but the \n" +
                "the current strain is causing people to awake from the \n" +
                "dead. They prey on others who are not infected by attacking\n" +
                "them and passing the virus. The virus is transmitted by\n" +
                "scratching, biting, blood and saliva contact. Once the virus is\n" +
                "contracted, it takes 2-4hrs to turn into a zombie. ";                                  
        }
        public static string MarburgZombieDescription()
        {
            return "The Marburg Zombie is a zombie infected with the Marburg\n" +
                "virus. Those infected die within minutes and turn into zombies.\n" +
                "Though the Marburg virus was not nearly as bad as the others in the\n" +
                "past, the problem is with the speed at which those infected turn into\n" +
                "zombies. Initial infection takes only 5 minutes and death occurs \n" +
                "approximately 10 minutes after initial infection. The person infected\n" +
                "wakes from the dead approximately 5 minutes after death. They begin\n" +
                "spreading the virus by scratching, biting, and blood and saliva contact.\n" +
                "The Marburg virus is highly dangerous because it only takes 20 minutes\n" +
                "to turn.";
        }
        //**End of Options menu object Zombie descriptions**




















        public static string MovementMenu()
        {
            //Allows unicode to display in console.
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //returns movement menu
            return " \u2191 Move North   \u2193 Move South" +
                  "\n \u2192 Move East    \u2190 Move West";

        }

        public static string AttackMenu()
        {
            return "-------------------------\n" +
                   "|      Attack menu      |\n" +
                   "-------------------------\n" +
                   "|1. Attack     2.Scream |\n" +
                   "|3. Potion     4.Weapons|\n" +
                   "-------------------------\n" +
                   "Make a selection -->";
        }
    }
}
