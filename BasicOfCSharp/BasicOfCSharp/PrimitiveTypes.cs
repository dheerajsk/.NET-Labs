using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfCSharp.Types
{
    class PrimitiveTypes
    {
        public static void Do()
        {
            bool xbool = true;
            int xint = 100;
            long xlong = 100000000000000;
            short xshort = 10;
            float xfloat = 10.05f;
            double xdouble = 10001.897;
            decimal xdecimal = 87.9M;
            string xstring = "name";
            char xchar = 'c';
            object xobject = new object();

            Console.Write(xchar);
            Console.Write(xlong);
            Console.WriteLine(xstring);
            Console.WriteLine(xshort);
        }
    }
}
