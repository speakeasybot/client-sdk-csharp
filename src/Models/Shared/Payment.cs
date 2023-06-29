
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
    
    public class Payment
    {
        
        [JsonProperty("amount")]
        public float? Amount { get; set; }
        
        
        [JsonProperty("bankingTransactionRefs")]
        public List<BankingTransactionRef>? BankingTransactionRefs { get; set; }
        
    /// <summary>
    /// The currency data type in Codat is the [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code, e.g. _GBP_.
    /// 
    /// <remarks>
    /// 
    /// ## Unknown currencies
    /// 
    /// In line with the ISO 4217 specification, the code _XXX_ is used when the data source does not return a currency for a transaction. 
    /// 
    /// There are only a very small number of edge cases where this currency code is returned by the Codat system.
    /// </remarks>
    /// </summary>
        
        [JsonProperty("currency")]
        public string? Currency { get; set; }
        
    /// <summary>
    /// Rate to convert the total amount of the payment into the base currency for the company at the time of the payment.
    /// 
    /// <remarks>
    /// 
    /// Currency rates in Codat are implemented as the multiple of foreign currency units to each base currency unit.  
    /// 
    /// Where the currency rate is provided by the underlying accounting platform, it will be available from Codat with the same precision (up to a maximum of 9 decimal places). 
    /// 
    /// For accounting platforms which do not provide an explicit currency rate, it is calculated as `baseCurrency / foreignCurrency` and will be returned to 9 decimal places.
    /// 
    /// ## Examples with base currency of GBP
    /// 
    /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (GBP) |
    /// | :--------------- | :------------- | :------------ | :------------------------- |
    /// | **USD**          | $20            | 0.781         | £15.62                     |
    /// | **EUR**          | €20            | 0.885         | £17.70                     |
    /// | **RUB**          | ₽20            | 0.011         | £0.22                      |
    /// 
    /// ## Examples with base currency of USD
    /// 
    /// | Foreign Currency | Foreign Amount | Currency Rate | Base Currency Amount (USD) |
    /// | :--------------- | :------------- | :------------ | :------------------------- |
    /// | **GBP**          | £20            | 1.277         | $25.54                     |
    /// | **EUR**          | €20            | 1.134         | $22.68                     |
    /// | **RUB**          | ₽20            | 0.015         | $0.30                      |
    /// </remarks>
    /// </summary>
        
        [JsonProperty("currencyRate")]
        public float? CurrencyRate { get; set; }
        
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
        
    /// <summary>
    /// ID of the invoice, which may be a GUID but it may be something else depending on the accounting platform
    /// </summary>
        
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        
        [JsonProperty("paymentType")]
        public string? PaymentType { get; set; }
        
    }
}