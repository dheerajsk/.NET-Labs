using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behaviroal_Patterns.TemplateMethod
{
    class Plane : Transport
    {
        public override string MoveForward()
        {
            return "Pull yoke back and thurst engines to take off";
        }

        public override string StartEngine()
        {
            return "Start engines";
        }

        public override string StopEngine()
        {
            return "Push yoke down and wheels down and land the plane";
        }
    }
}
