using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
namespace ConsoleUI
{
    class Program
    {
        public static List<Employee> employeeInfo = new List<Employee>();
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
            string[] employeeName = new string[SIZE];
            //Create string array to store employee phone number
            string[] employeePhone = new string[SIZE];
            //Create list to store employee age

            int index = 0;
            do
            {
                //Displays main menu
                Console.Write(EmployeeLibrary.StandardMessages.DisplayMainMenu());
                input = Console.ReadLine();
                //Switch to direct to proper process
                switch (input)
                {
                    case "1":
                        //Get employee's info
                        EnterEmployeeInformation(ref employeeInfo, input, index);
                        index++;
                        break;
                    case "2":
                        //Display employee's information
                        DisplayEmployee(ref employeeInfo);
                        break;
                    case "3":
                        //TODO Display average age of employee                       

                        break;
                    case "4":
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
        public static void EnterEmployeeInformation(ref List<Employee> employeeData, string input, int index)
        {
            //Get employee information and store in list
            int number = 0;

            Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesName());
            input = Console.ReadLine();
            employeeData.Add(new Employee());
            employeeData[index].Name = input;
            Console.Write(EmployeeLibrary.StandardMessages.GetPhoneNumber());
            input = Console.ReadLine();
            employeeData[index].PhoneNumber = input;
            Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesAge());
            number = int.Parse(Console.ReadLine());
            employeeData[index].Age = number;
        }

        public static void DisplayEmployee(ref List<Employee> employeeInfo)
        {
            //Display employee's information
            foreach (Employee employData in employeeInfo)
            {
                Console.WriteLine($"Name: {employData.Name} Phone Number: {employData.PhoneNumber} Age: {employData.Age}");
            }
            Console.ReadLine();
        }

        public static void DisplayAverageAge(ref List<int> age)
        {

        }
    }
}
