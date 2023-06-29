
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.Categories
{
    using System;
using System.Net.Http;
using Newtonsoft.Json;
using Codat.Utils;
    
    public class GetAccountCategoryRequest
    {
    /// <summary>
    /// Nominal account id
    /// </summary>
        
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
        
        
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }
        
        
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetAccountCategoryRequest value, string baseUrl)
        {
            if("get-account-category" == operationId)
            {
                
                var accountId = PathParamSerializer.Serialize("simple", false, value.AccountId);
                
                var companyId = PathParamSerializer.Serialize("simple", false, value.CompanyId);
                
                var connectionId = PathParamSerializer.Serialize("simple", false, value.ConnectionId);
                var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/data/companies/{companyId}/connections/{connectionId}/assess/accounts/{accountId}/categories");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetAccountCategoryRequest]");
        }
    }
}