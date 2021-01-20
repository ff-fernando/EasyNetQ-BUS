using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyNetQBus
{
    public class PublisherService
    {
        private IBus _bus;

        public PublisherService(IBus bus)
        {
            _bus = bus;
        }

        public void Process()
        {
            var input = String.Empty;
            Console.WriteLine("Enter a message. 'Quit' to quit.");
            while ((input = Console.ReadLine()) != "Quit")
            {
                _bus.Publish(new MessageA { Id = 1, Message = input });
                //Console.WriteLine("Message published!");
            }
        }
    }
}
