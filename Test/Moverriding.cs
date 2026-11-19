using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //method overriding
    public class Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("Animal Sleep");
        }
    }
    public class Dog : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Dog Sleep");
        }
        public static void Main(String[] args)
        {
            Animal obj = new Dog();
            obj.Sleep();
        }
    }
}
