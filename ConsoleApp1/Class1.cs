using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1
    {
        public int obj { get; set; }
        public int t { get; set; }
        public string k { get; set; }
        private int m { get; set; }
        public int l() { return obj + t; }
        public void dis()
        {

            Console.WriteLine(l());
        }
       
      
    }
}
