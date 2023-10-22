namespace RabbitMQ.Implementations;

public interface IMessageProducer
{
    void SendMessage<T>(T message);
}