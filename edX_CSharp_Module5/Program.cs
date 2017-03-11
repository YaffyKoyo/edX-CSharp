using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //students instantiation
            var JohnDoe1 = new Student() {
                firstName = "John",
                lastName = "Junior",
            };
            var JohnDoe2 = new Student()
            {
                firstName = "John",
                lastName = "Senior",
            };
            var JohnDoe3 = new Student()
            {
                firstName = "John",
                lastName = "Elder",
            };

            Student[] studentsArray = { JohnDoe1, JohnDoe2, JohnDoe3 };

            //teachers instantiation
            var JohnDoeT1 = new Teacher()
            {
                firstName = "John",
                lastName = "Teacherjunior"
            };
            var JohnDoeT2 = new Teacher()
            {
                firstName = "John",
                lastName = "Teachersenior"
            };
            var JohnDoeT3 = new Teacher()
            {
                firstName = "John",
                lastName = "Teacherelder"
            };

            Teacher[] teachersArray = { JohnDoeT1, JohnDoeT2, JohnDoeT3 };

            //course instantiation
            var course1 = new Course() {
                name = "Programming with C#",
                students = studentsArray,
                teachers = teachersArray
            };

            //degree instantiation
            var degree1 = new Degree() {
                name = "Bachelor",
                course = course1
            };

            //Uprogram instantiation
            var Uprogram1 = new UProgram() {
                name = "Information Technology",
                degree = degree1
            };

            Console.WriteLine($"The {Uprogram1.name} program contains the {Uprogram1.degree.name} degree");
            Console.WriteLine($"The {degree1.name} degree contains the course {degree1.course.name}");
            Console.WriteLine($"The {course1.name} course contains {course1.students.Length} student(s)");

        }
    }
}
