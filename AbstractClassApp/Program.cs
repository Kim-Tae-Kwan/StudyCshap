using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    abstract class AbstractBase
    {
        protected void ProtectedMethodA()
        {
            Console.WriteLine("AbstractBase.ProtectedMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            ProtectedMethodA();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();

            Derived derived = new Derived();
            derived.AbstractMethodA();
            derived.PublicMethodA();
        }
    }
}
