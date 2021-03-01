using System;
using System.Collections.Generic;
using System.IO;

namespace BasicOfCSharp
{
    class FileProgram
    {
        public static void Do()
        {
            //WriteText();
            //ReadText();
            WriteLine();
            AppendLine();
            ReadLine();
            Delete();
        }

        private static void AppendLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
                List<string> list = new List<string>();
                list.Add("This is line five");
                list.Add("This is line six");
                list.Add("This is line seven");
                File.AppendAllLines(filename, list);
            }
        }

        private static void Delete()
        {
            Console.WriteLine("Deleting file...");
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
                File.Delete(filename);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            Console.WriteLine("File deleted");
        }

        private static void WriteLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }

            StreamWriter wrt = File.CreateText(filename);
            wrt.WriteLine("This is line one");
            wrt.WriteLine("This is line two");
            wrt.WriteLine("This is line three");
            wrt.WriteLine("This is line four");
            wrt.Close();
            Console.WriteLine("Content lines have been added into file");
        }

        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
                string[] contents = File.ReadAllLines(filename);
                foreach (var content in contents)
                {
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }


        private static void WriteText()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            Console.WriteLine(filename);
            if (!File.Exists(filename))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("File exists");
            }
            string content = "This is a test content";
            File.WriteAllText(filename, content);
            Console.WriteLine("Content is written into file");
        }

        private static void ReadText()
        {
            string dir = Directory.GetCurrentDirectory();
            string path = dir + "\\Content.txt";
            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("File exists");
                string content = File.ReadAllText(path);
                Console.WriteLine(content);
            }
        }
    }
}
