using NotificationApplication.AdapterPattern.Adapter_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.AdapterPattern.Adapter_Implementation
{
    public class SMSFormat : ISMSFormat
    {
        String subject;
        String message;

        public SMSFormat(String subject,String message)
        {
            this.subject = subject;
            this.message = message;
        }
        public void ReadSMSFormat()
        {
            Console.WriteLine();
            Console.WriteLine("----------- SMS Format -----------");
            Console.WriteLine();
            Console.WriteLine($"Dear User, Your verfication code for {subject} is {message}. ");
            Console.WriteLine(" Please do not share your otp with anyone.");
            Console.WriteLine(" If this is not done by you, please call at 21####");
            Console.WriteLine($"Team {subject}. ");
            Console.WriteLine();
        }
    }
}
