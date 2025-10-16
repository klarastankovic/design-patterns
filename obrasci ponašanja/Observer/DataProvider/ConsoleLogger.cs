using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DataProvider
{
    public class ConsoleLogger : Logger //konkretan observer
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine(DateTime.Now + "-> CPU load: " + 
                provider.CPULoad + " Available RAM: " + provider.AvailableRAM);
        }
    }
}
