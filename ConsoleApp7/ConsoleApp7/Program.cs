namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine()!);

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid Marks");
            }
            else if (marks >= 90)
            {
                Console.WriteLine("Student: " + name + " got Grade: A");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Student: " + name + " got Grade: B");
            }
            else if (marks >= 65)
            {
                Console.WriteLine("Student: " + name + " got Grade: C");
            }
            else if (marks >= 55)
            {
                Console.WriteLine("Student: " + name + " got Grade: D");
            }
            else
            {
                Console.WriteLine("Student: " + name + " got Failed!");



            }


            }
    }
}
