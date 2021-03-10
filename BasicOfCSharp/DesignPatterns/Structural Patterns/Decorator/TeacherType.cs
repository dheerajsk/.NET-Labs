using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns.Decorator
{
    abstract class TeacherType
    {
        protected string Name;
        public abstract void SetName(string name);
        public abstract string GetName();
        public abstract string GetDesignation();
    }
}
