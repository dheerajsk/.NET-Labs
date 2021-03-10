using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns
{
    class India
    {
        private readonly IWorkAbroad workAbroad;

        public India(IWorkAbroad work)
        {
            workAbroad = work;
        }

        public string StartWork()
        {
            return workAbroad.DoWork();
        }
    }
}
