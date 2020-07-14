using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 1, 2, 3 };
            int x = 100, y = 0;


            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(arr[i]);

                }
                y = 2;
                Console.WriteLine($"{x / y}");

                string sval = "RR";
                int val = int.Parse(sval);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Source}");

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"난 몰라 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("무조건 실행");
            }
            
        }
    }
}
