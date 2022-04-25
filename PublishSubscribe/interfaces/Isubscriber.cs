using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.interfaces
{
    internal interface Isubscriber
    {
        string Name { get; set; }
        void Notify(string message);
    }
}
