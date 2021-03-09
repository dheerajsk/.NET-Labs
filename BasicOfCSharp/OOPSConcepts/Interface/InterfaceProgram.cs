using System;

namespace OOPSConcepts.Interface
{
    class InterfaceProgram
    {
        public static void Do()
        {
            Teacher teacher = new Teacher();
            teacher.Name = "Jon Doe";
            teacher.Address = "Mumbai";
            teacher.DateOfJoining = DateTime.Today;

            Student student = new Student();
            student.Name = "Student";
            student.Address = "Pune";
            student.DateOfJoining = DateTime.Today;

            Console.WriteLine(teacher.GetInfo() + " \n" + teacher.GetTypeOfPerson());
            Console.WriteLine(student.GetInfo() + " \n" + student.GetTypeOfPerson());
        }
    }
}
