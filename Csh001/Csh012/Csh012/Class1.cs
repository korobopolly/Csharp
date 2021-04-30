using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh012
{
    class Class1
    {
        class Mymath
        {
            public static int Abs(int input) //static을 빼면 바로 메모리에 올라가지않는다.
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }

            public static double Abs(double input) //메서드 오버로딩
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }

            public static long Abs(long input) //메서드 오버로딩
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }

            static void Main(string[] args)
            {
                //메서드 오버로딩
                Console.WriteLine(Mymath.Abs(52));
                Console.WriteLine(Mymath.Abs(-273));

                Console.WriteLine(Mymath.Abs(52.273));
                Console.WriteLine(Mymath.Abs(-32.103));

                Console.WriteLine(Mymath.Abs(21474836470));
                Console.WriteLine(Mymath.Abs(-21474836470));

                Console.WriteLine("미디어소프트웨어학과,4학년,윈도우프로그래밍[002],20161449,이준성");
            }
        }
    }
}
