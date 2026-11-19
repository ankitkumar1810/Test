using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Test.Pract
{
    public class rev
    {
          

        public static void Main(string[] args)
        {
            int a = 0; int b = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a+" ");
                int temp = a + b;
                a = b;
                b = temp;
            }

        }
    }
}
