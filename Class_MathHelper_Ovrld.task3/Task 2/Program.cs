using System;
using System.Runtime.InteropServices;

namespace Task2
{
    public class MathHelper
    {
        
        public static int PrintValue(int a, int b)
        {
            return a + b;
        }

        public static int PrintValue(bool a)
        {
            if(a == true ) 
                return 1;
            else 
                return 0;
        }

        public  static  void PrintValue(string f, string d) 
        {
            Console.WriteLine(f + " " + d);
           
        }

        public static int PrintValue(int a, int b, int c)
        {
            return a * b * c;
        }
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = MathHelper.PrintValue(5, 7);
            Console.WriteLine(a);

            int b = MathHelper.PrintValue(false);
            Console.WriteLine(b);

            MathHelper.PrintValue("Hello","World");

            int c=MathHelper.PrintValue(2,5,7);
            Console.WriteLine(c);


            
        }
    }









}