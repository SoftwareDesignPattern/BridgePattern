﻿using System;

namespace BridgePattern.Sender
{
    class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Service Sender: \n{0}\n{1}\n", subject, body);
        }
    }
}
