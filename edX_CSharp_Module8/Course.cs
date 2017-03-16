using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module8
{
    class Course
    {
        public string name { get; set; }
        public int credits { get; set; }
        public int durationInWeeks { get; set; }
        public Teacher[] teachers { get; set; }
        public List<Student> students_list = new List<Student>();


        public void ListStuddents() {
            //just make it easier to tell the explicit cast
            foreach (Student stu in students_list) {
                Console.WriteLine($"{stu.firstName}, {stu.lastName}");
            }
        }
    }
}
