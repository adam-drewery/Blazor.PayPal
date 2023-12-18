using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class CreditFinancingOffer
{
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("total_payment")]
    public AmountWithCurrencyCodeOptional? TotalPayment { get; set; }

    [JsonPropertyName("total_interest")]
    public AmountWithCurrencyCodeOptional? TotalInterest { get; set; }

    [JsonPropertyName("installment_details")]
    public InstallmentDetails? InstallmentDetails { get; set; }

    [JsonPropertyName("term")]
    public int Term { get; set; }
}