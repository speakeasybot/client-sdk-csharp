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
using Codat.Models.Categories;
*/

public class CategorisedAccount
{
    [JsonProperty("accountRef")]
    public AccountRef? AccountRef { get; set; }
    
    [JsonProperty("confirmed")]
    public AccountCategoryDeprecated? Confirmed { get; set; }
    
    [JsonProperty("suggested")]
    public AccountCategoryDeprecated? Suggested { get; set; }
    
}
