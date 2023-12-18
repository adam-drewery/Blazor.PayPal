using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class PaymentMethod
{
    [JsonPropertyName("payer_selected")]
    public string? PayerSelected { get; set; }

    [JsonPropertyName("payee_preferred")]
    public string? PayeePreferred { get; set; }
}