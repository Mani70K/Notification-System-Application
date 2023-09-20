using NotificationApplication.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.Data.MockData
{
    public class SMSSubscriberGroup : IGroup
    {
        private readonly List<ISubscriber> smsuser = new List<ISubscriber>();
        public void Notify()
        {
            Console.WriteLine("----- :SMS Notification Recieved: -----");
            Console.WriteLine();
            foreach (var user in smsuser)
            {
                user.Notify();
            }
        }

        public void Subscribe(ISubscriber user)
        {
            if (!smsuser.Contains(user))
            {
                smsuser.Add(user);
            }

        }

        public void Unsubscribe(ISubscriber user)
        {
            smsuser.Remove(user);
        }
    }
}
