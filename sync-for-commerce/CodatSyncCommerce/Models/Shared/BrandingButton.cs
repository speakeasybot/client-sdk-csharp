
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
    /// Button branding references.
    /// </summary>
    public class BrandingButton
    {
        [JsonProperty("default")]
        public BrandingImage? Default { get; set; }
        
        [JsonProperty("hover")]
        public BrandingImage? Hover { get; set; }
        
    }
    
}