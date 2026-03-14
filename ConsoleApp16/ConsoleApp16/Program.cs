namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee(101, "Marko Horvat", 4500, 35);


            Console.WriteLine("Employee ID : " + employee.EmployeeId);
            Console.WriteLine("Full Name   : " + employee.FullName);
            Console.WriteLine("Age         : " + employee.Age);
            Console.WriteLine("Salary      : " + employee.Salary);


            employee.GiveRaise(20);
            Console.WriteLine("Updated Salary: " + employee.Salary);



             bool result = employee.DeductPenalty(300);

            if (result)
            {
                Console.WriteLine("Penalty applied!");
            }
            else
            {
                Console.WriteLine("Penalty could not be applied");
            }

            Console.WriteLine("Final Salary: " + employee.Salary);




        }
    }
}
