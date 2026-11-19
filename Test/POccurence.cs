using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class POccurence
    {
        //First Non Repeated Character  
        public static void Main(String[] args)
        {
            string str = "aaaaabbbbcde";

            var data = str.GroupBy(x => x).Where(g=>g.Count()==1).Select(g=>g.Key).FirstOrDefault();
            Console.WriteLine(data);
        }
    }
}
