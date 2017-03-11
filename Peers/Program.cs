using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peers
{
    class Program
    {
        static void Main(string[] args)
        {
            string x, o;
            int noRows, noColumns;
            x = "X";
            o = "O";
            noColumns = 1;
            for (noRows = 1; noRows < 9; noRows++)
            {


                if (noRows % 2 == 1 && noColumns % 2 == 1)
                { Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", x, o, x, o, x, o, x, o); }
                else
                { Console.WriteLine("{1}{2}{3}{4}{5}{6}{7}{8}", x, o, x, o, x, o, x, o, x); }
                noColumns++;


            }
            Console.Read();

        }
    }
}
