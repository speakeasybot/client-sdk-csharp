
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
    
    
    /// <summary>
    /// An integration that Codat supports
    /// </summary>
    public class Integration
    {
        [JsonProperty("dataProvidedBy")]
        public string? DataProvidedBy { get; set; }
        
        [JsonProperty("datatypeFeatures")]
        public List<DataTypeFeature>? DatatypeFeatures { get; set; }
        
        /// <summary>
        /// Whether this integration is enabled for your customers to use
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        
        /// <summary>
        /// A Codat ID representing the integration.
        /// </summary>
        [JsonProperty("integrationId")]
        public string? IntegrationId { get; set; }
        
        [JsonProperty("isBeta")]
        public bool? IsBeta { get; set; }
        
        [JsonProperty("isOfflineConnector")]
        public bool? IsOfflineConnector { get; set; }
        
        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration. View [accounting](https://docs.codat.io/integrations/accounting/accounting-platform-keys), [banking](https://docs.codat.io/integrations/banking/banking-platform-keys), and [commerce](https://docs.codat.io/integrations/commerce/commerce-platform-keys) platform keys. 
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
        
        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// A source-specific ID used to distinguish between different sources originating from the same data connection. In general, a data connection is a single data source. However, for TrueLayer, `sourceId` is associated with a specific bank and has a many-to-one relationship with the `integrationId`.
        /// </summary>
        [JsonProperty("sourceId")]
        public string? SourceId { get; set; }
        
        /// <summary>
        /// The type of platform of the connection.
        /// </summary>
        [JsonProperty("sourceType")]
        public SourceType? SourceType { get; set; }
        
    }
    
}