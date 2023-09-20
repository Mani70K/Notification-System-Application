using NotificationApplication.Channels.NotificationChannel_AbstractClass;
using NotificationApplication.StrategyPattern.Strategy_Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.Channels.NotificationChannel_Implementation
{
    public class EmailNotificationChannel: NotificationChannel
    {
        public EmailNotificationChannel():base(new EmailNotificationStrategy())
        {

        }
    }
}
