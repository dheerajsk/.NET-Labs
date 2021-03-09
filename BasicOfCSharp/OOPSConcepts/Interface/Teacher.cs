using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Interface
{
    public class Teacher : IPerson
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string GetAddress()
        {
            return Address;
        }

        public string GetInfo()
        {
            return "Name: " + Name + ", Address: " + Address + ", Joining Date: " + DateOfJoining;
        }

        public string GetTypeOfPerson()
        {
            return "Teacher";
        }
    }
}
