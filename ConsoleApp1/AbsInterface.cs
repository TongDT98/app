using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class tentuoi
    {
        public virtual void goiten()
        {
            Console.WriteLine("ten van tuoi");
        }
    }
    public class abc
    {
        public void mana()
        {
            Console.WriteLine("power");
        }
    }
     public interface ten
        {
               
            public void ten()
            {
                
            }
        }
     public interface tuoi
       {           
            public void tuoi()
            {

            }
       }
    public class name : abc
    {
        public void mana()
        {
            Console.WriteLine("karata");
        }
    }
    public class name1 : tentuoi
    {
        public override void goiten()
        {
            Console.WriteLine("haaha");
        }
    }
    public class nameage : ten, tuoi
    {
              

        public void ten()
        {
            Console.WriteLine("ten tao la: asdad");            
        }
        
        public void tuoi()
        {
            Console.WriteLine("tuoi tao la :123");
        }
    }
 }
