using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Polymorphism
{
    class ElementarySchoolGradeCard : BasicGradeCard
    {
        public int Maths { get; set; }

        public int English { get; set; }

        public int SecondLanguage { get; set; }

        public int SocialScience { get; set; }

        public ElementarySchoolGradeCard()
        {
            this.Maths = 0;
            this.English = 0;
            this.SocialScience = 0;
            this.SecondLanguage = 0;
        }

        public override int getTotalMarks()
        {
            this.totalMarks = this.Maths + this.English + this.SocialScience + this.SecondLanguage;
            return base.getTotalMarks();
        }
    }
}
