using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    //interface
    public interface IDrow
    {
        public  void Circle();
    }
    public class Area : IDrow
    {
        public void Circle()
        {
            Console.WriteLine("Circle Draw");
        }
        public static void Main(String[] args)
        {
            Area obj = new Area();
            obj.Circle();
        }

    }
}
