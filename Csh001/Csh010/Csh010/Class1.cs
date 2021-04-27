using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh010
{
    class Class1
    {
        static void Main(String[] args)
        {
            /*
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            

            List<int> list = new List<int>() { 52, 273, 32, 63 };

            list.Remove(52);

            foreach(var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }
            */

            Console.WriteLine(Math.Abs(-52273)); //절대값
            Console.WriteLine(Math.Ceiling(52.273)); //값보다 큰 최소 정수
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52,273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
        }
    }
}
