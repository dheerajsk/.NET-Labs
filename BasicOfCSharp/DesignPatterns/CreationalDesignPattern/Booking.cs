using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern
{
    class Booking : BookingType
    {
        public override BookingType Clone()
        {
            return this;
        }
    }
}
