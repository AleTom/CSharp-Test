using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.interfaces
{
    internal interface IcontrolDriven
    {
        void Subscribe(Isubscriber sub);
    }
}
