using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Evaluator
{
    public abstract class Evaluator : IEvaluator
    {
        protected IEvaluator next;
        public abstract Evaluation Evaluate(Document document);
        public void SetNext(IEvaluator evaluator)
        {
            this.next = evaluator;
        }
    }
}
