using System;

namespace EasyNetQBus
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ExchangeNameAttribute : Attribute
    {
        public ExchangeNameAttribute(string exchangeName)
        {
            ExchangeName = exchangeName;
        }

        public string ExchangeName { get; set; }
    }
}
