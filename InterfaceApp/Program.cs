using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    interface Ilogger
    {
        void Writelog(string message);
    }

    class ConsoleLogger : Ilogger
    {
        public void Writelog(string message)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now.ToLocalTime()},{message}");
        }
    }

    class FileLogger : Ilogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void Writelog(string message)
        {
            DateTime now = DateTime.Now;
            writer.WriteLine($"{now.ToLocalTime()},{message}");
        }
    }

    class ClimateMonitor
    {
        private Ilogger logger;

        public ClimateMonitor(Ilogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("\n온도 입력 : ");
                string temp = Console.ReadLine();
                if (temp == "q")
                    break;
                logger.Writelog("현재 온도 : " + temp);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));

            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());

            monitor.start();


        }
    }
}
