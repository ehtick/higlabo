﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/reportroot-getemailappusageusercounts?view=graph-rest-1.0
/// </summary>
public partial class ReportRootGetemailappusageUsercountsParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Reports_GetEmailAppUsageUserCounts: return $"/reports/getEmailAppUsageUserCounts";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Reports_GetEmailAppUsageUserCounts,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "GET";
    public QueryParameter<Field> Query { get; set; } = new QueryParameter<Field>();
    IQueryParameter IQueryParameterProperty.Query
    {
        get
        {
            return this.Query;
        }
    }
}
public partial class ReportRootGetemailappusageUsercountsResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/reportroot-getemailappusageusercounts?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getemailappusageusercounts?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetemailappusageUsercountsResponse> ReportRootGetemailappusageUsercountsAsync()
    {
        var p = new ReportRootGetemailappusageUsercountsParameter();
        return await this.SendAsync<ReportRootGetemailappusageUsercountsParameter, ReportRootGetemailappusageUsercountsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getemailappusageusercounts?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetemailappusageUsercountsResponse> ReportRootGetemailappusageUsercountsAsync(CancellationToken cancellationToken)
    {
        var p = new ReportRootGetemailappusageUsercountsParameter();
        return await this.SendAsync<ReportRootGetemailappusageUsercountsParameter, ReportRootGetemailappusageUsercountsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getemailappusageusercounts?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetemailappusageUsercountsResponse> ReportRootGetemailappusageUsercountsAsync(ReportRootGetemailappusageUsercountsParameter parameter)
    {
        return await this.SendAsync<ReportRootGetemailappusageUsercountsParameter, ReportRootGetemailappusageUsercountsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getemailappusageusercounts?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetemailappusageUsercountsResponse> ReportRootGetemailappusageUsercountsAsync(ReportRootGetemailappusageUsercountsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ReportRootGetemailappusageUsercountsParameter, ReportRootGetemailappusageUsercountsResponse>(parameter, cancellationToken);
    }
}
