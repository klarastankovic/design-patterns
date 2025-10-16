using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Evaluator
{
    public interface IEvaluator
    {
        Evaluation Evaluate(Document document);
        void SetNext(IEvaluator evaluator);
    }
}
