
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
    using System.Collections.Generic;
using Newtonsoft.Json;
using Codat.Models.Shared;
    
/// <summary>
/// The enhanced invoices report takes the key elements of the Invoices report verifying those marked as paid in the accounting platform have actually been paid by matching with the bank statement.
/// </summary>
    public class EnhancedInvoicesReport
    {
    /// <summary>
    /// Report additional information, which is specific to Assess reports
    /// </summary>
        
        [JsonProperty("reportInfo")]
        public ReportInfo? ReportInfo { get; set; }
        
        
        [JsonProperty("reportItems")]
        public List<EnhancedInvoicesReportReportItems>? ReportItems { get; set; }
        
    }
}