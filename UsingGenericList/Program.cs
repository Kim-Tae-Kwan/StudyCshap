using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> intList = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                intList.Add(i);
            }
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            intList.RemoveAt(2);
            intList.Insert(0, 500);
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            */
            /*
            Queue<double> q = new Queue<double>();
            q.Enqueue(11.11);
            q.Enqueue(22.22);
            q.Enqueue(33.33);
            q.Enqueue(44.44);

            while(q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            */

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["하나"] = 1;
            dic["둘"] = 2;
            dic["셋"] = 3;
            dic["넷"] = 4;

            Console.WriteLine(dic["하나"]);
        }
    }
}
