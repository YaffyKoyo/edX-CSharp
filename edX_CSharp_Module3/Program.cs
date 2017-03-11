using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module3
{
    class Program
    {


        static void Main(string[] args)
        {
            //GetStudentInformation();
            GetInformationExpStudent();
        }

        //date validation part
        static void dataValidation(int day, int month, int year)
        {
            throw new NotImplementedException();
        }

        //Student Information
        #region
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Birth date (DD, MM, YYYY) ");
            Console.Write("Day: "); int day = int.Parse(Console.ReadLine());
            Console.Write("Month: "); int month = int.Parse(Console.ReadLine());
            Console.Write("Year: "); int year = int.Parse(Console.ReadLine());
            try { dataValidation(day, month, year); }
            catch (NotImplementedException notImp) {
                Console.WriteLine(notImp.Message);
            }
            DateTime birthDate = new DateTime(year, month, day);
            string birthDate_str =birthDate.ToString("dd/MM/yyyy");
            PrintStudentDetails(firstName, lastName, birthDate_str);
        }

        

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
        #endregion

        //Get other Information
        #region
        static void GetInformationExpStudent() {
            GetTeacherInformation();
            GetCourseInformation();
            GetUprogramInformation();
            GetDegreeInformation();
        }
        #endregion

        //Teacher Information
        #region
        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Birth date (DD, MM, YYYY) ");
            Console.Write("Day: "); int day = int.Parse(Console.ReadLine());
            Console.Write("Month: "); int month = int.Parse(Console.ReadLine());
            Console.Write("Year: "); int year = int.Parse(Console.ReadLine());
            try { dataValidation(day, month, year); }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
            DateTime birthDate = new DateTime(year, month, day);
            string birthDate_str = birthDate.ToString("dd/MM/yyyy");
            PrintTeacherDetails(firstName, lastName, birthDate_str);
        }
        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
        #endregion

        //Course Information
        #region 
        static void GetCourseInformation() {
            Console.WriteLine("Enter the Course Name:");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the Course's Credits:");
            int credits = int.Parse(Console.ReadLine());
            string credits_str = credits.ToString();
            Console.WriteLine("Enter the Course's Duration in Weeks:");
            int duration = int.Parse(Console.ReadLine());
            string duration_str = duration.ToString();
            PrintCourseInformation(courseName, credits_str, duration_str);
        }
        static void PrintCourseInformation(string courseName, string credits, string duration) {
            Console.WriteLine("{0} has {1} credits and lasts {2} weeks.", courseName, credits,duration);
        }
        #endregion

        //Uprogram Information
        #region
        static void GetUprogramInformation()
        {
            Console.WriteLine("Enter the Program name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the Department Head: ");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Enter the degrees:");
            string degrees = Console.ReadLine();
            PrintUprogramInformation(programName, departmentHead,degrees);
        }

        static void PrintUprogramInformation(string programName, string departmentHead, string degrees)
        {
            Console.WriteLine("{0} is directed by {1} and it is {2} degrees.",programName,departmentHead,degrees);
        }
        #endregion

        //Degree Information
        #region
        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the Degree name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the Credits Required: ");
            string creditsRequired = Console.ReadLine();

            PrintDegreeInformation(degreeName, creditsRequired);
            
        }

        static void PrintDegreeInformation(string degreeName, string creditsRequired)
        {
            Console.WriteLine("Degree {0} needs {1} credits.", degreeName, creditsRequired);
        }

        #endregion 
    }
}
