using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh011
{
    class Class1
    {
        public int power(int x)
        {
            return x * x;
        }

        public int Multiply(int min,int max)
        {
            int output = 1;
            for(int i = min; i <= max; i++)
            {
                output *= i;
            }
            return output;
        }

        public int Sum(int min,int max)
        {
            int output = 0;
            for(int i = min; i <= max; i++)
            {
                output += i;
            }
            return output;
        }

        public void Test()
        {
            Mymath.Main(new string[] { "" });
        }

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

            class test
            {

                public void Test() //자신의 클래스 내부에 있는 클래스의 메서드
                {
                    Mymath.Main(new string[] { "" });
                }
            }

            public void Test() //자신의 클래스 내부에 있는 메서드
            {
                Mymath.Main(new string[] { "" });
            }

            public static void Main(string[] args) //접근 제한자 추가 public
            {
                Class1 class1 = new Class1();

                Console.WriteLine(class1.power(10));
                Console.WriteLine(class1.power(20));
                Console.WriteLine(class1.Multiply(1, 10));
                Console.WriteLine(class1.Sum(1, 100));

                //메서드 오버로딩
                Console.WriteLine(Mymath.Abs(-273));

                Console.WriteLine(Mymath.Abs(-27.323));

                Console.WriteLine(Mymath.Abs(-21474717289));
            }
        }
    }
}
