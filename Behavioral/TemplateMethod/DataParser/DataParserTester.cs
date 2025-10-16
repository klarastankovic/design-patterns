using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DataParser
{
    public static class DataParserTester
    {
        public static void Test()
        {
            Console.WriteLine("Csv data:");
            DataParser parser = new CSVDataParser();
            parser.DisplayData("data.csv");
            Console.WriteLine("Custom data:" );
            parser = new CustomDataParser();
            parser.DisplayData("data.custom");
        }
    }
}
