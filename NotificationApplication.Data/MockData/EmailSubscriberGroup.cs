using NotificationApplication.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.Data.MockData
{
    public class EmailSubscriberGroup : IGroup
    {
        private List<ISubscriber> emailuser = new List<ISubscriber>();
        public void Notify()
        {
            Console.WriteLine("----- :Email Notification Recieved: -----");
            Console.WriteLine();
            foreach (var user in emailuser)
            {
                user.Notify();
            }
        }

        public void Subscribe(ISubscriber user)
        {
            if (!emailuser.Contains(user))
            {
                emailuser.Add(user);
            }

        }

        public void Unsubscribe(ISubscriber user)
        {
            emailuser.Remove(user);
        }
    }
}
