///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace Codat.Models.Shared;
using Codat.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

/*

*/

public class Payment
{
    [JsonProperty("accountRef")]
    public AccountRef? AccountRef { get; set; }
    
    [JsonProperty("currency")]
    public string? Currency { get; set; }
    
    [JsonProperty("currencyRate")]
    public float? CurrencyRate { get; set; }
    
    [JsonProperty("customerRef")]
    public CustomerRef? CustomerRef { get; set; }
    
    [JsonProperty("date")]
    public string Date { get; set; }
    
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("lines")]
    public IEnumerable<PaymentLine>? Lines { get; set; }
    
    [JsonProperty("metadata")]
    public PaymentMetadata? Metadata { get; set; }
    
    [JsonProperty("modifiedDate")]
    public string? ModifiedDate { get; set; }
    
    [JsonProperty("note")]
    public string? Note { get; set; }
    
    [JsonProperty("paymentMethodRef")]
    public PaymentPaymentMethodRef? PaymentMethodRef { get; set; }
    
    [JsonProperty("reference")]
    public string? Reference { get; set; }
    
    [JsonProperty("sourceModifiedDate")]
    public string? SourceModifiedDate { get; set; }
    
    [JsonProperty("supplementalData")]
    public PaymentSupplementalData? SupplementalData { get; set; }
    
    [JsonProperty("totalAmount")]
    public float? TotalAmount { get; set; }
    
}
