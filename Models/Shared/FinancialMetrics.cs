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

public class FinancialMetrics
{
    [JsonProperty("currency")]
    public string? Currency { get; set; }
    
    [JsonProperty("errors")]
    public IEnumerable<FinancialMetricError>? Errors { get; set; }
    
    [JsonProperty("metrics")]
    public IEnumerable<FinancialMetric>? Metrics { get; set; }
    
    [JsonProperty("periodUnit")]
    public FinancialMetricsPeriodUnitEnum? PeriodUnit { get; set; }
    
}
