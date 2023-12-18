using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class AmountWithCurrencyCodeOptional
{
    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}