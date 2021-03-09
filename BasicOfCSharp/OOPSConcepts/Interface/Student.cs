using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Interface
{
    class Student : IPerson
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string GetInfo()
        {
            return "Name: " + Name + ", Address: " + Address + ", Joining Date: " + DateOfJoining;
        }

        public string GetTypeOfPerson()
        {
            return "Student";
        }
    }
}
