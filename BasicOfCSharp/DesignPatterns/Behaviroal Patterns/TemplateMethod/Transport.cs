using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behaviroal_Patterns.TemplateMethod
{
    abstract class Transport
    {
        public abstract string StartEngine();
        public abstract string MoveForward();
        public abstract string StopEngine();

        public string run()
        {
            string value = "";
            value += StartEngine() + "\n" + MoveForward() + "\n" + StopEngine();
            return value;
        }
    }
}
