using System.Text.Json.Serialization;

namespace Web.Models.Dtos.Camunda;

public class CompleteCamundaTaskDto : BaseDto
{
    [JsonPropertyName("variables")]
    public Dictionary<string, Dictionary<string, object>>? Variables { get; set; } 
}