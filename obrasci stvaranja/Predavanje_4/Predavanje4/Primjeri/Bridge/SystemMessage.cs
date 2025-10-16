namespace Primjeri.Bridge
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
