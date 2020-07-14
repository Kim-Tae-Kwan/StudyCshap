using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGeneric
{
    class MyList<T> : IEnumerator
    {
        private T[] array;

        public MyList()
        {
            array = new T[0];
        }
        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");

                }

                array[index] = value;
            }

        }

        public int Length
        {
            get { return array.Length; }
        }

        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            for (int i = 0; i < str_list.Length; i++)
            {
                Console.WriteLine(str_list[i]);
            }
            Console.WriteLine();

            MyList<float> float_list = new MyList<float>();
            float_list[0] = 12.4f;
            float_list[1] = 3.141592f;
                      


            foreach (var item in float_list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
