using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.Data.Interface
{
    public interface IGroup
    {
        void Subscribe(ISubscriber user);
        void Unsubscribe(ISubscriber user);
        void Notify();
    }
}
