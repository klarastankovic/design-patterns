using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageSender
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Sevice\n{0}\n{1}", subject, body);
        }
    }
}
