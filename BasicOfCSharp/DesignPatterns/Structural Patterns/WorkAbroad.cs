using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural_Patterns
{
    class WorkAbroad : IWorkAbroad
    {
        readonly China _china = new China();
        public string DoWork()
        {
            return _china.StartWork();
        }
    }
}
