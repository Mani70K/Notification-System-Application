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
    public class SMSNotificationStrategy : INotificationChannelStrategy
    {
        public void SendNotification(string subject, string message)
        {
            IRawFormat rawFormat;

            Console.WriteLine(" -------- Notification Via SMS Channel --------- ");


            rawFormat = new RawFormat(subject, message);

            ISMSFormat smsFormat = new RawToSMSAdapter(rawFormat);

            smsFormat.ReadSMSFormat();





            // Publish-Subscriber Pattern
            IGroup group;
            group = new SMSSubscriberGroup();

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
