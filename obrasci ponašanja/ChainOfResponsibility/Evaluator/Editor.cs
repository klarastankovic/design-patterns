using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Evaluator
{
    public class Editor : Evaluator
    {
        public override Evaluation Evaluate(Document document)
        {
            Evaluation result = new Evaluation() { Evaluator = "Editor", Approved = false };
            if (!string.IsNullOrWhiteSpace(document.Content) )
            {
                if (document.Content.Length > 1000 && next != null)
                {
                    return next.Evaluate(document);
                }
                if (document.Content.Length > 600)
                {
                    result.Approved = true;
                }
            }
            return result;
        }
    }
}
