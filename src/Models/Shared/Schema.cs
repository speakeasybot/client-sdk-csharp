
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
    
public class Schema
{
    [JsonProperty("canBeRetried")]
    public string? CanBeRetried { get; set; }
    
    [JsonProperty("correlationId")]
    public string? CorrelationId { get; set; }
    
    [JsonProperty("detailedErrorCode")]
    public int? DetailedErrorCode { get; set; }
    
    [JsonProperty("error")]
    public string? Error { get; set; }
    
    [JsonProperty("service")]
    public string? Service { get; set; }
    
    [JsonProperty("statusCode")]
    public int? StatusCode { get; set; }
    
}
}