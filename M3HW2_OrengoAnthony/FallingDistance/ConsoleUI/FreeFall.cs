using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class FreeFall
    {

        public static void FreeFallCalculator()
        {
            // declare and initialize sentinel for loop
            bool keep_going = false;

            //Constant variable
            decimal g = 9.8m;

            //Declare variables
            string input; //Gets input from user
            decimal h; // Variable to represent total meters
            decimal t; // Variable to represent time
            decimal minutes;//Used to convert minutes to seconds (minutes = m * 60)
            decimal m; // Used in coversion formula to calculate minutes to seconds)
            decimal seconds; // Used in formula to calculate total seconds(t = minutes + seconds)

            do
            {
                //Display main menu 
                Console.WriteLine("***********************************************");
                Console.WriteLine("*                  Main Menu                  *");
                Console.WriteLine("***********************************************");
                Console.WriteLine("* 1. Free Fall Calculator using seconds       *");
                Console.WriteLine("* 2. Free Fall Calculator using minutes/sec   *");
                Console.WriteLine("* 3. Exit                                     *");
                Console.WriteLine("*                                             *");
                Console.WriteLine("***********************************************");

                //Get input from user
                Console.Write("Make a selection --> ");
                input = Console.ReadLine();
                switch (input)
                {

                    case "1":
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("***************************************");
                            Console.WriteLine("* Free Fall Calculator using seconds  *");
                            Console.WriteLine("***************************************");
                            Console.WriteLine(" ");
                            //Get input from user
                            Console.Write("Enter time of falling in seconds --> ");
                            input = Console.ReadLine();

                            //Convert input to decimal
                            t = decimal.Parse(input);
                            //Formula to determine total distance of falling object
                            h = .5m * g * (t * t);

                            //Display the total seconds and distance fallen
                            Console.WriteLine(" ");
                            Console.WriteLine("Total seconds: " + input + "s");
                            Console.WriteLine("Total distance fallen: " + h + " Meters");

                            Console.WriteLine("----------------------------------- ");
                            //Return to main menu 
                            Console.WriteLine("Press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("******************************************");
                            Console.WriteLine("* Free Fall Calculator using minutes/sec *");
                            Console.WriteLine("******************************************");
                            Console.WriteLine(" ");
                            //Get minutes from user
                            Console.Write("Enter minutes --> ");
                            input = Console.ReadLine();
                            //Convert input to decimal
                            m = decimal.Parse(input);
                            //Converts minutes to seconds
                            minutes = m * 60;
                            //Get seconds from user
                            Console.Write("Enter seconds --> ");
                            input = Console.ReadLine();
                            seconds = decimal.Parse(input);
                            //Add minutes and seconds to get total time in seconds
                            t = minutes + seconds;

                            //Formula to determine total distance of falling object
                            h = .5m * g * (t * t);

                            //Display the total seconds and distance fallen
                            Console.WriteLine(" ");
                            Console.WriteLine("Total time: " + m + "min " + seconds + "s");
                            Console.WriteLine("Total distance fallen: " + h + " Meters");

                            Console.WriteLine("----------------------------------- ");
                            //Return to main menu 
                            Console.WriteLine("Press Enter to return to Main Menu");
                            Console.ReadLine();
                            break;
                        }

                    case "3":
                        {
                            //Ends the loop and program
                            keep_going = true;

                            break;
                        }

                    default:
                        {
                            //Used for invalid selection from main menu
                            Console.WriteLine(" ");
                            Console.WriteLine("Invalid selection!");
                            Console.WriteLine(" ");

                            break;
                        }
                }

                //Keeps the loop going until user inputs exit selection
            } while (keep_going == false);

        }
    }
}
