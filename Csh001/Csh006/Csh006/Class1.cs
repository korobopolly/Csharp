using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh006
{
    class Class1
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            if(input%2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }

            if (input % 2 == 1)
            {
                Console.WriteLine("홀수입니다!");
            }

            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            
            Console.WriteLine(DateTime.Now.Year+"."+ DateTime.Now.Month + "." + DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }

            if (12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후입니다.");
            }
            

            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }

            else
            {
                Console.WriteLine("홀수입니다!");
            }
            

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }

            else
            {
                Console.WriteLine("오후입니다.");
            }
            

            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }

            else
            {
                if(DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
            }
            

            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }

            else if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }

            else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
                

            double score = 4.3;
            if(4.0<score && score < 4.5)
            {
                Console.Write("4.0 < " + score + " < 4.5");
            }
            

            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다!");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다!");
                    break;
            }
            

            Console.Write("이번 달은 몇 월인가요: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄 입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름 입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 월을 입력하였습니다.");
                    break;
            }
            */

            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.WriteLine(number > 0 ? "자연수입니다." : "자연수가 아닙니다.");

        }
    }
}
