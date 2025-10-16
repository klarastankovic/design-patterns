using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Document
{
    public static class Tester
    {
        public static void Test()
        {
            Document[] documents = new Document[2] { new Resume(), new TechnicalReport() };

            foreach (Document document in documents)
            {
                Console.WriteLine(document.GetType().Name + ":");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine("\t" + page.GetType().Name);
                }
                Console.WriteLine();
            }
        }
    }
}
