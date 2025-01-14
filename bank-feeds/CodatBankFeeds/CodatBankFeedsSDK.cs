
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds
{
    using CodatBankFeeds.Models.Shared;
    using CodatBankFeeds.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface ICodatBankFeedsSDK
    {
        public IAccountMappingSDK AccountMapping { get; }
        public ICompaniesSDK Companies { get; }
        public IConnectionsSDK Connections { get; }
        public ISourceAccountsSDK SourceAccounts { get; }
        public ITransactionsSDK Transactions { get; }
    }
    
    public class SDKConfig
    {
    }

    public class CodatBankFeedsSDK: ICodatBankFeedsSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.codat.io",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.91.4";
        private const string _openapiDocVersion = "3.0.0";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAccountMappingSDK AccountMapping { get; private set; }
        public ICompaniesSDK Companies { get; private set; }
        public IConnectionsSDK Connections { get; private set; }
        public ISourceAccountsSDK SourceAccounts { get; private set; }
        public ITransactionsSDK Transactions { get; private set; }

        public CodatBankFeedsSDK(Security? security = null, string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? CodatBankFeedsSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            if(security != null)
            {
                _securityClient = SecuritySerializer.Apply(_defaultClient, security);
            }
            
            Config = new SDKConfig()
            {
            };

            AccountMapping = new AccountMappingSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Companies = new CompaniesSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Connections = new ConnectionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            SourceAccounts = new SourceAccountsSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Transactions = new TransactionsSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}