///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace Codat;
using System.Collections.Generic;
using Codat.Categories;
using Codat.DataIntegrity;
using Codat.ExcelReports;
using Codat.Reports;
using System.Net.Http;
using Codat.Models.Security;
using Codat.Utils;

public interface ICodatSDK
{
    public ICategoriesSDK Categories { get; }
    public IDataIntegritySDK DataIntegrity { get; }
    public IExcelReportsSDK ExcelReports { get; }
    public IReportsSDK Reports { get; }
}

public class CodatSDK: ICodatSDK
{
    public static List<string> ServerList = new List<string>()
    {
        "https://api.codat.io",
    };

    private const string language = "csharp";
    private const string sdkVersion = "0.0.1";
    private const string sdkGenVersion = "internal";
    public Uri ServerUrl { get { return _defaultClient.BaseAddress; } }
    private HttpClient _defaultClient;
    private HttpClient _securityClient;
    public ICategoriesSDK Categories { get; private set; }
    public IDataIntegritySDK DataIntegrity { get; private set; }
    public IExcelReportsSDK ExcelReports { get; private set; }
    public IReportsSDK Reports { get; private set; }

    public CodatSDK(HttpClient? client = null, string? serverUrl = null, Security? security = null)
    {
        _defaultClient = client;
        if(_defaultClient == null)
        {
            _defaultClient = new HttpClient();
            var _serverUrl = serverUrl ?? CodatSDK.ServerList[0];

            _defaultClient.BaseAddress = new System.Uri(_serverUrl);
        }
        _securityClient = _defaultClient;
        if(security != null)
        {
_securityClient.DefaultRequestHeaders.Add("Authorization", security.AuthHeader);
        }
        Categories = new CategoriesSDK(_defaultClient, _securityClient);
        DataIntegrity = new DataIntegritySDK(_defaultClient, _securityClient);
        ExcelReports = new ExcelReportsSDK(_defaultClient, _securityClient);
        Reports = new ReportsSDK(_defaultClient, _securityClient);
    }
}