using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Dataset
{
    public class LoggingProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        private ConsoleLogger logger;
        public LoggingProxyDataset(string filePath)
        {
            this.filePath = filePath;
            logger = ConsoleLogger.GetInstance();
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            logger.Log();
            return dataset.GetData();
        }
    }
}
