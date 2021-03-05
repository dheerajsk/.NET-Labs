using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts
{
    class StructProgram
    {
        public static void Do()
        {
            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Name = "Name: " + i.ToString();
                students[i].Address = "Address: " + i.ToString();
                students[i].RollNumber = i;
                students[i].ClassName = "ClassName: " + i.ToString();
                students[i].DateOfBirth = DateTime.Now.AddYears(-25);
            }
            foreach (Student student in students)
            {
                Console.Write(student.Name + ", ");
                Console.Write(student.Address + ", ");
                Console.Write(student.RollNumber + ", ");
                Console.Write(student.ClassName + ", ");
                Console.Write(student.DateOfBirth + ", ");
                Console.WriteLine("\n=============");
            }
        }
    }

    struct Student
    {
        public string Name;
        public string Address { get; set; }

        public int RollNumber;
        public string ClassName;
        public DateTime DateOfBirth;
    }
}
