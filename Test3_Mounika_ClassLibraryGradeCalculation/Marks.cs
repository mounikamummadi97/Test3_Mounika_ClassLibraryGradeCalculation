using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3_Mounika_ClassLibraryGradeCalculation
{
    public interface Student_Marks
    {
        public int Telugu { get; set; }
        public int Hindi { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }



        public abstract void SetStudentMarks();
        public abstract void DisplayStudentMarks();



    }
}
