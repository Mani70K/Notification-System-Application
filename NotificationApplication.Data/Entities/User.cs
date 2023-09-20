using NotificationApplication.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.Data.Entities
{
    public class User : ISubscriber
    {
        private readonly int userId;
        public User(int userId)
        {
            this.userId = userId;
        }

        public void Notify()
        {
            Console.WriteLine($"User With Id {userId} Has Received Notification ");
        }
    }
}
