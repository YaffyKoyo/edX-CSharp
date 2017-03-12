using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module6
{
    class Student : Person
    {


        public static int count = 0;

        public Student()
        {
            count++;
        }

        public void TakeTest()
        {
            Console.WriteLine("Student is taking test.");
        }
    }
}
