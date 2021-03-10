using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns.Decorator
{
    class SeniorSchoolClassTeacher : ClassTeacher
    {
        public override string GetDesignation()
        {
            string baseValue = base.GetDesignation();
            return baseValue + " of Senior School";
        }
    }
}
