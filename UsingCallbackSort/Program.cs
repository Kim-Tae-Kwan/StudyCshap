using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCallbackSort
{
    delegate int Compare<T>(T a, T b);
    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> comparer)
        {
            int temp = 0;

            for (int i = 0; i < DataSet.Length-1; i++)
            {
                for (int j = 0; j < DataSet.Length-(i+1); j++)
                {
                    if(comparer(DataSet[j],DataSet[j+1])>0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 9, 8, 2, 4 };
            Console.WriteLine("Sorting ascending....");
            BubbleSort(arr, new Compare(AscendCompare));

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("Sorting descending....");
            BubbleSort(arr, new Compare(DescendCompare));

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
