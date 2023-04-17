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

public class ReportDimension
{
    [JsonProperty("displayName")]
    public string? DisplayName { get; set; }
    
    [JsonProperty("index")]
    public int? Index { get; set; }
    
    [JsonProperty("items")]
    public IEnumerable<ReportDimensionItems>? Items { get; set; }
    
    [JsonProperty("type")]
    public string? Type { get; set; }
    
}
