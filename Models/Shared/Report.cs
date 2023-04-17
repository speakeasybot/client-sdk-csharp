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
using Codat.Models.ExcelReports;
using Codat.Models.Reports;
*/

public class Report
{
    [JsonProperty("dimensions")]
    public IEnumerable<ReportDimension>? Dimensions { get; set; }
    
    [JsonProperty("errors")]
    public IEnumerable<ReportError>? Errors { get; set; }
    
    [JsonProperty("measures")]
    public IEnumerable<ReportMeasure>? Measures { get; set; }
    
    [JsonProperty("reportData")]
    public IEnumerable<ReportComponent>? ReportData { get; set; }
    
    [JsonProperty("reportInfo")]
    public Dictionary<string, string>? ReportInfo { get; set; }
    
}