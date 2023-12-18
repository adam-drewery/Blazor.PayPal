using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class PurchaseItem
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }

    [JsonPropertyName("unit_amount")]
    public AmountWithCurrencyCodeOptional? UnitAmount { get; set; }

    [JsonPropertyName("tax")]
    public AmountWithCurrencyCodeOptional? Tax { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; } // Could also be an enum
}