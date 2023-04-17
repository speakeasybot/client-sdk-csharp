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

public class GetRecurringRevenueMetricsRequest
{
    [JsonProperty("companyId")]
    public string CompanyId { get; set; }
    
    [JsonProperty("connectionId")]
    public string ConnectionId { get; set; }
    
    internal HttpRequestMessage BuildHttpRequestMessage(string operationId)
    {
        if("get-recurring-revenue-metrics" == operationId)
        {
            // add path params
            
            var companyId = PathParamSerializer.Serialize("simple", false, this.CompanyId);
            
            var connectionId = PathParamSerializer.Serialize("simple", false, this.ConnectionId);
            var message = new HttpRequestMessage(HttpMethod.Get, $"/data/companies/{companyId}/connections/{connectionId}/assess/subscriptions/mrr");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetRecurringRevenueMetricsRequest]");
    }
}