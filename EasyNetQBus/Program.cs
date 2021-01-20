using EasyNetQ;
using EasyNetQBus.IoC;
using System;

namespace EasyNetQBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrap.Start();

            new PublisherService(Bootstrap.container.GetInstance<IBus>()).Process();
        }
    }
}
