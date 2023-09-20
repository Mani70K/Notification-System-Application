using NotificationApplication.AdapterPattern.Adapter_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.AdapterPattern.Adapter_Implementation
{
    public class RawFormat : IRawFormat
    {
        String subject;
        String message;

        public RawFormat(String subject, String message)
        {
            this.subject = subject;
            this.message = message;
        }

        public string GetMessage()
        {
            return message;
        }

        public string GetSubject()
        {
            return subject;
        }

        public void ReadRawFormat()
        {
            Console.WriteLine();
            Console.WriteLine("----------- Raw Format -----------");
            Console.WriteLine($" Subject: -> {subject} \n Message: -> {message} ");
            Console.WriteLine();
        }
    }
}
