using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MessageSender
{
    public static class MessageSenderTester
    {
        public static void Test()
        {
            List<IMessageSender> senders = new List<IMessageSender>()
            {
                new EmailSender(), new MSMQSender(), new WebServiceSender()
            };
            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";
            foreach(IMessageSender sender in senders)
            {
                message.MessageSender = sender;
                message.Send();
            }
            UserMessage userMessage = new UserMessage();
            userMessage.Subject = "Test Message";
            userMessage.Body = "Hi, This is a Test Message";
            userMessage.UserComments = "I can add comments!!!";
            userMessage.MessageSender = new EmailSender();
            userMessage.Send();
        }
    }
}
