using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Dataset
{
    public class ConsoleLogger
    {
        private static ConsoleLogger instance;
        private ConsoleLogger() {}
        public static ConsoleLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }
        public void Log()
        {
            Console.WriteLine("Logged in.");
        }
    }
}
