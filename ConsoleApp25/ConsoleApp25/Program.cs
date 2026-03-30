using System.IO;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter folder path:");
            string dirName = Console.ReadLine();

            try
            {
                string[] files = Directory.GetFiles(dirName);

                int count = 0;

                Console.WriteLine("\nFile Details:\n");

                foreach (string file in files)
                {
                    FileInfo Info = new FileInfo(file);

                    Console.WriteLine("File Name   : " + Info.Name);
                    Console.WriteLine("File Size   : " + Info.Length + " bytes");
                    Console.WriteLine("Created On  : " + Info.CreationTime);
                    Console.WriteLine("-----------------------------");

                    count++;
                }

                Console.WriteLine("\nTotal Files: " + count);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: Directory not found!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Access denied!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nProgram execution completed.");
            }


            // 4.-----------------------------all projects inside the project directory---------------------------------


            try
            {
                Console.Write("Enter root directory path: ");
                string path = Console.ReadLine();

                DirectoryInfo Dir = new DirectoryInfo(path);

                if (Dir.Exists == false)
                {
                    Console.WriteLine("Directory does not exist!");
                    return;
                }

                DirectoryInfo[] sub = Dir.GetDirectories();

                Console.WriteLine("\n Number of Subdirectories and Files:\n");

                foreach (DirectoryInfo dir in sub)
                {
                    try
                    {
                        FileInfo[] files = dir.GetFiles();
                        Console.WriteLine($"Folder: {dir.Name}");
                        Console.WriteLine($"Number of files: {files.Length}\n");
                    }
                    catch (UnauthorizedAccessException)
                    {

                        Console.WriteLine("Access Denied!\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nProgram execution completed.");
            }

            //------------------------------------ 5.Disk storage and identify drives running out of space-------------------------------

            //        try
            //        {

            //            DriveInfo[] drives = DriveInfo.GetDrives();

            //            Console.WriteLine("\nDisk Storage");


            //            foreach (DriveInfo drive in drives)
            //            {

            //                if (drive.IsReady)
            //                {
            //                    Console.WriteLine($"Drive Name: {drive.Name}");
            //                    Console.WriteLine($"Drive Type: {drive.DriveType}");

            //                    long totalSize = drive.TotalSize;
            //                    long freeSpace = drive.AvailableFreeSpace;

            //                    Console.WriteLine($"Total Size: {totalSize / (1024 * 1024 * 1024)} GB");
            //                    Console.WriteLine($"Free Space: {freeSpace / (1024 * 1024 * 1024)} GB");


            //                    double free = (freeSpace * 100.0) / totalSize;
            //                    Console.WriteLine($"Free Space %: {free:F2}%");


            //                    if (free < 15)
            //                    {
            //                        Console.WriteLine("disk  space is Low!");
            //                    }

            //                    Console.WriteLine("-----------------------------------");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Drive {drive.Name} is not ready.");
            //                    Console.WriteLine("-----------------------------------");
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Error: " + ex.Message);
            //        }
            //        finally
            //        {

            //         Console.WriteLine("\nProgram execution completed.");


            //        }


        }
      }
    }




    

