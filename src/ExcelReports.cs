
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.ExcelReports
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using NodaTime;
    using Codat.Models.Shared;
    using Codat.Models.ExcelReports;
    using Codat.Utils;

    public interface IExcelReportsSDK
    {
        Task<GenerateExcelReportResponse> GenerateExcelReportAsync(GenerateExcelReportRequest request);
        Task<GetAccountingMarketingMetricsResponse> GetAccountingMarketingMetricsAsync(GetAccountingMarketingMetricsRequest request);
        Task<GetExcelReportResponse> GetExcelReportAsync(GetExcelReportRequest request);
        Task<GetExcelReportGenerationStatusResponse> GetExcelReportGenerationStatusAsync(GetExcelReportGenerationStatusRequest request);
    }

    public class ExcelReportsSDK: IExcelReportsSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "1.0";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public ExcelReportsSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    public async Task<GenerateExcelReportResponse> GenerateExcelReportAsync(GenerateExcelReportRequest request)
    {
        string baseUrl = "";
        var message = GenerateExcelReportRequest.BuildHttpRequestMessage("generate-excel-report", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GenerateExcelReportResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.ExcelStatus = JsonConvert.DeserializeObject<ExcelStatus>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetAccountingMarketingMetricsResponse> GetAccountingMarketingMetricsAsync(GetAccountingMarketingMetricsRequest request)
    {
        string baseUrl = "";
        var message = GetAccountingMarketingMetricsRequest.BuildHttpRequestMessage("get-accounting-marketing-metrics", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetAccountingMarketingMetricsResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Report = JsonConvert.DeserializeObject<Report>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetExcelReportResponse> GetExcelReportAsync(GetExcelReportRequest request)
    {
        string baseUrl = "";
        var message = GetExcelReportRequest.BuildHttpRequestMessage("get-excel-report", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetExcelReportResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/octet-stream",response.ContentType))
            {
                response.Body = await response.RawResponse.Content.ReadAsByteArrayAsync();
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    public async Task<GetExcelReportGenerationStatusResponse> GetExcelReportGenerationStatusAsync(GetExcelReportGenerationStatusRequest request)
    {
        string baseUrl = "";
        var message = GetExcelReportGenerationStatusRequest.BuildHttpRequestMessage("get-excel-report-generation-status", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetExcelReportGenerationStatusResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.ExcelStatus = JsonConvert.DeserializeObject<ExcelStatus>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Schema = JsonConvert.DeserializeObject<Schema>(await httpResponseMessage.Content.ReadAsStringAsync(), new FlexibleObjectDeserializer());
            }
            return response;
        }
        return response;
    }

        
    }
}