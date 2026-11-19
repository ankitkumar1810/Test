using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //Find Second Highest Salary
    public class PSecondhighest
    {
        public static void Main(string[] args)
        {
            List<int> secondsal = new List<int>
            {
                80000,50000,30000,90000,90000
            };
            var result = secondsal.Distinct().OrderByDescending(x => x).Skip(1).FirstOrDefault();
            Console.WriteLine(result);
        }
    }
}
