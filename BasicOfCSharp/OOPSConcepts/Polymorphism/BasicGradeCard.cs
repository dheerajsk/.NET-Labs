using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Polymorphism
{
    class BasicGradeCard
    {
        protected int totalMarks;

        public BasicGradeCard()
        {
            totalMarks = 0;
        }

        public virtual int getTotalMarks()
        {
            Console.WriteLine("Returning from base");
            return totalMarks;
        }
    }
}
