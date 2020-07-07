using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("숫자를 입력하세요 : ");
                string input = Console.ReadLine();
                int num;
                if (int.TryParse(input, out num))
                {
                    if (num > 0)
                    {
                        if (num % 2 == 0)
                        {
                            Console.WriteLine($"{num} 는 짝수");
                        }
                        else
                            Console.WriteLine($"{num} 는 홀수");

                    }

                }
                else
                {
                    Console.WriteLine("입력값이 숫자가 아닙니다.");
                    return;
                }
            }
        }
    }
}
