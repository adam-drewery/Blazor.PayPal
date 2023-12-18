using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class OrderResponseBody : OrderResponseBodyMinimal
{
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    [JsonPropertyName("payer")]
    public Payer? Payer { get; set; }

    [JsonPropertyName("purchase_units")]
    public List<PurchaseUnit>? PurchaseUnits { get; set; }

    [JsonPropertyName("processing_instruction")]
    public string? ProcessingInstruction { get; set; }

    [JsonPropertyName("payment_source")]
    public Dictionary<string, object>? PaymentSource { get; set; }

    [JsonPropertyName("expiration_time")]
    public string? ExpirationTime { get; set; }

    [JsonPropertyName("credit_financing_offer")]
    public CreditFinancingOffer? CreditFinancingOffer { get; set; }
}