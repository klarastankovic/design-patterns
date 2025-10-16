using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MessagePR5
{
    public class ColoredConsoleMessage : ConsoleMessageDecorator
    {
        ConsoleColor color = ConsoleColor.Cyan;
        public ColoredConsoleMessage(IMessage message) : base(message)
        {
        }
        public override void Print()
        {
            Console.ForegroundColor = color;
            base.Print();
            Console.ResetColor();
        }
    }
}
