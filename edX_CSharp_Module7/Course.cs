using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module7
{
    class Course
    {
        public string name { get; set; }
        public int credits { get; set; }
        public int durationInWeeks { get; set; }
        public Teacher[] teachers { get; set; }
        //public Student[] students { get; set; }
        public ArrayList Students = new ArrayList();

        public void ListStuddents() {
            //just make it easier to tell the explicit cast
            foreach (System.Object stu in Students) {
                Console.WriteLine($"{((Student)stu).firstName}, {((Student)stu).lastName}");
            }
        }
    }
}
