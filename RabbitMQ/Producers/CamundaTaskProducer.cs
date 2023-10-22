using System.Text;
using System.Text.Json;
using RabbitMQ.Client;

namespace RabbitMQ.Implementations;

public class CamundaTaskProducer
{
    public void SendMessage<T>(T message)
    {
        var factory = new ConnectionFactory { HostName = "localhost" };
        var connection = factory.CreateConnection();
        using var channel = connection.CreateChannel();
        var json = JsonSerializer.Serialize(message);
        var body = Encoding.UTF8.GetBytes(json);

        channel.BasicPublish(exchange: "", routingKey: "camundaTask", body: body);
    }
}