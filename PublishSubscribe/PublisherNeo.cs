using PublishSubscribe.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{
    internal class PublisherNeo : Ipublisher, IcontrolDriven
    {
        List<Isubscriber> subs;

        public void Publish()
        {
            if (subs != null) 
            {
                foreach (var s in subs) 
                {
                    s.Notify("Started");
                }
                Thread.Sleep(1000);
                foreach (var s in subs)
                {
                    s.Notify("Completed");
                }
            }
        }

        public void Subscribe(Isubscriber sub)
        {
            if (subs == null)
                subs = new List<Isubscriber>();
            subs.Add(sub);
        }
    }
}
