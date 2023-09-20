using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.StrategyPattern.Strategy_Interface
{
    public interface INotificationChannelStrategy
    {
        void SendNotification(String subject, String message);
    }
}
