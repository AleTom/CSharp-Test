using PublishSubscribe.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{
    internal class Subscriber : Isubscriber
    {
        public string Name { get; set; }

        public void Notify(string message)
        {
            Console.WriteLine(this.Name + " : " + message);
        }
    }
}
