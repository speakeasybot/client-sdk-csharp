///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace Codat.Models.ExcelReports;
using Codat.Utils;
using Codat.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

/*
using Codat.Models.Shared;
*/

public class GetAccountingMarketingMetricsResponse {
    public string? ContentType { get; set; }
    
    public Report? Report { get; set; }
    
    public int StatusCode { get; set; }
    
    public HttpResponseMessage? RawResponse { get; set; }
    
}