using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MessagePR5
{
    public static class MessageTester
    {
        public static void Test()
        {
            IMessage simple = new ConsoleMessage("A demo message");
            IMessage colored = new ColoredConsoleMessage(simple);
            IMessage entitled = new EntitledConsoleMessage("Title", simple);
            IMessage colorEntitled = new EntitledConsoleMessage("Title and color", colored);
            IMessage entitledColor = new ColoredConsoleMessage(entitled);
            simple.Print();
            colored.Print();
            entitled.Print();
            colorEntitled.Print();
            entitledColor.Print();
        }
    }
}
