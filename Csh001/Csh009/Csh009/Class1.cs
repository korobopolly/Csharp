using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh009
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력해주세요: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자를 입력해주세요: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자를 입력해주세요: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자를 입력해주세요: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");
            int big = (a > b ? a : b);
            int bigger= ( c> big ? c : big);
            int biggger = (d > bigger ? d : bigger);

            int small = (a < b ? a : b);
            int smaller = (small < c ? small : c);
            int smalller = (smaller < d ? smaller : d);

            Console.WriteLine("가장 큰 수: "+biggger);
            Console.WriteLine("가장 작은 수: "+smalller);
        }
    }
}
