
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
    using Codat.Utils;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class DataIntegrityStatus
{
    [JsonProperty("amounts")]
    public DataIntegrityAmounts? Amounts { get; set; }
    
    [JsonProperty("connectionIds")]
    public DataIntegrityConnectionId? ConnectionIds { get; set; }
    
    [JsonProperty("dates")]
    public DataIntegrityDates? Dates { get; set; }
    
    [JsonProperty("statusInfo")]
    public DataIntegrityStatusInfo? StatusInfo { get; set; }
    
    [JsonProperty("type")]
    public string? Type { get; set; }
    
}
}