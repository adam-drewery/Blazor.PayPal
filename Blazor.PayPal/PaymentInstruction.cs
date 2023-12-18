using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class PaymentInstruction
{
    [JsonPropertyName("platform_fees")]
    public List<PlatformFee>? PlatformFees { get; set; }

    [JsonPropertyName("disbursement_mode")]
    public string? DisbursementMode { get; set; } // Could also be an enum
}