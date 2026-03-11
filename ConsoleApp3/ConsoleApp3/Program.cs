namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int empno;
            String ename;
            double salary;
            String job;

            Console.Write("Enter Employee Number: ");
            empno = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            ename = Console.ReadLine();

            Console.Write("Enter Salary: ");
            salary = int.Parse(Console.ReadLine());

            Console.Write("Enter Job: ");
            job = Console.ReadLine();

            Console.WriteLine("EmpNo: " + empno);
            Console.WriteLine("Ename: " + ename);
            Console.WriteLine("salary: " + salary);
            Console.WriteLine("Job: " + job);





        }
    }
}
