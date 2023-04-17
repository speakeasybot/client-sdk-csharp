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

public class DataIntegrityMatch
{
    [JsonProperty("amount")]
    public string? Amount { get; set; }
    
    [JsonProperty("connectionId")]
    public string? ConnectionId { get; set; }
    
    [JsonProperty("currency")]
    public string? Currency { get; set; }
    
    [JsonProperty("date")]
    public string? Date { get; set; }
    
    [JsonProperty("description")]
    public string? Description { get; set; }
    
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    [JsonProperty("type")]
    public string? Type { get; set; }
    
}
