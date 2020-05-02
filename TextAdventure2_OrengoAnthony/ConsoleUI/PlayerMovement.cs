using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class PlayerMovement
    {
        public static void CharacterMovement()
        {

            bool loop = false;//Declare and initialize sentinel
            int roomNum = 0; //Declare and initilize index variable
            string movementStatus = ""; //Declare and initilize movement status variable
            //Allows unicode to display in console.
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //string hi = "Welcome to the start";
            string choice;

            //Declare and intialize roomLocation array
            int[] roomLocation = new int[]
             {

                1,2,3,4,5,6
                
             };
            ConsoleKeyInfo keyboard;
            do
            {
                //Default player movement menu
                Console.WriteLine("ZOMBIE ADVENTURE");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Player " );//Display player name
                Console.WriteLine("Health: " );//Display player health
                Console.WriteLine("Coins: " );//Display player coins
                Console.WriteLine("Current Location: " + roomLocation[roomNum]); //Display players current location
                Console.WriteLine("Movement Status: " +movementStatus);//Displays player movement staus 
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(PlayerMovementOptions.MovementOptions.move()); //Displays player movement menu
                Console.WriteLine("----------------------------------------------");
                Console.Write("Make a selection -->");
                
                //Get input from user by using keyboard
                keyboard = Console.ReadKey();
                //To control flow of movement through the array
                switch (keyboard.Key)
                {

                    case ConsoleKey.DownArrow:
                        //Decreases the array index number(roomNum) to move through the array
                        if (roomNum > 0)
                        {
                            roomNum--;
                            Console.WriteLine("Current Location: " + roomLocation[roomNum]);
                            movementStatus = "";
                        }
                        //If roomNum equals zero display you went to far. Controls the array boundary.
                        else if (roomNum == 0)
                        {

                            movementStatus = "You went to far!";
                            Console.WriteLine("Current Location: " + roomLocation[roomNum]);
                            
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        //If roomNum equals 5 display you went to far. Controls the array boundary.
                        if (roomNum >= 0)
                        {
                            if (roomNum == 5)
                            {
                                movementStatus = "You went to far!";
                                Console.WriteLine("Current Location: " + roomLocation[roomNum]);

                            }
                            //Increases the array index number(roomNum) to move through the array 
                            else if (roomNum >= 0)
                            {
                                roomNum++;
                                movementStatus = "";
                                Console.WriteLine("You are in the: " + roomLocation[roomNum]);
                                Console.WriteLine("Keep going");
                            }

                        }
                        break;
                    case ConsoleKey.A:
                        //Gets random attack number and displays it to the user
                        int attack = 0;
                        Console.WriteLine("\nYou chose to attack the Zombie");
                        Console.WriteLine("-------------------------------------");
                        ZombieAttack.GenerateRandomAttackNumber(ref attack);
                        Console.WriteLine("Total damage: " + attack);
                        Console.WriteLine(" " +
                            "");
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();

                        Console.Clear();
                        break;
                    case ConsoleKey.Escape:
                       
                        //Ends program
                        Console.Clear();
                        Console.WriteLine("Good Bye!");
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        loop = true;


                        break;

                    default:
                        //Display invalid choice if user inputs something not on the menu
                        Console.WriteLine("Invalid choice!");
                        
                        break;
                }
                //Clears the current screen
                Console.Clear();


            } while (loop == false);

        }

    }
}
