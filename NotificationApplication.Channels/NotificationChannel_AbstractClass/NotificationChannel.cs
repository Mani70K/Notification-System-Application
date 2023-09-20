using NotificationApplication.Channels.NotificationChannel_Interface;
using NotificationApplication.StrategyPattern.Strategy_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.Channels.NotificationChannel_AbstractClass
{
    public abstract class NotificationChannel : INotificationChannel
    {
        INotificationChannelStrategy notificationChannelStrategy;
        public NotificationChannel(INotificationChannelStrategy notificationChannelStrategy)
        {
            this.notificationChannelStrategy = notificationChannelStrategy;
        }
        public void SendNotification(string subject, string message)
        {
            notificationChannelStrategy.SendNotification(subject,message);
        }
    }
}
