
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.Reports
{
    using System.Net.Http;
using Codat.Models.Shared;
    
    public class GetAccountsForEnhancedProfitAndLossResponse {
        public string? ContentType { get; set; }
        
    /// <summary>
    /// OK
    /// </summary>
        public EnhancedReport? EnhancedReport { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    /// <summary>
    /// Your API request was not properly authorized.
    /// </summary>
        public Schema? Schema { get; set; }
        
    }
}