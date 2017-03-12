using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module7
{
    class Teacher : Person
    {

        public static int count = 0;

        public Teacher()
        {
            count++;
        }

        public void GradeTest()
        {
            Console.WriteLine("Teacher is grading test.");
        }
    }
}
