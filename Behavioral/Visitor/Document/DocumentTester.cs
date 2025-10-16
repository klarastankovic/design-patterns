using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Document
{
    public static class DocumentTester
    {
        public static void Test()
        {
            Document doc = new Document();
            doc.Add(new PlainText("Hello friends, I am prince of Nigeria"));
            doc.Add(new BoldText("I have a business proposal."));
            doc.Add(new Hyperlink("www.suspiciouswebpage.nope", "Click here"));
            HtmlVisitor visitor = new HtmlVisitor();
            doc.Accept(visitor);
            Console.WriteLine("Html: " + Environment.NewLine + visitor.Output);
        }
    }
}
