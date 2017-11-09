namespace BridgePattern.Sender
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
