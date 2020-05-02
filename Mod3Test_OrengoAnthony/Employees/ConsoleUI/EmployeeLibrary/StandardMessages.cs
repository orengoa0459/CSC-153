using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public static class StandardMessages
    {
        public static string DisplayMenu()
        {

            return "1. Enter employee's name.\n2. Enter employee's phone number.\n3. Enter employee's age." +
                "\n4. Display employee's Information\n5. Display average age of employee's\n6. Exit.\nEnter a choice ";

        }
        //Message to get user name
        public static string GetEmployeesName()
        {
            return "Enter employees name -->";
        }

        //Message to get user phone number
        public static string GetPhoneNumber()
        {
            return "Enter employees phone number -->";

        }

        //Message to get user age
        public static string GetEmployeesAge()
        {
            return "Enter employees Age -->";

        }
        //Message to display employee information
        public static string DisplayEmployeesInformation(string[] name, string[] phone, List<int> age, int index)
        {
            return $"Employee Information\n---------------------" +
                $" \nEmployee name - {name[index]}\n" +
                $"Employee Phone - {phone[index]}\n" +
                $"Employee Age - {age[index]}\n\n";

        }
        //Message to display average employee age
        public static string DisplayAverageAge()
        {
            return "Average employee age";

        }
        public static string InvlaidNumber()
        {
            return "Not a valid number!";
        }
    }
}
