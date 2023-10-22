using System.Text.Json.Serialization;

namespace Web.Models.Dtos;

public class CompleteCamundaExternalTaskDto : BaseDto
{
    [JsonPropertyName("workerId")]
    public string? WorkerId { get; set; }
    [JsonPropertyName("variables")]
    public Dictionary<string, Dictionary<string, object>>? Variables { get; set; }
    [JsonPropertyName("topic")]
    public CamundaTopicDto? Topic { get; set; }
}