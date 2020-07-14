using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingYield
{
    class MyEnumerator
    {
        int[] num = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return num[0];
            yield return num[1];
            yield return num[2];
            //yield break;
           // yield return num[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyEnumerator a = new MyEnumerator();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
