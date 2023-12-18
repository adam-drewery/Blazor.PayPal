using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class OrderResponseBodyMinimal
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("links")]
    public List<LinkDescription>? Links { get; set; }
}