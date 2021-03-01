using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOfCSharp
{
    class DateProgram
    {
        public static void Do()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.AddDays(5));

            Console.WriteLine("Formatted custom date strings");
            Console.WriteLine(dt.ToString("d"));
            Console.WriteLine(dt.ToString("D"));
            Console.WriteLine(dt.ToString("F"));
            Console.WriteLine(dt.ToString("y"));

            DateTime dt2 = new DateTime(2021, 3, 2, 09, 57, 10);
            TimeSpan time = dt.Subtract(dt2);
            Console.WriteLine("Timespan between two dates is {0} hours", time);

        }
    }
}
