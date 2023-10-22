using System.Text.Json.Serialization;

namespace Web.Models.Dtos.Camunda;

public class CamundaTopicDto
{
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
    [JsonPropertyName("lockDuration")]
    public int LockDuration { get; set; }
    [JsonPropertyName("variables")]
    public List<string>? Variables { get; set; }
}