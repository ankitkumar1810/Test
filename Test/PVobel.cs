using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class PVobel
    {
        public static void Main(string[] args)
        {
            string str = "Ankit Kumar";
          int count=  str.Count(c =>"aeiouAEIOU".Contains(c));
            Console.WriteLine(count);
        }
    }
}
