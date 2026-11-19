using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //Method Overloading
    public class Calculator
    {
        public int Add(int a, int b)
        {

            return a + b;
        }
        public int Add(int a, int b, int c)
        {

            return a + b + c;
        }
        static void Main(String[] args)
        {
            Calculator obj = new Calculator();
            Console.WriteLine(obj.Add(2, 4));
            Console.WriteLine(obj.Add(2, 3, 4));
        }
    }
}
