using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Parent
    {
        protected string Name;

        public Parent(string name)
        {
            Name = name;
            Console.WriteLine($"{Name}.Parent()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }
    class Child : Parent
    {
        public Child(string name) : base(name)
        {
            Console.WriteLine($"{this.Name}.Child()");
        }

        public void DerivedMethod()
        {
            base.BaseMethod();
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Parent a = new Parent("a");
            a.BaseMethod();

            Child b = new Child("b");
            b.BaseMethod();
            b.DerivedMethod();

        }
    }
}
