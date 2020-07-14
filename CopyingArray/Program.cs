using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyingArray
{
    class Program
    {
        static void CopyArray<T>(T[] source,T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5, 6, 7 };
            int[] target = new int[source.Length];

            CopyArray(source, target);

            foreach (var item in target)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯", "일곱", "여덟", };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);

            foreach (var item in target2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


        }

        private static void TestProcess()
        {
            throw new NotImplementedException();
        }
    }
}
