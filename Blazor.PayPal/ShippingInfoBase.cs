using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public abstract class ShippingInfoBase
{
    public class Name
    {
        [JsonPropertyName("full_name")]
        public string? FullName { get; set; }
    }

    public class PhoneNumber
    {
        [JsonPropertyName("national_number")]
        public string? NationalNumber { get; set; }
    }

    [JsonPropertyName("name")]
    public Name? NameInfo { get; set; }

    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    [JsonPropertyName("phone_number")]
    public PhoneNumber? PhoneNumberInfo { get; set; }

    [JsonPropertyName("address")]
    public Address? AddressInfo { get; set; }
}