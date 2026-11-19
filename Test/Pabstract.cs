using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //abstract class,abstract method
    public abstract class Animals
    {
        public abstract void Sound();
    }
    public class Dogs:Animals
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Bark");
        }
        public static void Main(String[] args)
        {
            Dogs obj = new Dogs();
            obj.Sound();
        }
    }
}
