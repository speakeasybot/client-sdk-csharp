
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
    
    
    public class FeesSupplier
    {
        /// <summary>
        /// Selected supplier id from the list of supplier records on the accounting software.
        /// </summary>
        [JsonProperty("selectedSupplierId")]
        public string? SelectedSupplierId { get; set; }
        
        /// <summary>
        /// List of supplier options from the list of supplier records on the accounting software.
        /// </summary>
        [JsonProperty("supplierOptions")]
        public List<Option>? SupplierOptions { get; set; }
        
    }
    
}