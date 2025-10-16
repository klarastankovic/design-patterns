using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MessagePR5
{
    public abstract class ConsoleMessageDecorator : IMessage
    {
        IMessage message;
        public ConsoleMessageDecorator(IMessage message)
        {
            this.message = message;
        }
        public virtual void Print()
        {
            this.message.Print();
        }
    }
}
