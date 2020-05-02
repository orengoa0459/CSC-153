using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Date 03.02.2020
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
                Console.Write(EmployeeLibrary.StandardMessages.DisplayMenu());                
                Console.Write("-->");
                input = Console.ReadLine();
                //Switch to direct to proper process
                switch (input)
                {
                    case "1":
                        //Get employee's name
                        Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesName());
                        input = Console.ReadLine();
                        EnterName(ref employeeName, ref nameIndex, input);
                        break;
                    case "2":
                        //Get employee's phone number
                        Console.Write(EmployeeLibrary.StandardMessages.GetPhoneNumber());
                        input = Console.ReadLine();
                        EnterNumber(ref employeePhone, ref phoneIndex, input);
                        break;

                    case "3":
                        //Get employees age
                        Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesAge());
                        input = Console.ReadLine();
                        EnterAge(ref employeeAge, input);
                        break;

                    case "4":
                        //Display employee's information

                        DisplayEmployee(ref employeeName, ref employeePhone, ref employeeAge);

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
                        EmployeeLibrary.StandardMessages.InvlaidNumber();
                        break;


                }
            } while (exit == false);




        }
        public static void EnterName(ref string[] name, ref int index, string input)
        {            
            name[index] = input;
            index++;
        }

        public static void EnterNumber(ref string[] phone, ref int index, string input)
        {
            phone[index] = input;
            index++;
        }


        public static void EnterAge(ref List<int> age, string input)
        {
            int number = 0;
            
            if (int.TryParse(input, out number))
            {
                age.Add(number);
            }
            else
            {
                Console.WriteLine("Not a valid number");

            }

        }
        public static void DisplayEmployee(ref string[] name, ref string[] phone, ref List<int> age)
        {
            //Display employee's information
            for (int index = 0; index < age.Count; index++)
            {
                Console.Write(EmployeeLibrary.StandardMessages.DisplayEmployeesInformation(name, phone, age, index));

            }
        }

        public static void DisplayAverageAge(ref List<int> age)
        {
            //Display average age
            age.Average();
            Console.WriteLine(age.Average());
        }
    }
}
