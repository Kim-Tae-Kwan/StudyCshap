using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegate
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //이전까지 방식
            Calculator cal = new Calculator();
            Console.WriteLine("이전까지 방식");
            Console.WriteLine(cal.Plus(1, 2));
           // Console.WriteLine(cal.Minus(1,2));

            //대리자
            MyDelegate Callback = new MyDelegate(cal.Plus);
            Console.WriteLine("\n대리자");
            Console.WriteLine(Callback(10, 5));
            //Callback = new MyDelegate(cal.Minus);
            Console.WriteLine(Callback(10, 5));


        }
    }
}
