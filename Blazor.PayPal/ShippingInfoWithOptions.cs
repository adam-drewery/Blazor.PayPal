using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class ShippingInfoWithOptions : ShippingInfoBase
{
    [JsonPropertyName("options")]
    public List<ShippingInfoOption>? Options { get; set; }
}