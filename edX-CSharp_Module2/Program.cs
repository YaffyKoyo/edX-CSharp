using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX_CSharp_Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else {
                        Console.Write("O");
                    }
                }
                if (i < 7) Console.Write("\n");
            }
            Console.Read();
        }
    }
}
