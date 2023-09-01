
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Operations
{
    using CodatSyncExpenses.Utils;
    
    
    public class ListSyncTransactionsRequest
    {
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; }
        
        /// <summary>
        /// Page number. [Read more](https://docs.codat.io/using-the-api/paging).
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=page")]
        public int? Page { get; set; }
        
        /// <summary>
        /// Number of records to return in a page. [Read more](https://docs.codat.io/using-the-api/paging).
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=pageSize")]
        public int? PageSize { get; set; }
        
        /// <summary>
        /// Unique identifier for a sync.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=syncId")]
        public string SyncId { get; set; }
        
    }
    
}