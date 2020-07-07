using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            object obj = null;
            string s = Console.ReadLine();

            if (int.TryParse(s, out int out_i))
            {
                obj = out_i;
                Console.WriteLine($"{s.GetType()}, {obj.GetType()}");
            }
            else if (float.TryParse(s, out float out_f))
            {
                obj = out_f;
            }
            else
                obj = s;

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"{i}는 int형식입니다.");
                    break;
                case float f when f >= 0:
                    Console.WriteLine($"{f}는 0보다 큰 float형식입니다.");
                    break;
                case float f:
                    Console.WriteLine($"{f}는 float형식입니다.");
                    break;
                default:
                    break;
            }
            */

            List<string> strings = new List<string>();
            strings.Add("Hello");
            strings.Add("Bye");
            strings.Add("Hey~");

            List<string> subs = new List<string> { "Banana", "Apple" };
            strings.AddRange(subs);

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
