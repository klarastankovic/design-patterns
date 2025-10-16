using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MessagePR5
{
    public class EntitledConsoleMessage : ConsoleMessageDecorator
    {
        String title;
        public EntitledConsoleMessage(string title, IMessage message) : base(message)
        {
            this.title = title;
        }
        public override void Print()
        {
            Console.WriteLine(title);
            base.Print();
        }
    }
}
