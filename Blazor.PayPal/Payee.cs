using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class Payee
{
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; set; }

    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }
}