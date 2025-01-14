
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
    using System.Collections.Generic;
    
    
    /// <summary>
    /// > **Language tip:** Accounts are also referred to as **chart of accounts**, **nominal accounts**, and **general ledger**.
    /// 
    /// <remarks>
    /// 
    /// View the coverage for accounts in the <a className="external" href="https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=chartOfAccounts" target="_blank">Data coverage explorer</a>.
    /// 
    /// ## Overview
    /// 
    /// Accounts are the categories a business uses to record accounting transactions. From the Accounts endpoints, you can retrieve a list of all accounts for a specified company. 
    /// 
    /// The categories for an account include:
    ///   * Asset
    ///   * Expense
    ///   * Income
    ///   * Liability
    ///   * Equity.
    /// 
    /// The same account may have a different category based on the integration it is used in. For example, a current account (known as checking in the US) should be categorized as `Asset.Current` for Xero, and `Asset.Bank.Checking` for QuickBooks Online. 
    /// 
    /// At the same time, each integration may have its own requirements to the categories. For example, a Paypal account in Xero is of the `Asset.Bank` category and therefore requires additional properties to be provided. 
    /// 
    /// To determine the list of allowed categories for a specific integration, you can: 
    /// - Follow our [Create, update, delete data](https://docs.codat.io/using-the-api/push) guide and use the [Get create account model](https://docs.codat.io/accounting-api#/operations/get-create-chartOfAccounts-model).
    /// - Refer to the integration's own documentation. 
    /// 
    /// > **Accounts with no category**
    /// > 
    /// > If an account is pulled from the chart of accounts and its nominal code does not lie within the category layout for the company's accounts, then the **type** is `Unknown`. The **fullyQualifiedCategory** and **fullyQualifiedName** fields return `null`.
    /// > 
    /// > This approach gives a true representation of the company's accounts whilst preventing distorting financials such as a company's profit and loss and balance sheet reports.
    /// </remarks>
    /// </summary>
    public class Account
    {
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
        /// Current balance in the account.
        /// </summary>
        [JsonProperty("currentBalance")]
        public float? CurrentBalance { get; set; }
        
        /// <summary>
        /// Description for the account.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        /// <summary>
        /// Full category of the account. 
        /// 
        /// <remarks>
        /// 
        /// For example, `Liability.Current` or `Income.Revenue`. To determine a list of possible categories for each integration, see our examples, follow our [Create, update, delete data](https://docs.codat.io/using-the-api/push) guide, or refer to the integration's own documentation.
        /// </remarks>
        /// </summary>
        [JsonProperty("fullyQualifiedCategory")]
        public string? FullyQualifiedCategory { get; set; }
        
        /// <summary>
        /// Full name of the account, for example:
        /// 
        /// <remarks>
        /// - `Cash On Hand`
        /// - `Rents Held In Trust`
        /// - `Fixed Asset`
        /// </remarks>
        /// </summary>
        [JsonProperty("fullyQualifiedName")]
        public string? FullyQualifiedName { get; set; }
        
        /// <summary>
        /// Identifier for the account, unique for the company.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        /// <summary>
        /// Confirms whether the account is a bank account or not.
        /// </summary>
        [JsonProperty("isBankAccount")]
        public bool? IsBankAccount { get; set; }
        
        [JsonProperty("metadata")]
        public AccountMetadata? Metadata { get; set; }
        
        [JsonProperty("modifiedDate")]
        public string? ModifiedDate { get; set; }
        
        /// <summary>
        /// Name of the account.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        /// <summary>
        /// Reference given to each nominal account for a business. It ensures money is allocated to the correct account. This code isn't a unique identifier in the Codat system.
        /// </summary>
        [JsonProperty("nominalCode")]
        public string? NominalCode { get; set; }
        
        [JsonProperty("sourceModifiedDate")]
        public string? SourceModifiedDate { get; set; }
        
        /// <summary>
        /// Status of the account
        /// </summary>
        [JsonProperty("status")]
        public AccountStatus? Status { get; set; }
        
        /// <summary>
        /// Type of account
        /// </summary>
        [JsonProperty("type")]
        public AccountType? Type { get; set; }
        
        /// <summary>
        /// The validDatatypeLinks can be used to determine whether an account can be correctly mapped to another object; for example, accounts with a `type` of `income` might only support being used on an Invoice and Direct Income. For more information, see [Valid Data Type Links](/accounting-api#/schemas/ValidDataTypeLinks).
        /// </summary>
        [JsonProperty("validDatatypeLinks")]
        public List<AccountValidDataTypeLinks>? ValidDatatypeLinks { get; set; }
        
    }
    
}