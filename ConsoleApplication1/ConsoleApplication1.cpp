using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{


    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Globar Count = {Global.Count}");
            new ClassA();
            new ClassB();
            new ClassA();
            new ClassB();
            Console.WriteLine($"Globar Count = {Global.Count}");
        }
    }
}
