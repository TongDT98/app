using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class method
    {
        public void methodparam(string name, int tuoi)
        {
            Console.WriteLine( name +tuoi);         
        }
        public int methodoverload(int a, int b)
        {
            return a + b;
        }
        public double methodoverload(double c, double d)
        {
            return d - c;
        }
    }
}
