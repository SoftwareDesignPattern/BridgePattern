using System;

namespace BridgePattern.Sender
{
    class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ Sender: \n{0}\n{1}\n", subject, body);
        }
    }
}
