using NotificationApplication.Channels.NotificationChannel_Interface;
using NotificationApplication.FacadePattern.Facade_Interface;
using NotificationApplication.FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.FacadePattern.Facade_Implementation
{
    public class UserNotificationSystem : IUserNotificationSystem
    {
        private static UserNotificationSystem instance;
        private UserNotificationSystem()
        {

        }


        public static UserNotificationSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new UserNotificationSystem();
            }
            return instance;
        }
        public void SendNotification(string channel, string subject, string message)
        {
            INotificationChannel notificationChannel = NotificationChannelFactory.GetNotificationChannel(channel);
            notificationChannel.SendNotification(subject, message);
            
        }
    }
}
