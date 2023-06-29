
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
    using System.Collections.Generic;
using Newtonsoft.Json;
using Codat.Models.Shared;
    
/// <summary>
/// OK
/// </summary>
    public class CategorisedAccounts
    {
        
        [JsonProperty("_links")]
        public Links Links { get; set; }
        
        
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }
        
        
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
        
    /// <summary>
    /// A list confirmed and suggested account categories.
    /// </summary>
        
        [JsonProperty("results")]
        public List<CategorisedAccount>? Results { get; set; }
        
        
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }
        
    }
}