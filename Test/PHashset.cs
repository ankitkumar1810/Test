using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class PHashset
    {
        public static void Main(string[] args)
        {
            string[] fruits = { "apple", "Banana", "Mango", "orange", "payaya", "apple" };

            HashSet<string> list = new HashSet<string>(fruits);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
