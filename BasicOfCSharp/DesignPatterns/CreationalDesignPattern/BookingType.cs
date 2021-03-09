using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern
{
    abstract class BookingType
    {
        private string mSeat;

        public abstract BookingType Clone();

        public void SetSeat(string s)
        {
            mSeat = s;
        }

        public string GetSeat()
        {
            return mSeat;
        }
    }
}
