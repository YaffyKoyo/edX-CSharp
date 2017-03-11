using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module5
{
    class Course
    {
        public string name { get; set; }
        public int credits { get; set; }
        public int durationInWeeks { get; set; }
        public Teacher[] teachers { get; set; }
        public Student[] students { get; set; }
    }
}
