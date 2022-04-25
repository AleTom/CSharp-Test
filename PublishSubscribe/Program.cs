using System;

namespace PublishSubscribe 
{
    /// <summary>
    /// I proposed two implementation of the subscriber publisher pattern, the firs is a classic event driven subscription which however I noticed in my experience to be 
    /// less scalable as when code complexity increases the event hadling can grow out of control and events are not properly disposed in memory.
    /// I therefore prefer a control driven publisher/subscriber which is more controllable ans scalable.
    /// The interface structure is based on a publisher of two flavours event driven and control driven.
    /// </summary>
    static class Program {
        static void Main() 
        {
            var pub = new Publisher();
            var neo = new PublisherNeo();

            var sub1 = new Subscriber();
            var sub2 = new Subscriber();
            sub1.Name = "sub 1";
            sub2.Name = "sub 2";

            pub.Notify += Pub_Notify;
            pub.Publish();

            neo.Subscribe(sub1);
            neo.Subscribe(sub2);

            neo.Publish();

            Console.ReadLine();
        }

        private static void Pub_Notify(string messsage)
        {
            Console.WriteLine("Subscribed received " + messsage);
        }
    }
}
