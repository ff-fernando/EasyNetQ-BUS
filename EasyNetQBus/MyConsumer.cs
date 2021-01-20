using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using EasyNetQBus.IoC;
using System;

namespace EasyNetQBus
{
    public class MyConsumer :
        IConsume<MessageA>,
        IConsume<MessageB>
    {
        public void Consume(MessageA message)
        {
            Console.WriteLine("Message received MessageA: " + message.Message);

            Bootstrap.container.GetInstance<IBus>().Publish(new MessageB { Cod = 2, Nome = message.Message + " - Segunnda parte" });
        }

        public void Consume(MessageB message)
        {
            var teste = message.Cod;

            Console.WriteLine("Message received MessageB: " + message.Nome);
        }
    }
}
