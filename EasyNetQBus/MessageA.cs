namespace EasyNetQBus
{
    [ExchangeName("ExchangeA")]
    [QueueName("MessageA")]
    public class MessageA
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
}
