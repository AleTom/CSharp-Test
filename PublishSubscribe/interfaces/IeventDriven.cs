using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.interfaces
{
    public delegate void MessageNotifier(string messsage);
    internal interface IeventDriven
    {
        event MessageNotifier Notify;
    }
}
