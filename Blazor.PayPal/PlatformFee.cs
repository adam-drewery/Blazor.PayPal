using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class PlatformFee
{
    [JsonPropertyName("amount")]
    public AmountWithCurrencyCodeOptional? Amount { get; set; }

    [JsonPropertyName("payee")]
    public Payee? PayeeInfo { get; set; }
}