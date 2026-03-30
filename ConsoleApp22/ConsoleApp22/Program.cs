using System;
using System.Collections.Generic;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            while (true)
            {
                Console.WriteLine("\nTo-Do List Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter task: ");
                    string task = Console.ReadLine();

                    if (task == null || task == "")
                    {
                        Console.WriteLine("Task cannot be empty");
                    }
                    else
                    {
                        tasks.Add(task);
                        Console.WriteLine("Task added!");
                    }
                }
                else if (choice == 2)
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks");
                    }
                    else
                    {
                        Console.WriteLine("Tasks:");
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + tasks[i]);
                        }
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter task number: ");
                    int number = int.Parse(Console.ReadLine());

                    if (number < 1 || number > tasks.Count)
                    {
                        Console.WriteLine("Invalid task number");
                    }
                    else
                    {
                        Console.WriteLine("Removed: " + tasks[number - 1]);
                        tasks.RemoveAt(number - 1);
                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}