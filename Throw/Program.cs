using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dosomething(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
                Console.WriteLine($"도움말 링크 : {ex.HelpLink}");
                Console.WriteLine($"예외 위치 : {ex.Source}");
            }
            finally
            {
                Console.WriteLine("무조건");
            }
        }

        private static void Dosomething(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine($"arg : {arg}");
            }
            else
                throw new Exception("arg가 10보다 큽니다.")
                {
                    HelpLink = "https://www.google.com",
                    Source = "Throw Line 23",
                };
        }
    }
}
