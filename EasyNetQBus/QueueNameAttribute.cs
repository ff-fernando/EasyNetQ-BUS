using System;

namespace EasyNetQBus
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class QueueNameAttribute : Attribute
    {
        public QueueNameAttribute(string queueName)
        {
            QueueName = queueName;
        }

        public string QueueName { get; set; }
    }
}
