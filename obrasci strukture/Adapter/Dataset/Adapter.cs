using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Dataset
{
    public class Adapter : IAnalytics
    {
        private Analyzer3rdParty analitcsService;
        public Adapter(Analyzer3rdParty analitcsService)
        {
            this.analitcsService = analitcsService;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> data = dataset.GetData();
            int rowCount = data.Count;
            double[][] result = new double[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                int columnCount = data[i].Count;
                result[i] = new double[columnCount];
                for (int j = 0; j < columnCount; j++)
                {
                    result[i][j] = data[i][j];
                }
            }
            return result;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analitcsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analitcsService.PerRowAverage(data);
        }
    }
}
