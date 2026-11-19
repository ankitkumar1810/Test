using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //Single Inheritance
    public class MYParent
    {
        public void Show()
        {
            Console.WriteLine("Parent Class");
        }
    }
    public class  Child:MYParent
    {
        public void Display()
        {
            Console.WriteLine("Child Class");
        }

        
        
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Child obj = new Child();
            obj.Show();
            obj.Display();
        }
    }

}
