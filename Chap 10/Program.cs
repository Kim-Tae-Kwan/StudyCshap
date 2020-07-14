using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();


            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            list.Add("abcdetdlsjfaioewlkjlkcv");
            list.Add(2.153);


            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
