using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class ShippingInfoWithType : ShippingInfoBase
{
    [JsonPropertyName("type")]
    public string? Type { get; set; } // Could also be an enum

    // No options for this type
}