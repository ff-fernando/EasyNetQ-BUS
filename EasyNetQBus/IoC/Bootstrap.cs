using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using SimpleInjector;
using System;
using System.Configuration;
using System.Reflection;

namespace EasyNetQBus.IoC
{
    public class Bootstrap
    {
        public static Container container;

        public static void Start()
        {
            container = new Container();

            container.Register<IBus>(() => RabbitHutch.CreateBus(ConfigurationManager.ConnectionStrings["rabbitmqConnection"].ConnectionString,
                x => x.Register<IConventions, AttributeBasedConventions>()), 
                Lifestyle.Singleton);

            var subscriber = new AutoSubscriber(RabbitHutch.CreateBus(ConfigurationManager.ConnectionStrings["rabbitmqConnection"].ConnectionString,
                x => x.Register<IConventions, AttributeBasedConventions>()),
                AppDomain.CurrentDomain.FriendlyName);
            subscriber.Subscribe(Assembly.GetExecutingAssembly());
        }
    }
}
