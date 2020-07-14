using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unkownm";
        public DateTime Birthday { get; set; } = new DateTime(1900, 1, 1);

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo()
            {
                Name = "김태관",
                Birthday = new DateTime(2021, 07, 09)
            };

            Console.WriteLine($"{info.Name}, {info.Birthday}");

            var myIns = new { name = "김태관", Age = 27 };
            Console.WriteLine($"{myIns.name},{myIns.Age}");

            var b = new { Subject = "수학", Score = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject : {b.Subject}, Score : ");
            foreach (var item in b.Score)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
