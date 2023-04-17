///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace Codat.Models.Categories;
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

public class UpdateAccountsCategoriesRequest
{
    [JsonProperty("ConfirmCategories")]
    public ConfirmCategories? ConfirmCategories { get; set; }
    
    [JsonProperty("companyId")]
    public string CompanyId { get; set; }
    
    [JsonProperty("connectionId")]
    public string ConnectionId { get; set; }
    
    internal HttpRequestMessage BuildHttpRequestMessage(string operationId)
    {
        if("update-accounts-categories" == operationId)
        {
            // add path params
            
            
            var companyId = PathParamSerializer.Serialize("simple", false, this.CompanyId);
            
            var connectionId = PathParamSerializer.Serialize("simple", false, this.ConnectionId);
            var message = new HttpRequestMessage(HttpMethod.Patch, $"/data/companies/{companyId}/connections/{connectionId}/assess/accounts/categories");
            

            // do json serialization
            // ConfirmCategories :: UpdateAccountsCategoriesRequest

            string json = JsonConvert.SerializeObject(this.ConfirmCategories);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [UpdateAccountsCategoriesRequest]");
    }
}