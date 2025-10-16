using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Dataset
{
    public static class DatasetTester
    {
        public static void Test()
        {
            string filePath = "D:\\1 faks\\0 predmeti\\4 semestar\\rppoon\\RPPOON\\OBRASCI\\obrasci strukture\\Adapter\\Dataset\\File.csv";
            Dataset dataset = new Dataset(filePath);
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            Console.Write("Average per column: ");
            double[] averagePerColumn = adapter.CalculateAveragePerColumn(dataset);
            for (int i = 0; i < averagePerColumn.Length; i++)
            {
                Console.WriteLine(averagePerColumn[i]);
            }
            Console.Write("Average per row: ");
            double[] averagePerRow = adapter.CalculateAveragePerRow(dataset);
            for (int i = 0; i < averagePerRow.Length; i++)
            {
                Console.WriteLine(averagePerRow[i]);
            }
        }
    }
}
