
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.DataIntegrity
{
    using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Codat.Models.Shared;
using Codat.Utils;
    
    public class ListDataTypeDataIntegrityDetailsRequest
    {
        
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }
        
    /// <summary>
    /// A key for a Codat data type.
    /// </summary>
        
        [JsonProperty("dataType")]
        public DataIntegrityDataType DataType { get; set; }
        
    /// <summary>
    /// Field to order results by. [Read more](https://docs.codat.io/using-the-api/ordering-results).
    /// </summary>
        
        [JsonProperty("orderBy")]
        public string? OrderBy { get; set; }
        
    /// <summary>
    /// Page number. [Read more](https://docs.codat.io/using-the-api/paging).
    /// </summary>
        
        [JsonProperty("page")]
        public int? Page { get; set; }
        
    /// <summary>
    /// Number of records to return in a page. [Read more](https://docs.codat.io/using-the-api/paging).
    /// </summary>
        
        [JsonProperty("pageSize")]
        public int? PageSize { get; set; }
        
    /// <summary>
    /// Codat query string. [Read more](https://docs.codat.io/using-the-api/querying).
    /// </summary>
        
        [JsonProperty("query")]
        public string? Query { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, ListDataTypeDataIntegrityDetailsRequest value, string baseUrl)
        {
            if("list-data-type-data-integrity-details" == operationId)
            {
                var queryParams = new List<string>();
                
                
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "orderBy", "", value.OrderBy));
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "page", "", value.Page));
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "pageSize", "", value.PageSize));
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "query", "", value.Query));
                var queryParamString = $"?{String.Join("&", queryParams)}";
                
                var companyId = PathParamSerializer.Serialize("simple", false, value.CompanyId);
                
                var dataType = PathParamSerializer.Serialize("simple", false, value.DataType);
                
                
                
                
                var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/data/companies/{companyId}/assess/dataTypes/{dataType}/dataIntegrity/details" + queryParamString);
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [ListDataTypeDataIntegrityDetailsRequest]");
        }
    }
}