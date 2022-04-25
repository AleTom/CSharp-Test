using PublishSubscribe.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{
    internal class Publisher : Ipublisher, IeventDriven
    {
        public event MessageNotifier Notify;

        public void Publish()
        {
            Notify("Message published");
        }
    }
}
