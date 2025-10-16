using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MessagePR5
{
    public class ConsoleMessage : IMessage
    {
        public String Text { get; private set; }
        public ConsoleMessage(String text)
        {
            this.Text = text;
        }
        public void Print()
        {
            Console.WriteLine(this.Text);
        }
    }
}
