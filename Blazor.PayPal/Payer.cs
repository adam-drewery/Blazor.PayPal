using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Blazor.PayPal;

public class Payer
{
    public class Name
    {
        [JsonPropertyName("given_name")]
        [MaxLength(140)]
        public string? GivenName { get; set; }

        [JsonPropertyName("surname")]
        [MaxLength(140)]
        public string? Surname { get; set; }
    }

    public class Phone
    {
        [JsonPropertyName("phone_type")]
        public string? PhoneType { get; set; }

        [JsonPropertyName("phone_number")]
        public PhoneNumberType? PhoneNumber { get; set; }
    }

    public class PhoneNumberType
    {
        [JsonPropertyName("national_number")]
        public string? NationalNumber { get; set; }
    }

    public class TaxInfo
    {
        [JsonPropertyName("tax_id")]
        public string? TaxId { get; set; }

        [JsonPropertyName("tax_id_type")]
        public string? TaxIdType { get; set; }
    }

    [JsonPropertyName("name")]
    public Name? NameInfo { get; set; }

    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; set; }

    [JsonPropertyName("payer_id")]
    public string? PayerId { get; set; }

    [JsonPropertyName("phone")]
    public Phone? PhoneInfo { get; set; }

    [JsonPropertyName("birth_date")]
    public string? BirthDate { get; set; }

    [JsonPropertyName("tax_info")]
    public TaxInfo? TaxInformation { get; set; }

    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}