using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class CreateOrderRequestBody
{
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    [JsonPropertyName("purchase_units")]
    public List<PurchaseUnit>? PurchaseUnits { get; set; }

    [JsonPropertyName("payer")]
    public Payer? Payer { get; set; }

    [JsonPropertyName("application_context")]
    public OrderApplicationContext? ApplicationContext { get; set; }

    [JsonPropertyName("payment_source")]
    public Dictionary<string, object>? PaymentSource { get; set; }
}