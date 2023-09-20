using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.FacadePattern.Facade_Interface
{
    public interface IUserNotificationSystem
    {
        public void SendNotification(String channel, String subject, String message);
    }
}
