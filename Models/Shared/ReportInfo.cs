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

public class ReportInfo
{
    [JsonProperty("companyName")]
    public string? CompanyName { get; set; }
    
    [JsonProperty("generatedDate")]
    public string? GeneratedDate { get; set; }
    
    [JsonProperty("pageNumber")]
    public int? PageNumber { get; set; }
    
    [JsonProperty("pageSize")]
    public int? PageSize { get; set; }
    
    [JsonProperty("reportName")]
    public string? ReportName { get; set; }
    
    [JsonProperty("totalResults")]
    public int? TotalResults { get; set; }
    
}
