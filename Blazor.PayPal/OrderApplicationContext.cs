using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class OrderApplicationContext
{
    [JsonPropertyName("brand_name")]
    public string? BrandName { get; set; }

    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    [JsonPropertyName("shipping_preference")]
    public string? ShippingPreference { get; set; }

    [JsonPropertyName("user_action")]
    public string? UserAction { get; set; }

    [JsonPropertyName("payment_method")]
    public PaymentMethod? PaymentMethod { get; set; }
}