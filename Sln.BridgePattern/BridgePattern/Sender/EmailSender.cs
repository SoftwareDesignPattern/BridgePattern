using System;

namespace BridgePattern.Sender
{
    class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Email Sender: \n{0}\n{1}\n", subject, body);
        }
    }
}
