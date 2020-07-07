using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_1
{
    class MainApp
    {
        static double Square(double arg)
        {
            return arg * arg;
        }
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine($"결과 : {Square(arg)}");
        }
    }
}
