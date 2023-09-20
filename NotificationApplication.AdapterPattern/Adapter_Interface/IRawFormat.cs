using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationApplication.AdapterPattern.Adapter_Interface
{
    public interface IRawFormat
    {
        void ReadRawFormat();
        String GetSubject();
        String GetMessage();
    }

}
