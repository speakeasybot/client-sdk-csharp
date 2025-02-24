
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    
    public enum PullOperationStatus
    {
    	[JsonProperty("Initial")]
		Initial,
		[JsonProperty("Queued")]
		Queued,
		[JsonProperty("Fetching")]
		Fetching,
		[JsonProperty("MapQueued")]
		MapQueued,
		[JsonProperty("Mapping")]
		Mapping,
		[JsonProperty("Complete")]
		Complete,
		[JsonProperty("FetchError")]
		FetchError,
		[JsonProperty("MapError")]
		MapError,
		[JsonProperty("InternalError")]
		InternalError,
		[JsonProperty("ProcessingQueued")]
		ProcessingQueued,
		[JsonProperty("Processing")]
		Processing,
		[JsonProperty("ProcessingError")]
		ProcessingError,
		[JsonProperty("ValidationQueued")]
		ValidationQueued,
		[JsonProperty("Validating")]
		Validating,
		[JsonProperty("ValidationError")]
		ValidationError,
		[JsonProperty("AuthError")]
		AuthError,
		[JsonProperty("Cancelled")]
		Cancelled,
		[JsonProperty("Routing")]
		Routing,
		[JsonProperty("RoutingError")]
		RoutingError,
		[JsonProperty("NotSupported")]
		NotSupported,
		[JsonProperty("RateLimitError")]
		RateLimitError,
		[JsonProperty("PermissionsError")]
		PermissionsError,
		[JsonProperty("PrerequisiteNotMet")]
		PrerequisiteNotMet,
    }
    
    public static class PullOperationStatusExtension
    {
        public static string Value(this PullOperationStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PullOperationStatus ToEnum(this string value)
        {
            foreach(var field in typeof(PullOperationStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (PullOperationStatus)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum PullOperationStatus");
        }
    }
    
}