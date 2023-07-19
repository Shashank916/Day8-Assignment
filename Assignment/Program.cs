//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to the Document Management System!");
//            Console.WriteLine("Please select an operation:");
//            Console.WriteLine("1. Create a new file");
//            Console.WriteLine("2. Read a file");
//            Console.WriteLine("3. Append to a file");
//            Console.WriteLine("4. Delete a file");

//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Enter the file name:");
//                    string createFileName = Console.ReadLine();
//                    Console.WriteLine("Enter the file content:");
//                    string createFileContent = Console.ReadLine();
//                    CreateFile(createFileName, createFileContent);
//                    break;
//                case 2:
//                    Console.WriteLine("Enter the file name to read:");
//                    string readFile = Console.ReadLine();
//                    ReadFile(readFile);
//                    break;
//                case 3:
//                    Console.WriteLine("Enter the file name to append:");
//                    string appendFileName = Console.ReadLine();
//                    Console.WriteLine("Enter the content to append:");
//                    string appendContent = Console.ReadLine();
//                    AppendToFile(appendFileName, appendContent);
//                    break;
//                case 4:
//                    Console.WriteLine("Enter the file name to delete:");
//                    string deleteFileName = Console.ReadLine();
//                    DeleteFile(deleteFileName);
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice");
//                    break;
//            }
//        }

//        static void CreateFile(string fileName, string content)
//        {
//            try
//            {
//                using (StreamWriter writer = File.CreateText(fileName))
//                {
//                    writer.Write(content);
//                }
//                Console.WriteLine("File created successfully.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error creating file: " + ex.Message);
//            }
//        }

//        static void ReadFile(string fileName)
//        {
//            try
//            {
//                string fileContent = File.ReadAllText(fileName);
//                Console.WriteLine("File content:");
//                Console.WriteLine(fileContent);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error reading file: " + ex.Message);
//            }
//        }

//        static void AppendToFile(string fileName, string content)
//        {
//            try
//            {
//                using (StreamWriter writer = File.AppendText(fileName))
//                {
//                    writer.Write(content);
//                }
//                Console.WriteLine("Content appended to the file successfully.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error appending to file: " + ex.Message);
//            }
//        }

//        static void DeleteFile(string fileName)
//        {
//            try
//            {
//                File.Delete(fileName);
//                Console.WriteLine("File deleted successfully.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error deleting file: " + ex.Message);
//            }
//        }
//    }
//}





using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new text file");
            Console.WriteLine("2. Read the content of an existing text file");
            Console.WriteLine("3. Append content to an existing text file");
            Console.WriteLine("4. Delete an existing text file");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateFile();
                    break;
                case "2":
                    ReadFile();
                    break;
                case "3":
                    AppendFile();
                    break;
                case "4":
                    DeleteFile();
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateFile()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter the file content: ");
        string content = Console.ReadLine();

        try
        {
            File.WriteAllText(fileName, content);
            Console.WriteLine("File created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while creating the file: " + ex.Message);
        }
    }

    static void ReadFile()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            try
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine("File content:\n" + content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while reading the file: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    static void AppendFile()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter the content to append: ");
        string content = Console.ReadLine();

        if (File.Exists(fileName))
        {
            try
            {
                File.AppendAllText(fileName, content);
                Console.WriteLine("Content appended successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while appending the content: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    static void DeleteFile()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            try
            {
                File.Delete(fileName);
                Console.WriteLine("File deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while deleting the file: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
