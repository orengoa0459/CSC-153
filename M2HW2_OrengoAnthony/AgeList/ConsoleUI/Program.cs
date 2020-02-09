/**
* 02.06.2020
* CSC 153
* Anthony Orengo
* Program description: This program gets the user to input a set number of ages
* and then places them into a list. The list ages is then displayed to include the 
* average age from the inputted numbers;
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {

        //------------Beginning of main method-------------------------//

        //Displays program menu
        static void Main(string[] args) {
            menu();
        }

        static void menu()
        {        
            //Displays menu item choices for the program
            Console.WriteLine("Welcome to the Age Program");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Run the Age Program");
            Console.WriteLine("2. Display Pseudocode");
            Console.WriteLine("3. Exit Program");
            Console.WriteLine("===============================");
            Console.WriteLine("Enter a choice from the menu:");

            //Converts variable choice from string to int 
            int choice = Int32.Parse(Console.ReadLine());
            
            //Declare and initialize while loop variable
            int keep_going = 0;
            
            while(keep_going == 0)
            {
                //Starts the ageProgram method
                if (choice == 1)
                {
                    ageProgram();                   
        
                }
                if (choice == 2)
                {
                    //Displays Pseudocode for the program
                    Console.WriteLine("Pseudocode");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("1. Create choice menu in main method.");
                    Console.WriteLine("2. Declare int variables (choice  and keep_going) for while loop.");
                    Console.WriteLine("3. Create decision structure within while loop using if statement." +
                                            "ex: if(choice==1)");
                    Console.WriteLine("4. Get users choice from menu.");
                    Console.WriteLine("5. Create separate method called ageProgram.");
                    Console.WriteLine("6. Get number of ages from user.");
                    Console.WriteLine("7. Declare and initialize variable called (number) to parse users input");
                    Console.WriteLine("8. Declare and initialize integer List called (ageList)");
                    Console.WriteLine("9. Declare and initialize loop to get list of ages from user");
                    Console.WriteLine("9a.  * for(int i = 1; i <= number; i++) ");
                    Console.WriteLine("10. Display list of ages to user using a foreach loop");
                    Console.WriteLine("11. Calculate the average age using (double average = ageList.Average()); ");
                    Console.WriteLine("12. Display the average age to the user");
                    Console.WriteLine("13. End programusing System.Environment.Exit(0);");
                    Console.WriteLine("==============================================================");

                    //Get user to enter a choice to return to main menu or exit
                    Console.WriteLine("Return to main menu:");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("1. yes");
                    Console.WriteLine("2. No");
                    Console.WriteLine("Enter a choice:");
                    int choice1 = Int32.Parse(Console.ReadLine());
                    if (choice1 == 1)
                    {
                        menu();
                    }
                    else if (choice1 == 2)
                    {
                        System.Environment.Exit(0);

                    }

                }                

                //Ends while loop and program
                else if(choice == 3)
                {
                    keep_going++;
                    Console.WriteLine("Press Enter to Exit.");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }

            }//End of while loop               

        }
        //===============End of main method ==============================//  

       //------------Beginning of ageProgram method-------------------------//
        static void ageProgram()
        {

            //Get number of ages user wants to input
            Console.WriteLine("How many ages would you like to enter: ");            
            int number = int.Parse(Console.ReadLine());
            List<int> ageList = new List<int>(number)
            {

            };
            
            //For loop to get ages from user
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine("Enter an age: ");
                int age = int.Parse(Console.ReadLine());
                ageList.Add(age);
                
            }

            //Displays all the elements in ageList
            Console.WriteLine("Your ages are");
            foreach (var element in ageList)
            {
                Console.WriteLine(element);                
            }
            
            //Get average age from the ageList and display it
            double average = ageList.Average();
            Console.WriteLine("The average age is: " + average);
           
            //Exits program 
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            System.Environment.Exit(0);

        }//===============End of ageProgram ==============================//               
        

    }//End of class program

}//End of namspace



