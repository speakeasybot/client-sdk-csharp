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

public class FinancialMetricErrors
{
    [JsonProperty("details")]
    public Dictionary<string, IEnumerable<string>>? Details { get; set; }
    
    [JsonProperty("message")]
    public string? Message { get; set; }
    
    [JsonProperty("type")]
    public FinancialMetricErrorsTypeEnum? Type { get; set; }
    
}