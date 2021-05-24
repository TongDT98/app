using System;
using System.IO;

namespace ConsoleApp1
{
    class Program 
    {

        static void Main(string[] args)
        {
            Class1 a = new Class1();
            a.obj = 2;
            Console.WriteLine(a.obj);
           
       
            cin(a);
            Console.WriteLine(a.obj);
            int k = 5;
            Console.WriteLine(k.ToString());
            Console.ReadKey();
            // switch case
            int n = a.obj;
            switch (n)
            {
                case 1:
                    Console.WriteLine("ngay 1");
                    break;
                case 2:
                    Console.WriteLine("dit ba may");
                    break;
                case 3:
                    Console.WriteLine("helobb");
                    break;
                case 4:
                    Console.WriteLine("ok let go");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;


            }
            //. foreach
            for (int i = 1; i <= 4; i++)
            {
                if (i == 1) { Console.WriteLine("so1 ne"); }
                if (i == 2) { Console.WriteLine("bo nha may"); }
                break;
                if (i == 3) { Console.WriteLine("ok do con bo"); }
                if (i == 4) { Console.WriteLine("mano cay"); }


            }
            int m = 1;
            // while
            while (m <= 4)
            {
                Console.WriteLine("day la lan thu" + m);
                m++;
            }
            //input string
            input b = new input();
            Console.WriteLine("nhap ten dau ");
            b.FirstName = "nguyen";
            Console.WriteLine("nhap ten sau ");
            b.LastName = Console.ReadLine();
            Console.WriteLine("ten dau la" + b.FirstName);
            Console.WriteLine("ten sau la " + b.LastName);
            Console.WriteLine(b.FirstName.ToLower());
            Console.WriteLine(b.FirstName.ToUpper());
            if (b.FirstName.ToLower().Equals(b.LastName.ToLower()))
            {
                Console.WriteLine("trung ten");
            }
            else
            {
                Console.WriteLine("khong trung");
            }

            //math
            operators c = new operators();
            Console.WriteLine(c.min) ;
            Console.WriteLine(c.max);
            //Method
            Console.WriteLine("-----method");
            method d = new method();
            d.methodparam("thong", 19);
            int num1 = d.methodoverload(2, 3);
            double num2 = d.methodoverload(10.4, 5.5);
            Console.WriteLine(num2);
            Console.WriteLine(num1);
            //polimorphism
            name na = new name();
            na.mana();
            name1 na1 = new name1();
            na1.goiten();
            nameage ng = new nameage();
            ng.ten();
            ng.tuoi();
            //enum
            number num = number.ba;
            Console.WriteLine(num);
            //// fileIO
            string filenew = "daylafile";
            File.WriteAllText("file1.txt", filenew);
            string docfile = File.ReadAllText("file1.txt");
            Console.WriteLine(docfile);
            FileStream createfile = new FileStream("D:/file1.txt", FileMode.OpenOrCreate, FileAccess.Read);
            createfile.Position = 0;
            createfile.Close();



        }
        static void cin(Class1 value)
        {
          value.obj = 3;          
        }
    }
}
