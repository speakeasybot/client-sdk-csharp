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
using Codat.Models.Reports;
*/

public class EnhancedInvoicesReport
{
    [JsonProperty("reportInfo")]
    public ReportInfo? ReportInfo { get; set; }
    
    [JsonProperty("reportItems")]
    public IEnumerable<EnhancedInvoicesReportReportItems>? ReportItems { get; set; }
    
}