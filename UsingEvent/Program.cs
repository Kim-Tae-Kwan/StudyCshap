﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEvent
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void Dosomething(int num)
        {
            int temp = num % 10;
            if(temp !=0 && temp%3==0)
            {
                SomethingHappened($"{num} : 짝");
            }
        }
    }
    class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 1 ; i < 30; i++)
            {
                notifier.Dosomething(i);
            }
        }
    }
}
