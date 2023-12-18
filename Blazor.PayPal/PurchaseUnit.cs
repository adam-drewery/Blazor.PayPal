using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class PurchaseUnit
{
    [JsonPropertyName("items")]
    public List<PurchaseItem>? Items { get; set; }
    
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; set; }

    [JsonPropertyName("amount")]
    public AmountWithBreakdown? Amount { get; set; }
}