using NotificationApplication.AdapterPattern.Adapter;
using NotificationApplication.AdapterPattern.Adapter_Implementation;
using NotificationApplication.AdapterPattern.Adapter_Interface;
using NotificationApplication.Data.Entities;
using NotificationApplication.Data.Interface;
using NotificationApplication.Data.MockData;
using NotificationApplication.StrategyPattern.Strategy_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.StrategyPattern.Strategy_Implementation
{
    public class EmailNotificationStrategy : INotificationChannelStrategy
    {
        public void SendNotification(string subject, string message)
        {
            IRawFormat rawFormat;

            Console.WriteLine(" -------- Notification Via Email Channel --------- ");


            rawFormat = new RawFormat(subject, message);

            IEmailFormat emailFormat = new RawToEmailAdapter(rawFormat);

            emailFormat.ReadEmailFormat();


            // Publish-Subscriber Pattern
            IGroup group;
            group = new EmailSubscriberGroup();

            ISubscriber user1 = new User(1);
            ISubscriber user2 = new User(2);
            ISubscriber user4 = new User(4);

            Console.WriteLine();
            group.Subscribe(user1);
            group.Subscribe(user2);
            group.Subscribe(user4);
            group.Unsubscribe(user1);
            group.Notify();
        }
    }
}
