using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behaviroal_Patterns.TemplateMethod
{
    class Car : Transport
    {
        public override string MoveForward()
        {
            return "Put gear and accelerate";
        }

        public override string StartEngine()
        {
            return "Turn key for ignition";
        }

        public override string StopEngine()
        {
            return "Stop the engine";
        }
    }
}
