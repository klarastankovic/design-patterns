using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DataProvider
{
    public static class DataProviderTester
    {
        public static void Test()
        {
            SystemDataProvider provider = new SystemDataProvider();
            ConsoleLogger logger = new ConsoleLogger();
            provider.Attach(logger);
            provider.GetCPULoad();
            provider.GetRAMAvailable();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
