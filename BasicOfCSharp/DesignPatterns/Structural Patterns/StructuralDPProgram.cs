using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns
{
    class StructuralDPProgram
    {
        public static void Do()
        {
            Console.WriteLine(" == Adapter Pattern == ");
            India india = new India(new WorkAbroad());
            Console.WriteLine(india.StartWork());
        }
    }
}
