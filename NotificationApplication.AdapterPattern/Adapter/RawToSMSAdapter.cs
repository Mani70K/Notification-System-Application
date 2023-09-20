using NotificationApplication.AdapterPattern.Adapter_Implementation;
using NotificationApplication.AdapterPattern.Adapter_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.AdapterPattern.Adapter
{
    public class RawToSMSAdapter : ISMSFormat
    {
        IRawFormat rawFormat;
        public RawToSMSAdapter(IRawFormat rawFormat)
        {
            this.rawFormat = rawFormat;
        }

        public void ReadSMSFormat()
        {
            String subject, message;
            ISMSFormat smsFormat;

            subject = rawFormat.GetSubject();
            message = rawFormat.GetMessage();

            smsFormat = new SMSFormat(subject, message);

            /*Console.WriteLine("Original Format - - - - -");
            rawFormat.ReadRawFormat();
            Console.WriteLine();
            Console.WriteLine(" - - - - - To SMS Format. ");*/
            Console.WriteLine();
            smsFormat.ReadSMSFormat();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Note: -> The Above Message Recieved By All SMS Subscriber ");
        }
    }
}
