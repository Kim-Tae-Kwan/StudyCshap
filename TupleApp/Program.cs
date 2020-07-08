using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace TupleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //명명되지 않은 튜플
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1},{a.Item2}");

            //명명된 튜플
            var b = (Name: "김태관", Age: 27);
            Console.WriteLine($"{b.Name},{b.Age}");

            //분해
            var (name, age) = b;
            Console.WriteLine($"{name},{age}");

            b = a;
            Console.WriteLine($"{b.Name},{b.Age}");

        }
    }
}
