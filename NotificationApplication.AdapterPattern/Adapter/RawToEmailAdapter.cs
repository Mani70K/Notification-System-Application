using NotificationApplication.AdapterPattern.Adapter_Implementation;
using NotificationApplication.AdapterPattern.Adapter_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.AdapterPattern.Adapter
{
    public class RawToEmailAdapter : IEmailFormat
    {

        IRawFormat rawFormat;
        public RawToEmailAdapter(IRawFormat rawFormat)
        {
            this.rawFormat = rawFormat;
        }
        public void ReadEmailFormat()
        {
            String subject, message;
            IEmailFormat emailFormat;

            subject = rawFormat.GetSubject();
            message = rawFormat.GetMessage();

            emailFormat = new EmailFormat(subject,message);

            /*Console.WriteLine();

            Console.WriteLine("Original Format - - - - -");
            rawFormat.ReadRawFormat();
            Console.WriteLine();
            Console.WriteLine(" - - - - - To Email Format. ");*/

            Console.WriteLine();
            emailFormat.ReadEmailFormat();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Note: -> The Above Message Recieved By All Email Subscriber ");
        }
    }
}
