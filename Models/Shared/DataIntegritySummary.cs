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

public class DataIntegritySummary
{
    [JsonProperty("byAmount")]
    public DataIntegrityByAmount? ByAmount { get; set; }
    
    [JsonProperty("byCount")]
    public DataIntegrityByCount? ByCount { get; set; }
    
    [JsonProperty("type")]
    public string? Type { get; set; }
    
}
