
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
    
    public class AccountCategory
    {
    /// <summary>
    /// Most granular chart of account type.
    /// </summary>
        
        [JsonProperty("detailType")]
        public string? DetailType { get; set; }
        
    /// <summary>
    /// The account subtype.
    /// </summary>
        
        [JsonProperty("subtype")]
        public string? Subtype { get; set; }
        
    /// <summary>
    /// The top level account type.
    /// </summary>
        
        [JsonProperty("type")]
        public string? Type { get; set; }
        
    }
}