using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class PFactorial
    {
        //factorial program
        public static void Main(string[] args)
        {
            int n = 5;
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                
            }
            Console.Write(fact);
        }
    }
}
