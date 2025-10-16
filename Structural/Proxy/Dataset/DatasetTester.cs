using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Dataset
{
    public static class DatasetTester
    {
        public static void Test()
        {
            string filePath = "D:\\1 faks\\0 predmeti\\4 semestar\\rppoon\\RPPOON\\OBRASCI\\obrasci strukture\\Proxy\\Dataset\\sensitiveData.csv";
            IDataset dataset = new Dataset(filePath);
            IDataset virtualProxy = new VirtualProxyDataset(filePath);

            User user = User.GenerateUser("Klara");
            IDataset protectionProxy = new ProtectionProxyDataset(user);

            DataConsolePrinter printer = new DataConsolePrinter();
            printer.Print(dataset);
            Console.WriteLine();
            printer.Print(virtualProxy);
            Console.WriteLine();
            //printer.Print(protectionProxy);

            IDataset loggingProxy = new LoggingProxyDataset(filePath);
            printer.Print(loggingProxy);
        }
    }
}
