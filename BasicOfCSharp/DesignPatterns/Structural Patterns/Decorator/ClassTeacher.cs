using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns.Decorator
{
    class ClassTeacher : TeacherType
    {
        public override string GetDesignation()
        {
            return "Class Teacher";
        }

        public override string GetName()
        {
            return Name;
        }

        public override void SetName(string name)
        {
            this.Name = name;
        }
    }
}
