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

public class PaymentLineLink
{
    [JsonProperty("amount")]
    public float? Amount { get; set; }
    
    [JsonProperty("currencyRate")]
    public float? CurrencyRate { get; set; }
    
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("type")]
    public PaymentLinkTypeEnum Type { get; set; }
    
}
