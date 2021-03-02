using System;

namespace DataStructures
{
    class Arrays
    {
        public static void Do()
        {
            string[] students;

            students = new string[6] { "John", "Doe", "Sharma", "Dubey", "Shah", "Singh" };

            string[] subjects = new string[6];
            subjects[0] = "Math";
            subjects[1] = "Physics";
            subjects[2] = "Biology";
            subjects[3] = "Algorithms";
            subjects[4] = "Computer Networks";
            subjects[5] = "Software Engineering";

            int[] marks = new int[6];
            marks[0] = 67;
            marks[1] = 90;
            marks[2] = 71;
            marks[3] = 89;
            marks[4] = 98;
            marks[5] = 76;

            Console.WriteLine("Students are: ");
            foreach (string student in students)
            {
                Console.Write(student + "  ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Subjet and marks are");
            int total = 0;
            for (int i = 0; i < subjects.Length; i++)
            {
                total = total + marks[i];
                Console.WriteLine(subjects[i] + " - " + marks[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Total marks - " + total);
            Console.WriteLine("Total percent - " + total * 100 / 600);
        }
    }
}
