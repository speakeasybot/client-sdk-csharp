
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds.Models.Operations
{
    using CodatBankFeeds.Models.Shared;
    using System.Net.Http;
    using System;
    
    
    public class ListCreateOperationsResponse
    {
        
        public string? ContentType { get; set; }
        
        /// <summary>
        /// Your `query` parameter was not correctly formed
        /// </summary>
        
        public ErrorMessage? ErrorMessage { get; set; }
        
        /// <summary>
        /// OK
        /// </summary>
        
        public ListPushOperations? ListPushOperations { get; set; }
        
        
        public int StatusCode { get; set; }
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
    
}