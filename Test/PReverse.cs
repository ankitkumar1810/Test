using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class PReverse
    {
        public static void Main(string[] args)
        {
            // 1st way
            //string str = "Hello World";

            //for (int i = str.Length-1; i >=0; i--)
            //{
            //    Console.Write(str[i]);
            //}

            //2nd way

            //string str = "Hello World";
            //char[] arr= str.Reverse().ToArray();
            //Console.WriteLine(new string(arr));

            //3rd way
            string str = "Hello";
            char[] arr= str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));


            
        }
        
        
    }
}
