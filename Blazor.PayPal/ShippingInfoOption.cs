using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class ShippingInfoOption
{
    [JsonPropertyName("id")]
    [MaxLength(127)]
    public string? Id { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("amount")]
    public AmountWithCurrencyCode? Amount { get; set; }

    [JsonPropertyName("selected")]
    public bool Selected { get; set; }
}