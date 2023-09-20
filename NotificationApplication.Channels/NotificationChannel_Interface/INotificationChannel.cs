using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.Channels.NotificationChannel_Interface
{
    public interface INotificationChannel
    {
        void SendNotification(String subject, String message);
    }

}
