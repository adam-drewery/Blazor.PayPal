using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class InstallmentDetails
{
    [JsonPropertyName("period")]
    public string? Period { get; set; }

    [JsonPropertyName("interval_duration")]
    public string? IntervalDuration { get; set; }

    [JsonPropertyName("payment_due")]
    public AmountWithCurrencyCodeOptional? PaymentDue { get; set; }
}