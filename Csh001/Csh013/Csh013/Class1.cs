using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh013
{
    class Class1
    {
        /*
        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = counter + 1;
                this.id = counter;
                this.name = name;
                this.price = price;
            }
        }
        static void Main(string [] args)
        {
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Console.WriteLine(productA.id + ":" + productA.name);
            Console.WriteLine(productB.id + ":" + productB.name);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");
        }
        */

        
        class Product
        {
            public string name;
            public int price;
            public Product(string name, int price)
            {
                this.name = name;
                this.price = price;
            }
            ~Product() //소멸자
            {
                Console.WriteLine(this.name + "의 소멸자 호출");
            }
            static void Main(string[] args)
            {
                Product product = new Product("과자", 1000);
                Console.WriteLine("미디어소프트웨어학과,4학년,윈도우프로그래밍[002],20161449,이준성");
            }
        }
        

        /*
        class Box
        {
            private int width;
            private int height;

            public int Width
            {
                get { return width; }
                set
                {
                    if(value>0) { width = value; }
                    else { Console.WriteLine("너비는 자연수를 입력해주세요."); }
                }
            }

            public int Height
            {
                get { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { Console.WriteLine("높이는 자연수를 입력해주세요."); }
                }
            }

            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public int Area() { return this.width * this.height; }
        }
        static void Main(string[] args)
        {
            Box box = new Box(-10, -20); //생성자 메서드 호출

            box.Width = -200; // 셋터 호출
            box.Height = -100;
            Console.WriteLine("미디어소프트웨어학과,4학년,윈도우프로그래밍[002],20161449,이준성");
        }
        */
        
    }
}
