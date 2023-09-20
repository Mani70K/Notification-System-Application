using NotificationApplication.Channels.NotificationChannel_Implementation;
using NotificationApplication.Channels.NotificationChannel_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.FactoryPattern.Factory
{
    public class NotificationChannelFactory
    {
        public static INotificationChannel GetNotificationChannel(String channelType)
        {
            INotificationChannel channel;
            if (channelType == "1" || channelType == "email")
            {
                channel = new EmailNotificationChannel();
            }
            else if (channelType == "2" || channelType == "sms")
            {
                channel = new SMSNotificationChannel();
            }
            else
            {
                // The else condition will not be called because i have already verified the valid notification channel  
                channel = null;
            }
            return channel;
        }
    }
}
