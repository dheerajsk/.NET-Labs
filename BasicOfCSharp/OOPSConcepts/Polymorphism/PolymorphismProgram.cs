using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Polymorphism
{
    class PolymorphismProgram
    {
        public static void Do()
        {
            ElementarySchoolGradeCard elementary = new ElementarySchoolGradeCard();
            elementary.Maths = 90;
            elementary.English = 80;
            elementary.SocialScience = 78;
            elementary.SecondLanguage = 87;
            Console.WriteLine("Total Marks for Elementary School= " + elementary.getTotalMarks());

            MiddleSchoolGradeCard middle = new MiddleSchoolGradeCard();
            middle.Maths = 76;
            middle.History = 89;
            middle.SecondLanguage = 45;
            middle.Geography = 75;
            middle.SecondLanguage = 65;
            Console.WriteLine("Total Marks for Middle School=" + middle.getTotalMarks());
        }
    }
}
