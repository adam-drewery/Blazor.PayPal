using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class AmountWithBreakdown : AmountWithCurrencyCodeOptional
{
    public class Breakdown
    {
        [JsonPropertyName("item_total")]
        public AmountWithCurrencyCode? ItemTotal { get; set; }

        [JsonPropertyName("shipping")]
        public AmountWithCurrencyCode? Shipping { get; set; }

        [JsonPropertyName("handling")]
        public AmountWithCurrencyCode? Handling { get; set; }

        [JsonPropertyName("tax_total")]
        public AmountWithCurrencyCode? TaxTotal { get; set; }

        [JsonPropertyName("insurance")]
        public AmountWithCurrencyCode? Insurance { get; set; }

        [JsonPropertyName("shipping_discount")]
        public AmountWithCurrencyCode? ShippingDiscount { get; set; }

        [JsonPropertyName("discount")]
        public AmountWithCurrencyCode? Discount { get; set; }
    }

    [JsonPropertyName("breakdown")]
    public Breakdown? BreakdownInfo { get; set; }
}