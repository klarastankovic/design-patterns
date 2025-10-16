using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Evaluator
{
    public class Reviewer : Evaluator
    {
        public override Evaluation Evaluate(Document document)
        {
            Evaluation result = new Evaluation() { Evaluator = "Reviewer", Approved = false };
            result.Approved = !string.IsNullOrWhiteSpace(document.Content) &&
                                      document.Content.Length > 1000;
            return result;
        }
    }
}
