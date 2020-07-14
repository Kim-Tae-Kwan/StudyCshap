using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableGeneric
{
    class MyList<T>: IEnumerable<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }


        public int Length()
        {
            return array.Length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index>=array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> strList = new MyList<string>();
            strList[0] = "abc";
            strList[1] = "def";
            strList[2] = "ghi";

            foreach (var item in strList)
            {
                Console.WriteLine($"'{item}'");
            }
        }
    }
}
