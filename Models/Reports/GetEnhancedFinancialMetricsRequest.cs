///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace Codat.Models.Reports;
using Codat.Utils;
using Codat.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

/*

*/

public class GetEnhancedFinancialMetricsRequest
{
    [JsonProperty("companyId")]
    public string CompanyId { get; set; }
    
    [JsonProperty("connectionId")]
    public string ConnectionId { get; set; }
    
    [JsonProperty("numberOfPeriods")]
    public int NumberOfPeriods { get; set; }
    
    [JsonProperty("periodLength")]
    public int PeriodLength { get; set; }
    
    [JsonProperty("reportDate")]
    public string ReportDate { get; set; }
    
    [JsonProperty("showMetricInputs")]
    public bool? ShowMetricInputs { get; set; }
    
    internal HttpRequestMessage BuildHttpRequestMessage(string operationId)
    {
        if("get-enhanced-financial-metrics" == operationId)
        {
            // serialize query parameters
            var queryParams = new List<string>();
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "companyId", "", this.CompanyId));
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "connectionId", "", this.ConnectionId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "numberOfPeriods", "", this.NumberOfPeriods));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "periodLength", "", this.PeriodLength));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "reportDate", "", this.ReportDate));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "showMetricInputs", "", this.ShowMetricInputs));

            var queryParamString = $"?{String.Join("&", queryParams)}";
            // add path params
            
            var companyId = PathParamSerializer.Serialize("simple", false, this.CompanyId);
            
            var connectionId = PathParamSerializer.Serialize("simple", false, this.ConnectionId);
            
            
            
            
            var message = new HttpRequestMessage(HttpMethod.Get, $"/data/companies/{companyId}/connections/{connectionId}/assess/financialMetrics" + queryParamString);
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetEnhancedFinancialMetricsRequest]");
    }
}