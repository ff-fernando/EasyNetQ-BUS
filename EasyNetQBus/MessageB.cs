namespace EasyNetQBus
{
    [ExchangeName("ExchangeB")]
    [QueueName("MessageB")]
    public class MessageB
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
    }
}
