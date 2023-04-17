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
using Codat.Models.DataIntegrity;
*/

public class Details
{
    [JsonProperty("_links")]
    public Links Links { get; set; }
    
    [JsonProperty("pageNumber")]
    public int PageNumber { get; set; }
    
    [JsonProperty("pageSize")]
    public int PageSize { get; set; }
    
    [JsonProperty("results")]
    public IEnumerable<DataIntegrityDetails>? Results { get; set; }
    
    [JsonProperty("totalResults")]
    public int TotalResults { get; set; }
    
}
