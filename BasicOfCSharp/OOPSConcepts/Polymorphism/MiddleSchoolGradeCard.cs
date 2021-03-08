using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts.Polymorphism
{
    class MiddleSchoolGradeCard : BasicGradeCard
    {
        public int Maths { get; set; }

        public int English { get; set; }

        public int SecondLanguage { get; set; }

        public int Geography { get; set; }

        public int History { get; set; }

        public MiddleSchoolGradeCard()
        {
            this.Maths = 0;
            this.English = 0;
            this.SecondLanguage = 0;
            this.Geography = 0;
            this.History = 0;
        }

        public override int getTotalMarks()
        {
            return this.Maths + this.English + this.Geography + this.SecondLanguage + this.History;
        }
    }
}
