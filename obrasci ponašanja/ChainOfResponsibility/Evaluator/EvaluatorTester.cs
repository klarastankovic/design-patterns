using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Evaluator
{
    public static class EvaluatorTester
    {
        public static void Test()
        {
            List<Document> documents = new List<Document>()
            {
                new Document() { Id = 1, Content = new string('*', 500) },
                new Document() { Id = 2, Content = new string('*', 850) },
                new Document() { Id = 3, Content = new string('*', 1500) }
            };
            IEvaluator editor = new Editor();
            IEvaluator reviewer = new Reviewer();
            editor.SetNext(reviewer);
            foreach(Document document in documents)
            {
                Evaluation result = editor.Evaluate(document);
                Console.WriteLine(result.Approved ?
                    "Document {0} approved by {1}" : "Document {0} approved by {1}",
                    document.Id, result.Evaluator
                );
            }
        }
    }
}
