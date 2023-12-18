using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class AmountWithCurrencyCode
{
    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }  // Assuming value is a string representing a number, else adjust the type accordingly
}