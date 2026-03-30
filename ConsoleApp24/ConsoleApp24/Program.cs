using System;
using System.IO;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\Upgrad_.NET\sample.txt.txt";
           // "F:\Upgrad_.NET\sample.txt.txt"

            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);

                Console.WriteLine(fileInfo.Name);
                Console.WriteLine(fileInfo.FullName);
                Console.WriteLine(fileInfo.CreationTime);
                Console.WriteLine(fileInfo.Length);
            }
            else
            {
                Console.WriteLine("File not found!");
            }

            Console.WriteLine("------------------------------------");

            DirectoryInfo dio = new DirectoryInfo(@"F:\Upgrad_.NET");

            if (dio.Exists)
            {
                Console.WriteLine("Creation Time : {0}", dio.CreationTime);
                Console.WriteLine("Parent folder : {0}", dio.Parent);
                Console.WriteLine("Root folder   : {0}", dio.Root);
                Console.WriteLine("No. of Files  : {0}", dio.GetFiles().Length);
                Console.WriteLine("No. of Directories : {0}", dio.GetDirectories().Length);
            }
            else
            {
                Console.WriteLine("Directory not found!");
            }

            Console.WriteLine("-----------------------------------------");

            DriveInfo di = new DriveInfo("F");

            Console.WriteLine(di.DriveType);
            Console.WriteLine(di.TotalSize);
            Console.WriteLine(di.AvailableFreeSpace);

            Console.ReadLine();
        }
    }
}