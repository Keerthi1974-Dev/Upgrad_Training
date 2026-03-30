using static ConsoleApp21.Program;

namespace ConsoleApp21 //Student REcord management System
{
    internal class Program
    {

        // Declaration of record
        public record Student(int RollNumber, string Name, string Course, int Marks);

        static void Main(string[] args)
        {

            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());


            Student[] arr = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Roll Number: ");
                int roll = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();

                Console.Write("Enter Marks: ");
                int marks = int.Parse(Console.ReadLine());

                arr[i] = new Student(roll, name, course, marks);
            }


            //Displaying students
            Console.WriteLine("\nStudent Records:");
            foreach (var s in arr)
            {
                Console.WriteLine($"Roll No: {s.RollNumber} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
            }


            //Searching the student by Roll number
            Console.Write("\nEnter Roll Number to search: ");
            int searchbyId = int.Parse(Console.ReadLine());


            bool found = false;

            foreach (var s in arr)
            {
                if (s.RollNumber == searchbyId)
                {
                    Console.WriteLine($"Roll No: {s.RollNumber} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found");
            }
        }



        }
    }

