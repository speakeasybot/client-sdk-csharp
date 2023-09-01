
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
    using System.Collections.Generic;
    
    
    public class TaxRateAmount
    {
        /// <summary>
        /// Selected tax rate id from the list of tax rates on the accounting software.
        /// </summary>
        [JsonProperty("selectedTaxRateId")]
        public string? SelectedTaxRateId { get; set; }
        
        /// <summary>
        /// Array of tax rate options object.
        /// </summary>
        [JsonProperty("taxRateOptions")]
        public List<Option>? TaxRateOptions { get; set; }
        
    }
    
}