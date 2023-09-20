using NotificationApplication.Channels.NotificationChannel_AbstractClass;
using NotificationApplication.StrategyPattern.Strategy_Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.Channels.NotificationChannel_Implementation
{
    public class SMSNotificationChannel :NotificationChannel
    {
        public SMSNotificationChannel():base(new SMSNotificationStrategy())
        {

        }
    }
}
