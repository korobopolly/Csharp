﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh005
{
    class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    default:
                        Console.WriteLine("다른 키를 눌렀습니다");
                        break;
                }
            }
        }
    }
}
