
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Shared
{
    using Newtonsoft.Json;
    
    
    /// <summary>
    /// Logo branding references.
    /// </summary>
    public class BrandingLogo
    {
        [JsonProperty("full")]
        public BrandingImage? Full { get; set; }
        
        [JsonProperty("square")]
        public BrandingImage? Square { get; set; }
        
    }
    
}