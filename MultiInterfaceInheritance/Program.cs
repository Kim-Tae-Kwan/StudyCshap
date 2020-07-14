using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    class Vehicle
    {
        public string Year;
        public string Company;
        public float HorsePower;

    }

    class FlyingCar : Vehicle, IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly!Fly!");
        }

        public void Run()
        {
            Console.WriteLine("Run!Run!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();
            car.Company = "기아";

            IRunnable runnable = car;
            runnable.Run();

            IFlyable flyable = car;
            flyable.Fly();


        }
    }
}
