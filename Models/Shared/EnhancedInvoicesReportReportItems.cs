///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace Codat.Models.Shared;
using Codat.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

/*
using Codat.Models.Reports;
*/

public class EnhancedInvoicesReportReportItems
{
    [JsonProperty("invoices")]
    public IEnumerable<EnhancedInvoiceReportItem>? Invoices { get; set; }
    
}
