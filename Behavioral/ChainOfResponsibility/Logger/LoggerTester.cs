using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Logger
{
    public static class LoggerTester
    {
        public static void Test()
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = 
                new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            logger.SetNextLogger(fileLogger);
            logger.Log("Hurry!", MessageType.WARNING);

        }
    }
}
