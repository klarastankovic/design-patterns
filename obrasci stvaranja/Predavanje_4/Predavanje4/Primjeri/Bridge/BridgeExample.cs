using Primjeri.Utilities;
using System.Collections.Generic;

namespace Primjeri.Bridge
{
    class BridgeExample : IExample
    {
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        public void Run()
        {
            List<IMessageSender> senders = new List<IMessageSender>(){
                new EmailSender(), new MSMQSender(), new WebServiceSender()
            };

            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";

            foreach (IMessageSender sender in senders)
            {
                message.MessageSender = sender;
                message.Send();
            }

            UserMessage userMessage = new UserMessage();
            userMessage.Subject = "Test Message";
            userMessage.Body = "Hi, This is a Test Message";
            userMessage.UserComments = "I can add comments!!!!!";

            userMessage.MessageSender = new EmailSender();
            userMessage.Send();
        }
    }
}
