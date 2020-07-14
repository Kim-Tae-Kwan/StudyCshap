using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChains
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappened : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();

            EventListener eventListener1 = new EventListener("Listener1");
            EventListener eventListener2 = new EventListener("Listener2");
            EventListener eventListener3 = new EventListener("Listener3");
            EventListener eventListener4 = new EventListener("Listener4");

            notifier.EventOccured += eventListener1.SomethingHappend;
            notifier.EventOccured += eventListener2.SomethingHappend;
            notifier.EventOccured += eventListener3.SomethingHappend;
            notifier.EventOccured += eventListener4.SomethingHappend;

            notifier.EventOccured("You`ve got mail.");

            Console.WriteLine();
        }
    }
}
