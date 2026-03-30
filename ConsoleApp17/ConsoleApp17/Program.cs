using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Address object
            inheritance.Address addressObj = new inheritance.Address("15th Line", "Ameerpet", "500018");

            // Creating Employee object and passing Address
            inheritance.Employee emp = new inheritance.Employee(10144, "Narasimha", 75000, addressObj);

            // Display Employee Details
            emp.DisplayEmployee();

            Console.WriteLine("----------------------------");

            // Changing pincode
            emp.EmployeeAddress.PinCode = "500019";

            // Display updated details
            emp.DisplayEmployee();

            Console.ReadLine();
        }
    }
}