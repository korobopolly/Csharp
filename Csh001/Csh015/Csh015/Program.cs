using System;
using System.Collections.Generic;

namespace Csh015
{
    /*
    namespace A
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }

        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("자식 생성자");
            }
        }
    }

    namespace B
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }

        class Child : Parent
        {
            public Child():base()
            {
                Console.WriteLine("자식 생성자");
            }
        }
    }

    namespace C
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("Parent()");
            }

            public Parent(int param)
            {
                Console.WriteLine("Parent(int param)");
            }

            public Parent(string param)
            {
                Console.WriteLine("Parent(string param)");
            }
        }

        class Child : Parent
        {
            public Child():base(10)
            {
                Console.WriteLine("Child():base(10)");
            }

            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input):base(input)");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A.Child childA = new A.Child();
            Console.WriteLine();

            B.Child childB = new B.Child();
            Console.WriteLine();

            C.Child childC = new C.Child();
            C.Child childD = new C.Child("string");
            Console.WriteLine();

            Console.WriteLine("미디어소프트웨어학과,4학년,윈도우프로그래밍[002],20161449,이준성");
        }
    }
    */

    /*
    class Program
    {
        public static int number = 10;

        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public string variable = "shadowing";

            public void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main(string[] args)
        {
            int number = 20; //하이딩
            Console.WriteLine(number);
            Console.WriteLine();

            Child childA = new Child();
            Console.WriteLine(childA.variable);
            Child childB = new Child();
            Console.WriteLine(((Parent)childB).variable);

            Child childC = new Child();
            childC.Method();
            ((Parent)childC).Method();

            Console.WriteLine("미디어소프트웨어학과,4학년,윈도우프로그래밍[002],20161449,이준성");
        }
    }
    */

    class Program
    {
        class Animal
        { 
            public void Eat()
            {
                Console.WriteLine("냠냠 먹습니다.");
            }
        }

        class Dog : Animal
        {
            public void Eat()
            {
                Console.WriteLine("강아지 사료를 먹습니다.");
            }
        }

        class Cat : Animal
        {
            public void Eat()
            {
                Console.WriteLine("고양이 사료를 먹습니다.");
            }
        }

        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(),new Cat(),new Cat(),new Dog(),
                new Dog(),new Cat(),new Cat(),new Dog()
            };

            foreach(var item in Animals)
            {
                item.Eat();
            }

            Console.WriteLine("미디어소프트웨어학과,4학년,윈도우프로그래밍[002],20161449,이준성");
        }

    }
}
