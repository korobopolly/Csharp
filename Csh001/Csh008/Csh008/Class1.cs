using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh008
{
    class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 7-i; k++)
                {
                    Console.Write(" ");
                    
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k < i ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
