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

public class GetAccountsForEnhancedBalanceSheetRequest
{
    [JsonProperty("companyId")]
    public string CompanyId { get; set; }
    
    [JsonProperty("numberOfPeriods")]
    public int NumberOfPeriods { get; set; }
    
    [JsonProperty("reportDate")]
    public string ReportDate { get; set; }
    
    internal HttpRequestMessage BuildHttpRequestMessage(string operationId)
    {
        if("get-accounts-for-enhanced-balance-sheet" == operationId)
        {
            // serialize query parameters
            var queryParams = new List<string>();
            queryParams.Add(QueryParamSerializer.Serialize("simple",false, "companyId", "", this.CompanyId));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "numberOfPeriods", "", this.NumberOfPeriods));
            queryParams.Add(QueryParamSerializer.Serialize("form",true, "reportDate", "", this.ReportDate));

            var queryParamString = $"?{String.Join("&", queryParams)}";
            // add path params
            
            var companyId = PathParamSerializer.Serialize("simple", false, this.CompanyId);
            
            
            var message = new HttpRequestMessage(HttpMethod.Get, $"/companies/{companyId}/reports/enhancedBalanceSheet/accounts" + queryParamString);
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetAccountsForEnhancedBalanceSheetRequest]");
    }
}
