
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.Shared
{
    using Newtonsoft.Json;
using Codat.Models.Shared;
    
    public class FinancialMetricError
    {
        
        [JsonProperty("message")]
        public string? Message { get; set; }
        
        
        [JsonProperty("type")]
        public FinancialMetricErrorType? Type { get; set; }
        
    }
}