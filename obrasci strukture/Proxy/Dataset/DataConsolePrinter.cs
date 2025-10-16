using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Dataset
{
    public class DataConsolePrinter
    {
        public void Print(IDataset dataset)
        {
            IList<List<string>> data = dataset.GetData();
            foreach (var row in data)
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }
    }
}
