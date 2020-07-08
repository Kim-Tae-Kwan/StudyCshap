using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassApp
{
    class Person
    {
        public string name;
        public int age;
        public Color color;

        ///
        public Person()
        {
            name = "";
            age = 0;
            color = Color.Transparent;
        }
        /// <summary>
        /// 생성자 설정
        /// </summary>
        /// <param name="name">이름</param>
        /// <param name="age">나이</param>
        /// <param name="color">색</param>
        public Person(string name, int age, Color color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }

        public void Hello()
        {
            Console.WriteLine($"{name},안녕하세요~~!!");
        }
    }


    class Main_
    {
        static void Main(string[] args)
        {
            Person Kim = new Person(); //인스턴스화
            Kim.age = 27;
            Kim.name = "Tae Kwan";
            Kim.color = Color.Red;
            Kim.Hello();
            Console.WriteLine($"{Kim.color}");

            Person Son = new Person("Youjin", 25, Color.White);
            Son.Hello();
        }
    }
}
