using System;
using System.Collections.Generic;

namespace Csh014
{
    class Program
    {
        class Animal
        {
            public int Age { get; set; }
            public Animal() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        }

        class Dog : Animal
        {
            public string Color { get; set; }

            public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
        }

        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog()
            };


            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                //클래스 is 변수
                if(item is Dog) { ((Dog)item).Bark();}
                if(item is Cat) { ((Cat)item).Meow();}

                /* 변수 as 클래스
                var dog=item as Dog;
                if (dog != null) {dog.Bark();}

                var cat=item as Cat;
                if (cat != null) {cat.Meow();}
                */

                Console.WriteLine("");
            }
        }
            
    }
}
