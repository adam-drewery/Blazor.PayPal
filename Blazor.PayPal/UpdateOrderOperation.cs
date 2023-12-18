using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class UpdateOrderOperation
{
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("value")]
    public Dictionary<string, object>? Value { get; set; }
}