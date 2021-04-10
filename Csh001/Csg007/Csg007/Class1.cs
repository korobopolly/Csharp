using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csg007
{
    class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i%2==0)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.WriteLine("미디어소프트웨어학과,4학년,윈도우프로그래밍[002],20161449,이준성");
        }
    }
}
