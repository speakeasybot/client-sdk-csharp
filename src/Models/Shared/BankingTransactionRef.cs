
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
    
    public class BankingTransactionRef
    {
        
        [JsonProperty("accountId")]
        public string? AccountId { get; set; }
        
        
        [JsonProperty("accountName")]
        public string? AccountName { get; set; }
        
        
        [JsonProperty("amount")]
        public float? Amount { get; set; }
        
        
        [JsonProperty("dataConnectionId")]
        public string? DataConnectionId { get; set; }
        
    /// <summary>
    /// In Codat's data model, dates and times are represented using the <a class="external" href="https://en.wikipedia.org/wiki/ISO_8601" target="_blank">ISO 8601 standard</a>. Date and time fields are formatted as strings; for example:
    /// 
    /// <remarks>
    /// 
    /// ```
    /// 2020-10-08T22:40:50Z
    /// 2021-01-01T00:00:00
    /// ```
    /// 
    /// 
    /// 
    /// When syncing data that contains `DateTime` fields from Codat, make sure you support the following cases when reading time information:
    /// 
    /// - Coordinated Universal Time (UTC): `2021-11-15T06:00:00Z`
    /// - Unqualified local time: `2021-11-15T01:00:00`
    /// - UTC time offsets: `2021-11-15T01:00:00-05:00`
    /// 
    /// > Time zones
    /// > 
    /// > Not all dates from Codat will contain information about time zones.  
    /// > Where it is not available from the underlying platform, Codat will return these as times local to the business whose data has been synced.
    /// </remarks>
    /// </summary>
        
        [JsonProperty("date")]
        public string? Date { get; set; }
        
        
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        
        [JsonProperty("id")]
        public string? Id { get; set; }
        
    }
}