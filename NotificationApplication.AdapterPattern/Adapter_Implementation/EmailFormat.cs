using NotificationApplication.AdapterPattern.Adapter_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.AdapterPattern.Adapter_Implementation
{
    public class EmailFormat : IEmailFormat
    {
        String subject;
        String message;

        public EmailFormat(String subject, String message)
        {
            this.subject = subject;
            this.message = message;
        }
        public void ReadEmailFormat()
        {
            Console.WriteLine();
            Console.WriteLine("----------- Email Format -----------");
            Console.WriteLine("Hi User ");
            Console.WriteLine();
            Console.WriteLine($"  You have requested for {subject} to login to your gmail account. If this was you please input the code below to continue.");
            Console.WriteLine();
            Console.WriteLine($"  {message}  ");
            Console.WriteLine();
            Console.WriteLine("  If this wasn't you, let us know here. We recommend that you update your password to secure your account.");
            Console.WriteLine();
            Console.WriteLine("Regards,");
            Console.WriteLine("Team Google");
            Console.WriteLine();
        }
    }
}
