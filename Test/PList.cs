using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class PList
    {
        //List Max,Min,Count
        public static void Main(String[] args)
        {
            List<int> list = new List<int>()
        {
            100,200,300,400,500
        };
            var max = list.Max();
            var min = list.Min();
            var count = list.Count();

            Console.WriteLine("Maximum " +max);
            Console.WriteLine("Minimum "+min);
            Console.WriteLine("Count "+count);
        }
        
        
    }
}
