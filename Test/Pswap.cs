using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Pswap
    {
        //swap 2 number without using 3rd variable
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a); 
            Console.WriteLine(b);
        }
    }
}
