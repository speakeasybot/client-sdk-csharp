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

public class EnhancedReportInfo
{
    [JsonProperty("companyName")]
    public string? CompanyName { get; set; }
    
    [JsonProperty("currency")]
    public string? Currency { get; set; }
    
    [JsonProperty("generatedDate")]
    public string? GeneratedDate { get; set; }
    
    [JsonProperty("reportName")]
    public string? ReportName { get; set; }
    
}