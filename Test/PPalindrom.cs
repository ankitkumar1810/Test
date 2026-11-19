using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class PPalindrom
    {
        public static void Main(string[] args)
        {
            string str = "madam";
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.Write(str==new string(arr)?"Palindrom":"Not Palindrom");
        }
    }
}
