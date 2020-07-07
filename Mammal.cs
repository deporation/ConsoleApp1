using System;

namespace Mammals
{
    class Mammal
    {
        public Mammal()
        {
            Console.WriteLine("This is a Mammal");
        }
    }
    class Dog : Mammal
    {
        public Dog() : base()
        {
            Console.WriteLine("dog");
        }
    }
    class Cat : Mammal
    {
        public Cat() : base()
        {
            Console.WriteLine("cat");
        }
    }
}
