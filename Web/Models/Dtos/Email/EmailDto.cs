using System.Text.Json.Serialization;

namespace Web.Models.Dtos.Email;

public class EmailDto
{
    [JsonPropertyName("Status")]
    public string Status { get; set; }
    [JsonPropertyName("EmailAddress")]
    public string EmailAddress { get; set; }
}