using BridgePattern.Messages;
using BridgePattern.Sender;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender _EmailSender = new EmailSender();
            IMessageSender _MSMQSender = new MSMQSender();
            IMessageSender _WebServiceSender = new WebServiceSender();



            //User Message
            UserMessage _UserMessage = new UserMessage();
            _UserMessage.Subject = "User Message Subject: My system is not working";
            _UserMessage.Body = "User Message Body: Hello, Test message";
            _UserMessage.UserComments = "User Message Commenst: Hope you are doing well!";



            //Using Email Sender: User Message
            _UserMessage.MessageSender = _EmailSender;
            _UserMessage.Send();


            //Using MSMQ Sender: User Message           
            _UserMessage.MessageSender = _MSMQSender;
            _UserMessage.Send();


            //Using Web Service ender: User Message        
            _UserMessage.MessageSender = _WebServiceSender;
            _UserMessage.Send();




            //System Message
            Message _SystemMessage = new SystemMessage();
            _SystemMessage.Subject = "System Message Subject: Critical System error";
            _SystemMessage.Body = "System Message Body: System not working!!!";


            //Using Email Sender: System Message
            _SystemMessage.MessageSender = _EmailSender;
            _SystemMessage.Send();


            //Using MSMQ Sender: User Message           
            _SystemMessage.MessageSender = _MSMQSender;
            _SystemMessage.Send();


            //Using Web ServiceS ender: System Message        
            _SystemMessage.MessageSender = _WebServiceSender;
            _SystemMessage.Send();



            Console.ReadLine();

        }
    }
}
