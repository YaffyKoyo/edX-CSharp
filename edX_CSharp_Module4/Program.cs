using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module4
{
    public struct Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state_Province { get; set; }
        public string zip_Postal { get; set; }
        public string country { get; set; }
    }
    public struct Teacher
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state_Province { get; set; }
        public string zip_Postal { get; set; }
        public string country { get; set; }
    }
    public struct UProgram
    {
        public string name { get; set; }
        public string departmentHead { get; set; }
        public string degrees { get; set; }
    }
    public struct Degree
    {
        public string name { get; set; }
        public int creditsReq { get; set; }

    }
    public struct Course
    {
        public string name { get; set; }
        public int credits { get; set; }
        public int durationInWeeks { get; set; }
        public Teacher teacher { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentList = new Student[5];
            studentList[0].firstName = "Adam";
            studentList[0].lastName = "Lincoln";
            studentList[0].addressLine1 = "now where";
            studentList[0].addressLine1 = "else where";
            studentList[0].birthDate = new DateTime(1990, 10, 1);
            studentList[0].city = "Chicago";
            studentList[0].state_Province = "Illinois";
            studentList[0].zip_Postal = "65536";
            studentList[0].country = "United States";
            Console.WriteLine("{0} {1} is from {2},{3}, Address: Zip Code: {4}, and his/her birthday is {5}.",
                   studentList[0].firstName,
                   studentList[0].lastName,
                   studentList[0].city,
                   studentList[0].state_Province,
                   studentList[0].zip_Postal,
                   studentList[0].birthDate.ToString("dd/MM/yyyy"));
        }

    }
}
