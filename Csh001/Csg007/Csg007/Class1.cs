using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Csg007
{
    class Class1
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = 5;
            bool state = true;
            while (state)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);


                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("@");
                        y -= 1;
                        break;

                    case ConsoleKey.DownArrow:
                        Console.WriteLine("@");
                        y += 1;
                        break;

                    case ConsoleKey.RightArrow:
                        Console.WriteLine("@");
                        x += 1;
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("@");
                        x -= 1;
                        break;

                    case ConsoleKey.A:
                        Console.WriteLine("종료");
                        state = false;
                        break;
                    default:
                        Console.WriteLine("다른 키를 눌렀습니다");
                        break;
                }

                Thread.Sleep(100);
            }
        }
    }
}
