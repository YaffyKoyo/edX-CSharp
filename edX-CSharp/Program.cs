using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strudents infos
            string firstName;
            string lastName;
            DateTime Birthdate;
            int day;
            int month;
            int year;
            string addressLine1;
            string addressLine2;
            string City;
            string State;
            string Postal;
            string Country;

            Console.WriteLine("Type in the infos here");
            Console.Write("First Name: "); firstName = Console.ReadLine();
            Console.Write("Last Name: "); lastName = Console.ReadLine();
            Console.WriteLine("Birthdate (DD, MM, YYYY) ");
            Console.Write("Day: "); day = int.Parse(Console.ReadLine());
            Console.Write("Month: "); month = int.Parse(Console.ReadLine());
            Console.Write("Year: "); year = int.Parse(Console.ReadLine());
            Birthdate = new DateTime(year, month, day);
            string Birthdate2 = "Birthdate: " + Birthdate.ToString("dd/MM/yyyy");
            Console.WriteLine(Birthdate2);
            Console.Write("Address Line 1: "); addressLine1 = Console.ReadLine();
            Console.Write("Address Line 2 (Press 'ENTER' if not existing): "); addressLine2 = Console.ReadLine();
            if (addressLine2 == "")
                addressLine2 = "- ";
            Console.Write("City: "); City = Console.ReadLine();
            Console.Write("State: "); State = Console.ReadLine();
            Console.Write("Postal: "); Postal = Console.ReadLine();
            Console.Write("Country: "); Country = Console.ReadLine();
            // output in one line
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} ", "/n " + firstName + " " + lastName + " /n ", Birthdate2 + " /n ", addressLine1 + " /n ", addressLine2 + " /n ", City + " /n ", State + " /n ", Postal + " /n ", Country + " /n ");
            Console.Read();
        }
    }
}
