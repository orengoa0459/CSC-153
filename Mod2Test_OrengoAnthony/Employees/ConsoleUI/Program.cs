using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Date 02.10.2020
 * CSC 152
 * Anthony Orengo   
 * Description: This program gets the users name, phone number
 * and age, and diplays it.
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable to get user input 
            string input;
            //Sentry for loop
            bool exit = false;
            //Constant variable for array
            const int SIZE = 5;
            int nameIndex = 0, phoneIndex = 0;

            //Create string array to store employee name
            string [] employeeName = new string [SIZE];
            //Create string array to store employee phone number
            string[] employeePhone = new string [SIZE];
            //Create list to store employee age
            List<int> employeeAge = new List<int>();



            do
            {
                Console.WriteLine("              Main Menu ");
                Console.WriteLine("*************************************** ");
                Console.WriteLine("1. Enter employee's name.");
                Console.WriteLine("2. Enter employee's phone number.");
                Console.WriteLine("3. Enter employee's age.");
                Console.WriteLine("4. Display employee's Information");
                Console.WriteLine("5. Display average age of employee's");
                Console.WriteLine("6. Exit.");
                Console.WriteLine("--------------------------------------- ");
                
                Console.Write("-->");

                input = Console.ReadLine();
                //Switch to direct to proper process
                switch (input)
                {
                    case "1":
                        //Get employee's name
                        Console.Write("Enter employee's name -->");
                        input = Console.ReadLine();

                        employeeName[nameIndex] = input;
                        nameIndex++;

                        break;
                    case "2":
                        //Get employee's phone number
                        Console.Write("Enter employee's phone number -->");
                        input = Console.ReadLine();
                        employeePhone[phoneIndex] = input;
                        phoneIndex++;

                        break;

                    case "3":
                        //Get employees age
                        int number = 0;
                        Console.Write("Enter employee's age -->");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out number))
                        {
                            employeeAge.Add(number);
                        
                        }
                        else
                        {
                            Console.WriteLine("Not a valid number");

                        }
                        break;

                    case "4":
                        //Display employee's information
                        for(int index = 0; index < employeeAge.Count; index++)
                        {
                            Console.WriteLine("          Employee Information ");
                            Console.WriteLine("*************************************** ");
                            Console.WriteLine($"Employee name - {employeeName[index]}");
                            Console.WriteLine($"Employee Phone - {employeePhone[index]}");
                            Console.WriteLine($"Employee Age - {employeeAge[index]}");
                            Console.WriteLine(" ");  

                        }


                        break;

                    case "5":
                        //TODO Display average age of employee
                        employeeAge.Average();
                        Console.WriteLine(employeeAge.Average());
                        break;

                    case "6":
                        //exit program
                        exit = true;

                        break;

                    default:
                        //Create writeline invalid choice
                        Console.WriteLine("Not a valid choice");
                        break;


                }
            } while (exit == false);




        }
    }
}
