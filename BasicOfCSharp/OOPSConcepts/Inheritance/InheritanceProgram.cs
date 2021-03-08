using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Inheritance
{
    class InheritanceProgram
    {
        public static void Do()
        {
            Subject algebra = new Subject();
            algebra.Name = "Algebra";
            Subject physics = new Subject();
            physics.Name = "Physics";

            SubjectTeacher algebraTeacher = new SubjectTeacher();
            algebraTeacher.Name = "Mr. Algebra";
            algebraTeacher.Address = "Mumbai";
            algebraTeacher.ContactAddress = "Pune";
            algebraTeacher.DateOfJoining = DateTime.Now.AddYears(-5);
            algebraTeacher.Subject = algebra;

            SubjectTeacher physicsTeacher = new SubjectTeacher();
            physicsTeacher.Name = "Mr. Physics";
            physicsTeacher.Address = "Hyderabad";
            physicsTeacher.ContactAddress = "Delhi";
            physicsTeacher.DateOfJoining = DateTime.Now.AddYears(-6);
            physicsTeacher.Subject = physics;

            ClassTeacher teacherOfClass9 = new ClassTeacher();
            teacherOfClass9.Name = "Class 9 Teacher";
            teacherOfClass9.Address = "Banglore";
            teacherOfClass9.ContactAddress = "Indore";
            teacherOfClass9.DateOfJoining = DateTime.Now.AddMonths(-10);
            teacherOfClass9.Grade = "Class 9";

            Console.WriteLine(algebraTeacher.Name + " " + algebraTeacher.Address + " " + algebraTeacher.ContactAddress + " " + algebraTeacher.DateOfJoining + " " + algebraTeacher.Subject.Name);
            Console.WriteLine(physicsTeacher.Name + " " + physicsTeacher.Address + " " + physicsTeacher.ContactAddress + " " + physicsTeacher.DateOfJoining + " " + physicsTeacher.Subject.Name);
            Console.WriteLine(teacherOfClass9.Name + " " + teacherOfClass9.Address + " " + teacherOfClass9.ContactAddress + " " + teacherOfClass9.DateOfJoining + " " + teacherOfClass9.Grade);

        }
    }
}
